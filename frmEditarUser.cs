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
    public partial class frmEditarUser : Form
    {
        private int modo;
        public frmEditarUser(int mod)
        {
            this.modo = mod;
            InitializeComponent();
        }


        private void frmEditarUser_Load(object sender, EventArgs e)
        {
            if(this.modo == 1)
            {//cambio de nombre
                this.Text = "Cambiar Usuario";
                this.label1.Text = "Ingrese Nuevo Usuario";
                this.label2.Text = "Ingrese Contraseña Actual";
                this.stringIn2.UseSystemPasswordChar = true;
            }
            if (this.modo == 2)
            {//cambio de pass
                this.Text = "Cambiar Contraseña";
                this.label1.Text = "Ingrese Contraseña Actual";
                this.label2.Text = "Ingrese Nueva Contraseña";
                this.stringIn2.UseSystemPasswordChar = false;
            }
            if(this.modo == 3)
            {//eliminar user
                this.Text = "Eliminar Usuario";
                this.label1.Text = "Confirme Su Usuario";
                this.label2.Text = "Confirme Su Contraseña";
                this.stringIn2.UseSystemPasswordChar = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if(this.stringIn1.TextLength < 4 || this.stringIn2.TextLength < 4)
            {
                this.lblerror.Show();
                return;
            }


            if(this.modo == 1)//cambio nombre
            {
                if (this.stringIn1.TextLength == 0)
                {
                    label1.ForeColor = Color.Red;
                    return;
                }
                if (this.stringIn2.TextLength == 0)
                {
                    label2.ForeColor = Color.Red;
                    return;
                }
                if (CEjecutora.currUser.Verificar(this.stringIn2.Text) == false)
                {
                    MessageBox.Show("La Contraseña es incorrecta");
                    return;
                }
                if (CEjecutora.UBuscar(this.stringIn1.Text))
                {
                    MessageBox.Show("Ya existe un usuario registrado con ese nombre");
                    return;
                }
                CEjecutora.UEdit("user", stringIn1.Text);
            }
            if(this.modo == 2)//cambio pass
            {
                if (this.stringIn1.TextLength == 0)
                {
                    label1.ForeColor = Color.Red;
                    return;
                }
                if (this.stringIn2.TextLength == 0)
                {
                    label2.ForeColor = Color.Red;
                    return;
                }
                if (CEjecutora.currUser.Verificar(this.stringIn1.Text) == false)
                {
                    MessageBox.Show("La Contraseña es incorrecta");
                    return;
                }
                CEjecutora.UEdit("pass", stringIn2.Text);
            }
            if(this.modo == 3)//Eliminar User
            {
                if (this.stringIn1.TextLength == 0)
                {
                    label1.ForeColor = Color.Red;
                    return;
                }
                if (this.stringIn2.TextLength == 0)
                {
                    label2.ForeColor = Color.Red;
                    return;
                }
                if(CEjecutora.currUser.GetNom() != this.stringIn1.Text)
                {
                    MessageBox.Show("Usuario Ingresado no coincide con el de la sesion");
                    return;
                }
                if (CEjecutora.currUser.Verificar(this.stringIn2.Text) == false)
                {
                    MessageBox.Show("La Contraseña es incorrecta");
                    return;
                }
                if(MessageBox.Show(this,"Esta apunto de borrar el usuario "+CEjecutora.currUser.GetNom()+", " +
                    "Esto eliminara todas las cuentas almacenadas a nombre de este usuario \n¿Desea Continuar?","Eliminar Usuario",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CEjecutora.URemove(CEjecutora.currUser);
                }
            }
            this.Close();
        }
    }
}
