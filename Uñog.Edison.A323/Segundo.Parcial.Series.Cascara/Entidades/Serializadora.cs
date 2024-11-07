using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora : IGuardar<List<Serie>>
    {
        public Serializadora() { }
        
        public void Guardar(List<Serie> item, string ruta) // xml
        {
            try
            {
                using (StreamWriter rw = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Serie>));
                    xmlSerializer.Serialize(rw, item);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error al guardar en XML: {ex.Message}");
                throw new BackLogException("Algo salio mal", ex);
            }
        }

        void IGuardar<List<Serie>>.Guardar(List<Serie> series, string ruta) // json
        {
            try
            {
                string objeto = JsonSerializer.Serialize(series);
                File.AppendAllText(ruta, objeto);
            }
            catch (Exception ex)
            {
                Logger.Log($"Error al guardar en Json: {ex.Message}");
                throw new BackLogException("Algo salio mal", ex);
            }
        }

    }
}
