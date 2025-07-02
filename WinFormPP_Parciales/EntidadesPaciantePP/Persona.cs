using System.Text;

namespace EntidadesPaciantePP
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime fechaNacimiento;

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.fechaNacimiento.Ticks).Year - 1;
            }
        }

        public string NombresCompletos
        {
            get
            {
                return $" -{apellido}, {nombre}";
            }
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string barrioRecidencia)
            : this(nombre, apellido, fechaNacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }

        internal abstract string FichaExtra();
        //  internal override string Descripcion()
        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new();

            sb.AppendLine($"{p.ToString()}");
            sb.AppendLine($" -Edad: {p.Edad}");
            sb.AppendLine($" {p.FichaExtra()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.NombresCompletos;
        }
    }
}
