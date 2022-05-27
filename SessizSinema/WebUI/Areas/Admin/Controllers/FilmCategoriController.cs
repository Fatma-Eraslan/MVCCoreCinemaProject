using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUI.Models.DataBase;
using WebUI.Models.DataBase.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FilmCategoriController : Controller
    {
        private readonly AppDbContext _context;

        public FilmCategoriController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FilmCategori
        public async Task<IActionResult> Index()
        {
            return View(await _context.FilmCategorileri.ToListAsync());
        }

        // GET: Admin/FilmCategori/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmCategori = await _context.FilmCategorileri
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmCategori == null)
            {
                return NotFound();
            }

            return View(filmCategori);
        }

        // GET: Admin/FilmCategori/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/FilmCategori/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KategoriAdi")] FilmCategori filmCategori)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmCategori);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmCategori);
        }

        // GET: Admin/FilmCategori/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmCategori = await _context.FilmCategorileri.FindAsync(id);
            if (filmCategori == null)
            {
                return NotFound();
            }
            return View(filmCategori);
        }

        // POST: Admin/FilmCategori/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KategoriAdi")] FilmCategori filmCategori)
        {
            if (id != filmCategori.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmCategori);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmCategoriExists(filmCategori.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(filmCategori);
        }

        // GET: Admin/FilmCategori/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmCategori = await _context.FilmCategorileri
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmCategori == null)
            {
                return NotFound();
            }

            return View(filmCategori);
        }

        // POST: Admin/FilmCategori/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmCategori = await _context.FilmCategorileri.FindAsync(id);
            _context.FilmCategorileri.Remove(filmCategori);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmCategoriExists(int id)
        {
            return _context.FilmCategorileri.Any(e => e.Id == id);
        }
    }
}
