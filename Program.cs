using System;

namespace DojoIngresso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compra de ingresso\n");
            IngressoVIP ingresso = new IngressoVIP();
            inicioloop:
            Console.WriteLine("Escolha o filme que quer assistir: ");
            Console.WriteLine("1. Vingadores (noite);\n2. Vingadores (manhã);\n3. Interestelar (noite)\n4. Interestelar (manhã)\n");
            int escolha = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (escolha == 1 | escolha == 3) {
                ingresso.Valor = 20f;
                Console.WriteLine(ingresso.ImprimirValor());
                Console.WriteLine(ingresso.ImprimirValorVIP());
            }
            else if (escolha == 2 | escolha == 4) {
                ingresso.Valor = 15f;
                Console.WriteLine(ingresso.ImprimirValor());
                Console.WriteLine(ingresso.ImprimirValorVIP());
            }
            else {
                Console.WriteLine("Escolha um filme em cartaz!\n");
                goto inicioloop;
            }

            Console.WriteLine("Difereça de preços (taxa adicional): R$ "+ingresso.Adicional);
        }
    }
}
