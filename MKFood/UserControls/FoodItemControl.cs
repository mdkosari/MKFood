using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKFood
{
    public partial class FoodItemControl : UserControl
    {
        public FoodItemControl(string name, string des, string pic, double price)
        {
            InitializeComponent();
            setData(name,des,pic,price);
        }

        private void setData(string name, string des, string pic, double price)
        {
            FoodItemName.Text = name;
            FoodItemDes.Text = des;
            //FoodItemPic.Image = Image.FromFile(pic);
            FoodItemPrice.Text = $"$ {price}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FoodItemAddMealBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
