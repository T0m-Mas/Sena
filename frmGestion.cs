using Sena_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sena
{
    public partial class frmGestion : Form
    {
        
        public frmGestion()
        {
            InitializeComponent();
            if (CEjecutora.NumUsers() == 0)
            {
                this.Login.Enabled = false;
                this.lblmsg.Text = "No hay usuarios registrados";
                this.lblmsg.Visible = true;
            }
            if (CEjecutora.NumUsers() == 5)
            {
                this.Register.Enabled = false;
                this.lblmsg.Text = "No se pueden almacenar mas usuarios";
                this.lblmsg.Visible = true;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(this.usIn.Text.Length < 4 || this.passIn.Text.Length < 4)
            {
                this.lblmsg.Text = "Los campos Usuario y Contraseña deben tener al menos 4 caracteres";
                this.lblmsg.Visible = true;
                return;
            }
            else
            {
                if (CEjecutora.ULogin(usIn.Text, passIn.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (this.usIn.Text.Length < 4 || this.passIn.Text.Length < 4)
            {
                this.lblmsg.Text = "Los campos Usuario y Contraseña deben tener al menos 4 caracteres";
                this.lblmsg.Visible = true;
                return;
            }
            else
            {
                if (CEjecutora.URegister(usIn.Text, passIn.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        private void Cancelado(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
