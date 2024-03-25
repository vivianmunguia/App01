using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Revista : Publicacion
    {
        public string? Periodista { get; set; }

        public Revista(string? periodista, string nombre, int cantidadPaginas, decimal precio) 
            : base(nombre, precio, cantidadPaginas)
        {
            Periodista = periodista;
        }

        public override string GetDescripcion() 
            => $"Revista {Nombre} escrito por {Periodista}, paginas {NumeroPaginas}";
    }
}
