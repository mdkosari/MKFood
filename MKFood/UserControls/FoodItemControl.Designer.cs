namespace MKFood
{
    partial class FoodItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodItemControl));
            this.FoodItemPic = new System.Windows.Forms.PictureBox();
            this.FoodItemName = new System.Windows.Forms.Label();
            this.FoodItemDes = new System.Windows.Forms.Label();
            this.FoodItemAddMealBtn = new System.Windows.Forms.Button();
            this.FoodItemPrice = new System.Windows.Forms.Label();
            this.FoodItemEditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FoodItemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodItemPic
            // 
            this.FoodItemPic.Image = ((System.Drawing.Image)(resources.GetObject("FoodItemPic.Image")));
            this.FoodItemPic.Location = new System.Drawing.Point(3, 58);
            this.FoodItemPic.Name = "FoodItemPic";
            this.FoodItemPic.Size = new System.Drawing.Size(235, 136);
            this.FoodItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FoodItemPic.TabIndex = 0;
            this.FoodItemPic.TabStop = false;
            // 
            // FoodItemName
            // 
            this.FoodItemName.AutoSize = true;
            this.FoodItemName.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodItemName.Location = new System.Drawing.Point(3, 18);
            this.FoodItemName.Name = "FoodItemName";
            this.FoodItemName.Size = new System.Drawing.Size(111, 33);
            this.FoodItemName.TabIndex = 1;
            this.FoodItemName.Text = "Burger";
            this.FoodItemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // FoodItemDes
            // 
            this.FoodItemDes.AutoSize = true;
            this.FoodItemDes.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodItemDes.Location = new System.Drawing.Point(12, 206);
            this.FoodItemDes.Name = "FoodItemDes";
            this.FoodItemDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodItemDes.Size = new System.Drawing.Size(206, 44);
            this.FoodItemDes.TabIndex = 1;
            this.FoodItemDes.Text = "With Onion Potato And\r\n Bread";
            this.FoodItemDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FoodItemAddMealBtn
            // 
            this.FoodItemAddMealBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.FoodItemAddMealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodItemAddMealBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodItemAddMealBtn.ForeColor = System.Drawing.Color.White;
            this.FoodItemAddMealBtn.Location = new System.Drawing.Point(3, 287);
            this.FoodItemAddMealBtn.Name = "FoodItemAddMealBtn";
            this.FoodItemAddMealBtn.Size = new System.Drawing.Size(235, 35);
            this.FoodItemAddMealBtn.TabIndex = 2;
            this.FoodItemAddMealBtn.Text = "Add to Meal";
            this.FoodItemAddMealBtn.UseVisualStyleBackColor = false;
            this.FoodItemAddMealBtn.Click += new System.EventHandler(this.FoodItemAddMealBtn_Click);
            // 
            // FoodItemPrice
            // 
            this.FoodItemPrice.AutoSize = true;
            this.FoodItemPrice.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FoodItemPrice.Location = new System.Drawing.Point(12, 256);
            this.FoodItemPrice.Name = "FoodItemPrice";
            this.FoodItemPrice.Size = new System.Drawing.Size(68, 28);
            this.FoodItemPrice.TabIndex = 1;
            this.FoodItemPrice.Text = "$200";
            // 
            // FoodItemEditBtn
            // 
            this.FoodItemEditBtn.FlatAppearance.BorderSize = 0;
            this.FoodItemEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodItemEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("FoodItemEditBtn.Image")));
            this.FoodItemEditBtn.Location = new System.Drawing.Point(210, 3);
            this.FoodItemEditBtn.Name = "FoodItemEditBtn";
            this.FoodItemEditBtn.Size = new System.Drawing.Size(28, 29);
            this.FoodItemEditBtn.TabIndex = 3;
            this.FoodItemEditBtn.UseVisualStyleBackColor = true;
            // 
            // FoodItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.FoodItemEditBtn);
            this.Controls.Add(this.FoodItemAddMealBtn);
            this.Controls.Add(this.FoodItemDes);
            this.Controls.Add(this.FoodItemPrice);
            this.Controls.Add(this.FoodItemName);
            this.Controls.Add(this.FoodItemPic);
            this.Name = "FoodItemControl";
            this.Size = new System.Drawing.Size(241, 325);
            ((System.ComponentModel.ISupportInitialize)(this.FoodItemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox FoodItemPic;
        private Label FoodItemName;
        private Label FoodItemDes;
        private Button FoodItemAddMealBtn;
        private Label FoodItemPrice;
        private Button FoodItemEditBtn;
    }
}
