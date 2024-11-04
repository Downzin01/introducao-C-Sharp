using System;

namespace Exercitando2.Functions
{
    public class Util
    {
        public static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Downzin");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(@"
  ███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
  ██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
  █████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
  ██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
  ███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
  ╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================================================================\n");
            Console.ResetColor();
        }

        public static void ExibirOpcoesMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("» Digite 1 para o exercício 1");
            Console.WriteLine("» Digite 2 para o exercício 2");
            Console.WriteLine("» Digite 3 para o exercício 3");
            Console.WriteLine("» Digite 4 para o exercício 4");
            Console.WriteLine("» Digite 5 para o exercício 5");
            Console.WriteLine("» Digite 6 para o exercício 6");
            Console.WriteLine("» Digite 0 para sair\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n» Digite a opção escolhida:");

            int opcaoEscolhidaMenu = int.Parse(Console.ReadLine());

            switch (opcaoEscolhidaMenu)
            {
                case 1:
                    Console.Clear();
                    Atividades.PositivoNegativoZero();
                    break;
                case 2:
                    Console.Clear();
                    Atividades.DeMaiorIdade();
                    break;
                case 3:
                    Console.Clear();
                    Atividades.ParImpar();
                    break;
                case 4:
                    Console.Clear();
                    Atividades.MaiorNumero();
                    break;
                case 5:
                    Console.Clear();
                    Atividades.AvaliarNota();
                    break;
                case 6:
                    Console.Clear();
                    Atividades.CalcularMedia();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    ExibirOpcoesMenu();
                    break;
            }
        }
    }
}
