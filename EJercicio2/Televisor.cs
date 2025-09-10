using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercicio2
{
    public class Televisor
    {
        //e id, marca, modelo, tamaño y si es Smart
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 0;
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public Tamaño Tamaño { get; set; }
        public bool Smart { get; set; }
        public bool estado { get; set; }
        public int volumen { get; set; }

        public Televisor()
        {
            Id = UltimoId++;
        }

        public Televisor(Marca marca, string modelo, Tamaño tamaño, bool smart)
        {
            Id = UltimoId++;
            Marca = marca;
            Modelo = modelo;
            Tamaño = tamaño;
            Smart = smart;
        }




        public override string ToString()
        {
            string esSmart = Smart ? "Sí" : "No";
            int pulgadas = (int)Tamaño;
            return $"Marca: {Marca.Nombre} ({Marca.Pais.Codigo}), Modelo: {Modelo}, Pulgadas: {pulgadas}, Smart: {esSmart}. ";
        }
    }

}
