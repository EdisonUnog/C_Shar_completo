using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class TestSerializacion
    {
        [TestMethod]
        public void Guardar_DeberiaSerializarLaListaEnFormatoXML()
        {
            List<Serie> series = new List<Serie>
            {
                new Serie("Test1", "Genero1"),
                new Serie("Test2", "Genero2")
            };
            Serializadora serializadora = new Serializadora();
            string rutaXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TestBacklog.xml");

            serializadora.Guardar(series, rutaXml);

            Assert.IsTrue(File.Exists(rutaXml));
            File.Delete(rutaXml);
        }

        [TestMethod]
        public void IGuardar_DeberiaSerializarLaListaEnFormatoJson()
        {
            List<Serie> series = new List<Serie>
            {
                new Serie("Test1", "Genero1"),
                new Serie("Test2", "Genero2")
            };
            Serializadora serializadora = new Serializadora();
            string rutaJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TestSeriesParaVer.json");

            ((IGuardar<List<Serie>>)serializadora).Guardar(series, rutaJson);

            Assert.IsTrue(File.Exists(rutaJson));
            File.Delete(rutaJson);
        }
    }
}
