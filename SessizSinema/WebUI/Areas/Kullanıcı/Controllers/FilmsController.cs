using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUI.Models.DataBase;
using WebUI.Models.DataBase.Entities;

namespace WebUI.Areas.Kullanıcı.Controllers
{
    [Area("Kullanıcı")]
    public class FilmsController : Controller
    {
        private readonly AppDbContext _context;

        public FilmsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Kullanıcı/Films
        public async Task<IActionResult> Index()
        {
            return View(await _context.Filmler.ToListAsync());
        }

        // GET: Kullanıcı/Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        private bool FilmExists(int id)
        {
            return _context.Filmler.Any(e => e.Id == id);
        }
    }
}
