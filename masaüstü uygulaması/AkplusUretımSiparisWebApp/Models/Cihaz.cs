namespace AkplusUretımSiparisWebApp.Models
{
    public class Cihaz
    {
        public string CihazId { get; set; }
        public string CihazTuru { get; set; }
        public string CihazAdı { get; set; }

        // bir tane cihazın birden fazla siparişte kullanabileceğim için bu yapıyla tanımlıyorum
        //one-to-many relationship
        public ICollection<Siparis> Siparisler { get; set; }
    }
}
