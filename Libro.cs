using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Libro
    {
        private string _nombre;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        private string _autor;
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }

        private int _cantidadPaginas;
        public int CantidadPaginas
        {
            get => _cantidadPaginas;
            set => _cantidadPaginas = value;
        }

        //Ejemplo de la vida real
        public string MiPropiedad { get; set; }

        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcion() => $"{Nombre} escrito por {Autor}, paginas {CantidadPaginas}";
        //{
        //    return $"{_nombre} por {_autor}, cantidad {_cantidadPaginas}";
        //}
    }
}
