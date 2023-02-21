using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MKFood.DB;
using MKFood.DB.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.ComponentModel;

namespace MKFood
{
    public partial class Main : Form
    {

        Process myProcess;
        DBHelper? dbHelper;

        public Main()
        {
            InitializeComponent();

            //initial Show Home User Control
            SlidePanelMain.Height = HomeBtn.Height;//set side bar location
            homeControl1.BringToFront();

            //initial Open Browser
            myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;

            //initalize Databse
            InitialDB();           
        }

        private async void InitialDB()
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
            dbHelper = scope.ServiceProvider.GetRequiredService<DBHelper>();

            //Create Database
            string res = await dbHelper.CreateTheDatabaseAsync();
        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {

            SlidePanelMain.Height = HomeBtn.Height;
            SlidePanelMain.Top = HomeBtn.Top;
            homeControl1.BringToFront();


        }

        private void MenuFoodBtn_Click(object sender, EventArgs e)
        {
            SlidePanelMain.Height = MenuFoodBtn.Height;
            SlidePanelMain.Top = MenuFoodBtn.Top;
            foodMenuControler.BringToFront();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodMenuControler_Load(object sender, EventArgs e)
        {

        }

        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            Form name = new AddNewFood();
            name.ShowDialog();
        }

        private void InstagramBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess.StartInfo.FileName = "https://www.instagram.com/mdkosari/";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void GithubBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess.StartInfo.FileName = "https://github.com/mdkosari";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LinkedinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess.StartInfo.FileName = "https://www.linkedin.com/in/mdkosari/";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}