using System;

namespace Estudo.FluentInterface.App
{
    class Program
    {
        static void Main()
        {
            // Escrita de código fluente.
            var vendedora = new Vendedora()
                .Oferecer(Produto.Fogao)
                .ComDescontoDe(15)
                .ValendoAte(new DateTime(2010, 7, 1));

            vendedora.Escrever();
            vendedora.Falar();

            Console.ReadKey();
        }
    }
}
