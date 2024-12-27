namespace CarteiradeContatos
{
    public class Cliente : EntityBase
    {
        public required string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public ICollection<int> ContatoIds { get; set; } = new List<int>();
    }
}