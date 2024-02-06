/*
    Este algoritmo se encarga de realizar las operaciones básicas matemáticas de dos números

    1. El cliente ingresa un número x
    2. El cliente ingresa un segundo número y
    3. El cliente ingresa el tipo de operación a realizar que puede ser suma, resta, multiplicación o división
    4. El programa captura estos valores y los almacena en variables
    5. El programa se encarga de realizar la operación matemática 
    6. El programa se encarga de imprimir el resultado de la operación
 */
Console.WriteLine("Por favor ingrese su primer número");
var primerNumeroString = Console.ReadLine();

//if (primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("Ingresó un valor nulo o en blanco, terminó el programa");
//    return;
//}

if (string.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El valor es nulo o vacío, con el operador IsNullOrEmpty");
    return;
}

/*
    Algoritmo para evaluar si un texto tiene la nomenclatura de número, si es posible convertir un texto a número
    1. Declarar una variable para el resultado posible
    2. Condicionar si el texto está realtemente escrito en una nomenclatura numérica
    3. En caso de que no sea un número, entonces termina el programa
    4. En caso de que sí sea un número, entonces continúa la ejecución del programa
 */

int primerNumeroInt = 0;

if (!int.TryParse(primerNumeroString, out primerNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un número");
    return;
}

if (primerNumeroInt >= 100)
{
    Console.WriteLine("Su número es mayor igual que 100");
}
else
{
    Console.WriteLine("Su número es menor que 100");
}

if (primerNumeroInt <= 10)
{
    Console.WriteLine("Es menor igual que 10");
}
else if (primerNumeroInt > 10 && primerNumeroInt <= 20)
{
    Console.WriteLine("Es mayor que 10 y menor igual que 20");
}
else
{
    Console.WriteLine("El número es mayor que 20");
}

//var primerNumeroInt = int.Parse(primerNumeroString!);

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