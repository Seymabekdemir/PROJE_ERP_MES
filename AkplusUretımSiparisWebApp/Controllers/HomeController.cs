using System.Diagnostics;
using AkplusUretımSiparisWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AkplusUretımSiparisWebApp.Data;
using AkplusUretımSiparisWebApp.Models;

namespace AkplusUretımSiparisWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context; // EKLENDİ

        // Constructor
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context; // EKLENDİ
        }

        [HttpPost]
        public IActionResult Guncelle(string SiparisNo, string YeniDurum)
        {
            if (string.IsNullOrEmpty(SiparisNo) || string.IsNullOrEmpty(YeniDurum))
            {
                return RedirectToAction("Index");
            }

            var siparis = _context.Siparisler.FirstOrDefault(s => s.SiparisNo == SiparisNo);
            if (siparis != null)
            {
                siparis.SiparisDurumu = YeniDurum;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Index(List<string> durumlar)
        {
            var viewModel = new SiparisFiltreViewModel();

            var query = _context.Siparisler
                .Include(s => s.Cihaz)
                .AsQueryable();

            if (durumlar != null && durumlar.Any())
            {
                query = query.Where(s => durumlar.Contains(s.SiparisDurumu));
                viewModel.SecilenDurumlar = durumlar;
            }
            else
            {
                viewModel.SecilenDurumlar = new List<string>();
            }

            viewModel.Siparisler = query.ToList();

            return View(viewModel);
        }
    }
}