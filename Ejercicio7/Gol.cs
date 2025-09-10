using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Gol
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public Futbolista Futbolista { get; set; }
        public int Minuto { get; set; }
        public bool DePenal { get; set; }
        public TipoGol TipoGol { get; set; }


        public Gol()
        {
            Id = UltimoId++;
        }

        public Gol(Futbolista futbolista, int minuto,  bool dePenal, TipoGol tipoGol)
        {
            Id = UltimoId++;
            Futbolista = futbolista;
            Minuto = minuto;
            DePenal = dePenal;
            TipoGol = tipoGol;
        }







    }
}
