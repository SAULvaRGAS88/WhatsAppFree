using WhatsAppFree.Models;
using WhatsAppFree.Utils;
using System;

namespace WhatsAppFree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar instância do WhatsApp
            WhatsApp whatsapp = new WhatsApp();

            // Adicionar contatos
            Contatinho contato1 = new Contatinho("João", "123456789");
            Contatinho contato2 = new Contatinho("Maria", "987654321");
            Contatinho contato3 = new Contatinho("Pedro", "456789123");
            whatsapp.Contatos.Add(contato1);
            whatsapp.Contatos.Add(contato2);
            whatsapp.Contatos.Add(contato3);

            // Adicionar mensagem de texto
            MsgTexto msgTexto = new MsgTexto(contato1, "16/05/2024", "Olá, tudo bem?");
            whatsapp.Mensagens.Add(msgTexto);

            // Adicionar menagem de audio
            MsgAudio msgAudio = new MsgAudio(contato2, "16/05/2024", "Audio.mp3", 39);
            whatsapp.Mensagens.Add(msgAudio);

            // Adicionar mensgem de imagem
            MsgFoto msgImagem = new MsgFoto(contato3, "16/05/2024", "Imagem.jpg", 1024);
            whatsapp.Mensagens.Add(msgImagem);

            // Listar contatos e mensagens
            whatsapp.ListarContatos();
            whatsapp.ListarMensagens();
        }
    }
}
