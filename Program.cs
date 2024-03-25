using App01;

Libro donQuijote = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 5000);
//donQuijote._nombre = "Quijote Parte 2";

donQuijote.SetNombre("Quijote X Parte 3");
var nombreLibro = donQuijote.GetNombre();

donQuijote.SetAutor("Mario Blass");
var autor = donQuijote.GetAutor();

donQuijote.SetCantidadPaginas(900);
var cantidadPaginas = donQuijote.GetCantidadPaginas();

var resultado = donQuijote.GetDescripcion();

Console.WriteLine(resultado);


Libro harryPotter = new Libro("Harry Potter", "J.K Rowling", 3000);
//var resultado2 = harryPotter.GetDescripcion();
//Console.WriteLine(resultado2);