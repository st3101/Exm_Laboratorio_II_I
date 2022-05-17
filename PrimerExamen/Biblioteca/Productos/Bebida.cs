using Biblioteca.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bebida : Alimento
    {
        float litros;


        public Bebida(string nombre, string descripcion,float precio,float litros,int cantidad) : base(nombre, descripcion, precio,cantidad)
        {
            this.Litros = litros;
        }
        public Bebida(string nombre, string descripcion,float precio,float litros,int cantidad,int id) : base(nombre, descripcion, precio,cantidad,id)
        {
            this.Litros = litros;
        }

        public float Litros { get => litros; set => litros = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} *litros: {Litros}" );
            return sb.ToString();  
        }

    }
}
