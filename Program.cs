using App01;

Libro donQuijote = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 5000, 20.58m);
var libroResultado = donQuijote.GetDescripcion();
Console.WriteLine(libroResultado);

Revista revistaTimes = new Revista("María Lopez", "Times", 50, 10.10m);
var revistaResultado = revistaTimes.GetDescripcion();
Console.WriteLine(revistaResultado);