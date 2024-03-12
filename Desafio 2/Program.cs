using Desafio2.Models;

Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
int numero = Convert.ToInt32(Console.ReadLine());

Verificar verificador = new Verificar(numero);
verificador.VerificaFibonacci();
