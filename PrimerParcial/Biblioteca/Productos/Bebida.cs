using Biblioteca.Productos;
using System.Text;

namespace Biblioteca
{
    public class Bebida : Alimento
    {
        float litros;

        public Bebida(string nombre, string descripcion, float precio, float litros, int cantidad, ETemperatura temperatura) : base(nombre, descripcion, precio, cantidad, temperatura)
        {
            this.Litros = litros;
        }
        public Bebida(string nombre, string descripcion, float precio, float litros, int cantidad, int id, ETemperatura temperatura) : base(nombre, descripcion, precio, cantidad, id, temperatura)
        {
            this.Litros = litros;
        }

        public float Litros { get => litros; set => litros = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} - litros: {Litros}");
            return sb.ToString();
        }

    }
}
