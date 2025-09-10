using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio5
{
    public class Animal
    {
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Raza { get; set; }
        public int Categoria { get; set; }
        public int AnioNacimiento { get; set; }
        public double Peso { get; set; }
        public string NumeroCarne { get; set; }
        public Duenio Duenio { get; set; }


        public Animal(string nombre, string tipo, string raza, int categoria, int anioNacimiento, double peso, string numeroCarne, Duenio duenio)
        {
            Id = UltimoId++; ;
            Nombre = nombre;
            Tipo = tipo;
            Raza = raza;
            Categoria = categoria;
            AnioNacimiento = anioNacimiento;
            Peso = peso;
            NumeroCarne = numeroCarne;
            Duenio = duenio;
        }

        public Animal()
        {

        }

        public bool TieneTratoPreferencial(Servicio servicio)
        {
            if (servicio == Servicio.Baño && Categoria >= 2)
            {
                return true;
            }
            else if (servicio == Servicio.Manicura && Categoria >= 3)
            {
                return true;
            }
            else if (servicio == Servicio.Masaje && Categoria >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }

        public override string ToString()
        {
            return $"{Nombre}, {Duenio.Nombre} - {Duenio.NumeroSocio}, Valor cuota: {Duenio.PrecioMensualidad}, Último pago: {Duenio.FechaUltimoPago}";
        }
    }
}
