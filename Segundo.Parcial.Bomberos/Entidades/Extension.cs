using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        // Extender la clase DateTime para calcular la diferencia en segundos entre una fecha de inicio y una fecha de fin: 
        public static double CalcularDiferenciaEnSegundos(this DateTime inicio, DateTime fin)
        {
            return (fin - inicio).TotalSeconds;
        }
    }
}
