using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    public interface IProductView
    {
        // Propiedades para los campos de la vista
        string ProductId { get; set; }
        string ProductName { get; set; }
        string CategoryId { get; set; }
        string Price { get; set; }

        string GetSearchValue();
        void SetSearchValue(string value);

        Action<object, EventArgs> SaveProduct { get; set; }
        Action<object, EventArgs> CancelEvent { get; set; }
        bool IsEdit { get; set; }

        bool GetIsEdit();
        void SetIsEdit(bool value);
        bool GetIsSuccessful();
        void SetIsSuccessful(bool value);
        string GetMessage();
        void SetMessage(string value);
        void SetProductList(BindingSource productList);
        void ShowMessage(string v);

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;

        
    }
}
