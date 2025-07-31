namespace AkplusUretımSiparisWebApp.Models
{
    public class SiparisFiltreViewModel
    {
        public List<string> SecilenDurumlar { get; set; }
        public List<Siparis> Siparisler { get; set; }

        public List<string> TumDurumlar { get; set; } = new List<string>
    {
        "Yeni sipariş girildi.",
        "Sipariş üretimden onay bekliyor.",
        "Sipariş üretimde.",
        "Siparişin üretimi tamamlandı.",
        "Sipariş paketlemede.",
        "Sipariş kargoya hazır.",
        "Sipariş kargoya verildi.",
        "Sipariş alıcıya ulaştı.",
        "Sipariş tamamlandı."
    };
    }

}


