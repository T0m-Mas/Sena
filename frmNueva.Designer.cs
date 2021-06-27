namespace Sena_2
{
    partial class frmNueva
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
            this.usIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailIn = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.plusIn = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.boolPlus = new System.Windows.Forms.CheckBox();
            this.boolCorreo = new System.Windows.Forms.CheckBox();
            this.nomIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usIn
            // 
            this.usIn.Location = new System.Drawing.Point(14, 81);
            this.usIn.MaxLength = 28;
            this.usIn.Name = "usIn";
            this.usIn.Size = new System.Drawing.Size(218, 20);
            this.usIn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passIn
            // 
            this.passIn.Location = new System.Drawing.Point(13, 123);
            this.passIn.MaxLength = 28;
            this.passIn.Name = "passIn";
            this.passIn.Size = new System.Drawing.Size(218, 20);
            this.passIn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mailIn
            // 
            this.mailIn.Location = new System.Drawing.Point(13, 167);
            this.mailIn.MaxLength = 28;
            this.mailIn.Name = "mailIn";
            this.mailIn.Size = new System.Drawing.Size(218, 20);
            this.mailIn.TabIndex = 4;
            this.mailIn.TextChanged += new System.EventHandler(this.mailIn_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.lblCorreo.Location = new System.Drawing.Point(15, 149);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 15);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plusIn
            // 
            this.plusIn.Enabled = false;
            this.plusIn.Location = new System.Drawing.Point(12, 210);
            this.plusIn.MaxLength = 255;
            this.plusIn.Multiline = true;
            this.plusIn.Name = "plusIn";
            this.plusIn.Size = new System.Drawing.Size(218, 51);
            this.plusIn.TabIndex = 5;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Enabled = false;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.lblPlus.Location = new System.Drawing.Point(14, 192);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(106, 15);
            this.lblPlus.TabIndex = 4;
            this.lblPlus.Text = "Informacion Extra:";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(155, 296);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 8;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(12, 296);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 7;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // boolPlus
            // 
            this.boolPlus.AutoSize = true;
            this.boolPlus.Location = new System.Drawing.Point(215, 194);
            this.boolPlus.Name = "boolPlus";
            this.boolPlus.Size = new System.Drawing.Size(15, 14);
            this.boolPlus.TabIndex = 6;
            this.boolPlus.UseVisualStyleBackColor = true;
            this.boolPlus.CheckedChanged += new System.EventHandler(this.boolPlus_CheckedChanged);
            // 
            // boolCorreo
            // 
            this.boolCorreo.AutoSize = true;
            this.boolCorreo.Checked = true;
            this.boolCorreo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boolCorreo.Location = new System.Drawing.Point(215, 151);
            this.boolCorreo.Name = "boolCorreo";
            this.boolCorreo.Size = new System.Drawing.Size(15, 14);
            this.boolCorreo.TabIndex = 4;
            this.boolCorreo.UseVisualStyleBackColor = true;
            this.boolCorreo.CheckedChanged += new System.EventHandler(this.boolCorreo_CheckedChanged);
            // 
            // nomIn
            // 
            this.nomIn.Location = new System.Drawing.Point(14, 40);
            this.nomIn.MaxLength = 16;
            this.nomIn.Name = "nomIn";
            this.nomIn.Size = new System.Drawing.Size(218, 20);
            this.nomIn.TabIndex = 1;
            this.nomIn.TextChanged += new System.EventHandler(this.nomIn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alias:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNueva
            // 
            this.AcceptButton = this.bGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(246, 330);
            this.Controls.Add(this.boolCorreo);
            this.Controls.Add(this.boolPlus);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusIn);
            this.Controls.Add(this.mailIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passIn);
            this.Controls.Add(this.nomIn);
            this.Controls.Add(this.usIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNueva";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailIn;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox plusIn;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.CheckBox boolPlus;
        private System.Windows.Forms.CheckBox boolCorreo;
        private System.Windows.Forms.TextBox nomIn;
        private System.Windows.Forms.Label label3;
    }
}