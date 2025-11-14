public class Funcionario
{
    public string Nome;
    public double SalarioBase;

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}

public class Gerente : Funcionario
{
    public double Bonus;

    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}