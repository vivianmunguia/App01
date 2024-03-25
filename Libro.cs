using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Libro : Publicacion
    {
        private string _autor;
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }

        public Libro(string nombre, string autor, int cantidadPaginas, decimal precio) 
            : base(nombre, precio, cantidadPaginas)
        {
            _autor = autor;
        }

        public override string GetDescripcion() 
            => $"Libro {Nombre} escrito por {Autor}, paginas {NumeroPaginas}";
    }
}
