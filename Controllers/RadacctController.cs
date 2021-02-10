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
    public class RadacctController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RadacctController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Radacct
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radacct.ToListAsync());
        }

        // GET: Radacct/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radacct = await _context.Radacct
                .FirstOrDefaultAsync(m => m.Radacctid == id);
            if (radacct == null)
            {
                return NotFound();
            }

            return View(radacct);
        }

        // GET: Radacct/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radacct/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Radacctid,Acctsessionid,Acctuniqueid,Username,Groupname,Realm,Nasipaddress,Nasportid,Nasporttype,Acctstarttime,Acctstoptime,Acctsessiontime,Acctauthentic,ConnectinfoStart,ConnectinfoStop,Acctinputoctets,Acctoutputoctets,Calledstationid,Callingstationid,Acctterminatecause,Servicetype,Framedprotocol,Framedipaddress,Acctstartdelay,Acctstopdelay,Xascendsessionsvrkey,Btk")] Radacct radacct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radacct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radacct);
        }

        // GET: Radacct/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radacct = await _context.Radacct.FindAsync(id);
            if (radacct == null)
            {
                return NotFound();
            }
            return View(radacct);
        }

        // POST: Radacct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Radacctid,Acctsessionid,Acctuniqueid,Username,Groupname,Realm,Nasipaddress,Nasportid,Nasporttype,Acctstarttime,Acctstoptime,Acctsessiontime,Acctauthentic,ConnectinfoStart,ConnectinfoStop,Acctinputoctets,Acctoutputoctets,Calledstationid,Callingstationid,Acctterminatecause,Servicetype,Framedprotocol,Framedipaddress,Acctstartdelay,Acctstopdelay,Xascendsessionsvrkey,Btk")] Radacct radacct)
        {
            if (id != radacct.Radacctid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radacct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadacctExists(radacct.Radacctid))
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
            return View(radacct);
        }

        // GET: Radacct/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radacct = await _context.Radacct
                .FirstOrDefaultAsync(m => m.Radacctid == id);
            if (radacct == null)
            {
                return NotFound();
            }

            return View(radacct);
        }

        // POST: Radacct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var radacct = await _context.Radacct.FindAsync(id);
            _context.Radacct.Remove(radacct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadacctExists(long id)
        {
            return _context.Radacct.Any(e => e.Radacctid == id);
        }
    }
}
