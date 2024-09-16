namespace WhatsAppFree.Models
{
    // Classe Contatinho
    public class Contatinho
    {
        // Propriedades da classe Contatinho 
        public string Nome { get; set; }
        public string Celular { get; set; }

        // Construtor da classe Contatinho
        public Contatinho(string nome, string celular)
        {
            Nome = nome;
            Celular = celular;
        }

        // ToString da classe Contatinho
        public override string ToString()
        {
            return $"Nome: {Nome}, Celular: {Celular}";
        }
    }
}
