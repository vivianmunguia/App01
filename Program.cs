//1. El usuario ingresa un numero
//2. El programa captura el numero e imprime una lista de numeros superiores hasta el maximo de 100
//Regla: El numero ingresado por el usuario no debe ser mayor o igual que 100

Console.WriteLine("Ingrese un número menor que 100");
int numero = int.Parse(Console.ReadLine()!);

while (numero <= 100)
{
    Console.WriteLine(numero);
    numero++;
}