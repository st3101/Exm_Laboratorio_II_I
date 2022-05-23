using Biblioteca;
using Biblioteca.Sistema;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrnMenu : Form
    {
        private Empleado empleadoLogeado;
        private FrmEmpleados frmEmpleados;
        private FrmInventario frnInventario;
        private FrmMesa frmMesa;
        private FrmHistorial frmHistorial;
        private StringBuilder historial;

        private Empleado EmpleadoLogeado { get => empleadoLogeado; set => empleadoLogeado = value; }

        public FrnMenu(Empleado empledoLogeado)
        {
            InitializeComponent();
            this.EmpleadoLogeado = empledoLogeado;
            historial = new StringBuilder();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            EditarFormulario();
        }

        private void FrnMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro cerrar sesion?", "Cerrar sesion?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void ButtonEmpleado_Click(object sender, EventArgs e)
        {
            MotrarEmpleados();
        }

        private void ButtonInventario_Click(object sender, EventArgs e)
        {
            MostrarInvetario();
        }

        private void ButtonMesa_Click(object sender, EventArgs e)
        {
            Button botonApretado;

            botonApretado = (Button)sender;
            int valor;

            if (int.TryParse(botonApretado.Text, out valor))
            {
                if (valor >= 1 && valor <= 15)
                {
                    MostrarMesa(botonApretado, true);
                }
                else if (valor >= 16 && valor <= 20)
                {
                    MostrarMesa(botonApretado, false);
                }
            }
        }
        private void MostrarHistorial()
        {
            frmHistorial = new FrmHistorial(historial.ToString());

            if (frmHistorial is not null)
            {
                if (frmHistorial.ShowDialog() == DialogResult.OK)
                {
                    frmHistorial.Close();
                }
            }
        }

        private void MostrarMesa(Button btn, bool seVendeBebida)
        {
            DialogResult resultado;
            Cliente mesa = Sistema.BuscarMesaInice(btn.Text);
            frmMesa = new FrmMesa(mesa, seVendeBebida);


            if (mesa is not null && frmMesa is not null)
            {
                resultado = frmMesa.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CargarHistorial(mesa);
                    frmMesa.Close();
                    btn.BackColor = Color.DarkSlateBlue;
                }
                else if (resultado == DialogResult.Ignore)
                {
                    btn.BackColor = Color.FromArgb(90, 0, 200);
                }
                else
                {
                    btn.BackColor = Color.DarkSlateBlue;
                }
            }
        }
        private void MotrarEmpleados()
        {
            frmEmpleados = new FrmEmpleados();

            if (frmEmpleados is not null)
            {
                if (frmEmpleados.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    frmEmpleados.Close();
                }
            }
        }
        private void MostrarInvetario()
        {
            frnInventario = new FrmInventario();

            if (frnInventario.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                frnInventario.Close();
            }
        }
        private void EditarFormulario()
        {
            LblNombre.Text = EmpleadoLogeado.MostrarNombreAdminitrador();        

            if (empleadoLogeado.Administrador == true)
            {
                EstadoBotones(true);
                CambiarColorBotonUsuario(Color.Purple);
            }
            else
            {
                EstadoBotones(false);
                CambiarColorBotonUsuario(Color.Blue);
            }
        }

        private void EstadoBotones(bool estado)
        {
            BtnEmpleado.Enabled = estado;
            BtnInventario.Enabled = estado;
            BtnHistorial.Enabled = estado;
        }
        private void CambiarColorBotonUsuario(Color color)
        {
            BtnUsuario.BackColor = color;
        }
        private void CargarHistorial(Cliente mesa)
        {
            if (mesa is not null)
            {
                historial.AppendLine(mesa.HistorialVentaConFormato);
            }
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            MostrarHistorial();
        }
    }
}
