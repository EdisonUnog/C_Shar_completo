using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RobotVenta : Robot
    {
        private bool destino;

        protected override bool Destino
        {
            get { return this.destino; }
        }

        public RobotVenta(Marca marca, Modelo modelo, int stock, float importe, bool destino) 
            : base(marca, modelo, stock, importe)
        {
            this.destino = destino;
        }


    }
}
