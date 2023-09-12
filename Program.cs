using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("BEM VINDO ao Calculator!!");

            Console.WriteLine("");
            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Selecione uma opção: ");


            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Divisao();
                    break;

                case 4:
                    Multiplicacao();
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;

            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float var2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = var1 + var2;

            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float var2 = float.Parse(Console.ReadLine());

            float resultado = var1 - var2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float var2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = var1 / var2;

            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float var2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = var1 * var2;

            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}


