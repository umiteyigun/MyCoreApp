using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCoreApp.Models
{
    public partial class UsersInfo 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Tc { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [EmailAddress]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{2,4}")]
        [Display(Name = "Eposta Adresi", Prompt = "example@example.org")]
        public string Email { get; set; }
        public string Address { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Username { get; set; }
        public string Packet { get; set; }
        public string Accesspoint { get; set; }
        public string Ftipi { get; set; }
        public string Osifre { get; set; }
        public string Adurum { get; set; }
        public string Sabitip { get; set; }
        public string Atipi { get; set; }
        public int? Pasaportno { get; set; }
        public string Unvan { get; set; }
        public int? Vergino { get; set; }
        public string Cinsiyet { get; set; }
        public string Uyruk { get; set; }
        public string Babaadi { get; set; }
        public string Anaadi { get; set; }
        public string Anakizliksoyadi { get; set; }
        public string Dogumyeri { get; set; }
        
        [DisplayFormat(DataFormatString="{0:d}", NullDisplayText = "Dogum Tarihi Girilmemiş")]
        public string Dogumtarihi { get; set; }
        public string Meslek { get; set; }
        public int? Ciltno { get; set; }
        public int? Kutukno { get; set; }
        public int? Sayfano { get; set; }
        public string Kil { get; set; }
        public string Kilce { get; set; }
        public string Mahkoy { get; set; }
        public string Ktipi { get; set; }
        public string Kserino { get; set; }
        public string Kverildigiyer { get; set; }
        public string Kverildigitarih { get; set; }
        public string Ksahibi { get; set; }
        public string Til { get; set; }
        public string Tilce { get; set; }
        public string Tmahalle { get; set; }
        public string Tcadde { get; set; }
        public string Tdiskapino { get; set; }
        public string Tickapino { get; set; }
        public int? Tpostano { get; set; }
        public int? Tadresno { get; set; }
        public string Vergidairesi { get; set; }
        public string TanimliKullanici { get; set; }
        public string TanimliKullaniciSifre { get; set; }
    }
}
