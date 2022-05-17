using Biblioteca;
using Biblioteca.Sistema;
using System;
using System.Media;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmMesa : Form
    {
        Mesa mesa;
        bool seVendeComida;
        float valorEstasionamiento;
        string historial;
        public Mesa Mesa { get => mesa; set => mesa = value; }
        public bool SeVendeComida { get => seVendeComida; set => seVendeComida = value; }

        public FrmMesa(Mesa mesa, bool seVendeComida)
        {
            InitializeComponent();
            this.mesa = mesa;
            SeVendeComida = seVendeComida;
            valorEstasionamiento = 100;
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
        }

        private void CargarMesa()
        {
            ActualizarTodo();
            TxtNombreCliente.Text = mesa.Nombre;
            TxtApellidoCliente.Text = mesa.Apellido;
            CmbMetodoPago.Text = "Efectivo";
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
            DgvListaAlimentos.DataSource = mesa.ListaAlimentos;
        }

        private void MostarCuentaAlimento()
        {
            LblPrecioApagarNumero.Text = Mesa.GastoTotal.ToString();
        }
        private void CalcularCuentatotal()
        {
            float precioTotal = Sistema.CalculaTotal(Mesa.GastoTotal, CkbEstacionamiento.Checked, CmbMetodoPago.Text);
            LblTotal.Text = $"Total: {precioTotal}";
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

                if (auxBebida is not null && Sistema.PasarAliemntoAMesa(mesa, auxBebida))
                {
                    bebida.Cantidad--;

                    if (bebida.Cantidad == 0)
                    {
                        Sistema.EliminarBebida(indice);
                    }
                    mesa.CalcularPrecio();
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

                if (auxComida is not null && Sistema.PasarAliemntoAMesa(mesa, auxComida))
                {
                    comida.Cantidad--;

                    if (comida.Cantidad == 0)
                    {
                        Sistema.EliminarComida(indice);
                    }
                    mesa.CalcularPrecio();
                }
            }
            ActualizarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesa.GuardarInformacionVenta(CkbEstacionamiento.Checked, CmbMetodoPago.Text, LblTotal.Text);
            Sistema.BorrarMesa(mesa);
            this.DialogResult = DialogResult.OK;
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
            Sistema.BorrarMesa(mesa);
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
               
                mesa.Nombre = auxNombre;
                mesa.Apellido = auxApellido;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

    }

}
