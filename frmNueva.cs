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
    public partial class frmNueva : Form
    {
        private bool edit;
        private int nSenEdit;
        public frmNueva()
        {
            this.edit = false;
            InitializeComponent();
        }
        public frmNueva(string nomin, string passin, string usin, string mailin, string plusin,int N)
        {
            this.edit = true;
            this.nSenEdit = N;
            InitializeComponent();
            this.Text = "Modificar Cuenta";
            this.nomIn.Text = nomin;
            this.passIn.Text = passin;
            this.usIn.Text = usin;

            if (mailin == "No asignado") { this.mailIn.Clear(); this.boolCorreo.Checked = false; }
            else { this.mailIn.Text = mailin; this.boolCorreo.Checked = true; }
            if (plusin == "!=") { this.plusIn.Clear(); this.boolPlus.Checked = false; }
            else { this.plusIn.Text = plusin; this.boolPlus.Checked = true; }
        }



        private void boolCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.boolCorreo.Checked)
            {
                this.mailIn.Enabled = true;
                this.lblCorreo.Enabled = true;
            }
            else
            {
                this.mailIn.Enabled = false;
                this.lblCorreo.Enabled = false;
            }
        }

        private void boolPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (this.boolPlus.Checked)
            {
                this.plusIn.Enabled = true;
                this.lblPlus.Enabled = true;
            }
            else
            {
                this.plusIn.Enabled = false;
                this.lblPlus.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomin, passin, usin, mailin, plusin;

            nomin = this.nomIn.Text;

            if (nomin == "" || nomin == " ")
            {
                MessageBox.Show(this, "El campo 'Alias' no puede quedar vacio", "Error!", MessageBoxButtons.OK);
                return;
            }

            passin = this.passIn.Text;
            usin = this.usIn.Text;

            if(passin==""||passin==" ") { passin = "No asignado"; }
            if(usin==""||usin==" ") { usin = "No asignado"; }
            if(boolCorreo.Checked) { mailin = this.mailIn.Text; }
            else { mailin = "No asignado"; }
            if (boolPlus.Checked) { plusin = this.plusIn.Text; }
            else { plusin = "!="; }

            if (!this.edit) { CEjecutora.Agregar(nomin, passin, usin, mailin, plusin); }
            else { CEjecutora.Editar(nSenEdit, nomin, passin, usin, mailin, plusin); }
            
            this.Hide();
        }

        private void mailIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
