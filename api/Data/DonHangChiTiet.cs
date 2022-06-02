namespace api.Data
{
    public class DonHangChiTiet
    {
        public int MaDH { get; set; } // id đơn hàng
        public int ID { get; set; } // id hàng hóa
        public int SoLuong { get; set; }
        
        public double DonGia { get; set; }  
        //relationship
        public DonHang DonHang { get; set; }
        public HangHoa HangHoa { get; set; }

    }
}
