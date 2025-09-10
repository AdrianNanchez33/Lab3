using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Pelicula
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Titulo { get; set; }
        public Genero Genero { get; set; }
        public Director Director { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        public Pelicula() { }

        public Pelicula(string titulo, Genero genero, Director director,DateTime fechaLanzamiento, int duracion)
        {
            Id = UltimoId++;
            Titulo = titulo;
            Genero = genero;
            Director = director;
            FechaLanzamiento = fechaLanzamiento;
            Duracion = duracion;
        }

        public DateTime BajaDeCatalogo()
        {
            return FechaLanzamiento.AddMonths(3);
        }

        public bool EsApta()
        {
            if (Genero == Genero.Thriller || Genero == Genero.Terror || Genero == Genero.Suspenso)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"La pelicula {Titulo} es del género {Genero} y es dirigida por el director {Director.NombreCompleto}";
        }





    }
}
