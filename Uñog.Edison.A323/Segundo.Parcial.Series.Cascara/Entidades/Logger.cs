using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Logger
    {
        private static string ruta;
        private static DateTime tiempo;

        static Logger()
        {
            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ErroresLog.txt");
            tiempo = DateTime.Now;
        }

        public static DateTime Tiempo { get => tiempo; set => tiempo = value; }

        public static void Log(string mensaje)
        {
            using (StreamWriter sw = new StreamWriter(ruta, true)) // para seguir escribiendo sin pisar lo que ya esta
            {
                sw.WriteLine($"Fecha/Hora:{Tiempo} :: {mensaje}");
            }
        }

    }
}
