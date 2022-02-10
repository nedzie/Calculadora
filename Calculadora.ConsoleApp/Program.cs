/* Requisito 1 ok
 * requisito 2 ok
 * requisito 3 ok
 * requisito 4 ok
 * requisito 5 ok
 * requisito 6 ok
 * requi 7 ok
 */

using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis

            string option, opSelecionado = "";
            string[] historico = new string[100];
            int contador = 0;

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
                if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "s")
                {
                    Console.Clear();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n-~= Opção indisponível, digite uma válida! =~-\n");
                    Console.ResetColor();
                    continue; // Continue1
                }

                if (option == "5")
                {
                    if (contador == 0)
                    {
                        Console.WriteLine("Ainda não foram feitas operações");
                    }
                    else
                    {
                        foreach (var x in historico)
                        {
                            if (x == null)
                            {
                                continue;
                            }
                            else
                            if (x.Contains("+"))
                                Console.ForegroundColor = ConsoleColor.Green;
                            else if (x.Contains("-"))
                                Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(x);
                            Console.ResetColor();
                        }
                    }

                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }


                // Para sair do programa
                if (option == "s")
                {
                    break;
                }

                Console.Write("Digite o 1º número: ");
                string strPrimeiroNumero = Console.ReadLine(); // Faz a leitura

            voltaUm:
                Console.Write("Digite o 2º número: ");
                string strSegundoNumero = Console.ReadLine(); // Faz a leitura

                double primeiroNumero = double.Parse(strPrimeiroNumero);   // Fazem as
                double segundoNumero = double.Parse(strSegundoNumero);  // conversões necessárias
                double res = 0;

                if (option == "1")
                {
                    opSelecionado = "+";
                    res = primeiroNumero + segundoNumero; // Soma os dois valores
                }
                else if (option == "2")
                {
                    opSelecionado = "-";
                    res = primeiroNumero - segundoNumero; // Subtrai os dois valores
                }
                else if (option == "3")
                {
                    opSelecionado = "*";
                    res = primeiroNumero * segundoNumero; // Multiplica os dois valores
                }
                else if (option == "4")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Erro!");
                        goto voltaUm;
                    }
                    opSelecionado = "/";
                    res = primeiroNumero / segundoNumero; // Divide os dois valores
                }

                historico[contador] = primeiroNumero + " " + opSelecionado + " " + segundoNumero + " = " + res;
                contador++;

                Console.Write($"O resultado é: {res:F2}\n");
                Console.WriteLine("Pressione 'Enter' para continuar... ");
                Console.ReadKey();

            }
        } // Fecha main
    } // Fecha internal
} // Fecha geral