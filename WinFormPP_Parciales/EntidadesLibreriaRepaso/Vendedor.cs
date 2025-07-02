using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLibreriaRepaso
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }


        /// <summary>
        /// Retorna la información del vendedor, sus ventas y la ganancia total de las mismas.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float ganaciaTotal = 0;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" {vendedor.nombre.ToUpper()}");
            sb.AppendLine(" --------------------------------");

            foreach (Publicacion venta in vendedor.ventas)
            {
                sb.AppendLine($" PUBLICAION: {venta.ObtenerInformacion()}");
                ganaciaTotal += venta.Importe;
            }

            sb.AppendLine($" Ganacia Total: $$ {ganaciaTotal}");

            return sb.ToString();
        }


        /// <summary>
        /// Agrega al vendedor una publicación, 
        /// siempre y cuando haya stock suficiente para realizar una venta del producto, 
        /// agregando en ese caso la información de la venta a la lista 
        /// y descontando Stock de la publicación.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <param name="publicacion"></param>
        /// <returns></returns>
        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }

    }
}
