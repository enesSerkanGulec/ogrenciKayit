using Microsoft.EntityFrameworkCore;

namespace ogrenciKayit.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server = localhost; User ID = root; Password = 12345678; Database = ogrenciKayit;ssl mode=none");
        }
        public DbSet<Ogrenci> Ogrenci { get; set; }


    }


}
