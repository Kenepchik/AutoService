using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoService.Models
{
    public partial class CarsServiceContext : DbContext
    {
        public CarsServiceContext()
        {
        }

        public CarsServiceContext(DbContextOptions<CarsServiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<CustomersCars> CustomersCars { get; set; }
        public virtual DbSet<Masters> Masters { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Services> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CarsService;Username=juzi;Password=qq");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.ToTable("cars");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasMaxLength(255);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ClientService>(entity =>
            {
                entity.ToTable("client_service");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientService)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("client_service_client_id_foreign");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ClientService)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("client_service_service_id_foreign");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnName("telephone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CustomersCars>(entity =>
            {
                entity.ToTable("customers_cars");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarsId).HasColumnName("cars_id");

                entity.Property(e => e.ClientsId).HasColumnName("clients_id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(255);

                entity.Property(e => e.LicensePlate)
                    .IsRequired()
                    .HasColumnName("license_plate")
                    .HasMaxLength(255);

                entity.Property(e => e.Mileage).HasColumnName("mileage");

                entity.Property(e => e.Vin).HasColumnName("VIN");

                entity.Property(e => e.YearIssue).HasColumnName("year_issue");

                entity.HasOne(d => d.Cars)
                    .WithMany(p => p.CustomersCars)
                    .HasForeignKey(d => d.CarsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customers_cars_cars_id_foreign");

                entity.HasOne(d => d.Clients)
                    .WithMany(p => p.CustomersCars)
                    .HasForeignKey(d => d.ClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customers_cars_clients_id_foreign");
            });

            modelBuilder.Entity<Masters>(entity =>
            {
                entity.ToTable("masters");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Seniority).HasColumnName("seniority");

                entity.Property(e => e.Specialization)
                    .IsRequired()
                    .HasColumnName("specialization")
                    .HasMaxLength(255);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnName("telephone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientServiceId).HasColumnName("client_service_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CustomersCarsId).HasColumnName("customers_cars_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("date");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClientService)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_client_service_id_foreign");

                entity.HasOne(d => d.CustomersCars)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomersCarsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_customers_cars_id_foreign");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.ToTable("services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Complexity).HasColumnName("complexity");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Guarantee).HasColumnName("guarantee");

                entity.Property(e => e.MastersId).HasColumnName("masters_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Masters)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.MastersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("services_masters_id_foreign");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
