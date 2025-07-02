using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Gato : Animal
    {
        private string sonido;

        public string Sonido { get => sonido; set => sonido = value; }

        public Gato(string nombre, string raza, string color, string sonido) 
            : base(nombre, raza, color)
        {
            this.sonido = sonido;
        }

        public override string MostrarInformacion()
        {
            StringBuilder sb = new();

            sb.Append(base.DatosPersona());
            sb.AppendLine($"*Sonido: {sonido}");

            return sb.ToString();
        }
    }
}
