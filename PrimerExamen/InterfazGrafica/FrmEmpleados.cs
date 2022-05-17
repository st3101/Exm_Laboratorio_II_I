using Biblioteca.Sistema;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmEmpleados : Form
    {
        FrmEmpleadosAltaEditar formularioAltaEditar;
        public FrmEmpleados()
        {
            InitializeComponent();
            ActualizarDataGridView();  
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            formularioAltaEditar = new FrmEmpleadosAltaEditar("Agregar");
            MostarFormularioAltaEditar();

        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int indice = buscarFilaDataGridView();
            formularioAltaEditar = new FrmEmpleadosAltaEditar("Editar", indice);
            MostarFormularioAltaEditar();

        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (PreguntarBorrar("¿Seguro que quieres borrar al empleado?"))
            {
                int indice = buscarFilaDataGridView();
                EliminarEmpleado(indice);
                ActualizarDataGridView();
            }

        }
        private void MostarFormularioAltaEditar()
        {
            if (formularioAltaEditar.ShowDialog() == DialogResult.OK)
            {
                formularioAltaEditar.Close();
                ActualizarDataGridView();
            }
        }
        private void ActualizarDataGridView()
        {
            LimpiarDataGridView();
            DgvEmpleado.DataSource = Sistema.ListaEmpleado;

        }

        private void LimpiarDataGridView()
        {
            DgvEmpleado.DataSource = "";
        }

        private void FrmEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EliminarEmpleado(int indice)
        {
            if (Sistema.EliminarEmpleado(indice))
            {
                MessageBox.Show("Empleado Eliminado");
                
            }
            else
            {
                MessageBox.Show("Error Empleado No Eliminado");
            }
        }
        private bool PreguntarBorrar(string mensaje)
        {
            if (MessageBox.Show(mensaje, "Borrar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private int buscarFilaDataGridView()
        {
           return DgvEmpleado.CurrentCell.RowIndex;
        }
    }
}
