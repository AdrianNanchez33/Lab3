using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Futbolista
    {
        //id nombre apellido fecha de nac club 
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Club Club { get; set; }

        public Futbolista()
        {
            Id = UltimoId++;
        }

        public Futbolista(string nombreCompleto, DateTime fechaNacimiento, Club club)
        {
            Id = UltimoId++;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            Club = club;

        }

    }
}
