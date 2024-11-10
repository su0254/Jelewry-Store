using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class ProductServices
    {
        static int id = 1;
        public ProductServices()
        {
            
        }
        
        public List<Product> GetAllProducts()
        {
            return DataContextManager.Manager.Products;
        }
        public Product GetProductById(string makat)
        {
            if (DataContextManager.Manager.Products == null) return null;
            return DataContextManager.Manager.Products.Find((p) => p.Makat == makat);
        }
        public bool PostProduct(Product p)
        {
            if (p == null) return false;
            p.Id = id++;
            DataContextManager.Manager.Products.Add(p);
            return true;
        }
        public bool PutProduct(string makat,Product p)
        {
            if (p == null) return false;
            Product product = DataContextManager.Manager.Products.Find(p => p.Makat==makat);
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
            Product p = DataContextManager.Manager.Products.Find((p) => p.Makat == makat);
            if (p == null) return false;
            DataContextManager.Manager.Branches.Remove(p);
            return true;

        }
    }
}
