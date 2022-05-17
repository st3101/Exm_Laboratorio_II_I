using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        public Persona()
        {
            this.Nombre = null;
            this.Apellido = null;
        }

        public Persona(string nombre, string apellido)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public string Nombre
        {
            set
            {
                if (value is null || value == string.Empty)
                {
                    nombre = "No asignado";
                }
                else
                {
                    nombre = value;
                }
            }
            get => nombre;
        }

        public string Apellido
        {
            set
            {
                if (value is null || value == string.Empty)
                {
                    apellido = "No asignado";
                }
                else
                {
                    apellido = value;
                }
            }
            get => apellido;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {Nombre} Apellido: {Apellido}");
            return sb.ToString();
        }
        public virtual string MostrarNombreCompleto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {Nombre} {Apellido}");
            return sb.ToString();
        }

    }
}
