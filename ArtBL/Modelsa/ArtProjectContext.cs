using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ArtDL.Modelsa
{
    public partial class ArtProjectContext : DbContext
    {
        public ArtProjectContext()
        {
        }

        public ArtProjectContext(DbContextOptions<ArtProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommentsGaleryJunior> CommentsGaleryJuniors { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<GaleryJunior> GaleryJuniors { get; set; } = null!;
        public virtual DbSet<GaleryMaster> GaleryMasters { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-783IDMP\\SQLEXPRESS;Database=ArtProject;Trusted_Connection=True;encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommentsGaleryJunior>(entity =>
            {
                entity.ToTable("CommentsGaleryJunior");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommentsGaleryJuniors)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__COMMENTSG__UserI__440B1D61");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DetaIls).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<GaleryJunior>(entity =>
            {
                entity.ToTable("GaleryJunior");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GaleryJuniors)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__GLERYGUNU__UserI__3F466844");
            });

            modelBuilder.Entity<GaleryMaster>(entity =>
            {
                entity.ToTable("GaleryMaster");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GaleryMasters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__GLERYMAST__UserI__3C69FB99");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Desc).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
