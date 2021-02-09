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
    public class NasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nas.ToListAsync());
        }

        // GET: Nas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nas = await _context.Nas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nas == null)
            {
                return NotFound();
            }

            return View(nas);
        }

        // GET: Nas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nasname,Shortname,Type,Ports,Secret,Server,Community,Description")] Nas nas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nas);
        }

        // GET: Nas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nas = await _context.Nas.FindAsync(id);
            if (nas == null)
            {
                return NotFound();
            }
            return View(nas);
        }

        // POST: Nas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nasname,Shortname,Type,Ports,Secret,Server,Community,Description")] Nas nas)
        {
            if (id != nas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NasExists(nas.Id))
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
            return View(nas);
        }

        // GET: Nas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nas = await _context.Nas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nas == null)
            {
                return NotFound();
            }

            return View(nas);
        }

        // POST: Nas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nas = await _context.Nas.FindAsync(id);
            _context.Nas.Remove(nas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NasExists(int id)
        {
            return _context.Nas.Any(e => e.Id == id);
        }
    }
}
