using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDispositivoRepaso
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;


        /// <summary>
        /// Retorna el tamaño de la app + tamaño ocupado por las canciones.
        /// </summary>
        protected override int TamanioMb
        {
            get
            {
                int tamanioCanciones = listaCanciones.Count * 2;
                return tamanioMb + tamanioCanciones;
            }
        }


        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
            : this(nombre, sistemaOperativo, tamanioMb, new List<string>())
        {

        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> listaCanciones)
            : base(nombre, sistemaOperativo, tamanioMb)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }


        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine($"{Environment.NewLine} lista de canciones");

            foreach (string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }

            return sb.ToString();
        }
    }
}
