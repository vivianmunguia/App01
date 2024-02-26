//1. El usuario ingresa el numero que representa cuantas veces se generara este valor aleatorio
//2. En el bucle se generara un numero aleatorio entre 1 y 1000
//3. Imprimir dentro del bucle este numero aleatorio previamente generado

ImprimirNumeroAleatorio(10, "Bienvenido aleatorio");

void ImprimirNumeroAleatorio(int numeroRango, string mensaje)
{
	var random = new Random();

	for (int i = 1; i <= numeroRango; i++)
	{
		var numeroAleatorio = random.Next(1, 100);
		Console.WriteLine($"{mensaje} {numeroAleatorio}");
	}
}