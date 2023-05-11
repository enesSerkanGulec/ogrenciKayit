using System.ComponentModel.DataAnnotations;

namespace ogrenciKayit.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Ad { get; set; }
        [MaxLength(30)]
        public string Soyad { get; set; }
       
        public int Numara { get; set; }
        [MaxLength(20)]
        public string Sinif { get; set; }
        [MaxLength(20)]
        public string Bolum { get; set; }
    }
}
