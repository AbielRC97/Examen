using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using EN;

namespace ContactosJPB
{
    public partial class Registro : Form
    {
        ContactoBL contactoBL = new ContactoBL();
        ContactoEN contactoEN = new ContactoEN();
        public string usuario1 = "";

        public Registro()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( usuario1 != "")
            {
                MessageBox.Show("Tu Usuario se genero correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FrmLogeo frm = new FrmLogeo();
                frm.Show();

            }
            else
            {
                DialogResult aviso = MessageBox.Show("Esta seguro que desea No Registrarse", "Salir de Registro", MessageBoxButtons.YesNo);
                if (aviso == DialogResult.Yes)
                {
                    FrmLogeo frm = new FrmLogeo();
                    frm.Show();

                }
                else
                {
                    e.Cancel = true;

                }

            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Return))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (TxtEmail.Text.Length > 0)

            {

                if (!rEMail.IsMatch(TxtEmail.Text))

                {

                    MessageBox.Show("Formato de E-Mail Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtEmail.SelectAll();

                    e.Cancel = true;

                }

            }
        }

        private void TxtPWD1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Return) && ((e.KeyChar <= 47) || (e.KeyChar >= 58)))
            {
                MessageBox.Show("Solo se permiten letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void TxtPWD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Return) && ((e.KeyChar <= 47) || (e.KeyChar >= 58)))
            {
                MessageBox.Show("Solo se permiten letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if(TxtEmail.Text.Length == 0 || TxtNombre.Text.Length == 0 || TxtPWD1.Text.Length == 0 || TxtPWD2.Text.Length == 0)
            {
                MessageBox.Show("Los Campos Nombre, Email, Contraseña Son Obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (TxtPWD1.Text != TxtPWD2.Text)
                {
                    MessageBox.Show("Las Contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult aviso = MessageBox.Show("Estan correctos los Datos", "Guardar usuario", MessageBoxButtons.YesNo);
                    if (aviso == DialogResult.Yes)
                    {

                        string contacto = contactoBL.SpCONTUsuarioAdd(TxtNombre.Text, TxtEmail.Text, TxtPWD1.Text);
                        if (contacto.Length != 0 && contacto != null)
                        {
                            if (contacto.Substring(0, 1) == "E")
                            {
                                MessageBox.Show(contacto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                usuario1 = contacto;
                                this.Close();
                            }
                        }
                    }


                }
            }
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            TextBox txtb1 = TxtNombre;
            txtb1.SelectionStart = 0;
            txtb1.SelectionLength = txtb1.Text.Length;

        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            TextBox txtb1 = TxtEmail;
            txtb1.SelectionStart = 0;
            txtb1.SelectionLength = txtb1.Text.Length;

        }

        private void TxtPWD1_Enter(object sender, EventArgs e)
        {
            TextBox txtb1 = TxtPWD1;
            txtb1.SelectionStart = 0;
            txtb1.SelectionLength = txtb1.Text.Length;

        }

        private void TxtPWD2_Enter(object sender, EventArgs e)
        {
            TextBox txtb1 = TxtPWD2;
            txtb1.SelectionStart = 0;
            txtb1.SelectionLength = txtb1.Text.Length;

        }
    }
}
