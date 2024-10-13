using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;
using System.Runtime.ConstrainedExecution;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.productBindingSource = new BindingSource();

            // Suscribir los eventos de la vista a los métodos del presentador
            this.view.AddNewEvent += AddProduct;
            this.view.EditEvent += EditProduct;
            this.view.DeleteEvent += DeleteProduct;
            this.view.SaveProduct += SaveProduct;
            this.view.CancelEvent += Cancel;

            // Cargar la lista de productos
            LoadAllProducts();
        }

        private void LoadAllProducts()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
            view.SetProductList(productBindingSource);
        }

        // Métodos para manejar los eventos
        private void AddProduct(object sender, EventArgs e)
        {
            view.ProductId = "0"; // Establece el ID en "0" para indicar que es un nuevo producto
            view.ProductName = ""; // Limpia el campo de nombre
            view.CategoryId = ""; // Limpia el campo de categoría
            view.Price = ""; // Limpia el campo de precio
            view.IsEdit = false;
            view.ProductId = "0"; // Setea el ID en 0 cuando es un producto nuevo
            view.ShowMessage("Enter the new product details.");

        }

        private void EditProduct(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;
            view.ProductId = product.ProductId.ToString();
            view.ProductName = product.ProductName;
            view.CategoryId = product.CategoryId.ToString();
            view.Price = product.Price.ToString();
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;
            repository.Delete(product.ProductId);
            LoadAllProducts();
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            var product = new ProductModel
            {
                ProductId = int.Parse(view.ProductId),
                ProductName = view.ProductName,
                CategoryId = int.Parse(view.CategoryId),
                Price = decimal.Parse(view.Price)
            };

            if (product.ProductId == 0)
                repository.Add(product);
            else
                repository.Update(product);

            LoadAllProducts();
            view.ShowMessage("Product saved successfully.");
        }
        

        private void Cancel(object sender, EventArgs e)
        {
            view.ProductId = "";
            view.ProductName = "";
            view.CategoryId = "";
            view.Price = "";
        }
    }

    public interface IProductRepository
    {
        object view { get; }

        void Add(ProductModel product);
        void Delete(int productId);
        IEnumerable<ProductModel> GetAll();
        void Update(ProductModel product);
        private void SearchProducts(object sender, EventArgs e)
        {
            var searchTerm = view.SearchValue; // Esto debe coincidir con la propiedad en IProductView
            var results = Repository.SearchProducts(searchTerm);

            view.SetProductList(new BindingSource { DataSource = results.ToList() });

            if (!results.Any())
            {
                view.ShowMessage("No se encontraron productos.");
            }
        }
    }
    }
}

    

