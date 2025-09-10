namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dueño d1 = new Dueño("Adrian", "Nanchez", new DateTime(2001, 10, 28));
            Dueño d2 = new Dueño("Aruna", "Fleitas", new DateTime(2002, 11, 18));

            Auto a1 = new Auto("Gol G7", "Volkswagen", d1, new DateTime(2018, 11, 25));
            Auto a2 = new Auto("A3", "Audi", d2, new DateTime(2024, 12, 20));
            
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.ReadKey();
            Console.WriteLine("HOLA GIT");
        }
    }
}
