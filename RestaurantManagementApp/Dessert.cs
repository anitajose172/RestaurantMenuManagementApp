using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    // Derived class representing a "Dessert" menu item.
    // This class inherits from the "Menu" abstract class.
    public class Dessert:Menu
    {
        // Constructor for the Dessert class. It calls the base class constructor to initialize common properties.

        public Dessert(string name, decimal price, bool isAvailable, string dietaryInfo, int quantity)
            : base(name, price, isAvailable, dietaryInfo, quantity) { }

        // Override the abstract Category() method from the Menu class.
        // This method returns the specific category name for Desserts.
        public override string Category(){
            return "Dessert";
        }

        // Override the abstract DisplayItemInfo() method from the Menu class.
        // This method is responsible for displaying the specific details of a Dessert item.
        // The implementation of this method is specific to the Dessert class, demonstrating polymorphism.
        public override void DisplayItemInfo()
        {
            // Output the details of the Dessert item to the console

            Console.WriteLine($"{Category()}: {ItemName}, Price: {Price:C}, Available: {IsAvailable}, Dietary Info: {DietaryInfo}, Quantity: {Quantity}");
        }
    }
}
