namespace RestaurantManagementApp
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuListView = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dietary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.isAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dietaryInfoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.NewItem = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Menu Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(277, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(501, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(501, 731);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuListView
            // 
            this.menuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Category,
            this.Price,
            this.Dietary,
            this.Available,
            this.Quantity});
            this.menuListView.HideSelection = false;
            this.menuListView.Location = new System.Drawing.Point(494, 103);
            this.menuListView.Name = "menuListView";
            this.menuListView.Size = new System.Drawing.Size(774, 361);
            this.menuListView.TabIndex = 9;
            this.menuListView.UseCompatibleStateImageBehavior = false;
            this.menuListView.View = System.Windows.Forms.View.Details;
            this.menuListView.SelectedIndexChanged += new System.EventHandler(this.menuListView_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 70;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Dietary
            // 
            this.Dietary.Text = "Dietary";
            this.Dietary.Width = 100;
            // 
            // Available
            // 
            this.Available.Text = "Available";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(257, 103);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(231, 40);
            this.itemNameTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(257, 263);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(231, 40);
            this.priceTextBox.TabIndex = 12;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Appetizer",
            "Main Course",
            "Dessert",
            "Drinks"});
            this.categoryComboBox.Location = new System.Drawing.Point(257, 175);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(231, 41);
            this.categoryComboBox.TabIndex = 13;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // isAvailableCheckBox
            // 
            this.isAvailableCheckBox.AutoSize = true;
            this.isAvailableCheckBox.Location = new System.Drawing.Point(257, 345);
            this.isAvailableCheckBox.Name = "isAvailableCheckBox";
            this.isAvailableCheckBox.Size = new System.Drawing.Size(28, 27);
            this.isAvailableCheckBox.TabIndex = 14;
            this.isAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(257, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 40);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dietaryInfoTextBox
            // 
            this.dietaryInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dietaryInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietaryInfoTextBox.Location = new System.Drawing.Point(257, 486);
            this.dietaryInfoTextBox.Name = "dietaryInfoTextBox";
            this.dietaryInfoTextBox.Size = new System.Drawing.Size(440, 40);
            this.dietaryInfoTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dietary Info";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(48, 731);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(277, 731);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 50);
            this.button6.TabIndex = 20;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // NewItem
            // 
            this.NewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItem.Location = new System.Drawing.Point(730, 645);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(178, 50);
            this.NewItem.TabIndex = 21;
            this.NewItem.Text = "New Item";
            this.NewItem.UseVisualStyleBackColor = true;
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(730, 731);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(178, 50);
            this.exit.TabIndex = 22;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(257, 409);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(75, 38);
            this.numericUpDown.TabIndex = 24;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 70;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1596, 878);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.NewItem);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dietaryInfoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isAvailableCheckBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.menuListView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView menuListView;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckBox isAvailableCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox dietaryInfoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Dietary;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.Button NewItem;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ColumnHeader Quantity;
    }
}

