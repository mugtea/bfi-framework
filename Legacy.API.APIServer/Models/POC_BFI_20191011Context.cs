using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Legacy.API.APIServer.Models
{
    public partial class POC_BFI_20191011Context : DbContext
    {
        public POC_BFI_20191011Context()
        {
        }

        public POC_BFI_20191011Context(DbContextOptions<POC_BFI_20191011Context> options)
            : base(options)
        {
        }

        public virtual DbSet<PocBfiAddressDetail> PocBfiAddressDetail { get; set; }
        public virtual DbSet<PocBfiCustomer> PocBfiCustomer { get; set; }
        public virtual DbSet<PocBfiCustomerContact> PocBfiCustomerContact { get; set; }
        public virtual DbSet<PocBfiCustomerStatus> PocBfiCustomerStatus { get; set; }
        public virtual DbSet<PocBfiLeadsInfo> PocBfiLeadsInfo { get; set; }
        public virtual DbSet<PocBfiProduct> PocBfiProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.100.10.122;Database=POC_BFI_20191011;UID=sa;password=Indocyber.100;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PocBfiAddressDetail>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("POC_BFI_AddressDetail");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.CityKabupaten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HouseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kecamatan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kelurahan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province).IsUnicode(false);

                entity.Property(e => e.Rt)
                    .HasColumnName("RT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rw)
                    .HasColumnName("RW")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PocBfiAddressDetail)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_POC_BFI_AddressDetail_POC_BFI_Customer");
            });

            modelBuilder.Entity<PocBfiCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("POC_BFI_Customer");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeadsId).HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaPromotion).IsUnicode(false);

                entity.Property(e => e.MotherMaidenName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npwpnumber)
                    .HasColumnName("NPWPNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth).IsUnicode(false);

                entity.Property(e => e.ReferralName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfLeads)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerContact)
                    .WithMany(p => p.PocBfiCustomer)
                    .HasForeignKey(d => d.CustomerContactId)
                    .HasConstraintName("FK_POC_BFI_Customer_POC_BFI_CustomerContact");

                entity.HasOne(d => d.Leads)
                    .WithMany(p => p.PocBfiCustomer)
                    .HasForeignKey(d => d.LeadsId)
                    .HasConstraintName("FK_POC_BFI_Customer_POC_BFI_LeadsInfo");
            });

            modelBuilder.Entity<PocBfiCustomerContact>(entity =>
            {
                entity.HasKey(e => e.CustomerContactId);

                entity.ToTable("POC_BFI_CustomerContact");

                entity.Property(e => e.CodeArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PocBfiCustomerStatus>(entity =>
            {
                entity.ToTable("POC_BFI_CustomerStatus");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<PocBfiLeadsInfo>(entity =>
            {
                entity.HasKey(e => e.LeadsId);

                entity.ToTable("POC_BFI_LeadsInfo");

                entity.Property(e => e.LeadsId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeadsStatusExternal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeadsStatusInternal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PocBfiProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("POC_BFI_Product");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });
        }
    }
}
