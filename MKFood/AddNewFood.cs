

using Microsoft.Extensions.Hosting;
using MKFood.DB;
using MKFood.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MKFood
{
    public partial class AddNewFood : Form
    {

        public AddNewFood()
        {
            InitializeComponent();
            LoadCats();
        }

        private async void LoadCats()
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
            List<Category> cats = await dbHelper.AllCategory();
            foreach (var category in cats)
            {
                FoodDialogCategoryCB.Items.Add(category.Name);
            }
        }


        private async void AddFood()
        {
            string name = FoodDialogNameTB.Text;
            string des = FoodDialogDesTB.Text;
            string pic = FoodDialogPic.ImageLocation?? "burger.png";
            double price = Convert.ToDouble(FoodDialogPriceTB.Text);

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
            string cat = (string)FoodDialogCategoryCB.SelectedItem;
            Category? category = await dbHelper.ByNameCategory(cat);
            Food food = await dbHelper.AddFood(name, des, category, pic);
            _ = dbHelper.AddPrice(price, food);
        }

      

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodItemPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg)|*.png;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                try
                {
                    FoodDialogPic.Image = Image.FromFile(selectedFileName);
                }catch(Exception)
                {
                }
                //...
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

 

        private async void FoodDialogAddCatBtn_Click(object sender, EventArgs e)
        {
            //Connect To DB
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

            string newCat = FoodDialogCategoryCB.Text;
            Category category = await dbHelper.AddCategory(newCat);
            FoodDialogCategoryCB.Items.Add(category.Name);
        }

        private void FoodDialogSaveBtn_Click(object sender, EventArgs e)
        {
            AddFood();
        }
    }
}
