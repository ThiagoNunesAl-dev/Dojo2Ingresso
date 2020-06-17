namespace DojoIngresso
{
    public class Ingresso 
    {
        public float Valor { get; set; }
        
        public string ImprimirValor () {
            return "Preço do ingresso comum: R$ "+Valor+".";
        }
    }
}