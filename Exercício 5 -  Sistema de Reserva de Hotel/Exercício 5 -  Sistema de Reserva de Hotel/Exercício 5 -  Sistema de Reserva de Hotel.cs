using System;

class Program
{
    static void Main(string[] args)
    {
        Hospede hospede = new Hospede();
        Reserva reserva = new Reserva();

    
        hospede.ReceberDados();
        reserva.ReceberDadosReserva();
        reserva.CalcularTotal();

        int opcao;
        string novoTelefone;
        double percentual;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Mostrar dados do hóspede");
            Console.WriteLine("2 - Atualizar telefone");
            Console.WriteLine("3 - Mostrar reserva");
            Console.WriteLine("4 - Aplicar desconto");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    hospede.MostrarDados();
                    break;

                case 2:
                    Console.Write("Digite o novo telefone: ");
                    novoTelefone = Console.ReadLine();
                    hospede.AtualizarTelefone(novoTelefone);
                    break;

                case 3:
                    reserva.MostrarReserva();
                    break;

                case 4:
                    Console.Write("Digite o percentual de desconto: ");
                    percentual = double.Parse(Console.ReadLine());
                    reserva.AplicarDesconto(percentual);
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);

        Console.ReadKey();
    }
}