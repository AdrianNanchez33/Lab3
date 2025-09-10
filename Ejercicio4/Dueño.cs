using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Dueño
    {
        //id nombre apellido y fecha de nac
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public Dueño()
        {
            Id = UltimoId++;
        }

        public Dueño(string nombre, string apellido, DateTime fechaDeNacimiento)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
        }
    }
}
