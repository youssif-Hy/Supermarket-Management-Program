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
        public void BuyProduct(Product product , int quantity)
        {
            // Check if the product is available in the store
            if (Program.products.Contains(product) && product.Quantity >= quantity)
            {
                // Add the product to the cart
                cart.Add(new Product
                {
                    Name = product.Name,

                    Category = product.Category,

                    SerialNumber = product.SerialNumber,

                    Quantity = quantity,

                    ProductionDate = product.ProductionDate,

                    ExpiryDate = product.ExpiryDate
                });
                // Reduce the quantity of the product in the store
                product.Quantity -= quantity;

                Console.WriteLine($"{quantity} {product.Name}(s) added to your cart.");
            }
            else
            {
                Console.WriteLine("Product not available or insufficient quantity.");
            }
        }
    }
}
