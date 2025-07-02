using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPaciantePP
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> listaConsultas;
        private bool esResidente;


        /// <summary>
        /// Constructor de la clase Personal medico
        /// </summary>
        /// <param name="nombre">Nombre del paciente</param>
        /// <param name="apellido">Apellido del paciente</param>
        /// <param name="fechaNacimiento">fecha de nacimiento del paciente</param>
        /// <param name="esResidente">un booleano para indicar si es recidente o no.</param>
        public PersonalMedico(string nombre, string apellido, DateTime fechaNacimiento, bool esResidente)
            : base(nombre, apellido, fechaNacimiento)
        {
            listaConsultas = new List<Consulta>();
            this.esResidente = esResidente;
        }



        /// <summary>
        /// Obtiene todos los datos de un medico
        /// </summary>
        /// <returns>Un string con todos los datos del medico y sus pacientes atendidos en consultas</returns>
        internal override string FichaExtra()
        {
            //string residente = esResidente ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();

            //sb.AppendLine($" *¿Finalizo residencia? {residente}");
            sb.AppendLine($"¿Finalizó residencia? {(this.esResidente ? "SI" : "NO")}");
            sb.AppendLine(" *ATENCIONES:");

            foreach (Consulta consulta in this.listaConsultas)
            {
                sb.AppendLine(Persona.FichaPersonal(consulta.Paciente));
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = null;

            if (doctor is not null && paciente is not null)
            {
                consulta = new Consulta(DateTime.Now, paciente);
                doctor.listaConsultas.Add(consulta);

            }
            return consulta;
        }
    }
}
