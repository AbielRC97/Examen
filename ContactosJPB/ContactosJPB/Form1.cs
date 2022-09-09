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

namespace ContactosJPB
{
    public partial class FrmLogeo : Form
    {
        ContactoBL contactoBL = new ContactoBL();
        string usuario1 = "";

        public FrmLogeo()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro frm = new Registro();

            frm.Show();
        }

        private void FrmLogeo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void TxtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                button1_Click(sender, e);

            }

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Return) && ((e.KeyChar <= 47) || (e.KeyChar >= 58)))
            {
                MessageBox.Show("Solo se permiten letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text.Length == 0 || TxtPWD.Text.Length == 0)
            {
                MessageBox.Show("llene los campos de usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string contacto = contactoBL.SpCONTUsuarioValida(TxtEmail.Text, TxtPWD.Text);
                if (contacto.Length != 0 && contacto != null)
                {
                    if (contacto.Substring(0, 1) == "E")
                    {
                        MessageBox.Show(contacto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (contacto == "0")
                        {
                            MessageBox.Show("El usuario y la Contraseña son Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            usuario1 = contacto;
                            this.Hide();
                            Usuario frm = new Usuario();

                            frm.usuario1 = usuario1;
                            frm.Show();

                        }
                    }
                }

            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            TextBox txtb1 = TxtEmail;
            txtb1.SelectionStart = 0;
            txtb1.SelectionLength = txtb1.Text.Length;

        }

        private void TxtPWD_Enter(object sender, EventArgs e)
        {
            TextBox txtb1 = TxtPWD;
            txtb1.SelectionStart = 0;
            txtb1.SelectionLength = txtb1.Text.Length;

        }
    }
}
