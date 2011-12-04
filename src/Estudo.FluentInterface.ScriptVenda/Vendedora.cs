using System;
using System.Text;
using System.Speech.Synthesis;

namespace Estudo.FluentInterface
{
    public class Vendedora : IFluentConversa
    {
        Produto produto;
        decimal desconto;
        DateTime data;

        public IFluentConversa Oferecer(Produto produto)
        {
            this.produto = produto;
            return this;
        }

        public IFluentConversa ComDescontoDe(decimal desconto)
        {
            this.desconto = desconto;
            return this;
        }

        public IFluentConversa ValendoAte(DateTime data)
        {
            this.data = data;
            return this;
        }

        public void Falar()
        {
            var speech = new SpeechSynthesizer();
            speech.SelectVoice("Microsoft Anna");
            speech.Speak(MontarTexto());
        }

        public void Escrever()
        {
            Console.Write(MontarTexto());
        }

        private string MontarTexto()
        {
            var texto = new StringBuilder();
            texto.Append("Você gostaria de comprar ");

            switch (produto)
            {
                case Produto.Batedeira: texto.Append("uma batedeira "); break;
                case Produto.Cafeteira: texto.Append("uma cafeteira "); break;
                case Produto.Fogao: texto.Append("um fogão "); break;
                case Produto.Liquidificador: texto.Append("um liquidificador "); break;
            }

            texto.Append("com incríveis " + desconto.ToString() + "% de desconto? ");
            texto.Append("Essa promoção é valida até " + data.ToShortDateString() +  ".");

            return texto.ToString();
        }
    }
}
