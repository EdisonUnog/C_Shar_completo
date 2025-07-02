using Entidades;

namespace TestProject
{
    [TestClass]
    public class ExtensionesTest
    {
        [TestMethod]
        public void CalcularDiferenciaEnSegundos_DeberiaRetornarDiferenciaEnSegundos()
        {
            //Arranque
            DateTime inicio = new DateTime(2011, 11, 16, 12, 00, 00);
            DateTime fin = new DateTime(2011, 11, 16, 12, 01, 30);
            double valorEsperado = 90;

            //Act
            double resultado = inicio.CalcularDiferenciaEnSegundos(fin);

            //Assert
            Assert.AreEqual(valorEsperado, resultado);
        }

    }
}