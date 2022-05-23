using Biblioteca.Productos;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        private List<Alimento> listaAlimentos;
        private float gastoTotal;
        private string historialVenta;
        private string historialVentaConFormato;

        public Cliente() : base()
        {
            this.listaAlimentos = new List<Alimento>();
            gastoTotal = 0;
        }

        public Cliente(string nombre, string apellido, List<Alimento> listaAlimento) : base(nombre, apellido)
        {
            this.listaAlimentos = listaAlimento;
            gastoTotal = 0;
            CalcularPrecio();
        }


        public float GastoTotal { get => gastoTotal; set => gastoTotal = value; }
        public List<Alimento> ListaAlimentos { get => listaAlimentos; set => listaAlimentos = value; }
        public string HistorialVenta { get => historialVenta; set => historialVenta = value; }
        public string HistorialVentaConFormato { get => historialVentaConFormato; set => historialVentaConFormato = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} Gasto Total:");
            return sb.ToString();
        }

        public static bool operator +(Cliente cliente, Alimento Alimento)
        {
            if (cliente.listaAlimentos != null)
            {
                cliente.listaAlimentos.Add(Alimento);
                return true;
            }

            return false;
        }

        public static bool operator -(Cliente cliente, Alimento alimento)
        {
            if (cliente.listaAlimentos != null)
            {
                cliente.listaAlimentos.Remove(alimento);
                return true;
            }

            return false;
        }

        public static bool operator ==(Cliente cliente, Alimento alimento)
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
        public static bool operator !=(Cliente cliente, Alimento alimento)
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

        public void limpiarCliente()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            ListaAlimentos.Clear();
            gastoTotal = 0;
        }

        public void GuardarInformacionVenta(string estacionamiento, string metodoDepago, string precioFinal)
        {    
            historialVenta = HacerTiket(estacionamiento,metodoDepago,precioFinal);
            GuardarHistorial();
        }

        public string HacerTiket(string estacionamiento, string metodoDepago, string precioFinal)
        {
            Bebida auxBebida;
            Comida auxComida;
            StringBuilder sb = new StringBuilder();

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

            sb.AppendLine($"* Estacionamiento {estacionamiento} - Metodo de pago: {metodoDepago}");
            sb.AppendLine($"* Precio final: { precioFinal} ");
            return sb.ToString();
        }

        public void GuardarHistorial()
        {
            HistorialVentaConFormato = HistorialVenta;
            HistorialVentaConFormato += "-----------------------------------------------------------------------------------------------";
           
        }
    }
}
