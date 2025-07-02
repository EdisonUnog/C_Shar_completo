using EntidadesRobotPrueba;
using System.Text;

namespace apps
{ 
    class Courier
    {
        public virtual void Deliver()
        {
            System.Console.WriteLine("I need to deliver a package"); 
        }
        public virtual void Find(string text)
        {
            System.Console.WriteLine("i need find: " + text);
        }
    }


    class Couriers6 : Courier
    {
        public override void Deliver()
        {
            System.Console.WriteLine("i nee to deliver the chip to the lucky38"); // imprime
        }
    }

    //static class mall 
    //{
    //    public abstract string Rendir()
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        return sb;
    //    }
    //}
    public class A
    {
        public virtual string Informar()
        {
            return "kep you waiting, huh";
        }
    }

    public class B : A
    {
        public override string Informar()
        {
            return "ocelots are proud creatures";
        }
    }

    public class C : B
    {
        public override string Informar()
        {
            return "you re pretty good";
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            //B b = new C();
            //A a = b;



            A a = new B();
            B b = new C();
            A a2 = new C();

            //Console.WriteLine(a.Informar());
            //Courier courier = new Couriers6();
            //courier.Deliver();
            //int max = 5;
            //Stack<double> data = new Stack<double>();
            //int i;

            ////-------------------------------------------

            //for (i = max; i > 0; i--)
            //{
            //    data.Push(i);
            //}
            //for (i = 0; i < max; i++)
            //{
            //    Console.Write(String.Format("{0}- ", data.Pop()));
            //}

            ////-------------------------------------------

            //List<Animal> listaAnimales = new List<Animal>();
            //listaAnimales.Add(new Gato("Gato1", "Agipcio", "Gris", "maulla"));
            //listaAnimales.Add(new Perro("Perro1", "doberman", "Negro", "Ladra"));

            //foreach(Animal a in listaAnimales)
            //{
            //    Console.WriteLine(a.MostrarInformacion());
            //}

            //RobotVenta robotVenta = new RobotVenta(Marca.KUKA, Modelo.KR40PA, 5, 1234, true);
            //Robot robotAlquiler = (RobotAlquiler)Modelo.KR40PA;
            // true : venta     false : alquiler

            List<Robot> listaRobotsDestino = new List<Robot>();
            TiendaRobot tiendaRobot = new TiendaRobot("Mr. Robot");


            listaRobotsDestino.Add(new RobotVenta(Marca.KUKA, Modelo.KR40PA, 5, 1234, true));

            listaRobotsDestino.Add(new RobotAlquiler(Marca.ABB, Modelo.PALETIZADO, 3,  534));
            listaRobotsDestino.Add((RobotAlquiler)Modelo.KR40PA);

            foreach (Robot robot in listaRobotsDestino)
            {
                if (tiendaRobot + robot)
                {
                    Console.WriteLine(TiendaRobot.ObtenerInformacionDeVentas(tiendaRobot));
                }
                else
                {
                    Console.WriteLine("no se pudo concretar la venta, no hay stok");
                    Console.WriteLine($" Tienda: {tiendaRobot.NombreTienda} - Marca {robot.Modelo}");
                }
            }
           

        }
    }
}

