using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RobotAlquiler : Robot
    {
        protected override bool Destino
        {
            get { return false; }
        }

        /// <summary>
        /// Retorna true si hay stock. 
        /// </summary>
        public override bool HayStock
        {
            get { return stock > 0; }
        }

        public RobotAlquiler(Modelo modelo) : base (modelo)
        {
        }
        public RobotAlquiler(Marca marca, Modelo modelo) : base(marca, modelo)
        {
        }
        public RobotAlquiler(Marca marca, Modelo modelo, int stock) : base(marca, modelo)
        {
        }

        public RobotAlquiler(Marca marca, Modelo modelo, int stock, float importe)
            : base(marca, modelo, stock, importe)
        {
        }

        /// <summary>
        /// Genera un objeto al alquiler a partir del modelo.
        /// </summary>
        /// <param name="modelo"></param>
        public static explicit operator RobotAlquiler(Modelo modelo)
        {
            return new RobotAlquiler(modelo);
        }
    }
}
