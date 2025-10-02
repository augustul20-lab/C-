using System;


namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Data/Hora: {DateTime.Now}");
                Console.WriteLine("*******************************");
                Console.WriteLine("Bem-vindo à calculadora simples!");
                Console.WriteLine("ESCOLHA A OPERAÇÃO:");
                Console.WriteLine("*******************************");
                Console.WriteLine(" (1) Adição");
                Console.WriteLine(" (2) Subtração");
                Console.WriteLine(" (3) Multiplicação");
                Console.WriteLine(" (4) Divisão");
                Console.WriteLine(" (5) Módulo");
                Console.WriteLine(" (6) Sair");
                Console.WriteLine("*******************************");

                double operacao = double.Parse(Console.ReadLine());

                if (operacao == 6)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }

                Console.WriteLine("Digite o 1º número:");
                double nume1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2º número:");
                double nume2 = double.Parse(Console.ReadLine());

                double resul = 0;

                switch (operacao)
                {
                    case 1:
                        resul = adicao(nume1, nume2);
                        break;
                    case 2:
                        resul = subtracao(nume1, nume2);
                        break;
                    case 3:
                        resul = multiplicacao(nume1, nume2);
                        break;
                    case 4:
                        if (nume2 == 0)
                        {
                            Console.WriteLine("ERRO: Divisão por zero não é permitida.");
                            
                            continue;
                        }
                        resul = divisao(nume1, nume2);
                        break;
                    case 5:
                        if (nume2 == 0)
                        {
                            Console.WriteLine("ERRO: Módulo por zero não é permitido.");
                            Console.WriteLine("-------------------------------");

                            continue;
                        }
                        resul = modulo(nume1, nume2);
                        break;
                    default:
                        Console.WriteLine("ERRO: Operação inválida.");
                        continue;
                }
                Console.Clear();
                Console.WriteLine($"RESULTADO: {resul}");


                Console.WriteLine("Deseja realizar outra operação? (S/N)");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    return;
                }

                Console.Clear();
            }
        }

        public static double adicao(double num1, double num2) => num1 + num2;
        public static double subtracao(double num1, double num2) => num1 - num2;
        public static double multiplicacao(double num1, double num2) => num1 * num2;
        public static double divisao(double num1, double num2) => num1 / num2;
        public static double modulo(double num1, double num2) => num1 % num2;
    }
}

