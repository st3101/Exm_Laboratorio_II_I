using System.Text;

namespace Biblioteca.Productos
{

    public abstract class Alimento
    {
        private static int ultimoId;

        protected int id;
        protected string nombre;
        protected string descripcion;
        protected float precio;
        protected int cantidad;
        protected ETemperatura temperatura;

        static Alimento()
        {
            ultimoId = 1;
        }
        protected Alimento(string nombre, string descripcion, float precio, int cantidad,int id,ETemperatura temperatura)
        {
            this.id = id;
            this.Nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.cantidad = cantidad;
            this.Temperatura = temperatura;
        }

        protected Alimento(string nombre, string descripcion, float precio,int cantidad, ETemperatura temperatura) :this(nombre, descripcion, precio, cantidad, ultimoId,temperatura)
        {
            ultimoId++;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; } 

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public ETemperatura Temperatura { get => temperatura; set => temperatura = value; }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"* Alimento: {Nombre} - Precio: {Precio} - Descripcion: {Descripcion} - Cantidad: {Cantidad}");
            return sb.ToString();
        }
        public enum ETemperatura
        {
            caliente,
            tibio,
            frio
        }

    }
}
