using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCoreApp.Data;
using MyCoreApp.Models;

namespace MyCoreApp.Controllers
{
    public class SayiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SayiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sayi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sayi.ToListAsync());
        }

        // GET: Sayi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sayi = await _context.Sayi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sayi == null)
            {
                return NotFound();
            }

            return View(sayi);
        }

        // GET: Sayi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sayi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NatSayi,KutukSayi,Tarih")] Sayi sayi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sayi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sayi);
        }

        // GET: Sayi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sayi = await _context.Sayi.FindAsync(id);
            if (sayi == null)
            {
                return NotFound();
            }
            return View(sayi);
        }

        // POST: Sayi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NatSayi,KutukSayi,Tarih")] Sayi sayi)
        {
            if (id != sayi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sayi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SayiExists(sayi.Id))
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
            return View(sayi);
        }

        // GET: Sayi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sayi = await _context.Sayi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sayi == null)
            {
                return NotFound();
            }

            return View(sayi);
        }

        // POST: Sayi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sayi = await _context.Sayi.FindAsync(id);
            _context.Sayi.Remove(sayi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SayiExists(int id)
        {
            return _context.Sayi.Any(e => e.Id == id);
        }
    }
}
