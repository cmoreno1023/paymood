namespace Supermarket_mvp.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnSearch = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            DgProduct = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            txtCategoryId = new TextBox();
            TxtPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(TxtSearch);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 111);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 114);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(220, 46);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(100, 23);
            TxtSearch.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 49);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Product Management";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(362, 46);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 4;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 339);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgProduct);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product Mode List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCancel);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(TxtPrice);
            tabPage2.Controls.Add(txtCategoryId);
            tabPage2.Controls.Add(TxtProductName);
            tabPage2.Controls.Add(TxtProductId);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " Product Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(8, 61);
            DgProduct.Name = "DgProduct";
            DgProduct.Size = new Size(601, 242);
            DgProduct.TabIndex = 0;
            DgProduct.CellContentClick += DgProduct_CellContentClick;
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(50, 92);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 23);
            BtnNew.TabIndex = 1;
            BtnNew.Text = "NEW";
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(50, 143);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(50, 204);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 3;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(50, 257);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 4;
            BtnClose.Text = "CLOSE";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(161, 21);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(100, 23);
            TxtProductId.TabIndex = 0;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(161, 83);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(100, 23);
            TxtProductName.TabIndex = 1;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(161, 149);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(100, 23);
            txtCategoryId.TabIndex = 2;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(161, 209);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(100, 23);
            TxtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 24);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Product ID";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 91);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 5;
            label4.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 152);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "Category Id ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 212);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(50, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DgProduct;
        private TabPage tabPage2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductId;
        private Button btnCancel;
        private Button btnSave;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtPrice;
        private TextBox txtCategoryId;
        private TextBox TxtProductName;
    }
}