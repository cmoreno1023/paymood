namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPageModeDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeObservation = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPageModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 18);
            label1.Name = "label1";
            label1.Padding = new Padding(8);
            label1.Size = new Size(197, 70);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageModeDetail);
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(dataGridView1);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // tabPageModeDetail
            // 
            tabPageModeDetail.Controls.Add(BtnCancel);
            tabPageModeDetail.Controls.Add(BtnSave);
            tabPageModeDetail.Controls.Add(label5);
            tabPageModeDetail.Controls.Add(label4);
            tabPageModeDetail.Controls.Add(label3);
            tabPageModeDetail.Controls.Add(TxtPayModeObservation);
            tabPageModeDetail.Controls.Add(TxtPayModeName);
            tabPageModeDetail.Controls.Add(TxtPayModeId);
            tabPageModeDetail.Location = new Point(4, 24);
            tabPageModeDetail.Name = "tabPageModeDetail";
            tabPageModeDetail.Padding = new Padding(3);
            tabPageModeDetail.Size = new Size(792, 322);
            tabPageModeDetail.TabIndex = 1;
            tabPageModeDetail.Text = "Pay Mode Detail";
            tabPageModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(17, 48);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(509, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(532, 43);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(66, 31);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(581, 239);
            dataGridView1.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.ImageAlign = ContentAlignment.BottomCenter;
            BtnNew.Location = new Point(637, 80);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(88, 46);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(637, 142);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(88, 46);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(637, 205);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(88, 47);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += button3_Click;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(637, 271);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(88, 48);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += button4_Click;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(22, 36);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(127, 23);
            TxtPayModeId.TabIndex = 4;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(22, 103);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "pay Mode Name";
            TxtPayModeName.Size = new Size(237, 23);
            TxtPayModeName.TabIndex = 5;
            TxtPayModeName.TextChanged += TxtPayModeName_TextChanged;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(22, 178);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "pay Mode Observation ";
            TxtPayModeObservation.Size = new Size(237, 67);
            TxtPayModeObservation.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 18);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 7;
            label3.Text = "pay Mode Id";
            label3.Click += label3_Click_2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 85);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "pay Mode Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 160);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 9;
            label5.Text = "pay Mode Observation";
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Gray;
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(22, 265);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 40);
            BtnSave.TabIndex = 10;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.Gray;
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(126, 265);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 40);
            BtnCancel.TabIndex = 11;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModeView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPageModeDetail.ResumeLayout(false);
            tabPageModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPageModeDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}