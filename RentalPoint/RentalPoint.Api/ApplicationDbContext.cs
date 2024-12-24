using Microsoft.EntityFrameworkCore;
using RentalPoint.Api.Models;

namespace RentalPoint.Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            if(Database.IsRelational())
            {
                Database.Migrate();
            }
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Discounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rental>()
                .HasOne(r => r.Client)
                .WithMany(c => c.Rentals)
                .HasForeignKey(r => r.ClientId);

            modelBuilder.Entity<Rental>()
                .HasOne(r => r.Item)
                .WithMany(i => i.Rentals)
                .HasForeignKey(r => r.ItemId);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Category)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CategoryId);

            var categories = new[]
            {
                new Category { Id = Guid.Parse("d6f1e1d6-41f9-4b5e-9aeb-9d6b657b5c1a"), Name = "Electronics" },
                new Category { Id = Guid.Parse("b6ab5de6-8f1f-4dd4-8e14-b7f5b7e6c0ab"), Name = "Furniture" },
                new Category { Id = Guid.Parse("f8a7d5e4-1e8b-4d56-8a0a-8e5f6c7d7c8d"), Name = "Tools" },
                new Category { Id = Guid.Parse("b1c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"), Name = "Outdoor" },
                new Category { Id = Guid.Parse("b9c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"), Name = "Sports" },
                new Category { Id = Guid.Parse("a3c8e5d5-3f42-4c77-ae5c-1c9e1e4d3b8e"), Name = "Toys" },
                new Category { Id = Guid.Parse("c5e8a1b6-4d7f-4b8e-9d6b-4c1e6b8a8f2c"), Name = "Books" }
            };
            modelBuilder.Entity<Category>().HasData(categories);

            var clients = new[]
            {
                new Client { Id = Guid.Parse("f4a1b2c3-d4e5-6789-abcd-ef0123456789"), FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
                new Client { Id = Guid.Parse("4b3e2a1c-5d6f-7890-a1b2-c3d4e5f67890"), FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "098-765-4321" },
                new Client { Id = Guid.Parse("f9a8b7c6-d5e4-3f2a-1b0c-9e8f7a6b5c4d"), FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", PhoneNumber = "234-567-8901" },
                new Client { Id = Guid.Parse("c1a2b3d4-e5f6-7890-a1b2-c3d4e5f67890"), FirstName = "Bob", LastName = "Brown", Email = "bob.brown@example.com", PhoneNumber = "345-678-9012" },
                new Client { Id = Guid.Parse("d4e5f6a7-b8c9-0a1b-2c3d-4e5f6a7b8c9d"), FirstName = "Charlie", LastName = "Davis", Email = "charlie.davis@example.com", PhoneNumber = "456-789-0123" },
                new Client { Id = Guid.Parse("f1e2d3c4-b5a6-7890-a1b2-c3d4e5f67890"), FirstName = "Diana", LastName = "Evans", Email = "diana.evans@example.com", PhoneNumber = "567-890-1234" },
                new Client { Id = Guid.Parse("e1f2c3b4-a5d6-7890-b1c2-d3e4f5a6b7c8"), FirstName = "Edward", LastName = "Wilson", Email = "edward.wilson@example.com", PhoneNumber = "678-901-2345" }
            };
            modelBuilder.Entity<Client>().HasData(clients);

            var items = new[]
            {
                new Item { Id = Guid.Parse("f2b3c4d5-e6f7-89a0-b1c2-d3e4f5a6b7c8"), Name = "Laptop", Description = "A high-performance laptop.", Price = 1200.00m, IsRented = false, CategoryId = categories[0].Id },
                new Item { Id = Guid.Parse("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), Name = "Chair", Description = "A comfortable office chair.", Price = 150.00m, IsRented = false, CategoryId = categories[1].Id },
                new Item { Id = Guid.Parse("c1d2e3f4-a5b6-7890-a1b2-c3d4e5f67890"), Name = "Drill", Description = "A powerful electric drill.", Price = 100.00m, IsRented = false, CategoryId = categories[2].Id },
                new Item { Id = Guid.Parse("b2c3d4e5-a6f7-89a0-b1c2-d3e4f5a6b7c8"), Name = "Tent", Description = "A waterproof camping tent.", Price = 300.00m, IsRented = false, CategoryId = categories[3].Id },
                new Item { Id = Guid.Parse("e1f2c3a4-b5c6-7890-a1b2-c3d4e5f67890"), Name = "Soccer Ball", Description = "A regulation soccer ball.", Price = 25.00m, IsRented = false, CategoryId = categories[4].Id },
                new Item { Id = Guid.Parse("f2b3c4d5-e5f6-7890-a1b2-c3d4e5f67890"), Name = "Action Figure", Description = "A collectible action figure.", Price = 15.00m, IsRented = false, CategoryId = categories[5].Id },
                new Item { Id = Guid.Parse("c2d3e4f5-a6b7-8901-a1b2-c3d4e5f67890"), Name = "Cookbook", Description = "A cookbook for home chefs.", Price = 30.00m, IsRented = false, CategoryId = categories[6].Id }
            };
            modelBuilder.Entity<Item>().HasData(items);

            var events = new[]
            {
                new Event { Id = Guid.Parse("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67890"), Description = "New Year Discount", StartDate = new DateTime(2024, 1, 1), EndDate = new DateTime(2024, 1, 31) },
                new Event { Id = Guid.Parse("a4b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), Description = "Summer Sale", StartDate = new DateTime(2024, 6, 1), EndDate = new DateTime(2024, 6, 30) },
                new Event { Id = Guid.Parse("b4c2d3e4-f5a6-7890-a1b2-c3d4e5f67890"), Description = "Black Friday Deals", StartDate = new DateTime(2024, 11, 1), EndDate = new DateTime(2024, 11, 30) },
                new Event { Id = Guid.Parse("c4d2e3f4-a5b6-7890-a1b2-c3d4e5f67890"), Description = "Christmas Sale", StartDate = new DateTime(2024, 12, 1), EndDate = new DateTime(2024, 12, 25) },
                new Event { Id = Guid.Parse("e7f2c3d4-b5c6-7890-a1b2-c3d4e5f67890"), Description = "Spring Clearance", StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2024, 3, 31) },
                new Event { Id = Guid.Parse("f2a2b3c4-d5e6-7890-a1b2-c3d4e5f67890"), Description = "Fall Specials", StartDate = new DateTime(2024, 9, 1), EndDate = new DateTime(2024, 9, 30) },
                new Event { Id = Guid.Parse("b3c2d3e4-f5a6-7890-a1b2-c3d4e5f67890"), Description = "Labor Day Sale", StartDate = new DateTime(2024, 9, 1), EndDate = new DateTime(2024, 9, 5) }
            };
            modelBuilder.Entity<Event>().HasData(events);

            var rentals = new[]
            {
                new Rental { Id = Guid.Parse("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67891"), ClientId = clients[0].Id, ItemId = items[1].Id},
                new Rental { Id = Guid.Parse("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67892"), ClientId = clients[3].Id, ItemId = items[1].Id},
                new Rental { Id = Guid.Parse("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67893"), ClientId = clients[1].Id, ItemId = items[4].Id}
            };
            modelBuilder.Entity<Rental>().HasData(rentals);
        }


    }


}
