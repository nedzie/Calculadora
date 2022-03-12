using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new();
            char escolha = '0';
            while (escolha != 's')
            {
                escolha = VisualizaMenu(calculadora);
            }
        }
        public static char VisualizaMenu(Calculadora calculadora)
        {
            char escolha;
            Console.WriteLine("|.... Digite '1' para somar ........|");
            Console.WriteLine("|.... Digite '2' para subtrair .....|");
            Console.WriteLine("|.... Digite '3' para multiplicar ..|");
            Console.WriteLine("|.... Digite '4' para dividir ......|");
            Console.WriteLine("|.... Digite '5' para ver histórico.|");
            Console.WriteLine("|.... Digite 's' para sair .........|\n");
            escolha = VerificaMenu(calculadora);
            return escolha;
        }
        public static char VerificaMenu(Calculadora calculadora)
        {
            char escolha;
            string auxiliar = Console.ReadLine();
            if (auxiliar.Length > 1)
                escolha = default;
            else
                escolha = char.Parse(auxiliar);
            char temp = char.ToLower(escolha);
            escolha = temp;
            switch (escolha)
            {
                case '1':
                    calculadora.Somar();
                    break;
                case '2':
                    calculadora.Subtrair();
                    break;
                case '3':
                    calculadora.Multiplicar();
                    break;
                case '4':
                    calculadora.Dividir();
                    break;
                case '5':
                    calculadora.ExibirHistorico();
                    break;
                case 's':
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Tente novamente.\nTecle 'enter' para retomar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            return escolha;
        }
    }
}