using Microsoft.AspNetCore.Mvc;
using FilmNotebook.Data;
using Microsoft.EntityFrameworkCore;
using FilmNotebook.Models;
using System.Threading.Tasks;

namespace FilmNotebook.Controllers
{
    public class FilmsMvcController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmsMvcController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /FilmsMvc
        public async Task<IActionResult> Index()
        {
            var films = await _context.Films.ToListAsync();
            return View(films);
        }
    }
}
