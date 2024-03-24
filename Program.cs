using App01;

Libro donQuijote = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 5000);
Libro harryPotter = new Libro("Harry Potter", "J.K Rowling", 3000);

var resultado = donQuijote.GetDescripcion();
var resultado2 = harryPotter.GetDescripcion();

Console.WriteLine(resultado);
Console.WriteLine(resultado2);