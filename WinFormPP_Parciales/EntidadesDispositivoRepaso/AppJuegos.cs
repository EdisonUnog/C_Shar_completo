﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDispositivoRepaso
{
    public class AppJuegos : Aplicacion
    {
        protected override int TamanioMb
        {
            get { return tamanioMb; }
        }

        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
            : base(nombre, sistemaOperativo, tamanioMb)
        {

        }

    }
}
