class Produto
{
    public string Descricao { get; set; }

    private double precoUnitario;
    public double PrecoUnitario
    {
        get { return precoUnitario; }
        set
        {
            if (value >= 0)
                precoUnitario = value;
        }
    }

    private int quantidade;
    public int Quantidade
    {
        get { return quantidade; }
        set
        {
            if (value > 0)
                quantidade = value;
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Descricao} | Preço: {PrecoUnitario} | Quantidade: {Quantidade}");
    }

    public double CalcularSubtotal()
    {
        return PrecoUnitario * Quantidade;
    }
}