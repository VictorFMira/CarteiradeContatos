namespace CarteiradeContatos
{
    public class Contato : EntityBase
    {
        public required string Nome { get; set; }
        public List<string> Telefones { get; set; } = new();
        public string? Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
    }
}