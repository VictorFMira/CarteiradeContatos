using System.ComponentModel.DataAnnotations;

namespace CarteiradeContatos
{
    public class Contato : EntityBase
    {
        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Telefone { get; set; }

        [Required]
        public string? Email { get; set; }
    }

}