class Pagamento
{
    public string FormaPagamento { get; set; }

    private int parcelas;
    public int Parcelas
    {
        get { return parcelas; }
        set
        {
            if (value >= 1)
                parcelas = value;
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Pagamento: {FormaPagamento} | Parcelas: {Parcelas}");
    }

    public bool ValidarPagamento()
    {
        return Parcelas >= 1;
    }

    public double CalcularAcrescimo(double valorBase)
    {
        if (Parcelas > 1)
            return valorBase * 0.05;
        return 0;
    }
}