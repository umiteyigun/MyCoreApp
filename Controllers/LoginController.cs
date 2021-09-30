using Microsoft.AspNetCore.Mvc;
using MyCoreApp.Data;
using MyCoreApp.Helper;
using System.Data;
using System.Linq;
using System.Net;



//
//
// bu sayfadaki kodlar çalışmıyor ama projede login-controller-calisan-kod isimli txt belgesi var porgram.csnin üzerinde oradaki kodları kopyala yapıştır yaparak kullanabilirsiniz.
//xml kodları yok karışıklık olmasın diye koymadım (log tutmak için)
//
//

namespace MyCoreApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }


        public MK mikrotikLogin()
        {

            MK mikrotik = new MK("vpn.wifiburada.com");
            if (!mikrotik.Login("admin", "As081316"))
                throw new System.Exception("Bağlantı Hatası");

            return mikrotik;
        }

        public string ipadresiAl()
        {
            string ipAdres = "";
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                ipAdres = adres.ToString();
            }
            return ipAdres;
        }
        public bool KullaniciyiAktifEt(string usser, string pass, string ipAdresi)
        {
            var mikrotik = mikrotikLogin();
            mikrotik.Send("/ip/hotspot/active/login");
            mikrotik.Send("=user=" + usser);
            mikrotik.Send("=password=" + pass);
            mikrotik.Send("=ip=" + ipAdresi);
            mikrotik.Close();
            return true;
        }
        public bool KullaniciEkle(string usser, string pass)
        {
            // ip hotspot user add name=a password=a
            var mikrotik = mikrotikLogin();
            //var gonder = "/ip/hotspot/user/add name=" + usser + " password=" + pass;
            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=name=" + usser);
            mikrotik.Send("=password=" + pass);
            mikrotik.Close();
            return true;
        }
        public bool KullaniciVarmi(string usser)
        {
            // ip hotspot user print where name=a
            var mikrotik = mikrotikLogin();
            mikrotik.Send("/ip/hotspot/user/print");
            mikrotik.Send("?=name=" + usser);
            mikrotik.Send(".tag=sss", true);

            var donenVeri = "";
            foreach (string h in mikrotik.Read())
            {
                donenVeri += h;
            }

            mikrotik.Close();

            if (donenVeri.Contains(usser))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string tanimliKullanici)
        {
            var ipAdresi = ipadresiAl();
            var user = _context.TCNOIS.Where(w => w.YATANHASTATCS == tanimliKullanici).ToList().FirstOrDefault();
            if (user != null)
            {
                string usser = tanimliKullanici;
                string pass = tanimliKullanici;               

                if (KullaniciVarmi(usser) == false)
                    KullaniciEkle(usser, pass);

                KullaniciyiAktifEt(usser, pass, ipAdresi);

                return Redirect("/Login/Index");
            }
            else
            {
                ViewData["Hata"] = "Girmiş Olduğunuz TC numarası sistemde bulunmamaktadır.";
                return View(ViewData["Hata"]);
            }
        }
    }
}