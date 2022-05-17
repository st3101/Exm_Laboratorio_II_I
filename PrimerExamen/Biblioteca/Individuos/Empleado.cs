using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        private string usuario;
        private string password;
        private bool administrador;
        private string cuil;
        private float sueldo;


        public Empleado(string nombre,string apellido,string usuario, string password, bool administrador, string cuil, float sueldo) : base(nombre,apellido)
        {
            this.Usuario = usuario;
            this.Password = password;
            this.Administrador = administrador;
            this.Cuil = cuil;
            this.Sueldo = sueldo;
        }

        public string Usuario { get => usuario; set => usuario = value.ToLower(); }
        private string Password { get => password; set => password = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string Cuil { get => cuil; set => cuil = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }

        public static bool operator ==(Empleado empledo,string password)
        {
            if(empledo is not null && !String.IsNullOrEmpty(password))
            {
                if(empledo.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Empleado empledo, string password)
        {
            if (String.IsNullOrEmpty(password) && empledo is null )
            {
                if (empledo.Password == password)
                {
                    return false;
                }
            }
            return true;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} Cuil: {Cuil} Sueldo:{Sueldo}  Adminitrador: {esAdminitrador()}");
            return sb.ToString();
        }
        
        public string MostrarNombreAdminitrador()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.MostrarNombreCompleto()} Cuil: {Cuil} Adminitrador: {esAdminitrador()}");
            return sb.ToString();
        }

        public string esAdminitrador()
        {
            if(Administrador == true)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }
    }
}
