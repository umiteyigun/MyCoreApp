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
    public class RadgroupcheckController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadgroupcheckController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radgroupcheck
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radgroupcheck.ToListAsync());
        }

        // GET: Radgroupcheck/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radgroupcheck = await _context.Radgroupcheck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radgroupcheck == null)
            {
                return NotFound();
            }

            return View(radgroupcheck);
        }

        // GET: Radgroupcheck/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radgroupcheck/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Groupname,Attribute,Op,Value")] Radgroupcheck radgroupcheck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radgroupcheck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radgroupcheck);
        }

        // GET: Radgroupcheck/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radgroupcheck = await _context.Radgroupcheck.FindAsync(id);
            if (radgroupcheck == null)
            {
                return NotFound();
            }
            return View(radgroupcheck);
        }

        // POST: Radgroupcheck/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,Groupname,Attribute,Op,Value")] Radgroupcheck radgroupcheck)
        {
            if (id != radgroupcheck.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radgroupcheck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadgroupcheckExists(radgroupcheck.Id))
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
            return View(radgroupcheck);
        }

        // GET: Radgroupcheck/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radgroupcheck = await _context.Radgroupcheck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radgroupcheck == null)
            {
                return NotFound();
            }

            return View(radgroupcheck);
        }

        // POST: Radgroupcheck/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var radgroupcheck = await _context.Radgroupcheck.FindAsync(id);
            _context.Radgroupcheck.Remove(radgroupcheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadgroupcheckExists(uint id)
        {
            return _context.Radgroupcheck.Any(e => e.Id == id);
        }
    }
}
