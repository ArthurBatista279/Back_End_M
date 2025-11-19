namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante;
        public string Servico;

        public Contrato(string contratante, string servico)
        {
            Contratante = contratante;
            Servico = servico;
        }

        public void Imprimir()
        {
            Console.WriteLine($"[Contrato] Contratante: {Contratante} | Serviço: {Servico}");
        }
    }


}