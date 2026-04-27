using System;

class Hospede
{
    public string Nome;
    public string Cpf;
    public string Telefone;

    public void ReceberDados()
    {
        Console.Write("Digite o nome: ");
        Nome = Console.ReadLine();

        Console.Write("Digite o CPF: ");
        Cpf = Console.ReadLine();

        Console.Write("Digite o telefone: ");
        Telefone = Console.ReadLine();
    }

    public void MostrarDados()
    {
        Console.WriteLine("\n=== DADOS DO HÓSPEDE ===");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("CPF: " + Cpf);
        Console.WriteLine("Telefone: " + Telefone);
    }

    public void AtualizarTelefone(string novoTelefone)
    {
        Telefone = novoTelefone;
        Console.WriteLine("Telefone atualizado com sucesso!");
    }
}