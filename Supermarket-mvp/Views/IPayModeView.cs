using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation { get; set; }

        PayModeModel SelectedPayMode { get; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        void ShowDetailPanel();

        void HideDetailPanel();
        void SetPayModeListBildingSource(BindingSource payModelList);
        void Show();

       
    }
}
