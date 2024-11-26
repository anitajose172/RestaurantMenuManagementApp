using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    // Derived class representing a "Main Course" menu item.
    // This class inherits from the "Menu" abstract class, which provides common properties for all menu items.
    public class MainCourse: Menu
    {
        // Constructor for the MainCourse class.
        // It initializes the common properties inherited from the Menu base class.
        public MainCourse(string name, decimal price, bool isAvailable, string dietaryInfo, int quantity)
            : base(name, price, isAvailable, dietaryInfo, quantity) { }

        // Override the abstract Category() method from the Menu class.
        // This method returns the category name Main Course.
        public override string Category()
        {

            return "Main Course";
        }

        // Override the abstract DisplayItemInfo() method from the Menu class.
        // This method is responsible for displaying detailed information about the Main Course item.
        public override void DisplayItemInfo()
        {
            // Output the details of the Main Course item to the console
            Console.WriteLine($"{Category()}: {ItemName}, Price: {Price:C}, Available: {IsAvailable}, Dietary Info: {DietaryInfo}, Quantity: {Quantity}");
        }
    }
}
