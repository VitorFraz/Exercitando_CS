using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cabeçalho();
            ListaDeExercicio();
        }





        public static void Cabeçalho()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"╔══════════════════════════════════════════════════════════════════════════════════════╗
║ ███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░║
║ ██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗║
║ █████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║║
║ ██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║║
║ ███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝║
║ ╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;

        }




        public static void ListaDeExercicio()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n╔═════════════════╗");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("║ - Exercicio 1   ║");
            Console.WriteLine("║ - Exercicio 2   ║");
            Console.WriteLine("║ - Exercicio 3   ║");
            Console.WriteLine("║ - Exercicio 4   ║");
            Console.WriteLine("║ - Exercicio 5   ║");
            Console.WriteLine("║ - Exercicio 6   ║");
            Console.WriteLine("║ - Sair (0)      ║");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╚═════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Gray;


            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    CadInfo();
                    break;


                case 2:
                    CadInfo2();
                    break;


                case 3:
                    CadInfo3();
                    break;


                case 4:
                    CadInfo4();
                    break;


                case 5:
                    CadInfo5();
                    break;


                case 6:
                    CadInfo6();
                    break;


                case 0:
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }

        }
        private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("\n1º Exercicio: Crie um programa que leia três números e determine qual é o maior. ");

            double num1, num2, num3;

            Console.WriteLine("\nDigite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            num3 = Convert.ToDouble(Console.ReadLine());

            double maior = num1;

            if (num2 > maior)
            {
                maior = num2;
            }

            if (num3 > maior)
            {
                maior = num3;
            }

            Console.WriteLine("\nO maior número é: " + maior);

            Thread.Sleep(2000);
            Console.Clear();
            Cabeçalho();
            ListaDeExercicio();
        }


        private static void CadInfo2()
        {
            Console.Clear();
            Console.WriteLine("\n 2º Exercicio: Agora, faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5)");

            double nota;

            Console.WriteLine("\nDigite a nota do aluno:");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("\nAluno aprovado!");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("\nAluno em recuperação!");
            }
            else
            {
                Console.WriteLine("\nAluno reprovado!");
            }
                Thread.Sleep(2000);
                Console.Clear();
                Cabeçalho();
                ListaDeExercicio();
        }


        private static void CadInfo3()
        {
            Console.Clear();
            Console.WriteLine("\n3º Exercicio: Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.");

            int idade;

            Console.WriteLine("\nDigite a idade da pessoa:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("\nA pessoa é maior de idade.");
            }
            else
            {
                Console.WriteLine("\nA pessoa é menor de idade.");
            }
                Thread.Sleep(2000);
                Console.Clear();
                Cabeçalho();
                ListaDeExercicio();
        }


        private static void CadInfo4()
        {
            Console.Clear();
            Console.WriteLine("\n4º Exercicio: Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.");

            double numero;

            Console.WriteLine("\nDigite um número:");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("\nO número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("\nO número é negativo.");
            }
            else
            {
                Console.WriteLine("\nO número é zero.");
            }

                Thread.Sleep(2000);
                Console.Clear();
                Cabeçalho();
                ListaDeExercicio();
        }


        private static void CadInfo5()
        {
            Console.Clear();
            Console.WriteLine("\n5º Exercicio: Escreva um programa que leia o número de um mês e exiba o nome do mês correspondente.");

            int mes;

            Console.WriteLine("\nDigite o número do mês (1 a 12):");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("\nNúmero de mês inválido! Por favor, digite um número entre 1 e 12.");
                    break;
            }

            Thread.Sleep(2000);
            Console.Clear();
            Cabeçalho();
            ListaDeExercicio();
        }


        private static void CadInfo6()
        {
            Console.Clear();
            Console.WriteLine("\n6º Exercicio: 3. Escreva um programa que verifique se um número fornecido pelo usuário é um múltiplo de outro número fornecido pelo usuário.");

            int numero, divisor;

            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Divisor não pode ser zero.");
            }
            else
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine($"{numero} é um múltiplo de {divisor}.");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um múltiplo de {divisor}.");
                }
            }       
                    Thread.Sleep(2000);
                    Console.Clear();
                    Cabeçalho();
                    ListaDeExercicio();
        }
    }
}
