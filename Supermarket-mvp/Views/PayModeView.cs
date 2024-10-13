using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
      
        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return IsEdit; }
            set { IsEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return IsSuccessful; }
            set { IsSuccessful = value; }
        }
        public string Message
        {
            get { return Message; }
            set { Message = value; }
        }

        PayModeModel IPayModeView.SelectedPayMode => throw new NotImplementedException();

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewsEvents();

            tabControl1.TabPages.Remove(tabPageModeDetail);

            BtnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewsEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            BtnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            BtnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtPayModeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModelList)
        {
            DgPayMode.DataSource = payModelList;
        }
        
        private void tabPageModeDetail_Click(object sender, EventArgs e)
        {

        }
        private static PayModeView instance;

        public static PayModeView GetInstance (Form parentContainer)

        {
        
            if  (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;

                }
                instance.BringToFront();
            }
               return instance;
        }

        public void ShowDetailPanel()
        {
            throw new NotImplementedException();
        }

        public void HideDetailPanel()
        {
            throw new NotImplementedException();
        }
    }

    }


