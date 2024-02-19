//1. El usuario ingresa n veces numeros a sumarse
//2. Si el usuario ingresa un numero = 0 entonces se debe detener la suma 
//3. Imprime el total de la suma, de los numeros ingresados

int acumulador = 0;
int numero = 0;

do
{
    Console.WriteLine("Ingrese el número a sumar: ");
    numero = int.Parse(Console.ReadLine()!);
    acumulador += numero;
} while (numero != 0);

Console.WriteLine($"El total de la suma es: {acumulador}");