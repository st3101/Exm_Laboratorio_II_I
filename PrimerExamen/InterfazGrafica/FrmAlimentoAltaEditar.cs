using Biblioteca;
using Biblioteca.Productos;
using Biblioteca.Sistema;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmAlimentoAltaEditar : Form
    {
        string tipoAccion;
        string tipoAlimento;
        int indice;

        public FrmAlimentoAltaEditar()
        {
            InitializeComponent();
        }

        public FrmAlimentoAltaEditar(string tipoAccion, string tipoAlimento) : this()
        {
            TipoAccion = tipoAccion;
            TipoAlimento = tipoAlimento;
        }

        public FrmAlimentoAltaEditar(string tipoAccion, string tipoAlimento, int indice) : this(tipoAccion, tipoAlimento)
        {
            Indice = indice;
        }

        public int Indice { get => indice; set => indice = value; }
        public string TipoAccion { get => tipoAccion; set => tipoAccion = value; }
        public string TipoAlimento { get => tipoAlimento; set => tipoAlimento = value; }

        private void BtnAltaEditar_Click(object sender, EventArgs e)
        {
            if (TipoAccion == "Agregar")
            {
                if (TipoAlimento == "Comida")
                {
                    Sistema.AgregarComida(TxtNombre.Text, TxtDescripcion.Text, TxtPrecio.Text,TxtCantidad.Text);
                }
                else if(tipoAlimento == "Bebida")
                {
                    Sistema.AgregarBebida(TxtNombre.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtLitro.Text, TxtCantidad.Text);
                }
            }
            else if (TipoAccion == "Editar")
            {
                if (TipoAlimento == "Comida")
                {
                    Sistema.PisarComida(Sistema.CrearComida(TxtNombre.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text),Indice);
                }
                else if(TipoAlimento == "Bebida")
                {
                    Sistema.PisarBebida(Sistema.CrearBebida(TxtNombre.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtLitro.Text, TxtCantidad.Text), Indice);
                }
            }

            DialogResult = DialogResult.OK;
        }
        private void EditarFormulario()
        {
            CambiarTitulo();
            CargarTxtbox();
            CambiarEstadoLitro();
        }

        private void CambiarEstadoLitro()
        {
            if (TipoAlimento == "Comida")
            {
                EstadoLitrosTxt(false);
            }
            else
            {
                EstadoLitrosTxt(true);
            }
        }
        private void EstadoLitrosTxt(bool estado)
        {
            TxtLitro.Enabled = estado;
        }


        private void CambiarTitulo()
        {
            LblTitulo.Text = $"{TipoAccion} {tipoAlimento}";
            this.Text = $"{TipoAccion}";
        }

        private void CargarTxtbox()
        {

            if (TipoAccion == "Editar")
            {
               

                if (TipoAlimento == "Comida")
                {
                    Comida comidaAux = Sistema.BuscarComidaIndice(Indice);
                    CompletarTxtBoxComida(comidaAux);
                }
                else if (TipoAlimento == "Bebida")
                {
                    Bebida BebidaAux = Sistema.BuscarBebidaIndice(Indice);
                    CompletarTxtBoxBebida(BebidaAux);
                }
            }
        }
        private void CompletarTxtBoxBebida(Bebida bebida)
        {
            TxtNombre.Text = bebida.Nombre;
            TxtDescripcion.Text = bebida.Descripcion;
            TxtCantidad.Text = bebida.Cantidad.ToString();
            TxtPrecio.Text = bebida.Precio.ToString();
            TxtLitro.Text = bebida.Litros.ToString();

        }
        private void CompletarTxtBoxComida(Comida comida)
        {
            TxtNombre.Text = comida.Nombre;
            TxtDescripcion.Text = comida.Descripcion;
            TxtCantidad.Text = comida.Cantidad.ToString();
            TxtPrecio.Text = comida.Precio.ToString();
        }

        private void FrmAlimentoAltaEditar_Load(object sender, EventArgs e)
        {
            EditarFormulario();
        }
    }
}
