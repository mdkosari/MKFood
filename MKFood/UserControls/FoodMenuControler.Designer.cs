namespace MKFood
{
    partial class FoodMenuControler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenuControler));
            this.FoodMenuListFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.FoodMenuCategoryCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodMenuSearchTxt = new System.Windows.Forms.TextBox();
            this.FoodMenuPriceTB = new System.Windows.Forms.TrackBar();
            this.FoodMenuPrice = new System.Windows.Forms.Label();
            this.FoodMenuPriceTBStatus = new System.Windows.Forms.Label();
            this.FoodMenuAddItemBtn = new System.Windows.Forms.Button();
            this.FoodMenuActiveCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FoodMenuEditModeCb = new System.Windows.Forms.CheckBox();
            this.FoodMenuListFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenuPriceTB)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodMenuListFLP
            // 
            this.FoodMenuListFLP.AllowDrop = true;
            this.FoodMenuListFLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoodMenuListFLP.AutoScroll = true;
            this.FoodMenuListFLP.Controls.Add(this.foodItemControl1);
            this.FoodMenuListFLP.Controls.Add(this.foodItemControl3);
            this.FoodMenuListFLP.Controls.Add(this.foodItemControl2);
            this.FoodMenuListFLP.Controls.Add(this.foodItemControl4);
            this.FoodMenuListFLP.Controls.Add(this.foodItemControl5);
            this.FoodMenuListFLP.Location = new System.Drawing.Point(3, 150);
            this.FoodMenuListFLP.Name = "FoodMenuListFLP";
            this.FoodMenuListFLP.Padding = new System.Windows.Forms.Padding(20);
            this.FoodMenuListFLP.Size = new System.Drawing.Size(1133, 402);
            this.FoodMenuListFLP.TabIndex = 0;
            this.FoodMenuListFLP.WrapContents = false;
            // 
            
            // FoodMenuCategoryCB
            // 
            this.FoodMenuCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FoodMenuCategoryCB.FormattingEnabled = true;
            this.FoodMenuCategoryCB.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.FoodMenuCategoryCB.Location = new System.Drawing.Point(145, 39);
            this.FoodMenuCategoryCB.Name = "FoodMenuCategoryCB";
            this.FoodMenuCategoryCB.Size = new System.Drawing.Size(158, 28);
            this.FoodMenuCategoryCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categry : ";
            // 
            // FoodMenuSearchTxt
            // 
            this.FoodMenuSearchTxt.Location = new System.Drawing.Point(145, 85);
            this.FoodMenuSearchTxt.Name = "FoodMenuSearchTxt";
            this.FoodMenuSearchTxt.Size = new System.Drawing.Size(139, 27);
            this.FoodMenuSearchTxt.TabIndex = 3;
            this.FoodMenuSearchTxt.Text = "Product Name";
            // 
            // FoodMenuPriceTB
            // 
            this.FoodMenuPriceTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.FoodMenuPriceTB.AllowDrop = true;
            this.FoodMenuPriceTB.AutoSize = false;
            this.FoodMenuPriceTB.Location = new System.Drawing.Point(402, 52);
            this.FoodMenuPriceTB.Name = "FoodMenuPriceTB";
            this.FoodMenuPriceTB.Size = new System.Drawing.Size(276, 45);
            this.FoodMenuPriceTB.TabIndex = 4;
            this.FoodMenuPriceTB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.FoodMenuPriceTB.UseWaitCursor = true;
            // 
            // FoodMenuPrice
            // 
            this.FoodMenuPrice.AutoSize = true;
            this.FoodMenuPrice.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodMenuPrice.Location = new System.Drawing.Point(501, 18);
            this.FoodMenuPrice.Name = "FoodMenuPrice";
            this.FoodMenuPrice.Size = new System.Drawing.Size(101, 21);
            this.FoodMenuPrice.TabIndex = 2;
            this.FoodMenuPrice.Text = "Price Filter";
            // 
            // FoodMenuPriceTBStatus
            // 
            this.FoodMenuPriceTBStatus.AutoSize = true;
            this.FoodMenuPriceTBStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodMenuPriceTBStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FoodMenuPriceTBStatus.Location = new System.Drawing.Point(510, 100);
            this.FoodMenuPriceTBStatus.Name = "FoodMenuPriceTBStatus";
            this.FoodMenuPriceTBStatus.Size = new System.Drawing.Size(60, 28);
            this.FoodMenuPriceTBStatus.TabIndex = 2;
            this.FoodMenuPriceTBStatus.Text = "$200";
            // 
            // FoodMenuAddItemBtn
            // 
            this.FoodMenuAddItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FoodMenuAddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodMenuAddItemBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodMenuAddItemBtn.ForeColor = System.Drawing.Color.White;
            this.FoodMenuAddItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("FoodMenuAddItemBtn.Image")));
            this.FoodMenuAddItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoodMenuAddItemBtn.Location = new System.Drawing.Point(1040, 2);
            this.FoodMenuAddItemBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FoodMenuAddItemBtn.Name = "FoodMenuAddItemBtn";
            this.FoodMenuAddItemBtn.Size = new System.Drawing.Size(100, 41);
            this.FoodMenuAddItemBtn.TabIndex = 5;
            this.FoodMenuAddItemBtn.Text = "   Add";
            this.FoodMenuAddItemBtn.UseVisualStyleBackColor = false;
            this.FoodMenuAddItemBtn.Click += new System.EventHandler(this.FoodMenuAddItemBtn_Click);
            // 
            // FoodMenuActiveCb
            // 
            this.FoodMenuActiveCb.AutoSize = true;
            this.FoodMenuActiveCb.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodMenuActiveCb.Location = new System.Drawing.Point(733, 38);
            this.FoodMenuActiveCb.Name = "FoodMenuActiveCb";
            this.FoodMenuActiveCb.Size = new System.Drawing.Size(124, 25);
            this.FoodMenuActiveCb.TabIndex = 6;
            this.FoodMenuActiveCb.Text = "Only Active";
            this.FoodMenuActiveCb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search : ";
            // 
            // FoodMenuEditModeCb
            // 
            this.FoodMenuEditModeCb.AutoSize = true;
            this.FoodMenuEditModeCb.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodMenuEditModeCb.Location = new System.Drawing.Point(733, 85);
            this.FoodMenuEditModeCb.Name = "FoodMenuEditModeCb";
            this.FoodMenuEditModeCb.Size = new System.Drawing.Size(134, 25);
            this.FoodMenuEditModeCb.TabIndex = 6;
            this.FoodMenuEditModeCb.Text = "Edited Mode";
            this.FoodMenuEditModeCb.UseVisualStyleBackColor = true;
            // 
            // FoodMenuControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FoodMenuEditModeCb);
            this.Controls.Add(this.FoodMenuActiveCb);
            this.Controls.Add(this.FoodMenuAddItemBtn);
            this.Controls.Add(this.FoodMenuPriceTB);
            this.Controls.Add(this.FoodMenuSearchTxt);
            this.Controls.Add(this.FoodMenuPriceTBStatus);
            this.Controls.Add(this.FoodMenuPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodMenuCategoryCB);
            this.Controls.Add(this.FoodMenuListFLP);
            this.Name = "FoodMenuControler";
            this.Size = new System.Drawing.Size(1139, 555);
            this.Load += new System.EventHandler(this.FoodMenuControler_Load);
            this.FoodMenuListFLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenuPriceTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel FoodMenuListFLP;
        private ComboBox FoodMenuCategoryCB;
        private Label label1;
        private TextBox FoodMenuSearchTxt;
        private TrackBar FoodMenuPriceTB;
        private Label FoodMenuPrice;
        private FoodItemControl foodItemControl1;
        private FoodItemControl foodItemControl2;
        private FoodItemControl foodItemControl3;
        private FoodItemControl foodItemControl4;
        private FoodItemControl foodItemControl5;
        private Label FoodMenuPriceTBStatus;
        private Button FoodMenuAddItemBtn;
        private CheckBox FoodMenuActiveCb;
        private Label label2;
        private CheckBox FoodMenuEditModeCb;
    }
}
