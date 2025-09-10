namespace EJercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("Argentina", "ARG");
            Pais p2 = new Pais("Uruguay", "URU");
            Pais p3 = new Pais("Brasil", "Brasil");

            Marca m1 = new Marca("LG", p1);
            Marca m2 = new Marca("Samsung", p2);
            Marca m3 = new Marca("TLC", p3);

            Televisor t1 = new Televisor(m1, "LED", Tamaño.LG, true);
            Televisor t2 = new Televisor(m2, "QLED", Tamaño.SM, true);
            Televisor t3 = new Televisor(m1, "OLED", Tamaño.XL, false);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.ReadKey();


        }
    }
}
