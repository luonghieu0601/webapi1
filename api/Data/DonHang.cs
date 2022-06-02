using System;
using System.Collections.Generic;

namespace api.Data
{
    public enum TinhTrangDonDatHang
    {
        New = 0, Payment = 1, Complete = 2, Cancel = -1
    }
    public class DonHang
    {
        public int MaDH { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? dateTime { get; set; } 
        public TinhTrangDonDatHang TinhTrangDonhang { get; set; }
        public string NguoiNhan { get; set; }    
        public string DiaChiGiao { get; set; }
        public string SDT { get; set; }
        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DonHang()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }

    }
}
