using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    // Derived class representing a "Drinks" menu item. 
    // This class inherits from the "Menu" abstract class.
    public class Drinks:Menu
    {
        // Constructor for the Drinks class. It calls the base class constructor to initialize common properties.

        public Drinks(string name, decimal price, bool isAvailable, string dietaryInfo, int quantity)
            : base(name, price, isAvailable, dietaryInfo, quantity) { }

        // Override the abstract Category() method from the Menu class
        // This method returns the specific category name for Drinks.
        public override string Category(){
            return "Drinks";
        }

        // Override the abstract DisplayItemInfo() method from the Menu class
        // This method is responsible for displaying the specific details of a Drinks item.
        public override void DisplayItemInfo()
        {
            // Output the details of the Drinks item to the console
            Console.WriteLine($"{Category()}: {ItemName}, Price: {Price:C}, Available: {IsAvailable}, Dietary Info: {DietaryInfo}, Quantity: {Quantity}");
        }
    }
}
