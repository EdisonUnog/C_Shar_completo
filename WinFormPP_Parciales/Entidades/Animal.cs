using System.Text;

namespace Entidades
{
    public abstract class Animal
    {
        private string nombre;
        private string raza;
        private string color;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Color { get => color; set => color = value; }

        public Animal(string nombre, string raza, string color)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.color = color;
        }

        public abstract string MostrarInformacion();

        public string DatosPersona()
        {
            StringBuilder sb = new();

            sb.AppendLine($"*Nombre: {nombre}");
            sb.AppendLine($"*Raza: {raza}");
            sb.AppendLine($"*Color: {color}");

            return sb.ToString();
        }
    }
}
