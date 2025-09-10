using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Mesa
    {
        //ID, largo, ancho, altura, material, y
        // precio
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Altura { get; set; }
        public Material Material { get; set; }
        public int Precio { get; set; }

        public Mesa()
        {
            Id = UltimoId++;
        }

        public Mesa(decimal largo, decimal ancho, decimal altura, Material material, int precio)
        {
            Id = UltimoId++;
            Largo = largo;
            Ancho = ancho;
            Altura = altura;
            Material = material;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Mesa {Id} de {Material.Nombre} vale {Precio}";
        }

    }
}
