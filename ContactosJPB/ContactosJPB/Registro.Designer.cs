
namespace ContactosJPB
{
    partial class Registro
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPWD = new System.Windows.Forms.Label();
            this.LblPWD2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPWD1 = new System.Windows.Forms.TextBox();
            this.TxtPWD2 = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(36, 57);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(69, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(36, 90);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(52, 17);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email:";
            // 
            // LblPWD
            // 
            this.LblPWD.AutoSize = true;
            this.LblPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWD.Location = new System.Drawing.Point(36, 122);
            this.LblPWD.Name = "LblPWD";
            this.LblPWD.Size = new System.Drawing.Size(96, 17);
            this.LblPWD.TabIndex = 2;
            this.LblPWD.Text = "Contraseña:";
            // 
            // LblPWD2
            // 
            this.LblPWD2.AutoSize = true;
            this.LblPWD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWD2.Location = new System.Drawing.Point(36, 154);
            this.LblPWD2.Name = "LblPWD2";
            this.LblPWD2.Size = new System.Drawing.Size(171, 17);
            this.LblPWD2.TabIndex = 3;
            this.LblPWD2.Text = "Confirmar Contraseña:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(225, 57);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(335, 20);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(225, 90);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(335, 20);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // TxtPWD1
            // 
            this.TxtPWD1.Location = new System.Drawing.Point(225, 122);
            this.TxtPWD1.MaxLength = 20;
            this.TxtPWD1.Name = "TxtPWD1";
            this.TxtPWD1.PasswordChar = '*';
            this.TxtPWD1.Size = new System.Drawing.Size(169, 20);
            this.TxtPWD1.TabIndex = 6;
            this.TxtPWD1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPWD1_KeyPress);
            // 
            // TxtPWD2
            // 
            this.TxtPWD2.Location = new System.Drawing.Point(225, 154);
            this.TxtPWD2.MaxLength = 20;
            this.TxtPWD2.Name = "TxtPWD2";
            this.TxtPWD2.PasswordChar = '*';
            this.TxtPWD2.Size = new System.Drawing.Size(169, 20);
            this.TxtPWD2.TabIndex = 7;
            this.TxtPWD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPWD2_KeyPress);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(220, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(109, 25);
            this.LblTitulo.TabIndex = 8;
            this.LblTitulo.Text = "Registrate";
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(225, 197);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(75, 23);
            this.BtnReg.TabIndex = 9;
            this.BtnReg.Text = "Registro";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(363, 197);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 288);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtPWD2);
            this.Controls.Add(this.TxtPWD1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblPWD2);
            this.Controls.Add(this.LblPWD);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNombre);
            this.Name = "Registro";
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPWD;
        private System.Windows.Forms.Label LblPWD2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPWD1;
        private System.Windows.Forms.TextBox TxtPWD2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnCancel;
    }
}