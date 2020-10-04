namespace OrderAppForms
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.cusAgeTextBox = new System.Windows.Forms.TextBox();
            this.cusAgeLabel = new System.Windows.Forms.Label();
            this.cusNameTextBox = new System.Windows.Forms.TextBox();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.detailDataGridView = new System.Windows.Forms.DataGridView();
            this.detailGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.cusAgeTextBox);
            this.panel1.Controls.Add(this.cusAgeLabel);
            this.panel1.Controls.Add(this.cusNameTextBox);
            this.panel1.Controls.Add(this.cusNameLabel);
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 152);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(463, 78);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(106, 43);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // cusAgeTextBox
            // 
            this.cusAgeTextBox.Location = new System.Drawing.Point(173, 92);
            this.cusAgeTextBox.Name = "cusAgeTextBox";
            this.cusAgeTextBox.Size = new System.Drawing.Size(201, 29);
            this.cusAgeTextBox.TabIndex = 6;
            // 
            // cusAgeLabel
            // 
            this.cusAgeLabel.AutoSize = true;
            this.cusAgeLabel.Location = new System.Drawing.Point(37, 95);
            this.cusAgeLabel.Name = "cusAgeLabel";
            this.cusAgeLabel.Size = new System.Drawing.Size(130, 23);
            this.cusAgeLabel.TabIndex = 5;
            this.cusAgeLabel.Text = "Customer Age:";
            // 
            // cusNameTextBox
            // 
            this.cusNameTextBox.Location = new System.Drawing.Point(173, 58);
            this.cusNameTextBox.Name = "cusNameTextBox";
            this.cusNameTextBox.Size = new System.Drawing.Size(201, 29);
            this.cusNameTextBox.TabIndex = 4;
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.Location = new System.Drawing.Point(21, 61);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(146, 23);
            this.cusNameLabel.TabIndex = 3;
            this.cusNameLabel.Text = "Customer Name:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(463, 29);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(106, 43);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(173, 23);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(201, 29);
            this.IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(135, 29);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(32, 23);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.detailDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 515);
            this.panel2.TabIndex = 1;
            // 
            // detailDataGridView
            // 
            this.detailDataGridView.AutoGenerateColumns = false;
            this.detailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.detailDataGridView.DataSource = this.detailGridBindingSource;
            this.detailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailDataGridView.Location = new System.Drawing.Point(0, 0);
            this.detailDataGridView.Name = "detailDataGridView";
            this.detailDataGridView.RowHeadersWidth = 51;
            this.detailDataGridView.RowTemplate.Height = 27;
            this.detailDataGridView.Size = new System.Drawing.Size(628, 515);
            this.detailDataGridView.TabIndex = 0;
            // 
            // detailGridBindingSource
            // 
            this.detailGridBindingSource.DataSource = typeof(OrderAppForms.OrderDetailGrid);
            // 
            // commodityNameDataGridViewTextBoxColumn
            // 
            this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
            this.commodityNameDataGridViewTextBoxColumn.HeaderText = "Commodityn Name";
            this.commodityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
            this.commodityNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 70;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView detailDataGridView;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.BindingSource detailGridBindingSource;
        private System.Windows.Forms.TextBox cusAgeTextBox;
        private System.Windows.Forms.Label cusAgeLabel;
        private System.Windows.Forms.TextBox cusNameTextBox;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}