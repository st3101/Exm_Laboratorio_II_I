using Biblioteca.Sistema;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmInventario : Form
    {
        FrmAlimentoAltaEditar frmAlimentoAltaEditar;
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void BtnAgregarComida_Click(object sender, EventArgs e)
        {
            CrearFormularioAgregar("Agregar", "Comida");
        }

        private void BtnAgregarBebida_Click(object senderm, EventArgs e)
        {
            CrearFormularioAgregar("Agregar", "Bebida");
        }
        private void BtnEditarComida_Click(object sender, EventArgs e)
        {
            CrearFormularioEditar("Editar", "Comida", buscarFilaDataGridView(DgvComida));
        }
        private void CrearFormularioAgregar(string tipoAccion, string tipoComida)
        {

            frmAlimentoAltaEditar = new FrmAlimentoAltaEditar(tipoAccion, tipoComida);

            if (frmAlimentoAltaEditar.ShowDialog() == DialogResult.OK)
            {
                frmAlimentoAltaEditar.Close();
                ActualizarDataGridView(DgvComida);
                ActualizarDataGridView(DgvBebida);
            }

        }

        private void CrearFormularioEditar(string tipoAccion, string tipoComida, int indice)
        {
            frmAlimentoAltaEditar = new FrmAlimentoAltaEditar(tipoAccion, tipoComida, indice);

            if (frmAlimentoAltaEditar.ShowDialog() == DialogResult.OK)
            {
                frmAlimentoAltaEditar.Close();
                ActualizarDataGridView(DgvComida);
                ActualizarDataGridView(DgvBebida);
            }

        }
        private void ActualizarDataGridView(DataGridView datDgvComidaaGridView)
        {
            LimpiarDataGridView(datDgvComidaaGridView);
            CargarDataGrid(datDgvComidaaGridView);

        }

        private void LimpiarDataGridView(DataGridView datDgvComidaaGridView)
        {
            datDgvComidaaGridView.DataSource = "";
        }

        private void CargarDataGrid(DataGridView datDgvComidaaGridView)
        {
            if (datDgvComidaaGridView.Name == "DgvComida")
            {
                datDgvComidaaGridView.DataSource = Sistema.ListaComida;
            }
            else if (datDgvComidaaGridView.Name == "DgvBebida")
            {
                datDgvComidaaGridView.DataSource = Sistema.ListaBebida;
            }
        }

        private void BtnEditarBebida_Click(object sender, EventArgs e)
        {
            CrearFormularioEditar("Editar", "Bebida", DgvBebida.CurrentCell.RowIndex);
        }

        private void BtnBorrarComida_Click(object sender, EventArgs e)
        {
            if (preguntarBorrar("¿Seguro que quieres borrar la comida?"))
            {
                int indice = buscarFilaDataGridView(DgvComida);
                Sistema.EliminarComida(indice);
                ActualizarDataGridView(DgvComida);
            }
        }
        private void BtnEliminarBebida_Click(object sender, EventArgs e)
        {
            if (preguntarBorrar("¿Seguro que quieres borrar la bebida?"))
            {
                int indice = buscarFilaDataGridView(DgvBebida);
                Sistema.EliminarBebida(indice);
                ActualizarDataGridView(DgvBebida);
            }
        }

        private int buscarFilaDataGridView(DataGridView nombreDtg)
        {
            return nombreDtg.CurrentCell.RowIndex;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView(DgvComida);
            ActualizarDataGridView(DgvBebida);
        }

        private bool preguntarBorrar(string mensaje)
        {
            if (MessageBox.Show(mensaje, "Borrar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        
        private void  BorrarBebida(DataGridView dataGridView)
        {
            int indice = buscarFilaDataGridView(dataGridView);
            Sistema.EliminarBebida(indice);
            
        }
    }
}
