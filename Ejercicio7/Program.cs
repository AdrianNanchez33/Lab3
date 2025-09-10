namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Club club1 = new Club("Nacional", "Uruguay", new DateTime(1899,5,14));
            Club club2 = new Club("Boca Juniors", "Argentina", new DateTime(1905,10,18));
            Club club3 = new Club("Flamengo", "Brasil", new DateTime(1915,9,12));

            // ----- Precarga de futbolistas -----
            Futbolista f1 = new Futbolista("Luis Suárez", new DateTime(1987, 1, 24), club1);
            Futbolista f2 = new Futbolista("Edinson Cavani", new DateTime(1987, 2, 14), club2);
            Futbolista f3 = new Futbolista("Gabriel Barbosa", new DateTime(1996, 8, 30), club3);

            // ----- Precarga de goles -----
            Gol g1 = new Gol(f1, 15,false, TipoGol.AFavor);
            Gol g2 = new Gol(f2, 45, true, TipoGol.EnContra);
            Gol g3 = new Gol(f3, 78,true, TipoGol.AFavor);
        }
    }
}
