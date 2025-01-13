using System.ComponentModel.DataAnnotations;

public class Contato : EntityBase
{
    [Required]
    public required string Nome { get; set; }
    [Required]
    public required string Telefone { get; set; }
    [Required]
    public string? Email { get; set; }
}

public class EntityBase
{
    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
    
}
