using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    // Derived class representing an "Appetizer" menu item.
    // This class inherits from the "Menu" abstract class.
    public class Appetizer:Menu
    {
        // Constructor for the Appetizer class. It calls the base class constructor to initialize common properties.

        public Appetizer(string name, decimal price, bool isAvailable, string dietaryInfo, int quantity)
            : base(name, price, isAvailable, dietaryInfo, quantity) { }

        // Override the abstract Category() method from the Menu class.
        // This method returns the specific category name for Appetizers.
        public override string Category(){
            return "Appetizer";
        }

        // Override the abstract DisplayItemInfo() method from the Menu class.
        // This method is responsible for displaying the specific details of an Appetizer item.
        // The implementation of this method is specific to the Appetizer class, demonstrating polymorphism.

        public override void DisplayItemInfo()
        {
            // Output the details of the Appetizer item to the console

            Console.WriteLine($"{Category()}: {ItemName}, Price: {Price:C}, Available: {IsAvailable}, Dietary Info: {DietaryInfo}, Quantity: {Quantity}");
        }
    }
}
