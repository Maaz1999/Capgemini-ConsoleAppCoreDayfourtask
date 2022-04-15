using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleAppCoreDayfourtask1.Models
{
    public partial class tempdbContext : DbContext
    {
        public tempdbContext()
        {
        }

        public tempdbContext(DbContextOptions<tempdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegDet> RegDet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=CASPER\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegDet>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__RegDet__CAF055CADC345569");

                entity.Property(e => e.Rid).ValueGeneratedNever();

                entity.Property(e => e.Contactno)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Mailid)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Skillset)
                    .HasColumnName("skillset")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
