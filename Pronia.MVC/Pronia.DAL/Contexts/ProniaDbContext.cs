using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;

namespace Pronia.DAL.Contexts
{
    public class ProniaDbContext :DbContext
    {
        public DbSet<SliderItem> SliderItems { get; set; }
        public ProniaDbContext(DbContextOptions<ProniaDbContext> opt): base (opt)
        {
           
        }
        //public readonly string _conectionString = "Server=DESKTOP-9OJ3NSG\\SQLEXPRESS;DATABASE=proniap;Trusted_Connection=True;TrustServerCertificate=True;";

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_conectionString);
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
