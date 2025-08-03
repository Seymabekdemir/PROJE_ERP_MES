namespace AkplusUretımSiparisWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Siparis
    {
        [Key]
        public string SiparisNo { get; set; }

        public string SiparisAcıklaması { get; set; }
        public DateTime? SiparisOT { get; set; }
        public string SiparisTuru { get; set; }
        public string SiparisDurumu { get; set; }
        public DateTime? SiparisSTT { get; set; }
        public int SiparisMiktarı { get; set; }
        public string Olusturan { get; set; }

        public string CihazId { get; set; }
        public Cihaz Cihaz { get; set; }
    }
}