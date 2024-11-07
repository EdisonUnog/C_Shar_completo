namespace Entidades
{
    public class Serie
    {
        private string genero;
        private string nombre;

        public Serie() { }
        public Serie(string nombre, string genero)
        {
            this.genero = genero;
            this.nombre = nombre;
        }

        public string Genero { get => genero; set => genero = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"{this.nombre} - {this.genero}";
        }
    }
}
