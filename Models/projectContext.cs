using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_01.Models
{
    public partial class projectContext : DbContext
    {
        public projectContext()
        {
        }

        public projectContext(DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StuId);

                entity.ToTable("STUDENT");

                entity.Property(e => e.StuId)
                    .HasMaxLength(20)
                    .HasColumnName("STU_ID");

                entity.Property(e => e.StuBirthday)
                    .HasColumnType("datetime")
                    .HasColumnName("STU_BIRTHDAY");

                entity.Property(e => e.StuEmail)
                    .HasMaxLength(50)
                    .HasColumnName("STU_EMAIL");

                entity.Property(e => e.StuGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STU_GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.StuIdno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STU_IDNO");

                entity.Property(e => e.StuNameC)
                    .HasMaxLength(50)
                    .HasColumnName("STU_NAME_C");

                entity.Property(e => e.StuNameE)
                    .HasMaxLength(50)
                    .HasColumnName("STU_NAME_E");

                entity.Property(e => e.StuYear)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("STU_YEAR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
