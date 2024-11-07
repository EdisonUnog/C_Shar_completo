using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoBlacklog(Serie serie);
    public class ManejadorBacklog
    {
        public event DelegadoBlacklog serieParaVer;

        public void IniciarManejador(List<Serie> series)
        {
            Task.Run(() => MoverSeries(series));
        }


        private void MoverSeries(List<Serie> series)
        {
            while (series.Count > 0)
            {
                int indice = series.GenerarRandom();
                Serie serie = series[indice];

                AccesoDatos.ActualizarSerie(serie);
                series.RemoveAt(indice);

                Thread.Sleep(1500);

                if (serieParaVer != null)
                {
                    serieParaVer.Invoke(serie);
                }
            }
        }
    }
}
