using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RentOfMall
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Mall> Mall { get; set; }
        public virtual DbSet<Pavilion> Pavilion { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Renter> Renter { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ID_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.NameMall)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Sity)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Pavilion)
                .WithRequired(e => e.Mall)
                .HasForeignKey(e => e.IDMall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Mall)
                .HasForeignKey(e => e.ID_Mall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pavilion>()
                .Property(e => e.NumberPavilion)
                .IsUnicode(false);

            modelBuilder.Entity<Pavilion>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Pavilion>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Pavilion)
                .HasForeignKey(e => e.ID_Pavilion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Rent>()
                .HasMany(e => e.Renter1)
                .WithOptional(e => e.Rent1)
                .HasForeignKey(e => e.ID_Rent);

            modelBuilder.Entity<Renter>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Renter>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Renter>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Renter)
                .HasForeignKey(e => e.ID_Renter)
                .WillCascadeOnDelete(false);
        }
    }
}
