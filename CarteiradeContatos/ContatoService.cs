using System.Collections.Generic;
using System.Threading.Tasks;

public class ContatoService
{
    private readonly List<Contato> _contatos = new List<Contato>();

    public Task AddContatoAsync(Contato contato)
    {
        _contatos.Add(contato);
        return Task.CompletedTask;
    }

    public Task<List<Contato>> GetContatosAsync()
    {
        return Task.FromResult(_contatos);
    }
}
