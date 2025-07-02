using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Animal
    {
        private string sonido;

        public string Sonido { get => sonido; set => sonido = value; }

        public Perro(string nombre, string raza, string color, string sonido)
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
