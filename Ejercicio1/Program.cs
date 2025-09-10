using Ejercicio3;
using System.Xml;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("España", "ES");
            Director d1 = new Director(p1, "Roberto López");
            Pelicula pel1 = new Pelicula("Los Vengadores", Genero.Thriller,d1, new DateTime(2020, 10, 28),90);

            Console.WriteLine(pel1);
            Console.WriteLine($"El pais del director de la película {pel1.Titulo} es {pel1.Director.ObtenerPais()}");

            Console.ReadKey();



           
        }
    }
}
