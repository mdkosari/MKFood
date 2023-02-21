using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MKFood.DB;
using MKFood.DB.Models;
using System.Formats.Asn1;

namespace MKFood
{
    public partial class FoodMenuControler : UserControl
    {
        public FoodMenuControler()
        {
            InitializeComponent();
            LoadFoods();
        }

        public async void LoadFoods()
        {
            using var host = Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) =>
             {
                 var connectionString = Variables.ConnectionString;
                 services.AddDbContext<MKFoodContext>(options =>
                 {
                     options.UseSqlServer(connectionString);
                 });
                 services.AddScoped<DBHelper>();
             }).Build();
            using var scope = host.Services.CreateScope();
            var dbHelper = scope.ServiceProvider.GetRequiredService<DBHelper>();
            List<Food> foods = await dbHelper.AllFood();
            double price = 0;
            label1.Text = " " + foods.Count;
            foreach (Food food in foods)
            {
                while (food.Prices.GetEnumerator().MoveNext()) {
                    if (!food.Prices.GetEnumerator().Current.Expierd)
                    {
                        price = food.Prices.GetEnumerator().Current.Cost;
                        break;
                    }
                }

                FoodMenuListFLP.Controls.Add(new FoodItemControl(food.Name, food.Description, food.Picture, price));
            }
            
        }

        private void FoodMenuControler_Load(object sender, EventArgs e)
        {

        }

       

        private async void FoodMenuAddItemBtn_Click(object sender, EventArgs e)
        {
            
            new AddNewFood().ShowDialog();

        }

        private void foodItemControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
