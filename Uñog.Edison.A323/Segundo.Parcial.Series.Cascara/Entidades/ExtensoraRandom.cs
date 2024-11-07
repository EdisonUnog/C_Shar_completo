using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensoraRandom
    {
        private static Random rnd;

        static ExtensoraRandom()
        {
            rnd = new Random();
        }

        public static int GenerarRandom(this List<Serie> lista)
        {           
            return rnd.Next(0, lista.Count);
        }
    }
}
