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

namespace Sena_2
{
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            this.admuserout.Text = CEjecutora.currUser.GetNom();
            this.ncuentasout.Text = CEjecutora.GetNumSenas().ToString();
            this.fechaout.Text = CEjecutora.currUser.GetFecha();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarNom_Click(object sender, EventArgs e)
        {
            var editor = new frmEditarUser(1);
            editor.ShowDialog();
            editor.Dispose();
            this.admuserout.Text = CEjecutora.currUser.GetNom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editor = new frmEditarUser(2);
            editor.ShowDialog();
            editor.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var editor = new frmEditarUser(3);
            editor.ShowDialog();
            editor.Dispose();
        }
    }
}
