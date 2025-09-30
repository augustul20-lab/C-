
using System.ComponentModel;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ESCOLHA A OPERAÇÃO:");
            Console.WriteLine(" (1) Adição:");
            Console.WriteLine(" (2) Substração:");
            Console.WriteLine(" (3) Multiplicação:");
            Console.WriteLine(" (4) Divisão:");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 1º:");
            int nume1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2°:");
            int nume2 = int.Parse(Console.ReadLine());

            int resul = 0;

            switch (operacao)
            {

                case 1:
                    {
                        resul = adicao(nume1, nume2); break;
                    }


                case 2:
                    {
                        resul = subtracao(nume1, nume2); break;
                    }


                case 3:
                    {
                        resul = multipli(nume1, nume2); break;
                    }


                case 4:
                    {
                        resul = div(nume1, nume2); break;
                    }

                default:
                    Console.WriteLine("ERRO");
                    break;
            }

            Console.WriteLine("RESULTADO: {0}", resul);

            Console.ReadLine();


        }
        public static int adicao(int num1, int num2)
        {
            int resul = num1 + num2;
            return resul;
        }

        public static int subtracao(int num1, int num2)
        {
            int resul = num1 - num2;
            return resul;
        }

        public static int multipli(int num1, int num2)
        {
            int resul = num1 * num2;
            return resul;
        }

        public static int div(int num1, int num2)
        {
            int resul = num1 / num2;
            return resul;
        }




    }
}