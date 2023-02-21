namespace MKFood
{
    partial class AddNewFood
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFood));
            this.FoodDialogClose = new System.Windows.Forms.PictureBox();
            this.FoodDialogPic = new System.Windows.Forms.PictureBox();
            this.FoodDialogSaveBtn = new System.Windows.Forms.Button();
            this.FoodDialogNameTB = new System.Windows.Forms.TextBox();
            this.FoodDialogDesTB = new System.Windows.Forms.TextBox();
            this.FoodDialogPriceTB = new System.Windows.Forms.TextBox();
            this.FoodDialogCategoryCB = new System.Windows.Forms.ComboBox();
            this.FoodDialogAddCatBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDialogClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDialogPic)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodDialogClose
            // 
            this.FoodDialogClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodDialogClose.Image = ((System.Drawing.Image)(resources.GetObject("FoodDialogClose.Image")));
            this.FoodDialogClose.Location = new System.Drawing.Point(478, 1);
            this.FoodDialogClose.Name = "FoodDialogClose";
            this.FoodDialogClose.Size = new System.Drawing.Size(36, 35);
            this.FoodDialogClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FoodDialogClose.TabIndex = 0;
            this.FoodDialogClose.TabStop = false;
            this.FoodDialogClose.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // FoodDialogPic
            // 
            this.FoodDialogPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodDialogPic.Image = ((System.Drawing.Image)(resources.GetObject("FoodDialogPic.Image")));
            this.FoodDialogPic.Location = new System.Drawing.Point(60, 136);
            this.FoodDialogPic.Name = "FoodDialogPic";
            this.FoodDialogPic.Size = new System.Drawing.Size(296, 198);
            this.FoodDialogPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FoodDialogPic.TabIndex = 3;
            this.FoodDialogPic.TabStop = false;
            this.FoodDialogPic.Click += new System.EventHandler(this.FoodItemPic_Click);
            // 
            // FoodDialogSaveBtn
            // 
            this.FoodDialogSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.FoodDialogSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodDialogSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodDialogSaveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodDialogSaveBtn.ForeColor = System.Drawing.Color.White;
            this.FoodDialogSaveBtn.Location = new System.Drawing.Point(12, 575);
            this.FoodDialogSaveBtn.Name = "FoodDialogSaveBtn";
            this.FoodDialogSaveBtn.Size = new System.Drawing.Size(491, 45);
            this.FoodDialogSaveBtn.TabIndex = 6;
            this.FoodDialogSaveBtn.Text = "Save Food";
            this.FoodDialogSaveBtn.UseVisualStyleBackColor = false;
            this.FoodDialogSaveBtn.Click += new System.EventHandler(this.FoodDialogSaveBtn_Click);
            // 
            // FoodDialogNameTB
            // 
            this.FoodDialogNameTB.BackColor = System.Drawing.Color.White;
            this.FoodDialogNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodDialogNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodDialogNameTB.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodDialogNameTB.Location = new System.Drawing.Point(60, 53);
            this.FoodDialogNameTB.Multiline = true;
            this.FoodDialogNameTB.Name = "FoodDialogNameTB";
            this.FoodDialogNameTB.Size = new System.Drawing.Size(199, 60);
            this.FoodDialogNameTB.TabIndex = 8;
            this.FoodDialogNameTB.Text = "Burger";
            // 
            // FoodDialogDesTB
            // 
            this.FoodDialogDesTB.BackColor = System.Drawing.Color.White;
            this.FoodDialogDesTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodDialogDesTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodDialogDesTB.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodDialogDesTB.Location = new System.Drawing.Point(60, 365);
            this.FoodDialogDesTB.MaxLength = 42;
            this.FoodDialogDesTB.Multiline = true;
            this.FoodDialogDesTB.Name = "FoodDialogDesTB";
            this.FoodDialogDesTB.Size = new System.Drawing.Size(286, 72);
            this.FoodDialogDesTB.TabIndex = 8;
            this.FoodDialogDesTB.Text = "With Onion Potato And Bread";
            // 
            // FoodDialogPriceTB
            // 
            this.FoodDialogPriceTB.BackColor = System.Drawing.Color.White;
            this.FoodDialogPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodDialogPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodDialogPriceTB.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodDialogPriceTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FoodDialogPriceTB.Location = new System.Drawing.Point(60, 518);
            this.FoodDialogPriceTB.Multiline = true;
            this.FoodDialogPriceTB.Name = "FoodDialogPriceTB";
            this.FoodDialogPriceTB.Size = new System.Drawing.Size(118, 35);
            this.FoodDialogPriceTB.TabIndex = 8;
            this.FoodDialogPriceTB.Text = "$200";
            this.FoodDialogPriceTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FoodDialogCategoryCB
            // 
            this.FoodDialogCategoryCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodDialogCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FoodDialogCategoryCB.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodDialogCategoryCB.FormattingEnabled = true;
            this.FoodDialogCategoryCB.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.FoodDialogCategoryCB.Location = new System.Drawing.Point(60, 461);
            this.FoodDialogCategoryCB.Name = "FoodDialogCategoryCB";
            this.FoodDialogCategoryCB.Size = new System.Drawing.Size(158, 36);
            this.FoodDialogCategoryCB.TabIndex = 9;
            this.FoodDialogCategoryCB.Text = "Fast Food";
            // 
            // FoodDialogAddCatBtn
            // 
            this.FoodDialogAddCatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodDialogAddCatBtn.FlatAppearance.BorderSize = 0;
            this.FoodDialogAddCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodDialogAddCatBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodDialogAddCatBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodDialogAddCatBtn.Image = ((System.Drawing.Image)(resources.GetObject("FoodDialogAddCatBtn.Image")));
            this.FoodDialogAddCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoodDialogAddCatBtn.Location = new System.Drawing.Point(253, 461);
            this.FoodDialogAddCatBtn.Name = "FoodDialogAddCatBtn";
            this.FoodDialogAddCatBtn.Size = new System.Drawing.Size(37, 39);
            this.FoodDialogAddCatBtn.TabIndex = 10;
            this.FoodDialogAddCatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FoodDialogAddCatBtn.UseVisualStyleBackColor = true;
            this.FoodDialogAddCatBtn.Click += new System.EventHandler(this.FoodDialogAddCatBtn_Click);
            // 
            // AddNewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(515, 632);
            this.Controls.Add(this.FoodDialogAddCatBtn);
            this.Controls.Add(this.FoodDialogCategoryCB);
            this.Controls.Add(this.FoodDialogDesTB);
            this.Controls.Add(this.FoodDialogPriceTB);
            this.Controls.Add(this.FoodDialogNameTB);
            this.Controls.Add(this.FoodDialogSaveBtn);
            this.Controls.Add(this.FoodDialogPic);
            this.Controls.Add(this.FoodDialogClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FoodDialogClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDialogPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox FoodDialogClose;
        private PictureBox FoodDialogPic;
        private Button FoodDialogSaveBtn;
        private TextBox FoodDialogNameTB;
        private TextBox FoodDialogDesTB;
        private TextBox FoodDialogPriceTB;
        private ComboBox FoodDialogCategoryCB;
        private Button FoodDialogAddCatBtn;
    }
}