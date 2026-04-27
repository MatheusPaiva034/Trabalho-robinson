class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Cidade { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome} | CPF: {Cpf} | Cidade: {Cidade}");
    }

    public string RetornarApresentacao()
    {
        return $"Cliente {Nome}, CPF {Cpf}, residente em {Cidade}";
    }
}