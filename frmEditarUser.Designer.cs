
namespace Sena_2
{
    partial class frmEditarUser
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.stringIn1 = new System.Windows.Forms.TextBox();
            this.stringIn2 = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(141, 109);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // stringIn1
            // 
            this.stringIn1.Location = new System.Drawing.Point(12, 27);
            this.stringIn1.MaxLength = 16;
            this.stringIn1.Name = "stringIn1";
            this.stringIn1.Size = new System.Drawing.Size(206, 20);
            this.stringIn1.TabIndex = 3;
            // 
            // stringIn2
            // 
            this.stringIn2.Location = new System.Drawing.Point(12, 79);
            this.stringIn2.MaxLength = 16;
            this.stringIn2.Name = "stringIn2";
            this.stringIn2.Size = new System.Drawing.Size(206, 20);
            this.stringIn2.TabIndex = 4;
            // 
            // lblerror
            // 
            this.lblerror.Location = new System.Drawing.Point(9, 105);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(128, 42);
            this.lblerror.TabIndex = 5;
            this.lblerror.Text = "Los campos deben tener al menos 4 caracteres";
            this.lblerror.Visible = false;
            // 
            // frmEditarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 140);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.stringIn2);
            this.Controls.Add(this.stringIn1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "titulo";
            this.Load += new System.EventHandler(this.frmEditarUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox stringIn1;
        private System.Windows.Forms.TextBox stringIn2;
        private System.Windows.Forms.Label lblerror;
    }
}