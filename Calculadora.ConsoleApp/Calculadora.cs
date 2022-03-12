using System;

namespace Calculadora.ConsoleApp
{
    internal class Calculadora
    {
        public Calculo[] calculos = new Calculo[100];
        public int EncontrarPosicaoDisponivel()
        {
            for (int posicao = 0; posicao < calculos.Length; posicao++)
            {
                if (calculos[posicao] == null)
                    return posicao;
            }
            return -1;
        }
        public void Somar()
        {
            RealizarCalculo("somar", '+');
        }
        public void Subtrair()
        {
            RealizarCalculo("somar", '-');

        }
        public void Multiplicar()
        {
            RealizarCalculo("multiplicar", '*');
        }
        public void Dividir()
        {
            RealizarCalculo("dividir", '/');
        }
        private void RealizarCalculo(string operacao, char operador)
        {
            int posicao = EncontrarPosicaoDisponivel();
            Calculo calculo = new();
            MostrarOperacao(operacao);
            Console.Write("1º número: ");
            calculo.numeroUm = decimal.Parse(Console.ReadLine());
            resolveDivisaoPorZero:
            Console.Write("2º número: ");
            calculo.numeroDois = decimal.Parse(Console.ReadLine());
            if (operador == '/' && calculo.numeroDois == 0)
            {
                Console.WriteLine("Impossível dividir po 0, insira outro número: ");
                goto resolveDivisaoPorZero;
            }
            calculo.operador = operador;
            switch (operador)
            {
                case '+':
                    calculo.resultado = calculo.numeroUm + calculo.numeroDois;
                    break;
                case '-':
                    calculo.resultado = calculo.numeroUm - calculo.numeroDois;
                    break;
                case '/':
                    calculo.resultado = calculo.numeroUm / calculo.numeroDois;
                    break;
                case '*':
                    calculo.resultado = calculo.numeroUm * calculo.numeroDois;
                    break;
            }

            calculos[posicao] = calculo;
            ExibirResultado(calculo);
        }
        public void ExibirHistorico()
        {
            Console.Clear();
            for (int i = 0; i < calculos.Length; i++)
            {
                if (calculos[i] != null)
                    Console.WriteLine((i + 1) + " : " + calculos[i].numeroUm + " " + calculos[i].operador + " " + calculos[i].numeroDois + " = " + calculos[i].resultado);
            }
            Console.WriteLine("\nPressione 'enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExibirResultado(Calculo calculo)
        {
            Console.Clear();
            Console.WriteLine(calculo.numeroUm + " " + calculo.operador + " " + calculo.numeroDois + " = " + calculo.resultado);
            Console.WriteLine("\nPressione 'enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        public void MostrarOperacao(string operacao)
        {
            Console.Clear();
            Console.WriteLine("Vamos " + operacao + ": ");
            Console.WriteLine();
        }
    }
}
