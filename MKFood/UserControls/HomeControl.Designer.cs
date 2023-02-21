namespace MKFood
{
    partial class HomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.home_poduct_price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.home_product_name = new System.Windows.Forms.Label();
            this.home_product_des = new System.Windows.Forms.Label();
            this.home_meal_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_poduct_price
            // 
            this.home_poduct_price.AutoSize = true;
            this.home_poduct_price.Font = new System.Drawing.Font("Franklin Gothic Medium", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_poduct_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.home_poduct_price.Location = new System.Drawing.Point(112, 126);
            this.home_poduct_price.Name = "home_poduct_price";
            this.home_poduct_price.Size = new System.Drawing.Size(274, 151);
            this.home_poduct_price.TabIndex = 0;
            this.home_poduct_price.Text = "$19";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(112, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Only";
            // 
            // home_product_name
            // 
            this.home_product_name.AutoSize = true;
            this.home_product_name.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_product_name.Location = new System.Drawing.Point(112, 277);
            this.home_product_name.Name = "home_product_name";
            this.home_product_name.Size = new System.Drawing.Size(264, 44);
            this.home_product_name.TabIndex = 0;
            this.home_product_name.Text = "CheeseBurger";
            this.home_product_name.Click += new System.EventHandler(this.label4_Click);
            // 
            // home_product_des
            // 
            this.home_product_des.AutoSize = true;
            this.home_product_des.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_product_des.Location = new System.Drawing.Point(125, 341);
            this.home_product_des.Name = "home_product_des";
            this.home_product_des.Size = new System.Drawing.Size(288, 23);
            this.home_product_des.TabIndex = 0;
            this.home_product_des.Text = "With Onion Potato And Bread";
            // 
            // home_meal_btn
            // 
            this.home_meal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.home_meal_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.home_meal_btn.FlatAppearance.BorderSize = 0;
            this.home_meal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_meal_btn.ForeColor = System.Drawing.Color.White;
            this.home_meal_btn.Location = new System.Drawing.Point(125, 417);
            this.home_meal_btn.Name = "home_meal_btn";
            this.home_meal_btn.Size = new System.Drawing.Size(288, 55);
            this.home_meal_btn.TabIndex = 1;
            this.home_meal_btn.Text = "Add to Meal";
            this.home_meal_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(492, 252);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 3;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.home_meal_btn);
            this.Controls.Add(this.home_poduct_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.home_product_name);
            this.Controls.Add(this.home_product_des);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1139, 555);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label home_poduct_price;
        private Label label3;
        private Label home_product_name;
        private Label home_product_des;
        private Button home_meal_btn;
        private PictureBox pictureBox1;
        private HScrollBar hScrollBar1;
    }
}
