using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int ID { get; set; }
        [Required]

        public string Name { get; set; }

        public double DonGia { get; set; }

        public int? IDLoai { get; set; }
        [ForeignKey("IDLoai")]
        public Loai Loai { get; set; }
        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public HangHoa()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }

        public void PrintInfo() => Console.WriteLine($"{ID} - {Name} - {DonGia} ");
    }
}
