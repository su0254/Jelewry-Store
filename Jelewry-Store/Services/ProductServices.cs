using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class ProductServices
    {
        static int id = 1;
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
        public bool PostProduct(Product p)
        {
            if (p == null) return false;
            p.Id = id++;
            products.Add(p);
            return true;
        }
        public bool PutProduct(string makat,Product p)
        {
            if (p == null) return false;
            Product product = products.Find(p => p.Makat==makat);
            product.Makat = p.Makat;
            product.Description = p.Description;
            product.Price = p.Price;
            product.Color = p.Color;
            product.Qty = p.Qty;
            product.EKategory = p.EKategory;
            product.ETarget = p.ETarget;
            return true;
        }
        public bool DeleteProduct(string makat)
        {
            return false;

        }
    }
}
