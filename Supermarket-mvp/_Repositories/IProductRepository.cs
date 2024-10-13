using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Supermarket_mvp.Models;
using System.Collections.Generic;



namespace Supermarket_mvp._Repositories
{
    internal interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel GetById(int id);
        void Add(ProductModel product);
        void Update(ProductModel product);
        void Delete(int id);
    }
}
