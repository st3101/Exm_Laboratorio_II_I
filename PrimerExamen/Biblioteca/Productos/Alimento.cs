using System.Text;

namespace Biblioteca.Productos
{
    public abstract class Alimento
    {
        private static int ultimoId;

        private string nombre;
        private float precio;
        private string descripcion;
        private int id;
        private int cantidad;

        static Alimento()
        {
            ultimoId = 1;
        }
        protected Alimento(string nombre, string descripcion, float precio, int cantidad,int id)
        {
            this.id = id;
            this.Nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.cantidad = cantidad;
        }

        protected Alimento(string nombre, string descripcion, float precio,int cantidad) 
        {
            this.Nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.cantidad = cantidad;
            this.id = ultimoId;
            ultimoId++;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"*Alimento: {Nombre} *Precio: {Precio} *Descripcion: {Descripcion} *Cantidad: {Cantidad}");

            return sb.ToString();
        }
    }
}
