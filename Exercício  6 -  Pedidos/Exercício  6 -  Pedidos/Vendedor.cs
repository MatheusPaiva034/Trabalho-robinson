class Vendedor
{
    private string nome;
    public string Nome
    {
        get { return nome; }
        set
        {
            nome = value;
            Matricula = nome + "10";
        }
    }

    public string Matricula { get; private set; }

    private double percentualComissao;
    public double PercentualComissao
    {
        get { return percentualComissao; }
        set
        {
            if (value >= 0)
                percentualComissao = value;
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Vendedor: {Nome} | Matrícula: {Matricula} | Comissão: {PercentualComissao}%");
    }

    public double CalcularComissao(double valorPedido)
    {
        return valorPedido * (PercentualComissao / 100);
    }
}