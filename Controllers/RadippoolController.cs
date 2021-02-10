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
    public class RadippoolController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadippoolController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radippool
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radippool.ToListAsync());
        }

        // GET: Radippool/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radippool = await _context.Radippool
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radippool == null)
            {
                return NotFound();
            }

            return View(radippool);
        }

        // GET: Radippool/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radippool/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PoolName,Framedipaddress,Nasipaddress,Calledstationid,Callingstationid,ExpiryTime,Username,PoolKey,Port")] Radippool radippool)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radippool);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radippool);
        }

        // GET: Radippool/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radippool = await _context.Radippool.FindAsync(id);
            if (radippool == null)
            {
                return NotFound();
            }
            return View(radippool);
        }

        // POST: Radippool/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,PoolName,Framedipaddress,Nasipaddress,Calledstationid,Callingstationid,ExpiryTime,Username,PoolKey,Port")] Radippool radippool)
        {
            if (id != radippool.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radippool);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadippoolExists(radippool.Id))
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
            return View(radippool);
        }

        // GET: Radippool/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radippool = await _context.Radippool
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radippool == null)
            {
                return NotFound();
            }

            return View(radippool);
        }

        // POST: Radippool/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var radippool = await _context.Radippool.FindAsync(id);
            _context.Radippool.Remove(radippool);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadippoolExists(uint id)
        {
            return _context.Radippool.Any(e => e.Id == id);
        }
    }
}
