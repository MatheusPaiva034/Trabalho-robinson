class Entrega
{
    public string Endereco { get; set; }

    private double distanciaKm;
    public double DistanciaKm
    {
        get { return distanciaKm; }
        set
        {
            if (value >= 0)
                distanciaKm = value;
        }
    }

    public string TipoEntrega { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Entrega: {Endereco} | Distância: {DistanciaKm} km | Tipo: {TipoEntrega}");
    }

    public double CalcularTaxaEntrega()
    {
        return DistanciaKm * 2; 
    }
}