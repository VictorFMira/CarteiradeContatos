public class ContatoService
{
    private readonly List<Contato> _contatos = new List<Contato>();

    public Task<List<Contato>> GetContatosAsync()
    {
        return Task.FromResult(_contatos);
    }

    public Task AddContatoAsync(Contato contato)
    {
        _contatos.Add(contato);
        return Task.CompletedTask;
    }
}

