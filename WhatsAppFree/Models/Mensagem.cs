using System;

namespace WhatsAppFree.Models
{
    // Classe abstrata para mensagens
    public abstract class Mensagem
    {
        // Propriedades da classe abstrata Messagem
        public Contatinho Destinatario { get; set; }
        public string Data { get; set; }
        public string Conteudo { get; set; }

        // Construtor da classe abstrata Mensagem
        protected Mensagem(Contatinho destinatario, string data, string conteudo)
        {
            Destinatario = destinatario;
            Data = data;
            Conteudo = conteudo;
        }

        // ToString da classe abstrata Mensagem, ToString serve para retornar o conteudo da mensagem
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
