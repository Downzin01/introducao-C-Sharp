using System;

namespace Exercitando2.Functions
{
    public class Atividades
    {
        public static void PositivoNegativoZero()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n» Insira um número (Para ver se é positivo ou não):");

                int numeroEscolhido;
                while (!int.TryParse(Console.ReadLine(), out numeroEscolhido))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n:O Entrada inválida. Por favor, insira um número inteiro.");
                }

                Console.ForegroundColor = ConsoleColor.Green;
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

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDeseja refazer novamente? (S/N)");

                if (Console.ReadLine().ToUpper() != "S")
                {
                    Console.Clear();
                    Util.ExibirCabecalho();
                    Util.ExibirOpcoesMenu();
                }

                Console.Clear();
                PositivoNegativoZero();
            }
        }

        public static void DeMaiorIdade()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n» Insira um número para verficar a idade:");

                int idadeInserida;
                while (!int.TryParse(Console.ReadLine(), out idadeInserida))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número inteiro.");
                }

                if (idadeInserida >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nA idade {idadeInserida} é de maior de idade");
                }
                else if (idadeInserida >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nA idade {idadeInserida} é de menor de idade");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nInsira uma idade válida!");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDesejar refazer novamente? (S/N)");

                if (Console.ReadLine().ToUpper() != "S")
                {
                    Console.Clear();
                    Util.ExibirCabecalho();
                    Util.ExibirOpcoesMenu();
                }

                Console.Clear();
                DeMaiorIdade();
            }
        }

        public static void ParImpar()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nInsira um número para verificar se é par ou impar:");

                int numeroEscolhido;
                while (!int.TryParse(Console.ReadLine(), out numeroEscolhido))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nInsira um número inteiro válido");
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                if (numeroEscolhido % 2 == 0)
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é par");
                }
                else
                {
                    Console.WriteLine($"\nO número {numeroEscolhido} é impar");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDeseja refazer novamente? (S/N)");

                if (Console.ReadLine().ToUpper() != "S")
                {
                    Console.Clear();
                    Util.ExibirCabecalho();
                    Util.ExibirOpcoesMenu();
                }

                Console.Clear();
                ParImpar();
            }
        }

        public static void MaiorNumero()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nInsira um número:");
            Console.ForegroundColor = ConsoleColor.White;
            int numero1 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nInsira um número:");
            Console.ForegroundColor = ConsoleColor.White;
            int numero2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nInsira um número:");
            Console.ForegroundColor = ConsoleColor.White;
            int numero3 = int.Parse(Console.ReadLine());

            int[] numerosArray = { numero1, numero2, numero3 };

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNumero Escolhidos:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Join(",", numerosArray));

            Array.Sort(numerosArray);
            Array.Reverse(numerosArray);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNúmeros Organizados:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Join(",", numerosArray));

            Console.WriteLine($"\nNumero maior: {numerosArray[0]}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDeseja refazer novamente? (S/N)");

            if (Console.ReadLine().ToUpper() != "S")
            {
                Console.Clear();
                Util.ExibirCabecalho();
                Util.ExibirOpcoesMenu();
            }

            Console.Clear();
            MaiorNumero();
        }

        public static void AvaliarNota()
        {
            Console.WriteLine("\nInsira sua nota de 0 à 10");
            float notaAdicionada = float.Parse(Console.ReadLine());

            if (notaAdicionada >= 7)
            {
                Console.WriteLine("\nVocê foi aprovado!");
            }
            else if (notaAdicionada >= 5)
            {
                Console.WriteLine("\nVocê está de recuperação!");
            }
            else
            {
                Console.WriteLine("\nVocê está reprovado!");
            }
        }

        public static void CalcularMedia()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n» Digite o nome do aluno:");

            Console.ForegroundColor = ConsoleColor.White;
            string nomeAluno = Console.ReadLine();
            Console.WriteLine();

            const int tamanho = 3;
            int[] notasArray = new int[tamanho];
            int soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"» Digite a {i + 1}ª nota:");
                Console.ForegroundColor = ConsoleColor.White;
                notasArray[i] = int.Parse(Console.ReadLine());
                soma += notasArray[i];
            }

            int resultadoMedia = soma / notasArray.Length;

            Console.ForegroundColor = ConsoleColor.Green;

            string respostaAprovacao;

            if (resultadoMedia >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                respostaAprovacao = "Está Aprovado!";
            }
            else if (resultadoMedia >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                respostaAprovacao = "Está Rescuperação!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                respostaAprovacao = "Está Reprovado!";
            }

            Console.WriteLine($"\n» A média de {nomeAluno} é {resultadoMedia}");
            Console.WriteLine($"» {respostaAprovacao}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nGostaria de refazer novamente? (S/N)");

            if (Console.ReadLine().ToLower() == "s")
            {
                Console.Clear();
                CalcularMedia();
            }
            else
            {
                Console.Clear();
                Util.ExibirCabecalho();
                Util.ExibirOpcoesMenu();
            }
        }
    }
}
