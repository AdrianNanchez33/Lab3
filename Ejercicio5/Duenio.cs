using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{

    public class Duenio
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public int NumeroSocio { get; set; }
        public string Email { get; set; }
        public DateTime FechaUltimoPago { get; set; }

        public static decimal PrecioMensualidad { get; set; } = 1200;

        public Duenio(string nombre, string documento, int numeroSocio, string email, DateTime fechaUltimoPago)
        {
            Nombre = nombre;
            Documento = documento;
            NumeroSocio = numeroSocio;
            Email = email;
            FechaUltimoPago = fechaUltimoPago;
        }

        public Duenio()
        {

        }

        public string RealizarPago(decimal monto)
        {
            if (monto >= PrecioMensualidad)
            {
                FechaUltimoPago = DateTime.Now;
                return "Pago actualizado";
            }
            else
            {
                return "Pago insuficiente";
            }
        }
    }
}

