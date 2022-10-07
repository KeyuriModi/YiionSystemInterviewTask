using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Students.Models
{
    public partial class StudentsContext : DbContext
    {
        public StudentsContext()
        {
        }

        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Hobby> Hobbies { get; set; }
        public virtual DbSet<Stud> Studs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3SQQOJJ;Database=Students;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hobby>(entity =>
            {
                entity.ToTable("Hobby");

                entity.Property(e => e.HobbyId).HasColumnName("HobbyID");

                entity.Property(e => e.HobbyName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__Student__4D11D65C0C55CE59");

                entity.ToTable("Stud");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HobbyId).HasColumnName("HobbyID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentImage).IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Studs)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK__Student__BranchI__29572725");

                entity.HasOne(d => d.Hobby)
                    .WithMany(p => p.Studs)
                    .HasForeignKey(d => d.HobbyId)
                    .HasConstraintName("FK__Student__HobbyID__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
