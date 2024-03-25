using App01;

Libro donQuijote = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 5000);
//donQuijote._nombre = "Quijote Parte 2";

donQuijote.Nombre = "Quijote X Parte 3";
var nombreLibro = donQuijote.Nombre;

donQuijote.Autor = "Mario Blass";
var autor = donQuijote.Autor;

donQuijote.CantidadPaginas = 900;
var cantidadPaginas = donQuijote.CantidadPaginas;

var resultado = donQuijote.GetDescripcion();

Console.WriteLine(resultado);


Libro harryPotter = new Libro("Harry Potter", "J.K Rowling", 3000);
//var resultado2 = harryPotter.GetDescripcion();
//Console.WriteLine(resultado2);