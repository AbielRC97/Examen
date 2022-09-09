
namespace ContactosJPB
{
    partial class FrmLogeo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblPWD = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPWD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(138, 26);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(244, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Bienvenido A Contactos";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // LblPWD
            // 
            this.LblPWD.AutoSize = true;
            this.LblPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWD.Location = new System.Drawing.Point(55, 117);
            this.LblPWD.Name = "LblPWD";
            this.LblPWD.Size = new System.Drawing.Size(96, 17);
            this.LblPWD.TabIndex = 2;
            this.LblPWD.Text = "Contraseña:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(210, 84);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(216, 20);
            this.TxtEmail.TabIndex = 3;
            this.TxtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // TxtPWD
            // 
            this.TxtPWD.Location = new System.Drawing.Point(210, 117);
            this.TxtPWD.Name = "TxtPWD";
            this.TxtPWD.PasswordChar = '*';
            this.TxtPWD.Size = new System.Drawing.Size(216, 20);
            this.TxtPWD.TabIndex = 4;
            this.TxtPWD.Enter += new System.EventHandler(this.TxtPWD_Enter);
            this.TxtPWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPWD_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLogeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 222);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPWD);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblPWD);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogeo";
            this.Text = "Logeo de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogeo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblPWD;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPWD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

