namespace Sena_2
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Listado = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Button();
            this.ocultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserOut = new System.Windows.Forms.Label();
            this.plusOut = new System.Windows.Forms.TextBox();
            this.lblplus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MailOut = new System.Windows.Forms.Label();
            this.PassOut = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrUserOut = new System.Windows.Forms.Label();
            this.MenuGestionUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CambiarUser = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMensage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuGestionUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Listado.FormattingEnabled = true;
            this.Listado.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Listado.ItemHeight = 16;
            this.Listado.Location = new System.Drawing.Point(12, 16);
            this.Listado.Name = "Listado";
            this.Listado.ScrollAlwaysVisible = true;
            this.Listado.Size = new System.Drawing.Size(125, 260);
            this.Listado.TabIndex = 0;
            this.Listado.Tag = "CUENTAS";
            this.Listado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(437, 251);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(88, 27);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(17, 49);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 23);
            this.mod.TabIndex = 1;
            this.mod.Text = "Modificar";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(17, 20);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 1;
            this.ver.Text = "Ver";
            this.ver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ver.UseVisualStyleBackColor = true;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // ocultar
            // 
            this.ocultar.Location = new System.Drawing.Point(17, 19);
            this.ocultar.Name = "ocultar";
            this.ocultar.Size = new System.Drawing.Size(75, 23);
            this.ocultar.TabIndex = 4;
            this.ocultar.Text = "Ocultar";
            this.ocultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ocultar.UseVisualStyleBackColor = true;
            this.ocultar.Visible = false;
            this.ocultar.Click += new System.EventHandler(this.ocultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ocultar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ver);
            this.groupBox1.Controls.Add(this.mod);
            this.groupBox1.Location = new System.Drawing.Point(161, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UserOut);
            this.panel1.Controls.Add(this.plusOut);
            this.panel1.Controls.Add(this.lblplus);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.MailOut);
            this.panel1.Controls.Add(this.PassOut);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(99, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 166);
            this.panel1.TabIndex = 3;
            // 
            // UserOut
            // 
            this.UserOut.Location = new System.Drawing.Point(53, 10);
            this.UserOut.Name = "UserOut";
            this.UserOut.Size = new System.Drawing.Size(191, 19);
            this.UserOut.TabIndex = 3;
            this.UserOut.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.UserOut.Visible = false;
            // 
            // plusOut
            // 
            this.plusOut.Enabled = false;
            this.plusOut.Location = new System.Drawing.Point(12, 85);
            this.plusOut.Multiline = true;
            this.plusOut.Name = "plusOut";
            this.plusOut.ReadOnly = true;
            this.plusOut.Size = new System.Drawing.Size(232, 53);
            this.plusOut.TabIndex = 1;
            // 
            // lblplus
            // 
            this.lblplus.AutoSize = true;
            this.lblplus.Location = new System.Drawing.Point(9, 65);
            this.lblplus.Name = "lblplus";
            this.lblplus.Size = new System.Drawing.Size(91, 13);
            this.lblplus.TabIndex = 0;
            this.lblplus.Text = "Informacion extra:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(209, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Eliminar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MailOut
            // 
            this.MailOut.AutoSize = true;
            this.MailOut.Location = new System.Drawing.Point(47, 47);
            this.MailOut.Name = "MailOut";
            this.MailOut.Size = new System.Drawing.Size(193, 13);
            this.MailOut.TabIndex = 0;
            this.MailOut.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.MailOut.Visible = false;
            // 
            // PassOut
            // 
            this.PassOut.Location = new System.Drawing.Point(72, 29);
            this.PassOut.Name = "PassOut";
            this.PassOut.Size = new System.Drawing.Size(172, 15);
            this.PassOut.TabIndex = 0;
            this.PassOut.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.PassOut.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(9, 47);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 13);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // lblCurrUserOut
            // 
            this.lblCurrUserOut.AutoSize = true;
            this.lblCurrUserOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrUserOut.Location = new System.Drawing.Point(433, 9);
            this.lblCurrUserOut.MinimumSize = new System.Drawing.Size(98, 13);
            this.lblCurrUserOut.Name = "lblCurrUserOut";
            this.lblCurrUserOut.Size = new System.Drawing.Size(98, 20);
            this.lblCurrUserOut.TabIndex = 3;
            this.lblCurrUserOut.Text = "Username";
            this.lblCurrUserOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrUserOut.UseMnemonic = false;
            this.lblCurrUserOut.Click += new System.EventHandler(this.lblCurrUserOut_Click);
            // 
            // MenuGestionUsers
            // 
            this.MenuGestionUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambiarUser,
            this.GestionUsers});
            this.MenuGestionUsers.Name = "MenuGestionUsers";
            this.MenuGestionUsers.ShowImageMargin = false;
            this.MenuGestionUsers.Size = new System.Drawing.Size(183, 48);
            // 
            // CambiarUser
            // 
            this.CambiarUser.Name = "CambiarUser";
            this.CambiarUser.Size = new System.Drawing.Size(182, 22);
            this.CambiarUser.Text = "Cambiar de usuario";
            this.CambiarUser.Click += new System.EventHandler(this.CambiarUser_Click);
            // 
            // GestionUsers
            // 
            this.GestionUsers.Name = "GestionUsers";
            this.GestionUsers.Size = new System.Drawing.Size(182, 22);
            this.GestionUsers.Text = "Administrar Usuario";
            this.GestionUsers.Click += new System.EventHandler(this.GestionUsers_Click);
            // 
            // lblMensage
            // 
            this.lblMensage.AutoSize = true;
            this.lblMensage.Location = new System.Drawing.Point(158, 257);
            this.lblMensage.MinimumSize = new System.Drawing.Size(260, 13);
            this.lblMensage.Name = "lblMensage";
            this.lblMensage.Size = new System.Drawing.Size(260, 13);
            this.lblMensage.TabIndex = 4;
            this.lblMensage.Text = "Se ha alcanzado el maximo de cuenas almacenadas";
            this.lblMensage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMensage.Visible = false;
            this.lblMensage.Click += new System.EventHandler(this.lblMensage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 297);
            this.Controls.Add(this.lblMensage);
            this.Controls.Add(this.lblCurrUserOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 326);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sena";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuGestionUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Agregar;
        public System.Windows.Forms.ListBox Listado;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.Button ocultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip MenuGestionUsers;
        private System.Windows.Forms.ToolStripMenuItem CambiarUser;
        private System.Windows.Forms.ToolStripMenuItem GestionUsers;
        private System.Windows.Forms.Label lblMensage;
        public  System.Windows.Forms.Label lblCurrUserOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserOut;
        private System.Windows.Forms.TextBox plusOut;
        private System.Windows.Forms.Label lblplus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label MailOut;
        private System.Windows.Forms.Label PassOut;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

