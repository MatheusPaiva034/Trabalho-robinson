using Atividade_08;

ReservaHotel r1 = new ReservaHotel("Carlos", 12);
ReservaHotel r2 = new ReservaHotel("", -8, 0, -300);

r1.ExibirReserva();
r2.ExibirReserva();

Console.WriteLine(r1.CalcularTotal());
Console.WriteLine(r2.CalcularTotal());

r1.AdicionarDiarias(2);
r1.ExibirReserva();

r2.CancelarReserva();
r2.ExibirReserva();

r2.ReativarReserva();
r2.ExibirReserva();
