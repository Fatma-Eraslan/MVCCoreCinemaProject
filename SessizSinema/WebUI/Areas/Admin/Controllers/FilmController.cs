using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUI.Areas.Admin.Models;
using WebUI.Models.DataBase;
using WebUI.Models.DataBase.Entities;
using WebUI.Models.DataBase.Repositories.Abstract;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FilmController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IRepository<Film> filmRepository;
        private readonly IRepository<FilmCategori> filmCategoriRepository;
        private readonly IRepository<Seans> seansRepository;

        public FilmController(AppDbContext context, IRepository<Film> filmRepository, IRepository<FilmCategori> filmCategoriRepository, IRepository<Seans> seansRepository)
        {
            _context = context;
            this.filmRepository = filmRepository;
            this.filmCategoriRepository = filmCategoriRepository;
            this.seansRepository = seansRepository;
        }

        // GET: Admin/Film
        public async Task<IActionResult> Index()
        {
            return View(await _context.Filmler.ToListAsync());
        }

        // GET: Admin/Film/Details/5
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

        // GET: Admin/Film/Create
        public IActionResult Create()
        {
            FilmVM filmVM = new FilmVM();
            filmVM.FilmCategorileri = filmCategoriRepository.GetAll();
            filmVM.Seanslar = seansRepository.GetAll();
            return View(filmVM);
        }

        [HttpPost]
        public IActionResult Create(FilmVM filmVM)
        {
            if(ModelState.IsValid)
            {
                if(filmVM.Film.FilmPoster!=null)
                {
                    string ticks = DateTime.Now.Ticks.ToString();
                    var path = Directory.GetCurrentDirectory() +
                        @"\wwwroot\img\" + ticks + Path.GetExtension(filmVM.Film.FilmPoster.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        filmVM.Film.FilmPoster.CopyTo(stream);
                    }
                    filmVM.Film.FilmPosterFotografYolu = @"\img\" + ticks + Path.GetExtension
                        (filmVM.Film.FilmPoster.FileName);
                }
                filmRepository.Add(filmVM.Film);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                TempData["Message"] = "Film eklenemedi!";
                return View(filmVM);
            }
            return View();
        }

        // POST: Admin/Film/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Ad,Fiyat,VizyonaGirisTarih,VizyonDanKalkisTarih,FilmOzet,FilmSuresi,FilmYönetmeni,FilmPosterFotografYolu,Id")] Film film)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(film);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(film);
        //}

        // GET: Admin/Film/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmler.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        // POST: Admin/Film/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ad,Fiyat,VizyonaGirisTarih,VizyonDanKalkisTarih,FilmOzet,FilmSuresi,FilmYönetmeni,FilmPosterFotografYolu,Id")] Film film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.Id))
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
            return View(film);
        }

        // GET: Admin/Film/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Admin/Film/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Filmler.FindAsync(id);
            _context.Filmler.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.Filmler.Any(e => e.Id == id);
        }
    }
}
