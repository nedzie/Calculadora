/* Requisito 1 ok
 * requisito 2 ok
 * requisito 3 ok
 * requisito 4 ok
 * requisito 5 ok
 * requisito 6 em andamento
 * 
 */

using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string option;
            int regOps;

            // Entradas

            Console.WriteLine("Digite os números abaixo, Dona Mariana :)\n");
            while (true) // Continue1 volta pra cá
            {

                Console.WriteLine("|.... Digite '1' para somar ........|");
                Console.WriteLine("|.... Digite '2' para subtrair .....|");
                Console.WriteLine("|.... Digite '3' para multiplicar ..|");
                Console.WriteLine("|.... Digite '4' para dividir ......|");
                Console.WriteLine("|.... Digite '5' para ver histórico.|"); // Depois
                Console.WriteLine("|.... Digite 's' para sair .........|\n");

                option = Console.ReadLine(); // Recebe a opção escolhida


                // Verificará se foi selecionado algo inválido
                if(option != "1"  && option != "2" && option != "3" && option != "4" && option != "5" && option != "s")
                {
                    Console.Clear();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n-~= Opção indisponível, digite uma válida! =~-\n");
                    Console.ResetColor();
                    continue; // Continue1
                }

                if(option == "5")
                {

                }

                // Para sair do programa
                if (option == "s")
                {
                    break;
                }

                Console.Write("Digite o 1º número: ");
                string strPrimeiroNumero = Console.ReadLine(); // Faz a leitura

                Console.Write("Digite o 2º número: ");
                string strSegundoNumero = Console.ReadLine(); // Faz a leitura

                int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);   // Fazem as
                int segundoNumero = Convert.ToInt32(strSegundoNumero);     // conversões necessárias
                int res = 0;

                if (option == "1")
                {
                    res = primeiroNumero + segundoNumero; // Soma os dois valores
                }
                else if (option == "2")
                {
                    res = primeiroNumero - segundoNumero; // Subtrai os dois valores
                }
                else if (option == "3")
                {
                    res = primeiroNumero * segundoNumero; // Multiplica os dois valores
                }
                else if (option == "4")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Erro!");
                        break;
                    }
                    res = primeiroNumero / segundoNumero; // Divide os dois valores
                }

                Console.Write("O resultado é: " + res + "\n");
                Console.WriteLine("Pressione 'Enter' para continuar... ");
                Console.ReadLine();

            }

        } // Fecha main
    } // Fecha internal
} // Fecha geral