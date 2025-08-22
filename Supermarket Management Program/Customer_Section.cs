using productSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_Program
{
    class Customer_Section
    {
        public string customer_name { get; set; }
        List<Product> cart = new List<Product>();
        Product product;
        public void BuyProduct(int serialnumber , int quantity)
        {
            // Check if the product is available in the store
            if (serialnumber == int.Parse(product.SerialNumber) && product.Quantity >= quantity)
            {
                // Add the product to the cart
                cart.Add(new Product(product.Name, product.Category, product.SerialNumber, quantity, product.ProductionDate, product.ExpiryDate));

                // Reduce the quantity of the product in the store
                product.Quantity -= quantity;

                Console.WriteLine($"{quantity} {product.Name}(s) added to your cart.");
            }
            else
            {
                Console.WriteLine("Product not available or insufficient quantity.");
            }
        }
        public void RemoveProductFromCart(int serialnumber, int quantity)
        {
            // Check if the product is available in the store
            if (serialnumber == int.Parse(product.SerialNumber))
            {
                // Add the product to the cart
                cart.Remove(new Product(product.Name, product.Category, product.SerialNumber, quantity, product.ProductionDate, product.ExpiryDate));

                // Reduce the quantity of the product in the store
                product.Quantity += quantity;

                Console.WriteLine($"{quantity} {product.Name}(s) removed from your cart.");
            }
            else
            {
                Console.WriteLine("Product not available or insufficient quantity.");
            }
        }
        public void CheckOutProduct()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }
            Console.WriteLine("You have the following products in your cart:");
            foreach (var item in cart)
            {
                Console.WriteLine($"{item.Quantity} {item.Name}(s) - Serial Number: {item.SerialNumber}");
            }
            
            Console.WriteLine("Thank you for your purchase!");

            cart.Clear(); // Clear the cart after checkout
        }

    }
}
