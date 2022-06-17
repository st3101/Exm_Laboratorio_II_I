using Biblioteca;
using Biblioteca.Sistema;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmEmpleadosAltaEditar : Form
    {
        string nombreAccion;
        int indice;
        public FrmEmpleadosAltaEditar(string NombreAccion)
        {
            InitializeComponent();
            this.nombreAccion = NombreAccion;
        }
        public FrmEmpleadosAltaEditar(string NombreAccion, int indice) : this(NombreAccion)
        {
            CompletarTxtBoxEmpleado(Sistema.BuscarEmpleadoIndice(indice));
            Indice = indice;
        }
        public string NombreAccion { get => nombreAccion; set => nombreAccion = value; }
        public int Indice { get => indice; set => indice = value; }

        private void BtnAgregarAlta_Click(object sender, EventArgs e)
        {
            //Metodo para validar todos las compos
            //Contraseñas sean iguales 

            if (nombreAccion == "Agregar")
            {
                if (Sistema.AgregarEmpleado(TxtNombre.Text, TxtApellido.Text, TxtUsuario.Text, TxtPassword.Text, ChkAdminitrador.Checked, TxtCuil.Text, TxtSueldo.Text))
                {
                    MessageBox.Show("Empleado Agregado Correctamente");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error Carga de empleado");
                }
            }
            else if (nombreAccion == "Editar")
            {
                if (Sistema.PisarEmpleado(Sistema.CrearEmpleado(TxtNombre.Text, TxtApellido.Text, TxtCuil.Text, TxtSueldo.Text, TxtUsuario.Text, TxtPassword.Text, ChkAdminitrador.Checked), Indice))
                {
                    MessageBox.Show("Empleado Editado Correctamente");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error Edicion de empleado");
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void CambiarTituloBoton()
        {
            LblTitulo.Text = NombreAccion;
        }

        private void CompletarTxtBoxEmpleado(Empleado empleado)
        {
            TxtNombre.Text = empleado.Nombre;
            TxtApellido.Text = empleado.Apellido;
            TxtCuil.Text = empleado.Cuil;
            TxtSueldo.Text = empleado.Sueldo.ToString();
            TxtUsuario.Text = empleado.Usuario;
            ChkAdminitrador.Checked = empleado.Administrador;
        }

        private void LimpiarFormulario()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCuil.Text = "";
            TxtSueldo.Text = "";
            TxtUsuario.Text = "";
            TxtPassword.Text = "";
            TxtRepetirPassword.Text = "";
            ChkAdminitrador.Checked = false;
        }

        private void FrmEmpleadosAltaEditar_Load(object sender, EventArgs e)
        {
            CambiarTituloBoton();
            CambiarTitulo();
        }
        private void CambiarTitulo()
        {
            this.Text = nombreAccion;
        }
    }
}
