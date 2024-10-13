using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp.Views;
using System;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Presenters;
using System.Windows.Forms;
using System.ComponentModel;


namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView

      
    {
        public string GetSearchValue()
        {
            return TxtSearch.Text;
        }

        public void SetSearchValue(string value)
        {
            TxtSearch.Text = value;
        }

        private bool isEdit;

        public bool GetIsEdit()
        {
            return isEdit;
        }

        public void SetIsEdit(bool value)
        {
            isEdit = value;
        }

        private bool isSuccessful;

        public bool GetIsSuccessful()
        {
            return isSuccessful;
        }

        public void SetIsSuccessful(bool value)
        {
            isSuccessful = value;
        }

        private string message;

        public string GetMessage()
        {
            return message;
        }

        public void SetMessage(string value)
        {
            message = value;
        }

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            Presenters.IProductRepository productRepository = new ProductRepository();

            // Crear una instancia del presentador
            Presenters = new ProductPresenter(this, productRepository);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            BtnNew.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            BtnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnClose.Click += delegate { this.Close(); }; ;


            BtnSave.Click += delegate { SaveProductEvent?.Invoke(this, EventArgs.Empty); }; // Asegúrate de que BtnSave está definido
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };

        public string ProductId
        {
            get => TxtProductId.Text;
            set => TxtProductId.Text = value;
        }
        public string ProductName
        {
            get => TxtProductName.Text;
            set => TxtProductName.Text = value;

        }

        public string CategoryId
        {
            get => txtCategoryId.Text;
            set => txtCategoryId.Text = value;
        }

        public string Price
        {
            get => TxtPrice.Text;
            set => TxtPrice.Text = value;
        }
        public string SearchValue
        {
            get => TxtSearch.Text; // Asegúrate de que TxtSearch es el nombre correcto de tu TextBox
            set => TxtSearch.Text = value;
        }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public Action<object, EventArgs> SaveProduct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Action<object, EventArgs> IProductView.CancelEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        internal ProductPresenter Presenters { get; }
        public object BtnSave { get; private set; }

        // Eventos definidos en IProductView
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveProductEvent; // Evento para guardar el producto
        public event EventHandler CancelEvent; // Evento para cancelar

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void DgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public void SetProductList(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
