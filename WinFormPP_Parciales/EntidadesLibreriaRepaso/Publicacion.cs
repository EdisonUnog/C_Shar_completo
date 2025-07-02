using System.Text;

namespace EntidadesLibreriaRepaso
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected abstract bool EsColor { get; }

        /// <summary>
        /// Retorna true si hay sotck y el importe es mayor a cero.
        /// </summary>
        public virtual bool HayStock
        {
            get { return stock > 0 && importe > 0; }
        }

        /// <summary>
        /// Retorna el importe de la publicación.
        /// </summary>
        public float Importe
        {
            get { return importe; }
        }


        /// <summary>
        /// Retorna el stock de la publicación. El valor asignado debe ser mayor a cero.
        /// </summary>
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
            }
        }

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            Stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }


        /// <summary>
        /// Retorna los datos de la Publicacion.
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacion()
        {
            string esColor = EsColor ? "SI" : "NO";

            StringBuilder sb = new();

            sb.AppendLine($" Nombre: {nombre}");
            sb.AppendLine($" Stock: {Stock}");
            sb.AppendLine($" Es Color: {esColor}");
            sb.AppendLine($" Valor: {importe}");

            return sb.ToString();
        }


        /// <summary>
        /// Retorna el nombre de la publicación.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }
    }
}
