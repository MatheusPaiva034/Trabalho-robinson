using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_08
{
    internal class ReservaHotel
    {
        public string NomeHospede { get; private set; }
        public int NumeroQuarto { get; private set; }
        public int QuantidadeDiarias { get; private set; }
        public double ValorDiaria { get; private set; }
        public string Status { get; private set; }

     
        public ReservaHotel(string nomeHospede, int numeroQuarto)
        {
            NomeHospede = string.IsNullOrWhiteSpace(nomeHospede) ? "Hóspede não informado" : nomeHospede;
            NumeroQuarto = numeroQuarto <= 0 ? 1 : numeroQuarto;

            QuantidadeDiarias = 1;
            ValorDiaria = 50;
            Status = "Ativa";
        }

        public ReservaHotel(string nomeHospede, int numeroQuarto, int quantidadeDiarias, double valorDiaria)
        {
            NomeHospede = string.IsNullOrWhiteSpace(nomeHospede) ? "Hóspede não informado" : nomeHospede;
            NumeroQuarto = numeroQuarto <= 0 ? 1 : numeroQuarto;
            QuantidadeDiarias = quantidadeDiarias <= 0 ? 1 : quantidadeDiarias;
            ValorDiaria = valorDiaria <= 0 ? 50 : valorDiaria;

            Status = "Ativa";
        }


        public double CalcularTotal()
        {
            return QuantidadeDiarias * ValorDiaria;
        }

   
        public void ExibirReserva()
        {
            Console.WriteLine("----- RESERVA -----");
            Console.WriteLine($"Hóspede: {NomeHospede}");
            Console.WriteLine($"Quarto: {NumeroQuarto}");
            Console.WriteLine($"Diárias: {QuantidadeDiarias}");
            Console.WriteLine($"Valor diária: R$ {ValorDiaria}");
            Console.WriteLine($"Total: R$ {CalcularTotal()}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine();
        }

     
        public void AdicionarDiarias(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeDiarias += quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade inválida!");
            }
        }

        public void CancelarReserva()
        {
            Status = "Cancelada";
        }
        public void ReativarReserva()
        {
            Status = "Ativa";
        }
    }
}
