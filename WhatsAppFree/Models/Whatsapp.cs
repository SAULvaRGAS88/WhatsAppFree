using System;
using System.Collections.Generic;

namespace WhatsAppFree.Models
{
    //Classe WhatsApp
    public class WhatsApp
    {
        //Atributos da classe WhatsApp  Lista de Contatos e Lista de Mensagens (Contatos e Mensagens)
        public List<Contatinho> Contatos { get; set; }
        public List<Mensagem> Mensagens { get; set; }

        //Construtor da classe WhatsApp
        public WhatsApp()
        {
            Contatos = new List<Contatinho>();
            Mensagens = new List<Mensagem>();
        }

        //Método da classe WhatsApp  ListarContatos e ListarMensagens
        public void ListarContatos()
        {
            Console.WriteLine("Contatos:");
            foreach (var contato in Contatos)
            {
                Console.WriteLine(contato);
            }
        }

        public void ListarMensagens()
        {
            Console.WriteLine("Mensagens:");
            foreach (var mensagem in Mensagens)
            {
                Console.WriteLine(mensagem.ToString());
            }
        }
    }
}
