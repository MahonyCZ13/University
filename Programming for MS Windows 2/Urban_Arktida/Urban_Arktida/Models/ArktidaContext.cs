using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Urban_Arktida.Models
{
    public partial class ArktidaContext : DbContext
    {
        public ArktidaContext()
        {
        }

        public ArktidaContext(DbContextOptions<ArktidaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mesta> Mesta { get; set; }
        public virtual DbSet<Staty> Staty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Arktida;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesta>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK__mesta__DF5032ECCF845E31");

                entity.ToTable("mesta");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Nazev)
                    .HasColumnName("nazev")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Obyvatele).HasColumnName("obyvatele");

                entity.Property(e => e.Rozloha).HasColumnName("rozloha");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Mesta)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mesta__cid__2D27B809");
            });

            modelBuilder.Entity<Staty>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__staty__D837D05FB161DD5E");

                entity.ToTable("staty");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Nazev)
                    .HasColumnName("nazev")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Obyvatelstvo).HasColumnName("obyvatelstvo");

                entity.Property(e => e.Rozloha).HasColumnName("rozloha");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
