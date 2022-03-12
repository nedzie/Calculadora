using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Calculadora
    {
        public Calculo[] calculos = new Calculo[100];
        public int EncontrarPosicaoDisponivel()
        {
            for (int posicao = 0; posicao < calculos.Length; posicao++)
            {
                if(calculos[posicao] == null)
                return posicao;
            }
            return -1;
        }
        public void Somar()
        {
            RealizarCalculo();
        }
        public void Subtrair()
        {
            RealizarCalculo();

        }
        public void Multiplicar()
        {
            RealizarCalculo();
        }
        public void Dividir()
        {
            RealizarCalculo();
        }
        private void RealizarCalculo()
        {
            int posicao = EncontrarPosicaoDisponivel();
            Calculo calculo = new();
            MostrarOperacao("multiplicar");
            Console.Write("1º número: \n> ");
            calculo.numeroUm = decimal.Parse(Console.ReadLine());
            Console.Write("2º número: \n> ");
            calculo.numeroDois = decimal.Parse(Console.ReadLine());
            calculo.operador = '*';
            calculo.resultado = calculo.numeroUm * calculo.numeroDois;
            calculos[posicao] = calculo;
            ExibirResultado(calculo);
        }
        public void ExibirHistorico()
        {
            Console.Clear();
            for (int i = 0; i < calculos.Length; i++)
            {
                if(calculos[i] != null)
                Console.WriteLine((i+1) + "º.: " + calculos[i].numeroUm + " " + calculos[i].operador + " " + calculos[i].numeroDois + " = " + calculos[i].resultado);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void ExibirResultado(Calculo calculo)
        {
            Console.Clear();
            Console.WriteLine(calculo.numeroUm + " " + calculo.operador + " " + calculo.numeroDois + " = " + calculo.resultado);
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
