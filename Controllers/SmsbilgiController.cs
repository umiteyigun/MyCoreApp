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
    public class SmsbilgiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SmsbilgiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Smsbilgi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Smsbilgi.ToListAsync());
        }

        // GET: Smsbilgi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smsbilgi = await _context.Smsbilgi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smsbilgi == null)
            {
                return NotFound();
            }

            return View(smsbilgi);
        }

        // GET: Smsbilgi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Smsbilgi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Smsuser,Smspass,Smsno,Smsapi,Dis")] Smsbilgi smsbilgi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smsbilgi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(smsbilgi);
        }

        // GET: Smsbilgi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smsbilgi = await _context.Smsbilgi.FindAsync(id);
            if (smsbilgi == null)
            {
                return NotFound();
            }
            return View(smsbilgi);
        }

        // POST: Smsbilgi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Smsuser,Smspass,Smsno,Smsapi,Dis")] Smsbilgi smsbilgi)
        {
            if (id != smsbilgi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smsbilgi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmsbilgiExists(smsbilgi.Id))
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
            return View(smsbilgi);
        }

        // GET: Smsbilgi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smsbilgi = await _context.Smsbilgi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smsbilgi == null)
            {
                return NotFound();
            }

            return View(smsbilgi);
        }

        // POST: Smsbilgi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smsbilgi = await _context.Smsbilgi.FindAsync(id);
            _context.Smsbilgi.Remove(smsbilgi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmsbilgiExists(int id)
        {
            return _context.Smsbilgi.Any(e => e.Id == id);
        }
    }
}
