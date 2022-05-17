using Biblioteca.Productos;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Mesa : Persona
    {
        private List<Alimento> listaAlimentos;
        private float gastoTotal;
        private string historialVenta;

        public Mesa() : base()
        {
            this.listaAlimentos = new List<Alimento>();
            gastoTotal = 0;
        }

        public Mesa(string nombre, string apellido, List<Alimento> listaAlimento) : base(nombre, apellido)
        {
            this.listaAlimentos = listaAlimento;
            gastoTotal = 0;
            CalcularPrecio();
        }


        public float GastoTotal { get => gastoTotal; set => gastoTotal = value; }
        public List<Alimento> ListaAlimentos { get => listaAlimentos; set => listaAlimentos = value; }
        public string HistorialVenta { get => historialVenta; set => historialVenta = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} Gasto Total:");
            return sb.ToString();
        }

        public static bool operator +(Mesa cliente, Alimento Alimento)
        {
            if (cliente.listaAlimentos != null)
            {
                cliente.listaAlimentos.Add(Alimento);
                return true;
            }

            return false;
        }

        public static bool operator -(Mesa cliente, Alimento alimento)
        {
            if (cliente.listaAlimentos != null)
            {
                cliente.listaAlimentos.Remove(alimento);
                return true;
            }

            return false;
        }

        public static bool operator ==(Mesa cliente, Alimento alimento)
        {
            foreach (Alimento item in cliente.listaAlimentos)
            {
                if (item.Nombre == alimento.Nombre)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Mesa cliente, Alimento alimento)
        {
            foreach (Alimento item in cliente.listaAlimentos)
            {
                if (!(item == alimento))
                {
                    return false;
                }
            }

            return true;
        }

        public void CalcularPrecio()
        {
            gastoTotal = 0;

            for (int indice = 0; indice < ListaAlimentos.Count; indice++)
            {
                for (int cantidad = 0; cantidad < ListaAlimentos[indice].Cantidad; cantidad++)
                {
                    gastoTotal += listaAlimentos[indice].Precio;
                }
            }
        }

        public void limpiarMesa()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            ListaAlimentos.Clear();
            gastoTotal = 0;
        }

        public void GuardarInformacionVenta(bool estacionamiento, string MetodoDepago, string precioFinal)
        {
            StringBuilder sb = new StringBuilder();
            Bebida auxBebida;
            Comida auxComida;
           

            sb.AppendLine($"Cliente: {Nombre} {Apellido}");

            foreach (var item in ListaAlimentos)
            {
                if (item is Bebida)
                {
                    auxBebida = (Bebida)item;
                    sb.AppendLine(auxBebida.Mostrar());
                }
                else
                {
                    auxComida = (Comida)item;
                    sb.AppendLine(auxComida.Mostrar());
                }

            }
            sb.AppendLine($"*Estacionamiento {estacionamiento} *Metodo de pago: {MetodoDepago} *Precio final: {precioFinal}");
            sb.AppendLine("----------------------------------------------------");

            HistorialVenta = sb.ToString();
        }



    }
}
