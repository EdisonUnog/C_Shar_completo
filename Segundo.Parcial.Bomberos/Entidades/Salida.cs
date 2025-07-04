﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
     1_El constructor dará inicio a la salida colocando la fecha y hora actual en el atributo correspondiente.
     2_El método FinalizarSalida dará fin a la salida colocar la fecha y hora actual en el atributo correspondiente.
     3_La propiedad TiempoTotal retornará la diferencia en segundos entre la fecha de inicio y la fecha de fin. 
     */
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salida()
        {
            fechaInicio = DateTime.Now;
        }

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public double TiempoTotal { get => fechaInicio.CalcularDiferenciaEnSegundos(fechaFin); }

        public void FinalizarSalida()
        {
            fechaFin = DateTime.Now;
        }


    }
}
