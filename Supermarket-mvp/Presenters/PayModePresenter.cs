using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository Repository;
        private BindingSource payModeBindinSource;
        private IEnumerable<PayModeModel> PayModelList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindinSource = new BindingSource();


            this.view = view;
            this.Repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindinSource);

            loadAllPayModelList();

            this.view.Show();

        }

        private void loadAllPayModelList()
        {
            PayModelList = Repository.GetAll();
            payModeBindinSource.DataSource = PayModelList;

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                PayModelList = Repository.GetByValue(this.view.SearchValue);

            }
            else
            {
                PayModelList = Repository.GetAll();

            }
            payModeBindinSource.DataSource = PayModelList;
        }
    }
}
