using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    // Abstract class representing a Menu item. 
    // It contains common properties and methods for all menu items
    public abstract class Menu
    {
        // Defines common properties for all Menu items

        public string ItemName;
        public decimal Price;
        public bool IsAvailable;
        public string DietaryInfo;
        public int Quantity;

        // Constructor to initialize a Menu item

        public Menu(string name, decimal price, bool isAvailable, string dietaryInfo, int quantity)
        {
            ItemName = name;
            Price = price;
            IsAvailable = isAvailable;
            DietaryInfo = dietaryInfo;
            Quantity = quantity;
        }

        // Method to get the name of the menu item
        //Encapsulation achieved through controlled access methods
        //allow data to be retrived while preventing direct modification
        public string readItem()
        {
            return ItemName;
        }

        // Method to get the price of the menu item

        public decimal readPrice()
        {
            return Price;
        }

        // Method to get the availability status of the menu item

        public bool readAvailable()
        {
            return IsAvailable;
        }

        // Method to get the dietary information of the menu item

        public string readDietary()
        {
            return DietaryInfo;
        }

        // Method to get the quantity of the menu item
        //Abstract methods, that are overriden in child classes- Polymorphism
        public int readQuantity()
        {
            return Quantity;
        }

        // Abstract method to be implemented by derived classes to return the category of the item
        // Polymorphism is demonstrated here: different types of menu items will implement this method differently

        public abstract string Category();

        // Abstract method for displaying item info, each derived class will implement its version of how to display the item
        // Polymorphism in action: the implementation of this method will differ for each specific menu item type (e.g., Appetizer, MainCourse, etc.)
        public abstract void DisplayItemInfo();
    }
}
