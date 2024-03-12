
using Desafio5.Models;

Console.WriteLine("Digite uma string para inverter:");
string texto = Console.ReadLine();

Inverter inverter = new Inverter();

string textoInvertido = inverter.InverterTexto(texto);
Console.WriteLine($"String invertida: {textoInvertido}");
