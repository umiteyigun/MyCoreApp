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
    public class BakiyeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BakiyeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bakiye
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bakiye.ToListAsync());
        }

        // GET: Bakiye/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakiye = await _context.Bakiye
                .FirstOrDefaultAsync(m => m.Bakiyeid == id);
            if (bakiye == null)
            {
                return NotFound();
            }

            return View(bakiye);
        }

        // GET: Bakiye/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bakiye/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bakiyeid,Username,Gelir,Gider,Tarih,Ekleyen,Aciklama,Baglanti,Baglantitip")] Bakiye bakiye)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bakiye);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bakiye);
        }

        // GET: Bakiye/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakiye = await _context.Bakiye.FindAsync(id);
            if (bakiye == null)
            {
                return NotFound();
            }
            return View(bakiye);
        }

        // POST: Bakiye/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bakiyeid,Username,Gelir,Gider,Tarih,Ekleyen,Aciklama,Baglanti,Baglantitip")] Bakiye bakiye)
        {
            if (id != bakiye.Bakiyeid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bakiye);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BakiyeExists(bakiye.Bakiyeid))
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
            return View(bakiye);
        }

        // GET: Bakiye/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakiye = await _context.Bakiye
                .FirstOrDefaultAsync(m => m.Bakiyeid == id);
            if (bakiye == null)
            {
                return NotFound();
            }

            return View(bakiye);
        }

        // POST: Bakiye/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bakiye = await _context.Bakiye.FindAsync(id);
            _context.Bakiye.Remove(bakiye);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BakiyeExists(int id)
        {
            return _context.Bakiye.Any(e => e.Bakiyeid == id);
        }
    }
}
