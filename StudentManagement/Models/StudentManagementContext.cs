using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace StudentManagement.Models
{
    public partial class StudentManagementContext : DbContext
    {
        public StudentManagementContext()
        {
        }

        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DayHoc> DayHocs { get; set; }
        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<LopHocSinhVien> LopHocSinhViens { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<ThoiKhoaBieu> ThoiKhoaBieus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("StudentManagement"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DayHoc>(entity =>
            {
                entity.HasKey(e => e.MaDayHoc)
                    .HasName("PK__DayHoc__076A0A7FE8E0E05F");

                entity.ToTable("DayHoc");

                entity.Property(e => e.MaDayHoc).ValueGeneratedNever();

                entity.Property(e => e.MaGv)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MaGV");

                entity.Property(e => e.MaLop)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.DayHocs)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DayHoc__MaGV__47DBAE45");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.DayHocs)
                    .HasForeignKey(d => d.MaLop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DayHoc__MaLop__45F365D3");

                entity.HasOne(d => d.MaMonHocNavigation)
                    .WithMany(p => p.DayHocs)
                    .HasForeignKey(d => d.MaMonHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DayHoc__MaMonHoc__46E78A0C");
            });

            modelBuilder.Entity<Diem>(entity =>
            {
                entity.HasKey(e => new { e.MaSv, e.MaMonHoc })
                    .HasName("PK__Diem__C3377F2D6221FBB9");

                entity.ToTable("Diem");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MaSV");

                entity.Property(e => e.Diem1).HasColumnName("Diem");

                entity.HasOne(d => d.MaMonHocNavigation)
                    .WithMany(p => p.Diems)
                    .HasForeignKey(d => d.MaMonHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Diem__MaMonHoc__4316F928");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.Diems)
                    .HasForeignKey(d => d.MaSv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Diem__MaSV__4222D4EF");
            });

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.HasKey(e => e.MaGv)
                    .HasName("PK__GiangVie__2725AEF36DBA095E");

                entity.ToTable("GiangVien");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MaGV");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LopHoc>(entity =>
            {
                entity.HasKey(e => e.MaLop)
                    .HasName("PK__LopHoc__3B98D27393608EEB");

                entity.ToTable("LopHoc");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LopHocSinhVien>(entity =>
            {
                entity.HasKey(e => new { e.MaLop, e.MaSv })
                    .HasName("PK__LopHoc_S__89EA82F21B399FFF");

                entity.ToTable("LopHoc_SinhVien");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaSv)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MaSV");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.LopHocSinhViens)
                    .HasForeignKey(d => d.MaLop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHoc_Si__MaLop__3F466844");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.LopHocSinhViens)
                    .HasForeignKey(d => d.MaSv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHoc_Sin__MaSV__3E52440B");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMonHoc)
                    .HasName("PK__MonHoc__4127737FB4A99009");

                entity.ToTable("MonHoc");

                entity.Property(e => e.MaMonHoc).ValueGeneratedNever();

                entity.Property(e => e.TenMonHoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SinhVien__2725081A3BB4D076");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MaSV");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThoiKhoaBieu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ThoiKhoaBieu");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.HasOne(d => d.MaDayHocNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaDayHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThoiKhoaB__MaDay__49C3F6B7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
