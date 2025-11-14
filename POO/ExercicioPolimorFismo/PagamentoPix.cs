namespace ExercicioPolimorFismo
{
    public class PagamentoPix : Pagamento
    {
        // desconto de 5%
        private float desconto = 5;
        public float ValorCompra;
        //Devolve o valor com o desconto calculado
        public override float CalcularTotal()
        {
            float valorDesconto = ValorCompra / 100 * 5;
            return ValorCompra = ValorCompra - valorDesconto;
        }
    }
}