using System;

namespace Estudo.FluentInterface
{
    public interface IFluentConversa
    {
        IFluentConversa Oferecer(Produto produto);
        IFluentConversa ComDescontoDe(decimal desconto);
        IFluentConversa ValendoAte(DateTime data);

        void Falar();
        void Escrever();
    }
}
