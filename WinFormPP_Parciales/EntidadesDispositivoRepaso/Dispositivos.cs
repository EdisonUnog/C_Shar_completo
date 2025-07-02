using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDispositivoRepaso
{
    public class Dispositivos
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivos()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Sistemas Operativoss : {sistemaOperativo}{Environment.NewLine}");

            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }

            return sb.ToString();
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo != sistemaOperativo)
            {
                return false;
            }
            return appsInstaladas + app;
        }

    }
}
