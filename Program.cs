//Bucle para imprimir 80 veces el texto: Bienvenido al curso de C# avanzado
for (int i = 1; i <= 80; i++)
{
    Console.WriteLine("Bienvenido al curso de C# avanzado");
}

// 1. El usuario ingresa un número en la consola
// 2. El programa multiplica por los primeros 10 numeros a este numero ingresado
// 3. Se debe imprimir el resultado de cada operacion
Console.WriteLine("Ingrese un número a multiplicar 10 veces");
var numeroParaMultiplicar = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    int resultado = i * numeroParaMultiplicar;
    Console.WriteLine($"{i} x {numeroParaMultiplicar} = {resultado}");
}