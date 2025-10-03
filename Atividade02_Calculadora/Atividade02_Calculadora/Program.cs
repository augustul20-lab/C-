using System;
using System.ComponentModel;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("Bem-Vindo à Calculadora Simples");
            Console.WriteLine("**************************************");
            Console.WriteLine($"Data/Hora: {DateTime.Now}");
            Console.WriteLine("**************************************");

            string continuar = "sim";
            int operacaoVal = 0;
            int operacaoErro = 0;

            while (continuar.ToLower() == "sim")
            {
                Console.WriteLine("\nQual operação deseja fazer?");
                Console.WriteLine(" 1 - Adição");
                Console.WriteLine(" 2 - Subtração");
                Console.WriteLine(" 3 - Multiplicação");
                Console.WriteLine(" 4 - Divisão");
                Console.WriteLine(" 5 - Módulo");
                Console.WriteLine(" 6 - Sair");

                Console.Write("Digite a opção: ");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 6)
                {
                    Console.WriteLine("Até...");
                    Environment.Exit(0);
                }

                Console.Write("Digite o primeiro número: ");
                double nume1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double nume2 = double.Parse(Console.ReadLine());

                double resul = 0;
                bool erro = false;

                switch (operacao)
                {
                    case 1:
                        resul = adicao(nume1, nume2);
                        operacaoVal++;
                        break;

                    case 2:
                        resul = subtracao(nume1, nume2);
                        operacaoVal++;
                        break;

                    case 3:
                        resul = multipli(nume1, nume2);
                        operacaoVal++;
                        break;

                    case 4:
                        if (nume2 == 0)
                        {
                            Console.WriteLine("não funciona com divisor zero!");
                            operacaoErro++;
                            erro = true;
                        }
                        else
                        {
                            resul = div(nume1, nume2);
                            operacaoVal++;
                        }
                        break;

                    case 5:
                        if (nume2 == 0)
                        {
                            Console.WriteLine("não funciona com modulo zero!");
                            operacaoErro++;
                            erro = true;
                        }
                        else
                        {
                            resul = modulo(nume1, nume2);
                            operacaoVal++;
                        }
                        break;

                    default:
                        Console.WriteLine("ERRO.");
                        erro = true;
                        operacaoErro++;
                        break;
                }
                if (!erro)
                    Console.WriteLine($"resultado é: {resul}");

                Console.WriteLine("-------------------------------------------");
                Console.Write("Deseja realizar outra operação? (Sim/Não): ");
                continuar = Console.ReadLine().ToLower();
                Console.Clear();
            }


            Console.WriteLine("**************************************");
            Console.WriteLine("Final de tudo:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Operações válidas: {operacaoVal}");
            Console.WriteLine($"Erros encontrados: {operacaoErro}");
            Console.WriteLine("Até a proxima operação matematica");
            Console.WriteLine("**************************************");


        }




        public static double adicao(double num1, double num2)
        {
            double resul = num1 + num2;
            return resul;
        }

        public static double subtracao(double num1, double num2)
        {
            double resul = num1 - num2;
            return resul;
        }

        public static double multipli(double num1, double num2)
        {
            double resul = num1 * num2;
            return resul;
        }

        public static double div(double num1, double num2)
        {
            double resul = num1 / num2;
            return resul;
        }

        public static double modulo(double num1, double num2)
        {
            double resul = num1 / num2;
            return resul;
        }


    }
}