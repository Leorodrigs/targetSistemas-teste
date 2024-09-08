namespace TesteTecnicoTarget.Models
{
    public class Questao2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine().ToLower();
            int count = 0;

            foreach (char c in frase)
            {
                if (c == 'a')
                    count++;
            }

            Console.WriteLine($"A letra 'a' aparece {count} vezes na frase.");
        }
    }
}
