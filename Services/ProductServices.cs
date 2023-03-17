using graphQL.Interfaces;
using graphQL.Models;

namespace graphQL.Services
{
    public class ProductServices : IProduct
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(){Id = 0, Name = "Coffe", Price = 10 },
            new Product(){Id = 0, Name = "Tea", Price = 15 },

        };


        public Product AddProduct(Product product)
        {

            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);

        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.Find(p => p.Id == id);

        }

        public Product UpdateProduct(int id, Product product)
        {

            products[id] = product;
            return product;
        }
    }
}
