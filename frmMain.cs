using Sena;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sena_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {            
            InitializeComponent();            
            CargarListado();
            lblCurrUserOut.Text = CEjecutora.currUser.GetNom();

            if (CEjecutora.GetNumSenas() == 32)
            {
                this.Agregar.Enabled = false;
                this.lblMensage.Visible = true;
            }
        }

        private void CargarListado()
        {
            string str;

            str = CEjecutora.DarNombre();

            while(str != "\n")
            {
                this.Listado.Items.Add(str);
                str = CEjecutora.DarNombre();
            }


        }
        public void RecargarListado()
        {
            this.Listado.Items.Clear();
            string str;

            str = CEjecutora.DarNombre(1);

            while (str != "\n")
            {
                this.Listado.Items.Add(str);
                str = CEjecutora.DarNombre();
            }
            if(this.Listado.Items.Count>0)
                this.Listado.SetSelected(0, true);
            else
            {
                this.groupBox1.Text = "";
                this.linkLabel1.Enabled = false;
                this.ocultar.Hide();
                this.ver.Show();
                OcultarDatos();
            }       

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Listado.SelectedIndex >= 0)
            {
                string msgConfirm = "¿Esta seguro que desea eliminar la cuenta " + this.Listado.SelectedItem.ToString() + "?";
                if (MessageBox.Show(this, msgConfirm, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CEjecutora.Eliminar(this.Listado.SelectedIndex);
                    this.RecargarListado();
                }
            }
        }        

        private void MostrarDatos()
        {
            this.UserOut.Show();
            this.PassOut.Show();
            this.MailOut.Show();
            //this.plusOut.Enabled = true;
        }
        private void OcultarDatos()
        {
            this.UserOut.Hide();
            this.PassOut.Hide();
            this.MailOut.Hide();
            this.plusOut.Clear();
            this.plusOut.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Listado.SelectedIndex >= 0)//si 
            {
                this.linkLabel1.Enabled = true;
                if(this.Listado.Items.Count == 0) { this.groupBox1.Text = ""; this.linkLabel1.Enabled = false; }
                else this.groupBox1.Text = this.Listado.SelectedItem.ToString();
            }
            else
            {
                this.linkLabel1.Enabled = false;
            }
            
            OcultarDatos();
            this.ocultar.Hide();
            this.ver.Show();
        }

        private void ver_Click(object sender, EventArgs e)
        {
            if (this.Listado.SelectedIndex >= 0)
            {

                Sena S = CEjecutora.DarDatos(this.Listado.SelectedIndex);

                this.UserOut.Text = S.User;
                this.PassOut.Text = S.Pass;
                this.MailOut.Text = S.Mail;
                if (S.Extra == "!=") { this.plusOut.Clear(); this.plusOut.Enabled = false; }
                else { this.plusOut.Text = S.Extra; this.plusOut.Enabled = true; }

                MostrarDatos();
                this.ver.Hide();
                this.ocultar.Show();
            }

        }

        private void ocultar_Click(object sender, EventArgs e)
        {
            OcultarDatos();
            this.ocultar.Hide();
            this.ver.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmNew = new frmNueva();
            frmNew.ShowDialog();
            this.RecargarListado();
        }

        private void mod_Click(object sender, EventArgs e)
        {
            
            if(this.Listado.SelectedIndex<0) { return; }
            Sena S = CEjecutora.DarDatos(this.Listado.SelectedIndex);
            
            var frmNew = new frmNueva(S.Nom,S.Pass,S.User,S.Mail,S.Extra,this.Listado.SelectedIndex);
            frmNew.ShowDialog();
            this.RecargarListado();

        }

        private void lblCurrUserOut_Click(object sender, EventArgs e)
        {
            MenuGestionUsers.Show(MousePosition);
        }

        private void CambiarUser_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GestionUsers_Click(object sender, EventArgs e)
        {
            var frmGestion = new frmGestionUsuarios();
            frmGestion.ShowDialog();
            frmGestion.Dispose();
            this.lblCurrUserOut.Text = CEjecutora.currUser.GetNom();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblMensage_Click(object sender, EventArgs e)
        {

        }
    }
}
