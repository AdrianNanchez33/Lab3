
namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duenio d1 = new Duenio("Ana López", "4.567.890-1", 101, "ana@mail.com", new DateTime (2025,8,10));

            Animal a1 = new Animal("Firulais", "Perro", "Labrador", 3, 2018, 25.4, "C123", d1);
            
            

            Console.WriteLine(d1.RealizarPago(1600));
            Console.WriteLine(a1);

            Console.WriteLine(a1.TieneTratoPreferencial(Servicio.Masaje));
            Console.WriteLine(a1.TieneTratoPreferencial(Servicio.Baño));

            Console.ReadKey();
        }
    }
}
