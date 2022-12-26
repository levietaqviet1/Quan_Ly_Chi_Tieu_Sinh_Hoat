using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace TinhTienSinhHoat.Models
{
    public partial class QuanLyChiTieuContext : DbContext
    {
        public QuanLyChiTieuContext()
        {
        }

        public QuanLyChiTieuContext(DbContextOptions<QuanLyChiTieuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTieu> ChiTieus { get; set; } = null!;
        public virtual DbSet<LoaiChiTieu> LoaiChiTieus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTieu>(entity =>
            {
                entity.ToTable("ChiTieu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GiaTien).HasColumnName("gia_tien");

                entity.Property(e => e.LoaiChiTieuId).HasColumnName("loai_chi_tieu_id");

                entity.Property(e => e.MucDichChiTieu).HasColumnName("muc_dich_chi_tieu");

                entity.Property(e => e.ThoiGian)
                    .HasColumnType("date")
                    .HasColumnName("thoi_gian");

                entity.HasOne(d => d.LoaiChiTieu)
                    .WithMany(p => p.ChiTieus)
                    .HasForeignKey(d => d.LoaiChiTieuId)
                    .HasConstraintName("FK_ChiTieu_LoaiChiTieu");
            });

            modelBuilder.Entity<LoaiChiTieu>(entity =>
            {
                entity.ToTable("LoaiChiTieu");

                entity.Property(e => e.LoaiChiTieuId).HasColumnName("loai_chi_tieu_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.TenChiTieu)
                    .HasMaxLength(50)
                    .HasColumnName("ten_chi_tieu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
