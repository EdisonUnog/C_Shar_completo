using System.Xml.Serialization;

namespace Entidades
{
    /*
     1_Implementará la interfaz IArchivos tantas veces como muestra el diagrama. Esto requerirá implementar la interfaz de forma implícita y de forma explícita.
      -Para Bombero: serializará y deserializará el objeto en formato XML. Almacenarlo en un archivo Bombero.xml en el escritorio.
      -Para string: guardará y leerá de la base de datos el mensaje recibido como parámetro. Al leer concatenar todos las entradas del log en un solo string.
     2_El método AtenderSalida realizará lo siguiente:
      -Agregará una nueva salida a la lista del bombero.
      -Suspenderá el hilo entre 2 y 4 segundos.
      -Finalizará la salida.
      -Registrará la salida (horario de inicio, horario de fin y duración total) en la tabla log de la base de datos.
      -Avisará mediante el evento MarcarFin que se terminó la salida. Utilizar el parámetro bomberoIndex para informar al formulario cuál bombero fue. 
     */

    public delegate void FinDeSalida(int bomberoIndex);

    public class Bombero : IArchivo<Bombero>, IArchivo<string> // dos implementaciones
    {
        public event FinDeSalida MarcarFin; // evento no tiene metodo, solo se invoka
        private string nombre;
        private List<Salida> salidas; 
        private static string rutaArchivo;
        public static Random random;

        public Bombero(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Bombero()
        {
            salidas = new List<Salida>();
        }

        static Bombero()
        {
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bomberos.xml");
            random = new Random();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salida> Salidas { get => salidas; set => salidas = value; }


        public void AtenderSalida(int bomberoIndex)
        {
            // 1 -creo la salida
            Salida salida = new Salida();
            salidas.Add(salida);

            // 2 -duerme el hilo por separado
            int tiempo = random.Next(2000, 4000);
            Thread.Sleep(tiempo);

            // 3
            salida.FinalizarSalida();

            // 4 
            // ToLongTimeString: nos da horas minutos y segundos.
            string log = $"salida finalizada. Inicio: {salida.FechaInicio.ToLongTimeString()}. " + 
                         $"Fin {salida.FechaFin.ToLongTimeString()}. duracio: {salida.TiempoTotal} segundos";
            // 5 -registro de salida en sql
            ((IArchivo<string>)this).Guardar(log);

            // 6 -lanzamoe le evento para apagar el fueguito de ese bombero
            MarcarFin.Invoke(bomberoIndex);
        }


        public void Guardar(Bombero info) //xml
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                xmlSerializer.Serialize(sw, info);
            }
        }


        public Bombero Leer() //xml
        {
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                return xmlSerializer.Deserialize(sr) as Bombero;
            }
        }

        void IArchivo<string>.Guardar(string info) //sql
        {
            LogDao logDao = new LogDao();
            logDao.InsertarLog(info);
        }

        string IArchivo<string>.Leer() //sql
        {
            LogDao logDao = new LogDao();
            return logDao.LeerLog();
        }

    }
}
