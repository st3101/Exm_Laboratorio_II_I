using Biblioteca;
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
    public partial class FrmFacturacion : Form
    {
        Cliente cliente;
        public FrmFacturacion(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void BtnCerrarCuenta_Click(object sender, EventArgs e)
        {
            cliente.GuardarInformacionVenta(Sistema.TieneEstacionamiento(CkbEstacionamiento.Checked), CmbMetodoDePago.Text, LblTotal.Text);
            DialogResult = DialogResult.OK;
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
            CmbMetodoDePago.Text = "Efectivo";
        }

        private void ActualizarDatos()
        {
            calcularTotal();
            ActualizacionTotalAlimneto();
            ActualizarDataGridView();         
        }
        private void calcularTotal()
        {
            float precioTotal = Sistema.CalculaTotal(cliente.GastoTotal, CkbEstacionamiento.Checked, CmbMetodoDePago.Text);
            LblTotal.Text = $"Precio Final: ${precioTotal}";
        }

        private void CmbMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void CkbEstacionamiento_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        private void CmbMetodoDePago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        private void ActualizacionTotalAlimneto()
        {
            LblPrecioAlimento.Text = $"Precio Alimento: ${cliente.GastoTotal.ToString()}";
        }
        private void ActualizarDataGridView()
        {
            DtgAlimentos.DataSource = cliente.ListaAlimentos;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnCerraCuenta_Click(object sender, EventArgs e)
        {
            cliente.GuardarInformacionVenta(Sistema.TieneEstacionamiento(CkbEstacionamiento.Checked),CmbMetodoDePago.Text, Sistema.CalculaTotal(cliente.GastoTotal, CkbEstacionamiento.Checked, CmbMetodoDePago.Text).ToString());
            MessageBox.Show(cliente.HistorialVenta,"Tiket");
            DialogResult = DialogResult.OK;
        }
    }
}
