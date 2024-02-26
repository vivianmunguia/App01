//Objetivo: Calcular el sueldo total de un empleado
//1. El metodo recibe los valores de salario, impuesto, salud
//2. Calcula el total que debe recibir de salario en funcion a estos parametros
//3. El metodo debe devolver el salario total

int salarioTotal = 0;
CalcularSalarioTotal(salario: 1000, impuesto: 400, salud: 100, out salarioTotal);
Console.WriteLine($"El salario total es {salarioTotal}");

void CalcularSalarioTotal(int salario, int impuesto, int salud, out int total)
{
    total = salario - impuesto - salud;
}