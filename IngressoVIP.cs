namespace DojoIngresso
{
    public class IngressoVIP : Ingresso
    {
        public float Adicional = 50f;
        public string ImprimirValorVIP () {
            float PrecoVIP = Valor + Adicional;
            return $"Preço do ingresso VIP: R$ {PrecoVIP}.";
        }
    }
}