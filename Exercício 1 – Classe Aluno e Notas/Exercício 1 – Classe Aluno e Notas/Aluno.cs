using System;

class Aluno
{
    // Atributos
    public string RA;
    public string Nome;
    public double NotaProva;
    public double NotaTrabalho;
    public double NotaFinal;

    // Método para receber dados
    public void ReceberDados()
    {
        Console.Write("Digite o RA: ");
        RA = Console.ReadLine();

        Console.Write("Digite o Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Digite a Nota da Prova: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.Write("Digite a Nota do Trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }

    // Calcula média
    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    // Calcula situação do aluno
    public bool CalcularNotaFinal()
    {
        double mediaMinima = 6.0;

        if (NotaFinal >= mediaMinima)
        {
            Console.WriteLine("Aluno aprovado direto!");
            return true;
        }
        else
        {
            double notaNecessaria = mediaMinima - NotaFinal;
            Console.WriteLine("Aluno precisa de prova final.");
            Console.WriteLine("Precisa tirar pelo menos: " + notaNecessaria.ToString("F2"));
            return false;
        }
    }

    // Mostra a média
    public void ImprimirNotaFinal()
    {
        Console.WriteLine("Nota final (média): " + NotaFinal.ToString("F2"));
    }
}