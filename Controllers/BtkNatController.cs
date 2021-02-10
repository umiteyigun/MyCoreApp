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
    public class BtkNatController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BtkNatController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BtkNat
        public async Task<IActionResult> Index()
        {
            return View(await _context.BtkNat.ToListAsync());
        }

        // GET: BtkNat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btkNat = await _context.BtkNat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btkNat == null)
            {
                return NotFound();
            }

            return View(btkNat);
        }

        // GET: BtkNat/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BtkNat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KullaniciAd,OzelIp,OIpPBas,OIpPBit,GercekIp,GIpPBas,GIpPBit,OBasTarih,OBitTarih,UpByte,DownByte,BKM,ODurum,BPvc,ServisNo,OKod,Imza")] BtkNat btkNat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(btkNat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(btkNat);
        }

        // GET: BtkNat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btkNat = await _context.BtkNat.FindAsync(id);
            if (btkNat == null)
            {
                return NotFound();
            }
            return View(btkNat);
        }

        // POST: BtkNat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KullaniciAd,OzelIp,OIpPBas,OIpPBit,GercekIp,GIpPBas,GIpPBit,OBasTarih,OBitTarih,UpByte,DownByte,BKM,ODurum,BPvc,ServisNo,OKod,Imza")] BtkNat btkNat)
        {
            if (id != btkNat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(btkNat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BtkNatExists(btkNat.Id))
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
            return View(btkNat);
        }

        // GET: BtkNat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btkNat = await _context.BtkNat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btkNat == null)
            {
                return NotFound();
            }

            return View(btkNat);
        }

        // POST: BtkNat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var btkNat = await _context.BtkNat.FindAsync(id);
            _context.BtkNat.Remove(btkNat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BtkNatExists(int id)
        {
            return _context.BtkNat.Any(e => e.Id == id);
        }
    }
}
