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
    public class RadgroupreplyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadgroupreplyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radgroupreply
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radgroupreply.ToListAsync());
        }

        // GET: Radgroupreply/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radgroupreply = await _context.Radgroupreply
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radgroupreply == null)
            {
                return NotFound();
            }

            return View(radgroupreply);
        }

        // GET: Radgroupreply/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radgroupreply/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Groupname,Attribute,Op,Value")] Radgroupreply radgroupreply)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radgroupreply);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radgroupreply);
        }

        // GET: Radgroupreply/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radgroupreply = await _context.Radgroupreply.FindAsync(id);
            if (radgroupreply == null)
            {
                return NotFound();
            }
            return View(radgroupreply);
        }

        // POST: Radgroupreply/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,Groupname,Attribute,Op,Value")] Radgroupreply radgroupreply)
        {
            if (id != radgroupreply.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radgroupreply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadgroupreplyExists(radgroupreply.Id))
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
            return View(radgroupreply);
        }

        // GET: Radgroupreply/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radgroupreply = await _context.Radgroupreply
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radgroupreply == null)
            {
                return NotFound();
            }

            return View(radgroupreply);
        }

        // POST: Radgroupreply/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var radgroupreply = await _context.Radgroupreply.FindAsync(id);
            _context.Radgroupreply.Remove(radgroupreply);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadgroupreplyExists(uint id)
        {
            return _context.Radgroupreply.Any(e => e.Id == id);
        }
    }
}
