namespace TesteTecnicoTarget.Models
{
    public class Questao1
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (PertenceFibonacci(numero))
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }

        private static bool PertenceFibonacci(int numero)
        {
            int a = 0, b = 1, c = 0;
            while (c < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c == numero || numero == 0;
        }
    }
}
