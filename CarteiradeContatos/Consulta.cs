using CarteiradeContatos;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CarteiradeContatos { 
    public class Consulta : PageModel
    {
        public IList<Contato> Contatos { get; set; }

        private readonly AppDbContext _context;

        public Consulta(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Contatos = await _context.Contatos.ToListAsync();
        }
    }
}