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
    public class AccessPointsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccessPointsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AccessPoints
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccessPoints.ToListAsync());
        }

        // GET: AccessPoints/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accessPoints = await _context.AccessPoints
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accessPoints == null)
            {
                return NotFound();
            }

            return View(accessPoints);
        }

        // GET: AccessPoints/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccessPoints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Nasname,Ip,Username,Secret,Port,Description,Lat,Long")] AccessPoints accessPoints)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accessPoints);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accessPoints);
        }

        // GET: AccessPoints/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accessPoints = await _context.AccessPoints.FindAsync(id);
            if (accessPoints == null)
            {
                return NotFound();
            }
            return View(accessPoints);
        }

        // POST: AccessPoints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Nasname,Ip,Username,Secret,Port,Description,Lat,Long")] AccessPoints accessPoints)
        {
            if (id != accessPoints.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accessPoints);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccessPointsExists(accessPoints.Id))
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
            return View(accessPoints);
        }

        // GET: AccessPoints/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accessPoints = await _context.AccessPoints
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accessPoints == null)
            {
                return NotFound();
            }

            return View(accessPoints);
        }

        // POST: AccessPoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accessPoints = await _context.AccessPoints.FindAsync(id);
            _context.AccessPoints.Remove(accessPoints);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccessPointsExists(int id)
        {
            return _context.AccessPoints.Any(e => e.Id == id);
        }
    }
}
