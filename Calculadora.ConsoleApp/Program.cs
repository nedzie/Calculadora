﻿using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;

            Console.WriteLine("Digite os números abaixo, Dona Mariana :)\n");
            do { 
            
            Console.WriteLine("|.... Digite '1' para somar ........|");
            Console.WriteLine("|.... Digite '2' para subtrair .....|");
            Console.WriteLine("|.... Digite '3' para multiplicar ..|");
            Console.WriteLine("|.... Digite '4' para dividir ......|");
            Console.WriteLine("|.... Digite 's' para sair .........|\n");

            option = Console.ReadLine();
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
            
            if(option == "1")
                {
                    res = primeiroNumero + segundoNumero; // Soma os dois valores
                } 
                else if (option == "2")
                    {
                        res = primeiroNumero - segundoNumero; // Subtrai os dois valores
                    } else if (option == "3")
                        {
                            res = primeiroNumero * segundoNumero; // Multiplica os dois valores
                        } else if (option == "4")
                            {
                                if(segundoNumero == 0)
                                    {
                                        Console.WriteLine("Erro!");
                                        break;
                                    }
                                            res = primeiroNumero / segundoNumero; // Divide os dois valores
                                    }

            Console.Write("O resultado é: " + res + "\n");
            Console.WriteLine("Pressione 'Enter' para continuar... ");
            Console.ReadLine();
           
            } while (option == "1" || option == "2" || option == "3" || option == "4");

        } // Fecha main
    } // Fecha internal
} // Fecha geral