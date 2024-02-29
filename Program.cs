/* 
Programa calculador de diárias de veículos
Versão 1.0 de 29/02/2024
Autor: Victor Freire de Carvalho
Programa criado para a disciplina de Programação Orientada a Objetos do Curso de
Análise e Desenvolvimento de Sistemas da Faculdade Senac
*/

using System;

namespace PtiPoo{
    //Classe básica de veiculo
    abstract class Veiculo
    {
        protected double TaxaDiaria { get; set; }
        public abstract double CalcularValorTotal(int numDiarias);
    }
    
    //Aqui começam as classes subsequentes utilizadas no programa, carro e moto
    class Carro : Veiculo 
    {
        public Carro(int taxa) => TaxaDiaria = taxa;

        public override double CalcularValorTotal(int numDiarias)
        {
            return numDiarias * TaxaDiaria;
        }
    }

    class Moto : Veiculo 
    {
        public Moto(int taxa) => TaxaDiaria = taxa;
        public override double CalcularValorTotal(int numDiarias)
        {
            return numDiarias * TaxaDiaria;
        }
    }

    //Aqui começa o programa propriamente dito, com um método Main tradicional
    class Program {
        static void Main(string[] args)
        {
            Carro carro1 = new(50);
            Moto moto1 = new(25);

            Console.WriteLine(carro1.CalcularValorTotal(10));
            Console.WriteLine(moto1.CalcularValorTotal(10));
        }
    }
}

