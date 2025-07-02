using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPaciantePP
{
    public class Paciente : Persona
    {
        private string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public Paciente(string nombre, string apellido, DateTime fechaNacimiento, string barrioRecidencia)
            : base(nombre, apellido, fechaNacimiento, barrioRecidencia)
        {

        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new();

            sb.AppendLine($"-Reside en: {barrioRecidencia}");
            sb.AppendLine($" -Diagnostico: {diagnostico}");

            return sb.ToString();
        }
    }
}
