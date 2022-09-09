
namespace ContactosJPB
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPWD1 = new System.Windows.Forms.Label();
            this.LblPWD2 = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblFechaReg = new System.Windows.Forms.Label();
            this.GVContacto = new System.Windows.Forms.DataGridView();
            this.LblTitulo2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPWD1 = new System.Windows.Forms.TextBox();
            this.TxtPWD2 = new System.Windows.Forms.TextBox();
            this.CmbEstatus = new System.Windows.Forms.ComboBox();
            this.LblEstatus = new System.Windows.Forms.Label();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnGuarda = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnModNum = new System.Windows.Forms.Button();
            this.btnDelNum = new System.Windows.Forms.Button();
            this.BtnADDNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(273, 38);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(230, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Bienvenido a Contacto";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(32, 89);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(32, 119);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(41, 13);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email:";
            // 
            // LblPWD1
            // 
            this.LblPWD1.AutoSize = true;
            this.LblPWD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWD1.Location = new System.Drawing.Point(32, 146);
            this.LblPWD1.Name = "LblPWD1";
            this.LblPWD1.Size = new System.Drawing.Size(75, 13);
            this.LblPWD1.TabIndex = 3;
            this.LblPWD1.Text = "Contraseña:";
            // 
            // LblPWD2
            // 
            this.LblPWD2.AutoSize = true;
            this.LblPWD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWD2.Location = new System.Drawing.Point(32, 171);
            this.LblPWD2.Name = "LblPWD2";
            this.LblPWD2.Size = new System.Drawing.Size(124, 13);
            this.LblPWD2.TabIndex = 4;
            this.LblPWD2.Text = "Confirma Contraseña";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(32, 198);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(115, 13);
            this.LblFecha.TabIndex = 5;
            this.LblFecha.Text = "Fecha de Registro:";
            // 
            // LblFechaReg
            // 
            this.LblFechaReg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFechaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFechaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaReg.Location = new System.Drawing.Point(177, 198);
            this.LblFechaReg.Name = "LblFechaReg";
            this.LblFechaReg.Size = new System.Drawing.Size(128, 20);
            this.LblFechaReg.TabIndex = 6;
            this.LblFechaReg.Text = "Fecha";
            // 
            // GVContacto
            // 
            this.GVContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVContacto.Location = new System.Drawing.Point(35, 261);
            this.GVContacto.MultiSelect = false;
            this.GVContacto.Name = "GVContacto";
            this.GVContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVContacto.Size = new System.Drawing.Size(359, 177);
            this.GVContacto.TabIndex = 7;
            this.GVContacto.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVContacto_RowEnter);
            // 
            // LblTitulo2
            // 
            this.LblTitulo2.AutoSize = true;
            this.LblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo2.Location = new System.Drawing.Point(31, 238);
            this.LblTitulo2.Name = "LblTitulo2";
            this.LblTitulo2.Size = new System.Drawing.Size(183, 20);
            this.LblTitulo2.TabIndex = 8;
            this.LblTitulo2.Text = "Numeros de Contacto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nuevo Numero:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(521, 275);
            this.TxtNumero.MaxLength = 10;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(137, 20);
            this.TxtNumero.TabIndex = 10;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(177, 89);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(423, 20);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(177, 119);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(423, 20);
            this.TxtEmail.TabIndex = 12;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // TxtPWD1
            // 
            this.TxtPWD1.Location = new System.Drawing.Point(177, 145);
            this.TxtPWD1.MaxLength = 20;
            this.TxtPWD1.Name = "TxtPWD1";
            this.TxtPWD1.PasswordChar = '*';
            this.TxtPWD1.Size = new System.Drawing.Size(163, 20);
            this.TxtPWD1.TabIndex = 13;
            this.TxtPWD1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPWD1_KeyPress);
            // 
            // TxtPWD2
            // 
            this.TxtPWD2.Location = new System.Drawing.Point(177, 171);
            this.TxtPWD2.MaxLength = 20;
            this.TxtPWD2.Name = "TxtPWD2";
            this.TxtPWD2.PasswordChar = '*';
            this.TxtPWD2.Size = new System.Drawing.Size(163, 20);
            this.TxtPWD2.TabIndex = 14;
            this.TxtPWD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPWD2_KeyPress);
            // 
            // CmbEstatus
            // 
            this.CmbEstatus.FormattingEnabled = true;
            this.CmbEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CmbEstatus.Location = new System.Drawing.Point(521, 196);
            this.CmbEstatus.Name = "CmbEstatus";
            this.CmbEstatus.Size = new System.Drawing.Size(121, 21);
            this.CmbEstatus.TabIndex = 15;
            // 
            // LblEstatus
            // 
            this.LblEstatus.AutoSize = true;
            this.LblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstatus.Location = new System.Drawing.Point(450, 199);
            this.LblEstatus.Name = "LblEstatus";
            this.LblEstatus.Size = new System.Drawing.Size(53, 13);
            this.LblEstatus.TabIndex = 16;
            this.LblEstatus.Text = "Estatus:";
            // 
            // BtnMod
            // 
            this.BtnMod.Location = new System.Drawing.Point(644, 90);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(93, 29);
            this.BtnMod.TabIndex = 17;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // BtnGuarda
            // 
            this.BtnGuarda.Location = new System.Drawing.Point(644, 130);
            this.BtnGuarda.Name = "BtnGuarda";
            this.BtnGuarda.Size = new System.Drawing.Size(93, 29);
            this.BtnGuarda.TabIndex = 18;
            this.BtnGuarda.Text = "Guardar";
            this.BtnGuarda.UseVisualStyleBackColor = true;
            this.BtnGuarda.Click += new System.EventHandler(this.BtnGuarda_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(644, 171);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(93, 29);
            this.BtnCancel.TabIndex = 19;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnModNum
            // 
            this.BtnModNum.Location = new System.Drawing.Point(521, 316);
            this.BtnModNum.Name = "BtnModNum";
            this.BtnModNum.Size = new System.Drawing.Size(104, 29);
            this.BtnModNum.TabIndex = 20;
            this.BtnModNum.Text = "Modifica Numero";
            this.BtnModNum.UseVisualStyleBackColor = true;
            this.BtnModNum.Click += new System.EventHandler(this.BtnModNum_Click);
            // 
            // btnDelNum
            // 
            this.btnDelNum.Location = new System.Drawing.Point(648, 316);
            this.btnDelNum.Name = "btnDelNum";
            this.btnDelNum.Size = new System.Drawing.Size(93, 29);
            this.btnDelNum.TabIndex = 21;
            this.btnDelNum.Text = "Elimina Numero";
            this.btnDelNum.UseVisualStyleBackColor = true;
            this.btnDelNum.Click += new System.EventHandler(this.btnDelNum_Click);
            // 
            // BtnADDNum
            // 
            this.BtnADDNum.Location = new System.Drawing.Point(411, 316);
            this.BtnADDNum.Name = "BtnADDNum";
            this.BtnADDNum.Size = new System.Drawing.Size(93, 29);
            this.BtnADDNum.TabIndex = 22;
            this.BtnADDNum.Text = "Agrega Numero";
            this.BtnADDNum.UseVisualStyleBackColor = true;
            this.BtnADDNum.Click += new System.EventHandler(this.BtnADDNum_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.BtnADDNum);
            this.Controls.Add(this.btnDelNum);
            this.Controls.Add(this.BtnModNum);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnGuarda);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.LblEstatus);
            this.Controls.Add(this.CmbEstatus);
            this.Controls.Add(this.TxtPWD2);
            this.Controls.Add(this.TxtPWD1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitulo2);
            this.Controls.Add(this.GVContacto);
            this.Controls.Add(this.LblFechaReg);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblPWD2);
            this.Controls.Add(this.LblPWD1);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Usuario_FormClosing);
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPWD1;
        private System.Windows.Forms.Label LblPWD2;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblFechaReg;
        private System.Windows.Forms.DataGridView GVContacto;
        private System.Windows.Forms.Label LblTitulo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPWD1;
        private System.Windows.Forms.TextBox TxtPWD2;
        private System.Windows.Forms.ComboBox CmbEstatus;
        private System.Windows.Forms.Label LblEstatus;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnGuarda;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnModNum;
        private System.Windows.Forms.Button btnDelNum;
        private System.Windows.Forms.Button BtnADDNum;
    }
}