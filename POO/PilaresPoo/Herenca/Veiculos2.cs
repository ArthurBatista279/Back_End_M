using Herenca;

public class Veiculo
{
    public string Marca;
    public string Modelo;

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

public class Carro : Veiculo
{
    public int QtdPortas;

    public override void MostrarInfo()
    {
        Console.WriteLine($"Carro - Marca: {Marca}, Modelo: {Modelo}, Portas: {QtdPortas}");
    }
}

public class Moto : Veiculo
{
    public string TipoCapacete;

    public override void MostrarInfo()
    {
        Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Capacete: {TipoCapacete}");
    }
}