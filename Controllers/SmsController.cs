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
    public class SmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SmsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sms
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sms.ToListAsync());
        }

        // GET: Sms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sms = await _context.Sms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sms == null)
            {
                return NotFound();
            }

            return View(sms);
        }

        // GET: Sms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Sms1,Number,Date")] Sms sms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sms);
        }

        // GET: Sms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sms = await _context.Sms.FindAsync(id);
            if (sms == null)
            {
                return NotFound();
            }
            return View(sms);
        }

        // POST: Sms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Sms1,Number,Date")] Sms sms)
        {
            if (id != sms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmsExists(sms.Id))
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
            return View(sms);
        }

        // GET: Sms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sms = await _context.Sms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sms == null)
            {
                return NotFound();
            }

            return View(sms);
        }

        // POST: Sms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sms = await _context.Sms.FindAsync(id);
            _context.Sms.Remove(sms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmsExists(int id)
        {
            return _context.Sms.Any(e => e.Id == id);
        }
    }
}
