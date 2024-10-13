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

            LoadAllPayModes();

        }

        private void LoadAllPayModes()
        {
            var payModeList = Repository.GetAll(); ;
            payModeBindinSource.DataSource = payModeList;
        }

        private void loadAllPayModelList()
        {
            PayModelList = Repository.GetAll();
            payModeBindinSource.DataSource = PayModelList;

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            view.HideDetailPanel(); 
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel
            {
                Id = Convert.ToInt32(view.PayModeId),
                Name = view.PayModeName,
                observation = view.PayModeObservation
            };

            try
            {
                if (view.IsEdit)  // Si estamos editando
                {
                    Repository.Edit(payMode);  // Editar el modo de pago existente
                    view.Message = "Modo de pago actualizado correctamente.";
                }
                else  // Si estamos agregando
                {
                    Repository.Add(payMode);  // Agregar un nuevo modo de pago
                    view.Message = "Modo de pago agregado correctamente.";
                }

                view.IsSuccessful = true;
                LoadAllPayModes();  // Recargar la lista
                view.HideDetailPanel();  // Ocultar panel de detalles
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al guardar el modo de pago.";
            };
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)view.SelectedPayMode; 
                Repository.Delete(payMode.Id);  
                view.IsSuccessful = true;
                view.Message = "Modo de pago eliminado correctamente.";
                LoadAllPayModes();  
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar el modo de pago.";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)view.SelectedPayMode;

            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.observation;

            view.IsEdit = true;  // Indica que estamos en modo edición
            view.ShowDetailPanel();  
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            view.ShowDetailPanel();
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
