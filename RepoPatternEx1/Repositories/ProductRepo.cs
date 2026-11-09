using RepoPatternEx1.Models;
using System.Collections.Generic;

namespace RepoPatternEx1.Repositories
{
    public class ProductRepo
    {

        static List<Product> lst;
        static ProductRepo()
        {
            
            lst = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Product A", MfgName = "Manufacturer A", Price = 10.99m },
                new Product { ProductID = 2, ProductName = "Product B", MfgName = "Manufacturer B", Price = 15.49m },
                new Product { ProductID = 3, ProductName = "Product C", MfgName = "Manufacturer C", Price = 7.99m },
                new Product { ProductID = 4, ProductName = "Product D", MfgName = "Manufacturer D", Price = 12.75m },
                new Product { ProductID = 5, ProductName = "Product E", MfgName = "Manufacturer E", Price = 9.50m }
            };
        }

        public List<Product> GetProducts() // all products from the list. 
        {
            return lst;
        }

        public void addProduct(Product p) // add a product to the list. 
        {
            p.ProductID = lst.Count + 1; // Assign a new ProductID based on the current count of products
            lst.Add(p);
        }

    }
}
