using Microsoft.EntityFrameworkCore;
using MKFood.DB.Models;

namespace MKFood.DB
{
    public class DBHelper
    {
        private readonly MKFoodContext _context;
        public DBHelper(MKFoodContext mkFoodContext)
        {
            _context = mkFoodContext;
        }
        public async Task<string> CreateTheDatabaseAsync()
        {
            bool created = await _context.Database.EnsureCreatedAsync();
            string creationInfo = created ? "Database Created Successfully" : "Database Before exists";
            return creationInfo;
        }

        // Add Category
        public async Task<Category> AddCategory(string name)
        {
            Category category = new Category(name);
            await _context.Categories.AddAsync(category);
            int record = await _context.SaveChangesAsync();
            return category;
        }

        //Add Price
        public async Task<Price> AddPrice(double cost, Food food)
        {
            Price price = new Price(cost) { Food = food };
            await _context.Prices.AddAsync(price);
            await _context.SaveChangesAsync();

            return price;
        }

        //Add Fodd
        public async Task<Food> AddFood(string name, string des, Category cat, string pic = "defualt")
        {
            Food food = new Food(name, des, pic)
            {
                Category = cat
            };
            await _context.AddAsync(food);
            await _context.SaveChangesAsync();

            return food;
        }

        //Add Customer
        public async Task<Customer> AddCustomer(string name)
        {
            Customer customer = new Customer(name);

            await _context.AddAsync(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        //Add Bill
        public async Task<Bill> AddBill(Customer customer, bool success = false)
        {
            Bill bill = new Bill(success) { Customer = customer };
            await _context.AddAsync(bill);
            await _context.SaveChangesAsync();

            return bill;
        }

        //Add Order
        public async Task<Order> AddOrder(Food food, Bill bill, int count = 1)
        {
            Order order = new Order() { Food = food, Bill = bill, Count = count };
            await _context.AddAsync(order);
            await _context.SaveChangesAsync();

            return order;
        }

        //Rade All Category
        public async Task<List<Category>> AllCategory(CancellationToken token = default)
        {
            List<Category> categories = await _context.Categories.ToListAsync(token);
            return categories;
        }

        //Read By Name Category
        public async Task<Category?> ByNameCategory(string cat, CancellationToken token = default)
        {
            List<Category> category = await _context.Categories.Where(c => c.Name == cat).ToListAsync(token);
            return category[category.Count - 1];
        }

        //Read All Food
        public async Task<List<Food>> AllFood(CancellationToken token = default)
        {
            List<Food> foods = await _context.Foods.ToListAsync(token);
            return foods;
        }


        //Read All Bill
        public async Task<List<Bill>> ReadAllBill(CancellationToken token = default)
        {
            List<Bill> bills = await _context.Bills.ToListAsync(token);
            return bills;
        }

        //Read By Date Range Bill
        public async Task<List<Bill>> ByDateBill(DateTime start, DateTime end, CancellationToken tokeen = default)
        {
            List<Bill> bills = await _context.Bills.Where(b => b.Created > start && b.Created < end).ToListAsync(tokeen);
            return bills;
        }

        //Read By Customer Bill
        public async Task<List<Bill>> ByCustomerBill(Customer customer, CancellationToken token = default)
        {
            List<Bill> bills = await _context.Bills.Where(b => b.Customer == customer).ToListAsync(token);
            return bills;
        }

        //Update Food 
        public async Task<int> UpdateFood(Food food)
        {
            Food? find = await _context.Foods.FindAsync(food.FoodId);
            return -1;
        }
    }
}
