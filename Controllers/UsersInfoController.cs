using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCoreApp.Data;
using MyCoreApp.Models;
using DanilovSoft.MikroApi;
using System.IO;
using System.Net.Sockets;
using MyCoreApp.Helper;


namespace MyCoreApp.Controllers
{
    public class UsersInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UsersInfo
        public async Task<IActionResult> Index()
        {
           
                //var Connection = ConnectionFactory.OpenConnection(TikConnectionType.Api, "vpn.wifiburada.com", "admin", "As081316");
                //var interfaces = Connection.LoadAll<Interface>();
                //return interfaces;
             return View(await _context.UsersInfo.ToListAsync());
            
        }

        // GET: UsersInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersInfo = await _context.UsersInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usersInfo == null)
            {
                return NotFound();
            }

            return View(usersInfo);
        }

        // GET: UsersInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsersInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Lastname,Tc,Email,Address,Phone1,Phone2,Phone3,Username,Packet,Accesspoint,Ftipi,Osifre,Adurum,Sabitip,Atipi,Pasaportno,Unvan,Vergino,Cinsiyet,Uyruk,Babaadi,Anaadi,Anakizliksoyadi,Dogumyeri,Dogumtarihi,Meslek,Ciltno,Kutukno,Sayfano,Kil,Kilce,Mahkoy,Ktipi,Kserino,Kverildigiyer,Kverildigitarih,Ksahibi,Til,Tilce,Tmahalle,Tcadde,Tdiskapino,Tickapino,Tpostano,Tadresno,Vergidairesi")] UsersInfo usersInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersInfo);
            //   MyCoreApp.Models.Nas nasss =new MyCoreApp.Models.Nas();
            //    nasss.Nasname=usersInfo.Address;
            //    var aa=_context.Users.Where(x=>x.Id=12345);
            //    _context.Add(nasss);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersInfo);
        }

        // GET: UsersInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersInfo = await _context.UsersInfo.FindAsync(id);
            if (usersInfo == null)
            {
                return NotFound();
            }
            return View(usersInfo);
        }

        // POST: UsersInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Lastname,Tc,Email,Address,Phone1,Phone2,Phone3,Username,Packet,Accesspoint,Ftipi,Osifre,Adurum,Sabitip,Atipi,Pasaportno,Unvan,Vergino,Cinsiyet,Uyruk,Babaadi,Anaadi,Anakizliksoyadi,Dogumyeri,Dogumtarihi,Meslek,Ciltno,Kutukno,Sayfano,Kil,Kilce,Mahkoy,Ktipi,Kserino,Kverildigiyer,Kverildigitarih,Ksahibi,Til,Tilce,Tmahalle,Tcadde,Tdiskapino,Tickapino,Tpostano,Tadresno,Vergidairesi")] UsersInfo usersInfo)
        {
            if (id != usersInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersInfoExists(usersInfo.Id))
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
            return View(usersInfo);
        }

        // GET: UsersInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersInfo = await _context.UsersInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usersInfo == null)
            {
                return NotFound();
            }

            return View(usersInfo);
        }

        // POST: UsersInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersInfo = await _context.UsersInfo.FindAsync(id);
            _context.UsersInfo.Remove(usersInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersInfoExists(int id)
        {
            return _context.UsersInfo.Any(e => e.Id == id);
        }
        
        public string AhmetMehmet()
        {
            MK mikrotik = new MK("vpn.wifiburada.com");
                
                    if (!mikrotik.Login("admin", "As081316"))
            {
                    //Console.WriteLine("Could not log in");
                    mikrotik.Close();
                   return "Hatalı";
            }
                var aa = "";
                //var aaa = "";
                   mikrotik.Send("/ip/address/print");
                   mikrotik.Send("?=address=10.1.1.1/24");
                   mikrotik.Send(".tag=sss", true);
                   foreach (string h in mikrotik.Read())
            {
                aa += h;
                aa +="\n";            
                //return h;
                //Console.WriteLine(h);
                
            }
            
            
            return aa;
        }



    }
}
