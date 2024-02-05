/*
    Este algoritmo se encarga de realizar las operaciones básicas matemáticas de dos números

    1. El cliente ingresa un número x
    2. El cliente ingresa un segundo número y
    3. El programa captura estos valores y los almacena en variables
    4. El programa se encarga de realizar la operación matemática 
    5. El programa se encarga de imprimir el resultado de la operación
 */
Console.WriteLine("Por favor ingrese su primer número");
var primerNumeroString = Console.ReadLine();
var primerNumeroInt = int.Parse(primerNumeroString!);

Console.WriteLine("Por favor ingrese su segundo número");
var segundoNumeroString = Console.ReadLine();
var segundoNumeroInt = int.Parse(segundoNumeroString!);

//var resultadoSuma = primerNumeroInt + segundoNumeroInt;
var resultadoSuma = primerNumeroInt;
resultadoSuma += segundoNumeroInt;
Console.WriteLine("El resultado de la suma es: " + resultadoSuma);

//var resultadoResta = primerNumeroInt - segundoNumeroInt;
var resultadoResta = primerNumeroInt;
resultadoResta -= segundoNumeroInt;
Console.WriteLine("El resultado de la resta es: " + resultadoResta);

//var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
var resultadoMultiplicacion = primerNumeroInt;
resultadoMultiplicacion *= segundoNumeroInt;
Console.WriteLine($"El resultado de la multiplicación es: {resultadoMultiplicacion}");

//var resultadoDivision = primerNumeroInt / segundoNumeroInt;
var resultadoDivision = primerNumeroInt;
resultadoDivision /= segundoNumeroInt;
Console.WriteLine($"El resultado de la división es: {resultadoDivision}");

var miVariable = 500;