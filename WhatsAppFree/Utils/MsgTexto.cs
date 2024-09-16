using WhatsAppFree.Models;

namespace WhatsAppFree.Utils
{
    //Classe para armazenar as mensagens de texto herdando propriedades da classe mensagem e metodos
    public class MsgTexto : Mensagem
    {
        //propriedades da classe NumChar seria a quantidade de caracteres da mensagem
        public int NumChar { get; set; }

        //Construtor da classe herdando propriedades da classe mensagem
        public MsgTexto(Contatinho destinatario, string data, string conteudo)
            : base(destinatario, data, conteudo)
        {
            NumChar = conteudo.Length;
        }

        //Metodo para retornar o conteudo da mensagem
        public override string ToString()
        {
            return $"Texto: {Conteudo}, Enviado para: {Destinatario.Nome}, Data: {Data}, Número de caracteres: {NumChar}";
        }
    }
}
