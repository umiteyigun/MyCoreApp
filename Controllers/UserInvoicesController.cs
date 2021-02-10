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
    public class UserInvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserInvoicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserInvoices
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserInvoices.ToListAsync());
        }

        // GET: UserInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInvoices = await _context.UserInvoices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userInvoices == null)
            {
                return NotFound();
            }

            return View(userInvoices);
        }

        // GET: UserInvoices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInvoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Price,Peydate,Expire,Packet,Tdurum,Taciklama,Tyapan,Kaciklama,Kmesaj,Taksit,Tekrar,Otarihi,Sms,Mcoid")] UserInvoices userInvoices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInvoices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userInvoices);
        }

        // GET: UserInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInvoices = await _context.UserInvoices.FindAsync(id);
            if (userInvoices == null)
            {
                return NotFound();
            }
            return View(userInvoices);
        }

        // POST: UserInvoices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Price,Peydate,Expire,Packet,Tdurum,Taciklama,Tyapan,Kaciklama,Kmesaj,Taksit,Tekrar,Otarihi,Sms,Mcoid")] UserInvoices userInvoices)
        {
            if (id != userInvoices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInvoices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInvoicesExists(userInvoices.Id))
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
            return View(userInvoices);
        }

        // GET: UserInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInvoices = await _context.UserInvoices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userInvoices == null)
            {
                return NotFound();
            }

            return View(userInvoices);
        }

        // POST: UserInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userInvoices = await _context.UserInvoices.FindAsync(id);
            _context.UserInvoices.Remove(userInvoices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserInvoicesExists(int id)
        {
            return _context.UserInvoices.Any(e => e.Id == id);
        }
    }
}
