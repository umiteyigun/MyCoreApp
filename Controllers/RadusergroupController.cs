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
    public class RadusergroupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadusergroupController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radusergroup
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radusergroup.ToListAsync());
        }

        // GET: Radusergroup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radusergroup = await _context.Radusergroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radusergroup == null)
            {
                return NotFound();
            }

            return View(radusergroup);
        }

        // GET: Radusergroup/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radusergroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Groupname,Priority")] Radusergroup radusergroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radusergroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radusergroup);
        }

        // GET: Radusergroup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radusergroup = await _context.Radusergroup.FindAsync(id);
            if (radusergroup == null)
            {
                return NotFound();
            }
            return View(radusergroup);
        }

        // POST: Radusergroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Groupname,Priority")] Radusergroup radusergroup)
        {
            if (id != radusergroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radusergroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadusergroupExists(radusergroup.Id))
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
            return View(radusergroup);
        }

        // GET: Radusergroup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radusergroup = await _context.Radusergroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radusergroup == null)
            {
                return NotFound();
            }

            return View(radusergroup);
        }

        // POST: Radusergroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var radusergroup = await _context.Radusergroup.FindAsync(id);
            _context.Radusergroup.Remove(radusergroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadusergroupExists(int id)
        {
            return _context.Radusergroup.Any(e => e.Id == id);
        }
    }
}
