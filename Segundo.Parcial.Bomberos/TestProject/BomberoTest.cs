using Entidades;

namespace TestProject
{
    [TestClass]
    public class BomberoTest
    {
        [TestMethod]
        public void Leer_DeberiaRetornarELBomberoSerializado()
        {
            //arrange
            Bombero bombero =  new Bombero("prueba");

            //Act
            bombero.Guardar(bombero);

            //Asset
            Bombero bomberoDeserializado = bombero.Leer();
            Assert.AreEqual(bomberoDeserializado.Nombre, bombero.Nombre);
        }
    }
}