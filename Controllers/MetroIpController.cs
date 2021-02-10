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
    public class MetroIpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MetroIpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MetroIp
        public async Task<IActionResult> Index()
        {
            return View(await _context.MetroIp.ToListAsync());
        }

        // GET: MetroIp/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metroIp = await _context.MetroIp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metroIp == null)
            {
                return NotFound();
            }

            return View(metroIp);
        }

        // GET: MetroIp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MetroIp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nasname,Ipaddress,Ports,User")] MetroIp metroIp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(metroIp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(metroIp);
        }

        // GET: MetroIp/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metroIp = await _context.MetroIp.FindAsync(id);
            if (metroIp == null)
            {
                return NotFound();
            }
            return View(metroIp);
        }

        // POST: MetroIp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nasname,Ipaddress,Ports,User")] MetroIp metroIp)
        {
            if (id != metroIp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metroIp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetroIpExists(metroIp.Id))
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
            return View(metroIp);
        }

        // GET: MetroIp/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metroIp = await _context.MetroIp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metroIp == null)
            {
                return NotFound();
            }

            return View(metroIp);
        }

        // POST: MetroIp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var metroIp = await _context.MetroIp.FindAsync(id);
            _context.MetroIp.Remove(metroIp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetroIpExists(int id)
        {
            return _context.MetroIp.Any(e => e.Id == id);
        }
    }
}
