namespace ExercicioPolimorFismo
{
    public class PagamentoCartao : Pagamento
    {
        private float acrescimo = 5.38f;
        public float ValorCompra;
        //Devolve o valor com o acréscimo calculado
        public override float CalcularTotal()
        {
            float valorAcrescimento = ValorCompra / 100 * acrescimo;//qtd paga mais
            return ValorCompra = ValorCompra + valorAcrescimento;
        }
    }
}