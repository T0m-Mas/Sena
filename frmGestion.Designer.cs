namespace Sena
{
    partial class frmGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usIn = new System.Windows.Forms.TextBox();
            this.passIn = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // usIn
            // 
            this.usIn.Location = new System.Drawing.Point(15, 29);
            this.usIn.MaxLength = 16;
            this.usIn.Name = "usIn";
            this.usIn.Size = new System.Drawing.Size(189, 20);
            this.usIn.TabIndex = 1;
            // 
            // passIn
            // 
            this.passIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passIn.Location = new System.Drawing.Point(15, 68);
            this.passIn.MaxLength = 16;
            this.passIn.Name = "passIn";
            this.passIn.PasswordChar = 'x';
            this.passIn.Size = new System.Drawing.Size(189, 20);
            this.passIn.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(223, 29);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 59);
            this.Login.TabIndex = 3;
            this.Login.Text = "Entrar";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(223, 94);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 28);
            this.Register.TabIndex = 4;
            this.Register.Text = "Registrarse";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 94);
            this.lblmsg.MaximumSize = new System.Drawing.Size(193, 28);
            this.lblmsg.MinimumSize = new System.Drawing.Size(0, 28);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(174, 28);
            this.lblmsg.TabIndex = 4;
            this.lblmsg.Text = "Los campos Usuario y contraseña deben tener al menos 4 caracteres.";
            this.lblmsg.Visible = false;
            // 
            // frmGestion
            // 
            this.AcceptButton = this.Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 136);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passIn);
            this.Controls.Add(this.usIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usIn;
        private System.Windows.Forms.TextBox passIn;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label lblmsg;
    }
}