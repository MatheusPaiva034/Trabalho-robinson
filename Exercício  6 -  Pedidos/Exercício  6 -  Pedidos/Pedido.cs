class Pedido
{
    private static int contador = 1;

    public int Numero { get; private set; }

    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
    public Produto Produto { get; set; }
    public Pagamento Pagamento { get; set; }
    public Entrega Entrega { get; set; }

    public Pedido()
    {
        Numero = contador++;
    }

    public double CalcularValorFinal()
    {
        double subtotal = Produto.CalcularSubtotal();
        double taxa = Entrega.CalcularTaxaEntrega();
        double acrescimo = Pagamento.CalcularAcrescimo(subtotal);

        return subtotal + taxa + acrescimo;
    }

    public double CalcularComissaoVendedor()
    {
        return Vendedor.CalcularComissao(CalcularValorFinal());
    }

    public void ExibirResumo()
    {
        Console.WriteLine("\n===== RESUMO DO PEDIDO =====");
        Console.WriteLine($"Número: {Numero}");

        Cliente.ExibirDados();
        Vendedor.ExibirDados();
        Produto.ExibirDados();
        Pagamento.ExibirDados();
        Entrega.ExibirDados();

        Console.WriteLine($"Valor Final: {CalcularValorFinal():C}");
        Console.WriteLine($"Comissão Vendedor: {CalcularComissaoVendedor():C}");
    }
}