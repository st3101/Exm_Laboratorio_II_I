using Biblioteca.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Comida : Alimento
    {

        //enumerado frio caliente tibiio 
        public Comida(string nombre,string descripcion,float precio, int cantidad) : base(nombre, descripcion, precio,cantidad)
        {

        } 
       public Comida(string nombre,string descripcion,float precio, int cantidad,int id) : base(nombre, descripcion, precio,cantidad,id)
        {

        }

    }
}
