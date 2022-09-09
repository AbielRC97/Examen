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
    public partial class Usuario : Form
    {
        ContactoBL contactoBL = new ContactoBL();
        ContactoEN contactoEN = new ContactoEN();
        public string usuario1 = "";
        string accion = "O";
        public Usuario()
        {
            InitializeComponent();
        }

        public void LlenaConsulta()
        {
            
            var lista = contactoBL.VCONTUsuarioDet(Convert.ToInt32(usuario1));

            GVContacto.AutoGenerateColumns = true;
            GVContacto.DataSource = lista;
            GVContacto.Refresh();
            GVContacto.Columns["IdContacto"].Visible = false;
            GVContacto.Columns.Remove("FechaRegistro");
            GVContacto.Columns.Remove("IdUsuario");

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            string dato = "";

            dato = contactoBL.VCONTUsuario(Convert.ToInt32(usuario1), "NickName");

            if (dato.Length != 0)
            {
                TxtNombre.Text = dato;
            }

            dato = contactoBL.VCONTUsuario(Convert.ToInt32(usuario1), "Email");
            if (dato.Length != 0)
            {
                TxtEmail.Text = dato;
            }

            dato = contactoBL.VCONTUsuario(Convert.ToInt32(usuario1), "Contrasena");
            if (dato.Length != 0)
            {
                TxtPWD1.Text = dato;
            }

            dato = contactoBL.VCONTUsuario(Convert.ToInt32(usuario1), "Contrasena");
            if (dato.Length != 0)
            {
                TxtPWD2.Text = dato;
            }

            dato = contactoBL.VCONTUsuario(Convert.ToInt32(usuario1), "Estatus");
            if (dato.Length != 0)
            {
                //string texto1 = "";
                if (Convert.ToBoolean(dato) )
                {
                    CmbEstatus.SelectedIndex = 0;
                }
                else
                {
                    CmbEstatus.SelectedIndex = 1;
                }
                //int indice = CmbEstatus.FindString(texto1);
                //CmbEstatus.SelectedText = texto1;
            }

            dato = contactoBL.VCONTUsuario(Convert.ToInt32(usuario1), "FechaRegistro");
            if (dato.Length != 0)
            {
                LblFechaReg.Text = dato;
            }

            if (accion == "O")
            {
                TxtEmail.ReadOnly = true;
                TxtNombre.ReadOnly = true;
                TxtPWD1.ReadOnly = true;
                TxtPWD2.ReadOnly = true;
                TxtNumero.ReadOnly = true;
                CmbEstatus.Enabled = false;
                btnDelNum.Enabled = false;
                BtnADDNum.Enabled = false;
                BtnGuarda.Enabled = false;
                BtnMod.Enabled = true;
                BtnCancel.Enabled = true;
                BtnModNum.Enabled = false;
                GVContacto.Enabled = false;
            }

            LlenaConsulta();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            TxtEmail.ReadOnly = true;
            TxtNombre.ReadOnly = false;
            TxtPWD1.ReadOnly = false;
            TxtPWD2.ReadOnly = false;
            TxtNumero.ReadOnly = false;
            CmbEstatus.Enabled = true;
            btnDelNum.Enabled = true;
            BtnADDNum.Enabled = true;
            BtnGuarda.Enabled = true;
            BtnMod.Enabled = false;
            BtnCancel.Enabled = true;
            BtnModNum.Enabled = true;
            GVContacto.Enabled = true;
            accion = "U";

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (accion == "O")
            {
                this.Close();

            }
            if (accion == "U")
            {
                DialogResult aviso = MessageBox.Show("Esta seguro que no Quere Guardar Cambios", "Deshacer cambios del Usuario", MessageBoxButtons.YesNo);
                if (aviso == DialogResult.Yes)
                {
                    accion = "O";
                    TxtEmail.ReadOnly = true;
                    TxtNombre.ReadOnly = true;
                    TxtPWD1.ReadOnly = true;
                    TxtPWD2.ReadOnly = true;
                    TxtNumero.ReadOnly = true;
                    CmbEstatus.Enabled = false;
                    btnDelNum.Enabled = false;
                    BtnADDNum.Enabled = false;
                    BtnGuarda.Enabled = false;
                    BtnMod.Enabled = true;
                    BtnCancel.Enabled = true;
                    BtnModNum.Enabled = false;
                    GVContacto.Enabled = true;
                }
            }
        }

        private void Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(accion == "O")
            {
               FrmLogeo frm = new FrmLogeo();
               frm.Show();

            }
            if(accion == "U")
            {
                DialogResult aviso = MessageBox.Show("Esta seguro que No Quere Guardar Cambios", "Salir del Usuario", MessageBoxButtons.YesNo);
                if (aviso == DialogResult.Yes)
                {
                    FrmLogeo frm = new FrmLogeo();
                    frm.Show();

                }
                if (aviso == DialogResult.No)
                {
                    e.Cancel = true;

                }

            }

        }

        private void BtnGuarda_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text.Length == 0 || TxtNombre.Text.Length == 0 || TxtPWD1.Text.Length == 0 || TxtPWD2.Text.Length == 0)
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
                        bool estatus = true;
                        int datoc = CmbEstatus.SelectedIndex;

                        if(datoc == 0)
                        {
                            estatus = true;
                        }
                        else
                        {
                            estatus = false;
                        }
                        string contacto = contactoBL.SpCONTUsuarioUP(Convert.ToInt32(usuario1), TxtNombre.Text, TxtEmail.Text, TxtPWD1.Text, estatus);
                        if (contacto.Length != 0 && contacto != null)
                        {
                            if (contacto.Substring(0, 1) == "E")
                            {
                                MessageBox.Show(contacto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                accion = "O";
                                TxtEmail.ReadOnly = true;
                                TxtNombre.ReadOnly = true;
                                TxtPWD1.ReadOnly = true;
                                TxtPWD2.ReadOnly = true;
                                TxtNumero.ReadOnly = true;
                                CmbEstatus.Enabled = false;
                                btnDelNum.Enabled = false;
                                BtnADDNum.Enabled = false;
                                BtnGuarda.Enabled = false;
                                BtnMod.Enabled = true;
                                BtnCancel.Enabled = true;
                                BtnModNum.Enabled = false;
                                GVContacto.Enabled = false;
                                MessageBox.Show("El Usuario se  Modifico Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }
                    }


                }
            }

        }

        private void BtnADDNum_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text.Length == 0)
            {
                MessageBox.Show("El campo numero debetener informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string contacto = contactoBL.SpCONTContactoAdd(TxtNumero.Text, Convert.ToInt32(usuario1));
                if (contacto.Length != 0 && contacto != null)
                {
                    if (contacto.Substring(0, 1) == "E")
                    {
                        MessageBox.Show(contacto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        LlenaConsulta();
                        TxtNumero.Text = "";
                        MessageBox.Show("El numero se agrego correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void BtnModNum_Click(object sender, EventArgs e)
        {
            int fila = GVContacto.Rows.Count;
            int id = 0;

            if (fila > 1)
            {
                int selectedrowindex = GVContacto.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = GVContacto.Rows[selectedrowindex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

            }

            if (TxtNumero.Text.Length == 0 || id == 0)
            {
                MessageBox.Show("El campo numero debetener informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string contacto = contactoBL.SpCONTContactoUP(id, TxtNumero.Text);
                if (contacto.Length != 0 && contacto != null)
                {
                    if (contacto.Substring(0, 1) == "E")
                    {
                        MessageBox.Show(contacto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        LlenaConsulta();
                        TxtNumero.Text = "";
                        MessageBox.Show("El numero se Modifico correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
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

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Return) && ((e.KeyChar <= 47) || (e.KeyChar >= 58)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }


        private void GVContacto_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int fila = GVContacto.Rows.Count;
            //if (fila > 1)
            //{
            //    int selectedrowindex = GVContacto.SelectedCells[0].RowIndex;

            //    DataGridViewRow selectedRow = GVContacto.Rows[selectedrowindex];
            //    TxtNumero.Text = selectedRow.Cells[1].Value.ToString();

            //}


        }

        private void btnDelNum_Click(object sender, EventArgs e)
        {
            int fila = GVContacto.Rows.Count;
            int id = 0;

            if (fila > 1)
            {
                int selectedrowindex = GVContacto.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = GVContacto.Rows[selectedrowindex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

            }

            if (id == 0)
            {
                MessageBox.Show("Seleccione el numero a Eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string contacto = contactoBL.SpCONTContactoDel(id);
                if (contacto.Length != 0 && contacto != null)
                {
                    if (contacto.Substring(0, 1) == "E")
                    {
                        MessageBox.Show(contacto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        LlenaConsulta();
                        TxtNumero.Text = "";
                        MessageBox.Show("El numero se Elimino correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }

        }
    }
}
