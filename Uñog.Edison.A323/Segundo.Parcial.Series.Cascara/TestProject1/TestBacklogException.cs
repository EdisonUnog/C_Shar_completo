using Entidades;

namespace TestProject1
{
    [TestClass]
    public class TestBacklogException
    {
        [TestMethod]
        [ExpectedException(typeof(BackLogException))]
        public void BacklogException_DeberiaLanzarseAlNoPoderSerializar()
        {
            Serializadora serializadora = new Serializadora();
            List<Serie> series = new List<Serie>();
            string rutaInvalida = string.Empty;

        }
    }
}