using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CMS.Models
{
    public partial class CMSContext : DbContext
    {
        public CMSContext()
        {
        }

        public CMSContext(DbContextOptions<CMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminOffice> AdminOffices { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-FIB1T83F;Initial Catalog=CMS;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AId);

                entity.ToTable("Admin");

                entity.Property(e => e.AId)
                    .ValueGeneratedNever()
                    .HasColumnName("A_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OId).HasColumnName("O_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminOffice>(entity =>
            {
                entity.HasKey(e => e.AoId);

                entity.ToTable("Admin_Office");

                entity.Property(e => e.AoId)
                    .ValueGeneratedNever()
                    .HasColumnName("AO_id");

                entity.Property(e => e.AId).HasColumnName("A_id");

                entity.Property(e => e.OId).HasColumnName("O_id");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("Comment");

                entity.Property(e => e.ComId)
                    .ValueGeneratedNever()
                    .HasColumnName("Com_id");

                entity.Property(e => e.AId).HasColumnName("A_id");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Comment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SId).HasColumnName("S_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.ContactId).HasColumnName("Contact_Id");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo).HasColumnName("Phone_No");
            });

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("Courier");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("C_id");

                entity.Property(e => e.Docket)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OId).HasColumnName("O_id");

                entity.Property(e => e.SId).HasColumnName("S_id");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("Customer");

                entity.Property(e => e.CustId)
                    .ValueGeneratedNever()
                    .HasColumnName("Cust_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OId).HasColumnName("O_id");

                entity.Property(e => e.SId).HasColumnName("S_id");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.LId);

                entity.ToTable("Login");

                entity.Property(e => e.LId)
                    .ValueGeneratedNever()
                    .HasColumnName("L_id");

                entity.Property(e => e.AId).HasColumnName("A_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.OId);

                entity.ToTable("Office");

                entity.Property(e => e.OId)
                    .ValueGeneratedNever()
                    .HasColumnName("O_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasKey(e => e.SId);

                entity.ToTable("Shipment");

                entity.Property(e => e.SId)
                    .ValueGeneratedNever()
                    .HasColumnName("S_id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FromCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("From_city");

                entity.Property(e => e.ToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("To_city");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 9)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
