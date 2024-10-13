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
            product.ProductId = products.Max(p => p.ProductId) + 1; // Asigna un nuevo ID
            products.Add(product);


        }
        public void Update(ProductModel product)
        {
            var existingProduct = products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.Price = product.Price;
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
    public void Delete(int ProductId)
        {
            var product = product.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                product.Remove(product); // Elimina el producto de la lista
            }
        }
        public IEnumerable<ProductModel> IProductRepository.GetAll()
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
        return product
             .Where(p => p.ProductName.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase))
             .ToList();
    }

        void IProductRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}







