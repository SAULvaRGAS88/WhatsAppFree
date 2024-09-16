using System;
using WhatsAppFree.Models;


namespace WhatsAppFree.Utils
{
    //Classe que representa uma mensagem de imagem
    public class MsgFoto : Mensagem
    {
        //Propriedade que representa o tamanho da imagem
        public int Tamanho { get; set; }

        //Construtor da classe MsgFoto que recebe o destinatario, a data, o conteudo e o tamanho da imagem
        public MsgFoto(Contatinho destinatario, string data, string conteudo, int tamanho) : base(destinatario, data, conteudo)
        {
            Tamanho = tamanho;
        }

        //ToString da classe MsgFoto que retorna uma string com o conteudo, o destinatario, a data e o tamanho da imagem
        public override string ToString()
        {
            return $"Foto: {Conteudo}, Enviado para: {Destinatario.Nome}, Data: {Data}, Tamanho: {Tamanho} bytes";
        }
    }
}
