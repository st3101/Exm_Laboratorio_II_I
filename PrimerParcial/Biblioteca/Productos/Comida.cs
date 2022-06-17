using Biblioteca.Productos;

namespace Biblioteca
{
    public class Comida : Alimento
    {
        public Comida(string nombre, string descripcion, float precio, int cantidad, ETemperatura temperatura) : base(nombre, descripcion, precio, cantidad,temperatura)
        {

        }
        public Comida(string nombre, string descripcion, float precio, int cantidad, int id, ETemperatura temperatura) : base(nombre, descripcion, precio, cantidad, id, temperatura)
        {

        }

    }
}
