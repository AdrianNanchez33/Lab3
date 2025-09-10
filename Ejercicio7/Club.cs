using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Club
    {
        //id nombre pais fecha de fundacion
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public DateTime FechaFundacion { get; set; }

        public Club() { }

        public Club(string nombre, string pais, DateTime fechaFundacion )
        {
            Id = UltimoId++;
            Nombre = nombre;
            Pais = pais;
            FechaFundacion = fechaFundacion;
        }
    }
}
