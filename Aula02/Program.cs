using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula02
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
░██████╗███████╗███╗░░██╗░█████╗░░█████╗░  ░█████╗░███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░███╗░░██╗░█████╗░
██╔════╝██╔════╝████╗░██║██╔══██╗██╔══██╗  ██╔══██╗████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗████╗░██║██╔══██╗
╚█████╗░█████╗░░██╔██╗██║███████║██║░░╚═╝  ███████║██╔████╔██║█████╗░░██████╔╝██║██║░░╚═╝███████║██╔██╗██║███████║
░╚═══██╗██╔══╝░░██║╚████║██╔══██║██║░░██╗  ██╔══██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║██║░░██╗██╔══██║██║╚████║██╔══██║
██████╔╝███████╗██║░╚███║██║░░██║╚█████╔╝  ██║░░██║██║░╚═╝░██║███████╗██║░░██║██║╚█████╔╝██║░░██║██║░╚███║██║░░██║
╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░  ╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================");
            Console.ResetColor();
        }

        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("Digite 1 para registrar informações");
            Console.WriteLine("Digite 2 para listar informações");
            Console.WriteLine("Digite 3 para apagar informações");
            Console.WriteLine("Digite 0 para sair\n");
            Console.WriteLine("\nDigite a opção escolhida:");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    CadInfo();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();

                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu a Opção 2");
                    Thread.Sleep(1000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();

                    break;

                case 3:
                    Console.WriteLine("\nVocê escolheu a Opção 3");
                    Thread.Sleep(1000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();

                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Thread.Sleep(1000);

                    break;

                default:
                    Console.WriteLine("\nVocê digitou a opção invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();

                    break;
            }
        }

        private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("Digite seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine($"\n Nome Cadastrado com Sucesso!!! {nomeUsuario}");
            Thread.Sleep(1000);

        }
    }
}


