using System;
using WhatsAppFree.Models;

namespace WhatsAppFree.Utils
{
    //Classe que representa uma mensagem de audio
    public class MsgAudio : Mensagem
    {
        //Propriedades da classe MsgAudio que representam a duração da mensagem em segundos
        public int Duracao { get; set; }

        //Construtor da classe MsgAudio que recebe um destinatário, uma data, um conteudo e uma duração 
        public MsgAudio(Contatinho destinatario, string data, string conteudo, int duracao) : base(destinatario, data, conteudo)
        {
            Duracao = duracao;
        }

        //Metodo que retorna uma string com as informações da mensagem de audio
        public override string ToString()
        {
            return $"Audio: {Conteudo}, Enviado para: {Destinatario.Nome}, Data: {Data}, Duração: {Duracao} segundos";
        }
    }
}
