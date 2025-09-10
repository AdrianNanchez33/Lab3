using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Auto
    {
        //id marca modelo año de fabr
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Dueño Dueño { get; set; }
        public DateTime FechaDeFabricacion { get; set; }

        public Auto()
        {
            Id = UltimoId++;
        }

        public Auto(string marca, string modelo, Dueño dueño, DateTime fechaDeFabricacion)
        {
            Id = UltimoId++;
            Marca = marca;
            Modelo = modelo;
            Dueño = dueño;
            FechaDeFabricacion = fechaDeFabricacion;
        }

        public override string ToString()
        {
            return $"{Marca}, {Modelo}, Fecha de fabricación: {FechaDeFabricacion}, Dueño: {Dueño.Nombre} {Dueño.Apellido}";
        }
    }
}
