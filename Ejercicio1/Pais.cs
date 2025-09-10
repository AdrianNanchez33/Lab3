using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Pais
    {
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string Codigo { get; set; }


    public Pais()
        {
            Id = UltimoId++;
        }


        public Pais(string nombre, string codigo)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}
