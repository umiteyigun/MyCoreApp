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
    public class PacketsInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PacketsInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PacketsInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.PacketsInfo.ToListAsync());
        }

        // GET: PacketsInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packetsInfo = await _context.PacketsInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packetsInfo == null)
            {
                return NotFound();
            }

            return View(packetsInfo);
        }

        // GET: PacketsInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PacketsInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Download,Upload,Price,Traffic,Sat")] PacketsInfo packetsInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(packetsInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(packetsInfo);
        }

        // GET: PacketsInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packetsInfo = await _context.PacketsInfo.FindAsync(id);
            if (packetsInfo == null)
            {
                return NotFound();
            }
            return View(packetsInfo);
        }

        // POST: PacketsInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Download,Upload,Price,Traffic,Sat")] PacketsInfo packetsInfo)
        {
            if (id != packetsInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packetsInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacketsInfoExists(packetsInfo.Id))
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
            return View(packetsInfo);
        }

        // GET: PacketsInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packetsInfo = await _context.PacketsInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packetsInfo == null)
            {
                return NotFound();
            }

            return View(packetsInfo);
        }

        // POST: PacketsInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var packetsInfo = await _context.PacketsInfo.FindAsync(id);
            _context.PacketsInfo.Remove(packetsInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacketsInfoExists(int id)
        {
            return _context.PacketsInfo.Any(e => e.Id == id);
        }
    }
}
