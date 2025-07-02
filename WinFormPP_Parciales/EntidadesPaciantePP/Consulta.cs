using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPaciantePP
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public Paciente Paciente
        {
            get
            {
                return this.paciente;
            }
        }

        /// <summary>
        /// constructor de la clase Consulta
        /// </summary>
        /// <param name="fecha">fecha de la consulta</param>
        /// <param name="paciente">Objeto de tipo paciente</param>
        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        /// <summary>
        /// Obtiene un string con la fecha de atencion y el nombre del paciente
        /// </summary>
        /// <returns>Un string con la fecha de atencion y el nombre del paciente</returns>
        public override string ToString()
        {
            return $" *Fecha: {fecha}, se ha atendidoa a: {paciente.NombresCompletos}";
        }
    }
}
