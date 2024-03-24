using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Libro
    {
        string _nombre;
        string _autor;
        int _cantidadPaginas;

        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcion()
        {
            return $"{_nombre} por {_autor}";
        }
    }
}
