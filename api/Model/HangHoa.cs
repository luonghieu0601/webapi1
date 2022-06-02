using System;

namespace api.Model
{
    public class HangHoaVM 
    {
        public string Name { get; set; }
        public double DonGia { get; set; }
    }

    public class Hanghoa : HangHoaVM
    {
        public int ID { get; set; }
    }
}
