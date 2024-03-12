namespace Desafio2.Models{
    public class Verificar{
        public int Numero { get; }
        public Verificar(int numero){
            Numero = numero; 
        }
    
        public void VerificaFibonacci(){
            int num = Numero;
            int a = 0;
            int b = 1;
            if (num == a || num == b){
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
                return; 
            }
            while (b < num){
                int proximo = a + b;
                a = b;
                b = proximo;

                if (b == num){
                    Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
                    return;
                }
            }
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
        }
    }
}
