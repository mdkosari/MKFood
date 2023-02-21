
using Microsoft.EntityFrameworkCore;

namespace MKFood.DB.Models
{

    public class MKFoodContext : DbContext
    {
        public MKFoodContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        private const string ConnectionString =Variables.ConnectionString;

        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Bill> Bills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("mc")
                .ApplyConfiguration(new CategoryConfiguration())
                .ApplyConfiguration(new FoodConfiguration())
                .ApplyConfiguration(new PriceConfiguration())
                .ApplyConfiguration(new CustomerConfiguration())
                .ApplyConfiguration(new OrderConfiguration())
                .ApplyConfiguration(new BillConfiguration());
        }


        // Shadow Properties
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.DetectChanges();

            //Food
            foreach (var item in ChangeTracker.Entries<Food>()
            .Where(e => e.State == EntityState.Added
            || e.State == EntityState.Modified))
            {
                item.CurrentValues["LastUpdated"] = DateTime.Now;
                
            }

            //Category
            foreach (var item in ChangeTracker.Entries<Category>()
            .Where(e => e.State == EntityState.Added
            || e.State == EntityState.Modified))
            {
                item.CurrentValues["LastUpdated"] = DateTime.Now;

            }

            //Bill
            foreach (var item in ChangeTracker.Entries<Bill>()
            .Where(e => e.State == EntityState.Added
            || e.State == EntityState.Modified))
            {
                item.CurrentValues["LastUpdated"] = DateTime.Now;

            }

            //Price
            foreach (var item in ChangeTracker.Entries<Price>()
            .Where(e => e.State == EntityState.Added
            || e.State == EntityState.Modified))
            {
                item.CurrentValues["LastUpdated"] = DateTime.Now;

            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
