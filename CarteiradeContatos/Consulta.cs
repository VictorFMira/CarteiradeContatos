using CarteiradeContatos;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class Consulta : PageModel
{
    public IList<Contato> Contatos { get; set; }

    private readonly MyDbContext _context;

    public Consulta(MyDbContext context)
    {
        _context = context;
    }

    public async Task OnGetAsync()
    {
        Contatos = await _context.Contatos.ToListAsync();
    }
}