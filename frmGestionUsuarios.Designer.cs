namespace Sena_2
{
    partial class frmGestionUsuarios
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCambiarNom = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.admuserout = new System.Windows.Forms.Label();
            this.ncuentasout = new System.Windows.Forms.Label();
            this.fechaout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Cuentas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Registro:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCambiarNom
            // 
            this.btnCambiarNom.Location = new System.Drawing.Point(12, 97);
            this.btnCambiarNom.Name = "btnCambiarNom";
            this.btnCambiarNom.Size = new System.Drawing.Size(202, 23);
            this.btnCambiarNom.TabIndex = 4;
            this.btnCambiarNom.Text = "Cambiar nombre de usuario";
            this.btnCambiarNom.UseVisualStyleBackColor = true;
            this.btnCambiarNom.Click += new System.EventHandler(this.btnCambiarNom_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cambiar contraseña";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Eliminar usuario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // admuserout
            // 
            this.admuserout.AutoSize = true;
            this.admuserout.Location = new System.Drawing.Point(116, 12);
            this.admuserout.MinimumSize = new System.Drawing.Size(98, 13);
            this.admuserout.Name = "admuserout";
            this.admuserout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.admuserout.Size = new System.Drawing.Size(98, 13);
            this.admuserout.TabIndex = 7;
            this.admuserout.Text = "userout";
            this.admuserout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ncuentasout
            // 
            this.ncuentasout.AutoSize = true;
            this.ncuentasout.Location = new System.Drawing.Point(116, 39);
            this.ncuentasout.MinimumSize = new System.Drawing.Size(98, 13);
            this.ncuentasout.Name = "ncuentasout";
            this.ncuentasout.Size = new System.Drawing.Size(98, 13);
            this.ncuentasout.TabIndex = 8;
            this.ncuentasout.Text = "0";
            this.ncuentasout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechaout
            // 
            this.fechaout.AutoSize = true;
            this.fechaout.Location = new System.Drawing.Point(116, 64);
            this.fechaout.MinimumSize = new System.Drawing.Size(98, 13);
            this.fechaout.Name = "fechaout";
            this.fechaout.Size = new System.Drawing.Size(98, 13);
            this.fechaout.TabIndex = 9;
            this.fechaout.Text = "DD/MM/AAAA";
            this.fechaout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 189);
            this.Controls.Add(this.fechaout);
            this.Controls.Add(this.ncuentasout);
            this.Controls.Add(this.admuserout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCambiarNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Usuario";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCambiarNom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label admuserout;
        private System.Windows.Forms.Label ncuentasout;
        private System.Windows.Forms.Label fechaout;
    }
}