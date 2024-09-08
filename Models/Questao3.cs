namespace TesteTecnicoTarget.Models
{
    public class Questao3
    {
        public static void Executar()
        {
            int INDICE = 12, SOMA = 0, K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"O valor da variável SOMA é {SOMA}");
        }
    }
}
