using Biblioteca;
using Biblioteca.Sistema;
using System;
using System.Media;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmMesa : Form
    {
        FrmFacturacion frmFacturacion;
        Cliente cliente;
        bool seVendeComida;
        float valorEstasionamiento;
        string historial;
        public Cliente Mesa { get => cliente; set => cliente = value; }
        public bool SeVendeComida { get => seVendeComida; set => seVendeComida = value; }

        public FrmMesa(Cliente mesa, bool seVendeComida)
        {
            InitializeComponent();
            this.cliente = mesa;
            SeVendeComida = seVendeComida;
            valorEstasionamiento = 100;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
        }

        private void CargarMesa() 
        {
            ActualizarTodo();
            TxtNombreCliente.Text = cliente.Nombre;
            TxtApellidoCliente.Text = cliente.Apellido;
  
        }

        private void ActualizarTodo()
        {
            MostarCuentaAlimento();
            CalcularCuentatotal();
            ActualizarDgvAlimento();
            ActualizarDgvComida();
            ActualizarDgvBebida();
        }

        private void ActualizarDgvComida()
        {
            if (seVendeComida == true)
            {
                DgvInventarioComida.DataSource = string.Empty;
                DgvInventarioComida.DataSource = Sistema.ListaComida;
            }
        }
        private void ActualizarDgvBebida()
        {
            DgvInventarioBebida.DataSource = string.Empty;
            DgvInventarioBebida.DataSource = Sistema.ListaBebida;
        }
        private void ActualizarDgvAlimento()
        {
            DgvListaAlimentos.DataSource = string.Empty;
            DgvListaAlimentos.DataSource = cliente.ListaAlimentos;
        }

        private void MostarCuentaAlimento()
        {
            LblPrecioApagarNumero.Text = $"Precio Alimentos: {Mesa.GastoTotal}";
        }
        private void CalcularCuentatotal()
        {

        }
        private void BtnActualizarDatos_Click(object sender, EventArgs e)
        {
            ActualizarNombreMesa();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            CargarMesa();
        }

        private void DgvInventarioBebida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llevar a sistema
            int indice = DgvInventarioBebida.CurrentCell.RowIndex;

            Bebida bebida = Sistema.BuscarBebidaIndice(indice);

            if (bebida is not null)
            {
                Bebida auxBebida = Sistema.ClonarBebidaMismoId(bebida);

                if (auxBebida is not null && Sistema.PasarAliemntoAMesa(cliente, auxBebida))
                {
                    bebida.Cantidad--;

                    if (bebida.Cantidad == 0)
                    {
                        Sistema.EliminarBebida(indice);
                    }
                    cliente.CalcularPrecio();
                }
            }
            ActualizarTodo();
        }

        private void DgvInventarioComida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llevar a sistema
            int indice = DgvInventarioComida.CurrentCell.RowIndex;

            Comida comida = Sistema.BuscarComidaIndice(indice);

            if (comida is not null)
            {
                Comida auxComida = Sistema.ClonarComidaMismoId(comida);

                if (auxComida is not null && Sistema.PasarAliemntoAMesa(cliente, auxComida))
                {
                    comida.Cantidad--;

                    if (comida.Cantidad == 0)
                    {
                        Sistema.EliminarComida(indice);
                    }
                    cliente.CalcularPrecio();
                }
            }
            ActualizarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MostrarFrmFacturacion())
            {
                cliente.limpiarCliente();
                DialogResult = DialogResult.OK;
            }       
        }

        private void CkbEstacionamiento_CheckedChanged(object sender, EventArgs e)
        {
            CalcularCuentatotal();
        }

        private void CmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularCuentatotal();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cliente.limpiarCliente();
            this.DialogResult = DialogResult.Cancel;
        }

        private void ActualizarNombreMesa()
        {
            string auxNombre;
            string auxApellido;

            auxNombre = TxtNombreCliente.Text;
            auxApellido = TxtApellidoCliente.Text;

            if (!string.IsNullOrEmpty(auxNombre) && !string.IsNullOrEmpty(auxApellido))
            {

                cliente.Nombre = auxNombre;
                cliente.Apellido = auxApellido;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private bool MostrarFrmFacturacion()
        {
            bool retorno = false;

            FrmFacturacion frmFacturacion = new FrmFacturacion(cliente);

            if (frmFacturacion.ShowDialog() == DialogResult.OK)
            {
                retorno = true;
            }

            frmFacturacion.Close();
            return retorno;
        }
    }
}
