using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_07
{
    internal class Filme
    {
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public int Duracao { get; private set; }
        public int Classificacao { get; private set; }

        
        public Filme(string nome, string genero, int duracao, int classificacao)
        {
            
            if (string.IsNullOrWhiteSpace(nome))
                Nome = "Inválido";
            else
                Nome = nome;

            if (string.IsNullOrWhiteSpace(genero))
                Genero = "Inválido";
            else
                Genero = genero;

            if (duracao <= 0)
                Duracao = 0;
            else
                Duracao = duracao;

            if (classificacao < 0)
                Classificacao = 0;
            else
                Classificacao = classificacao;
        }
        public void ExibirResumo()
        {
            Console.WriteLine("----- FILME -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Duração: {Duracao} min");
            Console.WriteLine($"Classificação: {Classificacao}+");
            Console.WriteLine();
        }
        public bool EhPermitido(int idade)
        {
            return idade >= Classificacao;
        }
        public void AlterarDuracao(int novaDuracao)
        {
            if (novaDuracao > 0)
            {
                Duracao = novaDuracao;
            }
            else
            {
                Console.WriteLine("Duração inválida!");
            }
        }
    }
}
