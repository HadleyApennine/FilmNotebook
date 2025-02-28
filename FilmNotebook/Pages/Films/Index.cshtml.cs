using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmNotebook.Data;
using FilmNotebook.Models;

namespace FilmNotebook.Pages_Films
{
    public class IndexModel : PageModel
    {
        private readonly FilmNotebook.Data.ApplicationDbContext _context;

        public IndexModel(FilmNotebook.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Film = await _context.Films.ToListAsync();
        }
    }
}
