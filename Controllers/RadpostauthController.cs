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
    public class RadpostauthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadpostauthController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radpostauth
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radpostauth.ToListAsync());
        }

        // GET: Radpostauth/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radpostauth = await _context.Radpostauth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radpostauth == null)
            {
                return NotFound();
            }

            return View(radpostauth);
        }

        // GET: Radpostauth/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radpostauth/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Pass,Reply,Authdate")] Radpostauth radpostauth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radpostauth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radpostauth);
        }

        // GET: Radpostauth/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radpostauth = await _context.Radpostauth.FindAsync(id);
            if (radpostauth == null)
            {
                return NotFound();
            }
            return View(radpostauth);
        }

        // POST: Radpostauth/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Pass,Reply,Authdate")] Radpostauth radpostauth)
        {
            if (id != radpostauth.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radpostauth);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadpostauthExists(radpostauth.Id))
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
            return View(radpostauth);
        }

        // GET: Radpostauth/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radpostauth = await _context.Radpostauth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radpostauth == null)
            {
                return NotFound();
            }

            return View(radpostauth);
        }

        // POST: Radpostauth/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var radpostauth = await _context.Radpostauth.FindAsync(id);
            _context.Radpostauth.Remove(radpostauth);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadpostauthExists(int id)
        {
            return _context.Radpostauth.Any(e => e.Id == id);
        }
    }
}
