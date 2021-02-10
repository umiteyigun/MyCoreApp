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
    public class RadcheckController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadcheckController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radcheck
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radcheck.ToListAsync());
        }

        // GET: Radcheck/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radcheck = await _context.Radcheck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radcheck == null)
            {
                return NotFound();
            }

            return View(radcheck);
        }

        // GET: Radcheck/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radcheck/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Attribute,Op,Value,Regdate")] Radcheck radcheck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radcheck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radcheck);
        }

        // GET: Radcheck/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radcheck = await _context.Radcheck.FindAsync(id);
            if (radcheck == null)
            {
                return NotFound();
            }
            return View(radcheck);
        }

        // POST: Radcheck/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,Username,Attribute,Op,Value,Regdate")] Radcheck radcheck)
        {
            if (id != radcheck.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radcheck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadcheckExists(radcheck.Id))
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
            return View(radcheck);
        }

        // GET: Radcheck/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radcheck = await _context.Radcheck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radcheck == null)
            {
                return NotFound();
            }

            return View(radcheck);
        }

        // POST: Radcheck/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var radcheck = await _context.Radcheck.FindAsync(id);
            _context.Radcheck.Remove(radcheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadcheckExists(uint id)
        {
            return _context.Radcheck.Any(e => e.Id == id);
        }
    }
}
