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
    public class BasvuruController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BasvuruController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Basvuru
        public async Task<IActionResult> Index()
        {
            return View(await _context.Basvuru.ToListAsync());
        }

        // GET: Basvuru/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basvuru = await _context.Basvuru
                .FirstOrDefaultAsync(m => m.id == id);
            if (basvuru == null)
            {
                return NotFound();
            }

            return View(basvuru);
        }

        // GET: Basvuru/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Basvuru/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Badi,Bsoyadi,Btc,Bemail,Badresi,Btelefon1,Btelefon2,Btelefon3,Bpaket,Bftipi,Bil,Bilce,Brandevu,Bsms,Bsmsid,Bbildiren,Bsonuc,Baciklama,Bhakedis")] Basvuru basvuru)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basvuru);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(basvuru);
        }

        // GET: Basvuru/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basvuru = await _context.Basvuru.FindAsync(id);
            if (basvuru == null)
            {
                return NotFound();
            }
            return View(basvuru);
        }

        // POST: Basvuru/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Badi,Bsoyadi,Btc,Bemail,Badresi,Btelefon1,Btelefon2,Btelefon3,Bpaket,Bftipi,Bil,Bilce,Brandevu,Bsms,Bsmsid,Bbildiren,Bsonuc,Baciklama,Bhakedis")] Basvuru basvuru)
        {
            if (id != basvuru.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basvuru);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasvuruExists(basvuru.id))
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
            return View(basvuru);
        }

        // GET: Basvuru/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basvuru = await _context.Basvuru
                .FirstOrDefaultAsync(m => m.id == id);
            if (basvuru == null)
            {
                return NotFound();
            }

            return View(basvuru);
        }

        // POST: Basvuru/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basvuru = await _context.Basvuru.FindAsync(id);
            _context.Basvuru.Remove(basvuru);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BasvuruExists(int id)
        {
            return _context.Basvuru.Any(e => e.id == id);
        }
    }
}
