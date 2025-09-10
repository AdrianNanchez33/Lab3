using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercicio2
{
    public class Marca
    {
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public Pais Pais { get; set; }

        public Marca() {
            Id = UltimoId++;
        }

        public Marca(string nombre, Pais pais)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Pais = pais;
            
        }
    }
}
