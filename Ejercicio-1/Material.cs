using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Material
    {
       public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string PaisOrigen {  get; set; }
////HOLA VS
        public Material()
        {
            Id = UltimoId++;
        }

        public Material(string nombre, string paisOrigen)
        {
            Nombre = nombre;
            PaisOrigen = paisOrigen;
        }
    }
}
