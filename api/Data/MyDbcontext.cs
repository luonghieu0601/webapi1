using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext()
        {
        }

        public MyDbcontext (DbContextOptions option) : base(option)
        { }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        // fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(e =>
            {
                e.ToTable("DonHang");
                e.HasKey(dh => dh.MaDH);
                e.Property(dh => dh.NgayDat).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.NguoiNhan).IsRequired().HasMaxLength(50);

            });
            modelBuilder.Entity<DonHangChiTiet>(entity =>
            {
                entity.ToTable("ChiTietDonHang");
                entity.HasKey(e => new {e.MaDH, e.ID});
                entity.HasOne(e => e.DonHang)
                    .WithMany(e => e.DonHangChiTiets)
                    .HasForeignKey(e => e.MaDH)
                    .HasConstraintName("FK_DonHangCT_DonHang");

                
                
                entity.HasOne(e => e.HangHoa)
                    .WithMany(e => e.DonHangChiTiets)
                    .HasForeignKey(e => e.ID)
                    .HasConstraintName("FK_DonHangCT_HangHoa");

            });
        }
    }
}
