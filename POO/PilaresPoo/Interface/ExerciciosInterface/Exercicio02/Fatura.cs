namespace Exercicio02
{
    public class Fatura : IImprimivel
{
    public string Cliente;
    public string Empresa;
    public float Valor;
    public int DiasAtraso;

    public Fatura(string cliente, string empresa, float valor, int dias)
    {
        Cliente = cliente;
        Empresa = empresa;
        Valor = valor;
        DiasAtraso = dias;
    }

    public void Imprimir()
    {
        Console.WriteLine($"[Fatura] Cliente: {Cliente} | Empresa: {Empresa} | Valor: R${Valor} | Atraso: {DiasAtraso} dias");
    }
}
}