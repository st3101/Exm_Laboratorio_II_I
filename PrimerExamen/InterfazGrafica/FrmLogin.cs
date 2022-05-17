using Biblioteca.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmLogin : Form
    {
        private FrnMenu menu;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {        
            if(!Loguear())
            {
                MessageBox.Show("No se encontro al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }

        private void btnAutoLoginAdmin_Click(object sender, EventArgs e)
        {
            CargarTextoLogin("st3101", "147");
        }

        private void BntLoginUsuario_Click(object sender, EventArgs e)
        {
            CargarTextoLogin("Pepapa", "meGusta");
        }
    
        private void CargarTextoLogin(string usuario,string password)
        {
            TxtUsuario.Text = usuario;
            TxtPassword.Text = password;
        }

        private bool Loguear()
        {
            if (Sistema.BuscarUsuarioLogin(TxtUsuario.Text, TxtPassword.Text))
            {
                menu = new FrnMenu(Sistema.BuscarEmpleado(TxtUsuario.Text, TxtPassword.Text));
                this.Hide();

                if (menu.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    menu.Close();
                }
                this.Show();
                return true;
            }
            return false;
        }

        private void limpiar()
        {
            TxtUsuario.Text = String.Empty;
            TxtPassword.Text = String.Empty;
        }
    }
}
