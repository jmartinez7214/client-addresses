using clients_addresses.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace clients_addresses.Data
{
    public class CompanyXDbContext : DbContext
    {
        public CompanyXDbContext(DbContextOptions<CompanyXDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(b => b.ClientAddresses)
                .WithOne(b => b.Client)
                .HasForeignKey(b => b.ClientId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClientAddress>();

            modelBuilder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id = 1,
                        FirstName = "Samuel",
                        LastName = "Polanco",
                    },
                    new Client
                    {
                        Id = 2,
                        FirstName = "Juan",
                        LastName = "Perez",
                    },
                    new Client
                    {
                        Id = 3,
                        FirstName = "Francisco",
                        LastName = "Rivera",
                    }
                );

            modelBuilder.Entity<ClientAddress>()
                .HasData(
                    new ClientAddress
                    {
                        Id = 1,
                        Address = "558 Henry Smith St., Southfield, MI 48076",
                        ClientId = 1,
                    },
                    new ClientAddress
                    {
                        Id = 2,
                        Address = "174 Prince Street, Hickory, NC 28601",
                        ClientId = 1,
                    },
                    new ClientAddress
                    {
                        Id = 3,
                        Address = "58 River St., Findlay, OH 45840",
                        ClientId = 2,
                    },
                    new ClientAddress
                    {
                        Id = 4,
                        Address = "7387 Myers Ave., Saint Joseph, MI 49085",
                        ClientId = 2,
                    },
                    new ClientAddress
                    {
                        Id = 5,
                        Address = "8228 Philmont Ave., Marshalltown, IA 50158",
                        ClientId = 2,
                    },
                    new ClientAddress
                    {
                        Id = 6,
                        Address = "7531 Thompson Drive, New York, NY 10002",
                        ClientId = 2,
                    },
                    new ClientAddress
                    {
                        Id = 7,
                        Address = "60 Dogwood Street, Vicksburg, MS 39180",
                        ClientId = 3,
                    },
                    new ClientAddress
                    {
                        Id = 8,
                        Address = "13 Alton St., South Richmond Hill, NY 11419",
                        ClientId = 3,
                    },
                    new ClientAddress
                    {
                        Id = 9,
                        Address = "7626 E. Armstrong Lane, Dickson, TN 37055",
                        ClientId = 3,
                    }
                );
        }

        public DbSet<Client>? Clients { get; set; }
        public DbSet<ClientAddress>? ClientAddresses { get; set; }
    }
}
