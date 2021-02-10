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
    public class RadreplyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadreplyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radreply
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radreply.ToListAsync());
        }

        // GET: Radreply/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radreply = await _context.Radreply
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radreply == null)
            {
                return NotFound();
            }

            return View(radreply);
        }

        // GET: Radreply/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radreply/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Attribute,Op,Value")] Radreply radreply)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radreply);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radreply);
        }

        // GET: Radreply/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radreply = await _context.Radreply.FindAsync(id);
            if (radreply == null)
            {
                return NotFound();
            }
            return View(radreply);
        }

        // POST: Radreply/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,Username,Attribute,Op,Value")] Radreply radreply)
        {
            if (id != radreply.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radreply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadreplyExists(radreply.Id))
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
            return View(radreply);
        }

        // GET: Radreply/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radreply = await _context.Radreply
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radreply == null)
            {
                return NotFound();
            }

            return View(radreply);
        }

        // POST: Radreply/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var radreply = await _context.Radreply.FindAsync(id);
            _context.Radreply.Remove(radreply);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadreplyExists(uint id)
        {
            return _context.Radreply.Any(e => e.Id == id);
        }
    }
}
