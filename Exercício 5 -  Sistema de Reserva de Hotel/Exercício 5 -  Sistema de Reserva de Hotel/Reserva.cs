using System;

class Reserva
{
    public string NumeroReserva;
    public int QuantidadeDiarias;
    public double ValorDiaria;
    public double ValorTotal;

    public void ReceberDadosReserva()
    {
        Console.Write("Digite o número da reserva: ");
        NumeroReserva = Console.ReadLine();

        Console.Write("Digite a quantidade de diárias: ");
        QuantidadeDiarias = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor da diária: ");
        ValorDiaria = double.Parse(Console.ReadLine());
    }

    public void CalcularTotal()
    {
        ValorTotal = QuantidadeDiarias * ValorDiaria;
    }

    public void AplicarDesconto(double percentual)
    {
        double desconto = ValorTotal * (percentual / 100);
        ValorTotal -= desconto;

        Console.WriteLine("Desconto aplicado!");
    }

    public void MostrarReserva()
    {
        Console.WriteLine("\n=== DADOS DA RESERVA ===");
        Console.WriteLine("Número: " + NumeroReserva);
        Console.WriteLine("Diárias: " + QuantidadeDiarias);
        Console.WriteLine("Valor da diária: R$ " + ValorDiaria.ToString("F2"));
        Console.WriteLine("Valor total: R$ " + ValorTotal.ToString("F2"));
    }
}