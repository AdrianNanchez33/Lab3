namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Material m1 = new Material("Madera", "Australia");
            Material m2 = new Material("Piedra", "Rusia");
            Material m3 = new Material("Plástico", "Bélgica");

            Mesa mesa1 = new Mesa(30, 20, 10, m1, 1300);
            Mesa mesa2 = new Mesa(24, 27, 12, m2, 1200);

            Console.WriteLine(mesa1);
            Console.WriteLine(mesa2);

            Console.ReadKey();

        }
    }
}
