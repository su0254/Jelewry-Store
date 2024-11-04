using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class ProductServices
    {
        static List<Product> products { get; }
        public ProductServices()
        {
            
        }
        static ProductServices()
        {
            products = new List<Product>();
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }
        public Product GetProductById(string makat)
        {
            foreach (Product p in products)
            {
                if (p.Makat == makat) 
                    return p;
            }
            return null;
        }
        public void PostProduct(Product p)
        {
            products.Add(p);
        }
        public void PutProduct(string makat,Product p)
        {
            for (int i = 0; i < products.Count(); i++)
            {
                if(p.Makat == makat)
                    products[i] = p;
            }
        }
        public void DeleteProduct(string makat)
        {
            foreach(Product p in products)
            {
                if(p.Makat == makat)
                    products.Remove(p);
            }
        }
    }
}
