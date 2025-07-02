using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiendaRobot
    {
        private string nombreTienda;
        private List<Robot> ventaRobots;

        public string NombreTienda { get => nombreTienda; set => nombreTienda = value; }

        private TiendaRobot()
        {
            ventaRobots = new List<Robot>();
        }

        public TiendaRobot(string nombre) :this()
        {
            this.nombreTienda = nombre;
        }

        /// <summary>
        /// Retorna la información del vendedor, sus ventas y la ganancia total de las mismas.
        /// </summary>
        /// <param name="tiendaRobot"></param>
        /// <returns></returns>
        /// 
        public static string ObtenerInformacionDeVentas(TiendaRobot tiendaRobot)
        {
            float ganaciaTotal = 0;

            StringBuilder sb = new();

            sb.AppendLine($"*Nombre Tienda: {tiendaRobot.nombreTienda.ToUpper()}");
            sb.AppendLine("---------------------------------------------");

            foreach(Robot robot in tiendaRobot.ventaRobots)
            {
                sb.AppendLine($"*INFORMACION DE ROBOT: {robot.ObtenerInformacion()}");
                ganaciaTotal += robot.Importe;
            }

            sb.AppendLine($"*Ganacias: $$ {ganaciaTotal}");

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
        public static bool operator +(TiendaRobot tiendaRobot, Robot robot)
        {
            if (robot.HayStock)
            {
                tiendaRobot.ventaRobots.Add(robot);
                robot.Stock--;
                return true;
            }
            return false;
        }

    }
}
