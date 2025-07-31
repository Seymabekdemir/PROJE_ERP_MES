using Microsoft.EntityFrameworkCore;
using AkplusUretımSiparisWebApp.Models;

namespace AkplusUretımSiparisWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Cihaz> Cihazlar { get; set; }

        // İlişkiler tanımlanacaksa buraya eklenebilir
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Siparis>()
                .HasOne(s => s.Cihaz)
                .WithMany(c => c.Siparisler)
                .HasForeignKey(s => s.CihazId);
        }
    }
}
