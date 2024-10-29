using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Exercitando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();
            ExibirOpcoesMenu();
        }

        public static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Downzin");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================");
            Console.ResetColor();
        }

        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("Digite 1 para o exercício 1");
            Console.WriteLine("Digite 2 para o exercício 2");
            Console.WriteLine("Digite 3 para o exercício 3");
            Console.WriteLine("Digite 4 para o exercício 4");
            Console.WriteLine("Digite 5 para o exercício 5");
            Console.WriteLine("Digite 6 para o exercício 6");
            Console.WriteLine("Digite 0 para sair\n");
            Console.WriteLine("\nDigite a opção escolhida:");

            int opcaoEscolhidaMenu = int.Parse(Console.ReadLine());

            switch (opcaoEscolhidaMenu)
            {
                case 1:
                    Console.Clear();
                    PositivoNegativoZero();
                    Thread.Sleep(2000);

                    break;
                case 2:
                    Console.Clear();
                    DeMaiorIdade();
                    Thread.Sleep(2000);

                    break;
                case 3:
                    Console.Clear();
                    ParImpar();
                    Thread.Sleep(2000);
                    
                    break;
                case 4:
                    Console.Clear();
                    MaiorNumero();
                    Thread.Sleep(2000);

                    break;
                default:

                    break;
            }
        }

        private static void PositivoNegativoZero()
        {
            while (true) 
            {
                Console.WriteLine("\nInsira um número:");

                int numeroEscolhido;
                while (!int.TryParse(Console.ReadLine(), out numeroEscolhido))
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número inteiro.");
                }

                if (numeroEscolhido == 0)
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é zero.");
                }
                else if (numeroEscolhido > 0)
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é positivo.");
                }
                else
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é negativo.");
                }

                Console.WriteLine("Deseja refazer novamente? (S/N)");
                string resposta = Console.ReadLine().ToUpper(); 

                if (resposta != "S") 
                {
                    break;
                }
            }
        }

        private static void DeMaiorIdade()
        {
            while(true)
            {
                Console.WriteLine("\nInsira um número para verficar a idade:");

                int idadeInserida;
                while(!int.TryParse(Console.ReadLine(),out idadeInserida))
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número inteiro.");
                }

                if (idadeInserida >= 18)
                {
                    Console.WriteLine($"\nA idade {idadeInserida} é de maior de idade");
                } else if (idadeInserida >= 0)
                {
                    Console.WriteLine($"\nA idade {idadeInserida} é de menor de idade");
                } else
                {
                    Console.WriteLine("\nInsira uma idade válida!");
                }

                Console.WriteLine("\nDesejar refazer novamente?(S/N)");

                string resposta = Console.ReadLine().ToUpper();

                if  (resposta != "S")
                {
                    break;
                }
            }
        }

        private static void ParImpar()
        {
            while(true)
            {
                Console.WriteLine("\nInsira um número para verificar se é par ou impar:");

                int numeroEscolhido;
                while(!int.TryParse(Console.ReadLine(), out numeroEscolhido))
                {
                    Console.WriteLine("\nInsira um número inteiro válido");
                }

                if (numeroEscolhido % 2 == 0)
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é par");
                } else
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é impar");
                }

                Console.WriteLine("\nDeseja refazer novamente? (S/N)");

                if(Console.ReadLine().ToUpper() != "S")
                {
                    break;
                }
            }
        }

        private static void MaiorNumero()
        {
            Console.WriteLine("\nInsira um número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira um número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira um número:");
            int numero3 = int.Parse(Console.ReadLine()); 

            int[] numerosArray = { numero1, numero2 , numero3 };

            Console.WriteLine("\nNumero Escolhidos:");
            Console.WriteLine(string.Join(",", numerosArray));

            Array.Sort(numerosArray);
            Array.Reverse(numerosArray);

            Console.WriteLine("\nNúmeros Organizados:");
            Console.WriteLine(string.Join(",", numerosArray));

            Console.WriteLine($"\nNumero maior: {numerosArray[0]}");

        }
    }
}
