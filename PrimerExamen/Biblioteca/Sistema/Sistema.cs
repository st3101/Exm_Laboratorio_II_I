using Biblioteca.Productos;
using System.Collections.Generic;

namespace Biblioteca.Sistema
{
    public static class Sistema
    {
        static public Mesa[] arrayMesas;
        static private List<Empleado> listaEmpleado;
        static private List<Comida> listaComida;
        static private List<Bebida> listaBebida;

        static Sistema()
        {
            HarcodearEmpleados();
            HarcodearBebidas();
            HarcodearComida();
            InstaciarMesas();
        }

        public static List<Empleado> ListaEmpleado { get => listaEmpleado; }
        public static List<Comida> ListaComida { get => listaComida; }
        public static List<Bebida> ListaBebida { get => listaBebida; }
        public static Mesa[] ArrayMesas { get => arrayMesas; set => arrayMesas = value; }

        private static void InstaciarMesas()
        {
            arrayMesas = new Mesa[20]
            {
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa(),
                new Mesa()
            };
        }
        public static Mesa BuscarMesaInice(string indice)
        {
            int aux;
            if (indice is not null && int.TryParse(indice, out aux) && aux >= 0 && arrayMesas.Length > aux)
            {
                return arrayMesas[aux - 1];
            }

            return null;
        }
        private static void HarcodearBebidas()
        {
            listaBebida = new List<Bebida>();

            listaBebida.Add(new Bebida("Coca-Cola", "Lata", 50, 1, 15));
            listaBebida.Add(new Bebida("Coca-Cola", "Botella", 100, (float)2.25, 10));         
            listaBebida.Add(new Bebida("Pepsi", "Lata", 45, 1, 5));
            listaBebida.Add(new Bebida("Pepsi", "Botella", 95, (float)2.25, 7));
            listaBebida.Add(new Bebida("Moster", "Lata", 75,(float)1.25, 2));
            listaBebida.Add(new Bebida("Caffe", "Taza", 50, (float)0.50, 30));
        }
        private static void HarcodearComida()
        {
            listaComida = new List<Comida>();

            listaComida.Add(new Comida("Pizza", "Salsa y queso", 20, 25));
            listaComida.Add(new Comida("Hamburgesa", "Completa", 50, 50));
            listaComida.Add(new Comida("Papas Fritas", "Con sal", 50, 150));
            listaComida.Add(new Comida("Milanesa", "Completa", 50, 150));

        }
        private static void HarcodearEmpleados()
        {
            //Empleados
            listaEmpleado = new List<Empleado>();

            listaEmpleado.Add(new Empleado("Santiago", "Leonardi", "st3101", "147", true, "23-42398998-9", 60500));
            listaEmpleado.Add(new Empleado("Daniela", "Ibasca", "Danery", "123456789", true, "23-42683254-3", 50000));
            listaEmpleado.Add(new Empleado("Papa", "Pepa", "Pepapa", "meGusta", false, "23-45684521-9", 5000));
            listaEmpleado.Add(new Empleado("fafa", "fefe", "LionCapo", "GokuMiDios123", false, "23-40225687-7", 6000));
            listaEmpleado.Add(new Empleado("Nene", "Nana", "Fachaenpersona", "soyyo", false, "23-42398998-9", 7500));
        }
        public static bool BuscarUsuarioLogin(string nombre, string password)
        {
            foreach (Empleado item in listaEmpleado)
            {
                if (item.Usuario == nombre.ToLower() && item == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static Empleado BuscarEmpleado(string nombre, string password)
        {
            foreach (Empleado item in listaEmpleado)
            {
                if (item.Usuario == nombre.ToLower() && item == password)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool AgregarEmpleado(string nombre, string apellido, string usuario, string password, bool adminitrador, string cuil, string sueldo)
        {
            Empleado empleadoAux;

            empleadoAux = CrearEmpleado(nombre, apellido, cuil, sueldo, usuario, password, adminitrador);

            if (empleadoAux is not null)
            {
                listaEmpleado.Add(empleadoAux);
                return true;
            }

            return false;
        }


        public static bool AgregarComida(string nombreComida, string descripcion, string precio, string cantidad)
        {
            Comida auxComida = CrearComida(nombreComida, descripcion, precio, cantidad);

            if (auxComida is not null)
            {
                listaComida.Add(auxComida);
                return true;
            }
            return false;
        }

        public static Empleado CrearEmpleado(string Nombre, string Apellido, string cuil, string sueldo, string usuario, string password, bool adminitrador)
        {
            Empleado auxEmpleado;

            auxEmpleado = new Empleado(Nombre, Apellido, usuario, password, adminitrador, cuil, float.Parse(sueldo));
            if (auxEmpleado is not null)
            {
                return auxEmpleado;
            }

            return null;
        }

        public static Comida CrearComida(string nombreComida, string descripcion, string precio, string cantidad)
        {
            Comida auxComida;

            if (int.Parse(cantidad) > 0)
            {
                auxComida = new Comida(nombreComida, descripcion, float.Parse(precio), int.Parse(cantidad));

                if (auxComida is not null)
                {
                    return auxComida;
                }
            }

            return null;
        }
        public static Comida CrearComidaMismoId(string nombreComida, string descripcion, string precio, string cantidad, int id)
        {
            Comida auxComida;

            if (int.Parse(cantidad) > 0)
            {
                auxComida = new Comida(nombreComida, descripcion, float.Parse(precio), int.Parse(cantidad), id);

                if (auxComida is not null)
                {
                    return auxComida;
                }
            }

            return null;
        }

        public static Bebida CrearBebida(string nombreBebida, string descripcion, string precio, string litros, string cantidad)
        {
            Bebida auxBebida = new Bebida(nombreBebida, descripcion, float.Parse(precio), float.Parse(litros), int.Parse(cantidad));

            if (auxBebida is not null)
            {
                return auxBebida;
            }

            return null;
        }
        public static Bebida CrearBebidaMismoId(string nombreBebida, string descripcion, string precio, string litros, string cantidad, int id)
        {
            Bebida auxBebida = new Bebida(nombreBebida, descripcion, float.Parse(precio), float.Parse(litros), int.Parse(cantidad), id);

            if (auxBebida is not null)
            {
                return auxBebida;
            }

            return null;
        }
        public static bool AgregarBebida(string nombreBebida, string descripcion, string precio, string litros, string cantidad)
        {
            Bebida auxBebida;

            if (int.Parse(cantidad) > 0)
            {
                auxBebida = new Bebida(nombreBebida, descripcion, float.Parse(precio), int.Parse(litros), int.Parse(cantidad));

                if (auxBebida is not null)
                {
                    listaBebida.Add(auxBebida);
                    return true;
                }
            }

            return false;
        }

        public static bool EliminarComida(int indice)
        {
            if (indice >= 0 && listaComida.Count >= indice)
            {
                listaComida.Remove(listaComida[indice]);
                return true;
            }
            return false;
        }

        public static bool EliminarBebida(int indice)
        {
            if (indice >= 0 && ListaBebida.Count >= indice)
            {
                ListaBebida.Remove(ListaBebida[indice]);
                return true;
            }
            return false;
        }
        public static bool EliminarEmpleado(int indice)
        {
            if (indice >= 0 && listaEmpleado.Count >= indice)
            {
                listaEmpleado.Remove(listaEmpleado[indice]);
                return true;
            }
            return false;
        }
        public static Empleado BuscarEmpleadoIndice(int indice)
        {
            Empleado aux;

            if (indice >= 0 && listaEmpleado.Count > indice && listaComida is not null)
            {
                aux = listaEmpleado[indice];

                if (aux is not null)
                {
                    return aux;
                }
            }
            return null;
        }

        public static Comida BuscarComidaIndice(int indice)
        {
            if (indice >= 0 && listaComida.Count > indice)
            {
                return listaComida[indice];
            }

            return null;
        }
        public static Bebida BuscarBebidaIndice(int indice)
        {
            if (indice >= 0 && listaBebida.Count > indice)
            {
                return listaBebida[indice];
            }

            return null;
        }

        public static bool PisarComida(Comida auxComida, int indice)
        {
            if (indice >= 0 && auxComida is not null)
            {            
                listaComida[indice] = auxComida;
                return true;
            }

            return false;
        }

        public static bool PisarEmpleado(Empleado auxEmpleado, int indice)
        {
            if (auxEmpleado is not null && listaEmpleado.Count >= indice && indice >= 0)
            {
                listaEmpleado[indice] = auxEmpleado;
                return true;
            }
            return false;
        }

        public static bool PisarBebida(Bebida auxBebida, int indice)
        {
            if (auxBebida is not null && listaBebida.Count >= indice && indice >= 0)
            {
                listaBebida[indice] = auxBebida;
                return true;
            }
            return false;
        }
        public static bool AgregarComidaAlimentoMesa(Mesa mesa, Comida comida, int indice)
        {
            if (indice >= 0 && mesa is not null)
            {
                mesa.ListaAlimentos[indice].Cantidad++;
                return true;
            }
            else if (indice == -1)
            {
                comida.Cantidad = 1;
                mesa.ListaAlimentos.Add(comida);
                return true;

            }

            return false;
        }

        private static bool AumentarBebida(Bebida bebida)
        {
            if (bebida is not null)
            {
                bebida.Cantidad++;
                return true;
            }
            return false;
        }


        public static Comida ClonarComidaMismoId(Comida comida)
        {
            Comida auxComida;

            if (comida is not null)
            {
                auxComida = CrearComidaMismoId(comida.Nombre, comida.Descripcion, comida.Precio.ToString(), comida.Cantidad.ToString(), comida.Id);


                if (auxComida is not null)
                {
                    return auxComida;
                }
            }

            return null;
        }

        public static Bebida ClonarBebidaMismoId(Bebida bebida)
        {
            Bebida auxBebida;

            if (bebida is not null)
            {
                auxBebida = CrearBebidaMismoId(bebida.Nombre, bebida.Descripcion, bebida.Precio.ToString(), bebida.Litros.ToString(), bebida.Cantidad.ToString(), bebida.Id);
                if (auxBebida is not null)
                {
                    return auxBebida;
                }
            }
            return null;
        }
        public static bool PasarAliemntoAMesa(Mesa mesa, Alimento comida)
        {
            if (comida is not null && mesa is not null)
            {
                for (int indice = 0; indice < mesa.ListaAlimentos.Count; indice++)
                {
                    if (mesa.ListaAlimentos[indice].Id == comida.Id)
                    {
                        mesa.ListaAlimentos[indice].Cantidad++;
                        return true;
                    }
                }
                comida.Cantidad = 1;
                mesa.ListaAlimentos.Add(comida);
                return true;
            }
            return false;
        }
        public static float CalculaTotal(float totalAlimento,bool estacionamiento,string metodoDePago)
        {
            float alimentoEstacionamiento;
            float resultadoRecarga;
            float TotalApagar;

            if(estacionamiento is true)
            {
                alimentoEstacionamiento = totalAlimento + 100;
            }
            else
            {
                alimentoEstacionamiento = totalAlimento;
            }

            if (metodoDePago == "Tarjeta")
            {
                resultadoRecarga = (10 * alimentoEstacionamiento) / 100;
                TotalApagar = resultadoRecarga + alimentoEstacionamiento;
            }
            else
            {
                TotalApagar = alimentoEstacionamiento;
            }
            return TotalApagar;
        }
        public static void BorrarMesa(Mesa mesa)
        {
            mesa.limpiarMesa();
        }
    }
}

