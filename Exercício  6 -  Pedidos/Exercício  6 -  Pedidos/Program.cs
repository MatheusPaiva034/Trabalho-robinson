class Program
{
    static void Main()
    {
        Cliente c = new Cliente { Nome = "Matheus Paiva Batista", Cpf = "08838958879", Cidade = "Araxá" };

        Vendedor v = new Vendedor { Nome = "Gustavo", PercentualComissao = 15 };

        Produto p = new Produto { Descricao = "Notebook", PrecoUnitario = 3999, Quantidade = 1 };

        Pagamento pg = new Pagamento { FormaPagamento = "Cartão", Parcelas = 7 };

        Entrega e = new Entrega { Endereco = "Rua Reginalda Ferreira Pinto", DistanciaKm = 5, TipoEntrega = "Normal" };

        Pedido pedido = new Pedido
        {
            Cliente = c,
            Vendedor = v,
            Produto = p,
            Pagamento = pg,
            Entrega = e
        };

        pedido.ExibirResumo();
    }
}