using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Marca { KUKA, ABB}
    public enum Modelo { KR40PA, KRquantecPA, PALETIZADO, KRtitanPA };
    public abstract class Robot
    {
        protected Marca marca;
        protected Modelo modelo;
        protected int stock;
        protected float importe;

        protected abstract bool Destino {  get; }
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
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        public Modelo Modelo { get => modelo; set => modelo = value; }

        public Robot(Modelo modelo)
        {
            this.modelo = modelo;
        }
        protected Robot(Marca marca, Modelo modelo) : this(modelo)
        {
            this.marca = marca;
        }
        public Robot(Marca marca, Modelo modelo, int stock) : this(marca, modelo)
        {
            Stock = stock;
        }

        public Robot(Marca marca, Modelo modelo, int stock, float importe) 
            : this(marca, modelo, stock)
        {
            this.importe = importe;
        }


        // <summary>
        /// Retorna los datos de la Publicacion.
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacion()
        {
            string destino = Destino ? "Venta" : "alquiler";

            StringBuilder sb = new();

            sb.AppendLine($"\n -Marca: {marca}");
            sb.AppendLine($" -Modelo: {modelo}");
            sb.AppendLine($" -Stock: {Stock}");
            sb.AppendLine($" -Importe: $$ {importe}");
            sb.AppendLine($" -Destinado a: {destino}");

            return sb.ToString();
        }


    }
}
