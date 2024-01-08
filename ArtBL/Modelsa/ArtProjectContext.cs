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

        public virtual DbSet<Commentsgaleryjunior> Commentsgaleryjuniors { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Glerygunure> Glerygunures { get; set; } = null!;
        public virtual DbSet<Glerymaster> Glerymasters { get; set; } = null!;
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
            modelBuilder.Entity<Commentsgaleryjunior>(entity =>
            {
                entity.ToTable("COMMENTSGALERYJUNIOR");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Commentsgaleryjuniors)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__COMMENTSG__UserI__440B1D61");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("CONTACTS");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DetaIls).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Glerygunure>(entity =>
            {
                entity.ToTable("GLERYGUNURES");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Glerygunures)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__GLERYGUNU__UserI__3F466844");
            });

            modelBuilder.Entity<Glerymaster>(entity =>
            {
                entity.ToTable("GLERYMASTER");

                entity.Property(e => e.Desc).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Glerymasters)
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
                entity.ToTable("USERS");

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
