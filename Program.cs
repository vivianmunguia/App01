
(int a, string b, bool c) miTupla2 = (20, "Vaxi Drez", false);
var miTupla = (20, "Vaxi Drez", false);

miTupla.Item1 = 100;
var miTuplaValorItem1 = miTupla.Item1;
Console.WriteLine($"Imprime mi primer valor de tupla {miTuplaValorItem1}");

miTupla.Item2 = "Curso C#";
var miTuplaValorItem2 = miTupla.Item2;
Console.WriteLine($"Imprime mi segundo valor de tupla {miTuplaValorItem2}");

miTupla.Item3 = true;
var miTuplaValor3 = miTupla.Item3;
Console.WriteLine($"Imprime mi tercer valor de tupla {miTuplaValor3}");