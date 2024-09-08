using System;
using TesteTecnicoTarget.Models;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Questão 1");
            Console.WriteLine("2 - Questão 2");
            Console.WriteLine("3 - Questão 3");
            Console.WriteLine("4 - Questão 4");
            Console.WriteLine("5 - Questão 5");
            Console.WriteLine("6 - Encerrar");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Questao1.Executar();
                    continuar = RetornarAoMenu();
                    break;
                case "2":
                    Questao2.Executar();
                    continuar = RetornarAoMenu();
                    break;
                case "3":
                    Questao3.Executar();
                    continuar = RetornarAoMenu();
                    break;
                case "4":
                    Questao4.Executar();
                    continuar = RetornarAoMenu();
                    break;
                case "5":
                    Questao5.Executar();
                    continuar = RetornarAoMenu();
                    break;
                case "6":
                    Console.WriteLine("Encerrando o programa...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static bool RetornarAoMenu()
    {
        Console.WriteLine("\n1 - Retornar ao menu");
        Console.WriteLine("2 - Encerrar");
        string escolha = Console.ReadLine();

        if (escolha == "1")
            return true;
        else if (escolha == "2")
        {
            Console.WriteLine("Encerrando o programa...");
            return false;
        }
        else
        {
            Console.WriteLine("Opção inválida. Retornando ao menu...");
            return true;
        }
    }
}
