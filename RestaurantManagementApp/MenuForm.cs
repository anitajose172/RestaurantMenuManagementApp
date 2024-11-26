using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManagementApp
{
    public partial class MenuForm : Form
    {
        //Aggregates multiple menu objects into a collection using a list to manage menu items dynamically
        private List<Menu> list = new List<Menu>();

        private static int count = 0;
        private static int current = 0;
        private decimal totalPrice = 0;

        public MenuForm()
        {
            InitializeComponent();
            InitializeList();
            DisplayCurrentItem();
            menuListView.SelectedIndexChanged += menuListView_SelectedIndexChanged;

        }
        public void InitializeList()
        {
            list.Add(new Appetizer("Breads", 7.5m, true, "Vegetarian", 1));
            list.Add(new Appetizer("Fries", 8m, true, "Vegan, Gluten-Free", 1));
            list.Add(new Appetizer("Popcorn", 5m, false, "Vegan, Gluten-Free", 1));

            list.Add(new MainCourse("Fried Rice", 12.5m, true, "Vegetarian, Gluten-Free", 1));
            list.Add(new MainCourse("Pasta", 15.5m, true, "Vegetarian", 1));
            list.Add(new MainCourse("Pizza", 13m, true, "Vegetarian", 1));

            list.Add(new Dessert("Ice-cream", 7.5m, true, "Vegetarian", 1));
            list.Add(new Dessert("Shake", 10m, true, "Vegetarian, Gluten-Free", 1));
            list.Add(new Dessert("Pudding", 7m, false, "Vegetarian, Gluten-Free", 1));

            list.Add(new Drinks("Tea", 4.5m, true, "Vegan, Gluten-Free", 1));
            list.Add(new Drinks("Coffee", 5m, false, "Vegan, Gluten-Free", 1));
            list.Add(new Drinks("Juice", 8.5m, true, "Vegan, Gluten-Free", 1));

            count = list.Count;
        }
        private void DisplayCurrentItem()
        {

            if (current >= 0 && current < list.Count)
            {
                // Set form fields based on the current item in the list
                var currentItem = list[current];
                itemNameTextBox.Text = currentItem.ItemName;
                categoryComboBox.SelectedItem = currentItem.Category();
                priceTextBox.Text = currentItem.readPrice().ToString("F2");
                isAvailableCheckBox.Checked = currentItem.readAvailable();
                dietaryInfoTextBox.Text = currentItem.DietaryInfo;
                numericUpDown.Value = currentItem.readQuantity();
            }
        }
        private void ClearFields()
        {
            itemNameTextBox.Clear();
            priceTextBox.Clear();
            isAvailableCheckBox.Checked = false;
            dietaryInfoTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            numericUpDown.Value = 0;
        }


        private void NextItem()
        {
            if (current < count - 1)
            {
                current++;
                DisplayCurrentItem();
            }
            else
            {
                MessageBox.Show("You have reached the end of the list.");
            }
        }

        private void PreviousItem()
        {
            if (current > 0)
            {
                current--;
                DisplayCurrentItem();
            }
            else
            {
                MessageBox.Show("You are at the beginning of the list.");
            }
        }


        private void AddNewItem()
        {

            // Validate fields
            if (string.IsNullOrWhiteSpace(itemNameTextBox.Text) || string.IsNullOrWhiteSpace(priceTextBox.Text) || categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            // Parse and validate price
            if (!decimal.TryParse(priceTextBox.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Set values
            string itemName = itemNameTextBox.Text;
            bool isAvailable = isAvailableCheckBox.Checked;
            string dietaryInfo = dietaryInfoTextBox.Text;
            string category = categoryComboBox.SelectedItem.ToString();
            int quantity = (int)numericUpDown.Value;

            // Create and add item to list
            Menu newItem;
            switch (category)
            {
                case "Appetizer":
                    newItem = new Appetizer(itemName, price, isAvailable, dietaryInfo, quantity);
                    break;
                case "Main Course":
                    newItem = new MainCourse(itemName, price, isAvailable, dietaryInfo, quantity);
                    break;
                case "Dessert":
                    newItem = new Dessert(itemName, price, isAvailable, dietaryInfo, quantity);
                    break;
                case "Drinks":
                    newItem = new Drinks(itemName, price, isAvailable, dietaryInfo, quantity);
                    break;
                default:
                    MessageBox.Show("Invalid category selected.");
                    return;
            }

            // Add item to list array and increment count
            list.Add(newItem);

            // Update the ListView
            AddItemToListView(newItem);

            // Update total price
            totalPrice += price * quantity;
            textBox2.Text = $"Total: ${totalPrice:F2}";

            MessageBox.Show("Item added successfully.");

        }

        private void AddItemToListView(Menu item)
        {
            ListViewItem listItem = new ListViewItem(item.readItem());
            listItem.SubItems.Add(item.Category());
            listItem.SubItems.Add($"${item.readPrice():F2}");
            listItem.SubItems.Add(item.readDietary());
            listItem.SubItems.Add(item.readAvailable() ? "Yes" : "No");
            listItem.SubItems.Add(item.readQuantity().ToString());
            // Set the Tag property to link the ListViewItem to the Menu object
            listItem.Tag = item;

            // Add ListViewItem to the ListView
            menuListView.Items.Add(listItem);
        }


        private void DeleteSelectedItem()
        {
            if (menuListView.SelectedItems.Count > 0)
            {
                // Get the selected index from the menuListView
                int selectedIndex = menuListView.SelectedIndices[0];

                // Remove the item from the list and the menuListView
                Menu itemToDelete = list[selectedIndex];
                list.RemoveAt(selectedIndex);
                menuListView.Items.RemoveAt(selectedIndex);

                // Update count
                count = list.Count;

                // Adjust 'current' index to prevent out-of-bounds access
                if (current >= count) current = count - 1;

                // Recalculate total price by iterating over the entire list
                //totalPrice = list.Sum(item => item.readPrice());
                decimal priceToDeduct = list[selectedIndex].readPrice() * list[selectedIndex].Quantity; 
                totalPrice -= priceToDeduct;

                totalPrice = 0;  // Reset total price

                foreach (ListViewItem item in menuListView.Items)
                {
                    // Try to parse the price from the ListView item (SubItem[2])
                    if (decimal.TryParse(item.SubItems[2].Text.Trim('$'), out decimal itemPrice))
                    {
                        totalPrice += itemPrice;
                    }
                    else
                    {
                        // Handle cases where price parsing fails
                        Console.WriteLine("Failed to parse price for item: " + item.Text);
                    }
                }


                // Update the total price displayed
                textBox2.Text = $"Total: ${totalPrice:F2}";

                // Show the updated current item details, if any
                if (count > 0)
                {
                    DisplayCurrentItem();
                }
                else
                {
                    ClearFields();
                }

                MessageBox.Show("Item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
            textBox2.Clear();
            menuListView.Items.Clear();
            totalPrice = 0;
        }

        private void UpdateItem()
        {
            if (menuListView.SelectedItems.Count > 0)
            {
                // Get the selected ListView item
                ListViewItem selectedListViewItem = menuListView.SelectedItems[0];

                // Retrieve the associated Menu object from the Tag property
                Menu selectedItem = (Menu)selectedListViewItem.Tag;

                // Get updated values from the form fields
                string updatedName = itemNameTextBox.Text;
                string updatedCategory = categoryComboBox.SelectedItem?.ToString();
                bool updatedAvailability = isAvailableCheckBox.Checked;
                string updatedDietaryInfo = dietaryInfoTextBox.Text;
                int updatedquantity = (int)numericUpDown.Value;

                // Validate and update the price
                if (!decimal.TryParse(priceTextBox.Text, out decimal updatedPrice) || updatedPrice < 0)
                {
                    MessageBox.Show("Please enter a valid non-negative price.");
                    return;
                }

                decimal oldPrice = selectedItem.readPrice();  // Get the old price
                decimal priceDifference = (updatedPrice * updatedquantity) - (oldPrice * selectedItem.Quantity);  // Calculate the price difference

                // Update the Menu object in the list
                switch (updatedCategory)
                {
                    case "Appetizer":
                        selectedItem = new Appetizer(updatedName, updatedPrice, updatedAvailability, updatedDietaryInfo, updatedquantity);
                        break;
                    case "Main Course":
                        selectedItem = new MainCourse(updatedName, updatedPrice, updatedAvailability, updatedDietaryInfo, updatedquantity);
                        break;
                    case "Dessert":
                        selectedItem = new Dessert(updatedName, updatedPrice, updatedAvailability, updatedDietaryInfo, updatedquantity);
                        break;
                    case "Drinks":
                        selectedItem = new Drinks(updatedName, updatedPrice, updatedAvailability, updatedDietaryInfo, updatedquantity);
                        break;
                    default:
                        MessageBox.Show("Invalid category selected.");
                        return;
                }

                // Update the corresponding Menu object in the list
                int selectedIndex = menuListView.SelectedIndices[0];
                list[selectedIndex] = selectedItem;

                // Update the ListView to reflect the changes
                UpdateListViewItem(selectedIndex);  // Calls the helper method

                // Recalculate total price by iterating over the list
                totalPrice = 0;  // Reset total price
                foreach (ListViewItem item in menuListView.Items)
                {
                    if (decimal.TryParse(item.SubItems[2].Text.Trim('$'), out decimal itemPrice) &&
        int.TryParse(item.SubItems[5].Text, out int itemQuantity))
                    {
                        totalPrice += itemPrice * itemQuantity;
                    }
                }

                // Update the total price displayed
                textBox2.Text = $"Total: ${totalPrice:F2}";
                textBox2.Refresh();

                MessageBox.Show("Item updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void UpdateListViewItem(int index)
        {
            if (index < 0 || index >= menuListView.Items.Count) return; // Ensure index is valid

            Menu updatedItem = list[index];

            // Update the ListView item at the given index
            ListViewItem listViewItem = menuListView.Items[index];
            listViewItem.Text = updatedItem.readItem(); // Update item name
            listViewItem.SubItems[1].Text = updatedItem.Category(); // Update category
            listViewItem.SubItems[2].Text = $"${updatedItem.readPrice():F2}"; // Update price
            listViewItem.SubItems[3].Text = updatedItem.readDietary(); // Update dietary info
            listViewItem.SubItems[4].Text = updatedItem.readAvailable() ? "Yes" : "No"; // Update availability
            listViewItem.SubItems[5].Text = updatedItem.readQuantity().ToString(); // Update quantity column

        }


        private void button2_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NextItem();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PreviousItem();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void menuListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure an item is selected in the ListView
            if (menuListView.SelectedItems.Count > 0)
            {
                // Get the selected ListViewItem
                ListViewItem selectedListViewItem = menuListView.SelectedItems[0];

                // Retrieve the associated Menu object from the Tag property
                Menu selectedItem = (Menu)selectedListViewItem.Tag;

                // Populate the form fields with the selected item's details
                itemNameTextBox.Text = selectedItem.readItem();
                priceTextBox.Text = selectedItem.readPrice().ToString("F2");
                isAvailableCheckBox.Checked = selectedItem.readAvailable();
                dietaryInfoTextBox.Text = selectedItem.readDietary();
                categoryComboBox.SelectedItem = selectedItem.Category();
                numericUpDown.Value = selectedItem.readQuantity();
            }
        }


        private void NewItem_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
