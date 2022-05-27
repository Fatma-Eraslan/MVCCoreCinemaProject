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
    public class SeansController : Controller
    {
        private readonly AppDbContext _context;

        public SeansController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Seans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Seanslar.ToListAsync());
        }

        // GET: Admin/Seans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seans = await _context.Seanslar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seans == null)
            {
                return NotFound();
            }

            return View(seans);
        }

        // GET: Admin/Seans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Seans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Saati,Id")] Seans seans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seans);
        }

        // GET: Admin/Seans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seans = await _context.Seanslar.FindAsync(id);
            if (seans == null)
            {
                return NotFound();
            }
            return View(seans);
        }

        // POST: Admin/Seans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Saati,Id")] Seans seans)
        {
            if (id != seans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeansExists(seans.Id))
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
            return View(seans);
        }

        // GET: Admin/Seans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seans = await _context.Seanslar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seans == null)
            {
                return NotFound();
            }

            return View(seans);
        }

        // POST: Admin/Seans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seans = await _context.Seanslar.FindAsync(id);
            _context.Seanslar.Remove(seans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeansExists(int id)
        {
            return _context.Seanslar.Any(e => e.Id == id);
        }
    }
}
