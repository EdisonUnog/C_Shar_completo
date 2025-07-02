using System.Data.Common;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EntidadesDispositivoRepaso
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo { get => sistemaOperativo; set => sistemaOperativo = value; }
        protected abstract int TamanioMb { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        /// <summary>
        /// Retorna los datos de la aplicación.
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new();

            sb.AppendLine($" Nombre: {nombre}");
            sb.AppendLine($" Sistema Operativo: {SistemaOperativo}");
            sb.AppendLine($" Tamaño: {TamanioMb}");

            return sb.ToString();
        }


        /// <summary>
        /// El operador implícito recibirá una lista de aplicaciones y devolverá la instancia de la aplicación
        /// que más tamaño tenga.
        /// </summary>
        /// <param name="listaApp"></param>
        /// 
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maximoTamanio = int.MinValue;
            Aplicacion aplicaccionPesada = null;

            foreach (Aplicacion app in listaApp)
            {
                if (app.TamanioMb > maximoTamanio)
                {
                    maximoTamanio = app.TamanioMb;
                    aplicaccionPesada = app;
                }
            }

            return aplicaccionPesada;
        }


        /// <summary>
        /// La sobrecarga del operador == buscará si una aplicación existe en la lista recibida por
        /// parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si ya existe.</returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (app is null || listaApp is null)
            {
                return false;
            }

            foreach (Aplicacion aplicacion in listaApp)
            {
                if (app.nombre == aplicacion.nombre)
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// La sobrecarga del operador != buscará si una aplicación no existe en la lista recibida por
        /// parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si no existe.</returns>
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }


        /// <summary>
        /// La sobrecarga del operador + añadirá una aplicación a la lista de aplicaciones pasada por
        /// parámetro siempre y cuando sea no exista previamente.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si pudo añadir la aplicación.</returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            return $" {nombre}";
        }

    }
}
