using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;
using System.Collections.Generic;
using System.Linq;
namespace Supermarket_mvp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> products; 
        // Esta lista simulará la base de datos

        public ProductRepository()
        {
            products = new List<ProductModel>
         {  new ProductModel { ProductId = 1, ProductName = "Product A", CategoryId = 1, Price = 10.0m },
                new ProductModel { ProductId = 2, ProductName = "Product B", CategoryId = 2, Price = 15.5m }

       };
            
       }
        public IEnumerable<ProductModel> SearchProducts(string searchTerm)
        {
            return products
                .Where(p => p.ProductName.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public ProductModel GetById(int id)
        {
            return products.FirstOrDefault(p => p.ProductId == id);
        }

        public void Add(ProductModel product)
        {
            products.Add(product);


        }
        public void Update(ProductModel product)
        {
            var existingProduct = GetById(product.ProductId);
            if (existingProduct != null)
            {

                existingProduct.ProductName = product.ProductName;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.Price = product.Price;
            }
        }
        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        IEnumerable<ProductModel> IProductRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        ProductModel IProductRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IProductRepository.Add(ProductModel product)
        {
            throw new NotImplementedException();
        }

        void IProductRepository.Update(ProductModel product)
        {
            throw new NotImplementedException();
        }

        void IProductRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}







