namespace InventoryManagementSystem
{
    partial class ViewInventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnAddViewInventory = new System.Windows.Forms.Button();
            this.btnUpdateViewInventory = new System.Windows.Forms.Button();
            this.btnRemoveViewInventory = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnBackViewInventory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAllViewInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(65, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(148, 24);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name  :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(65, 100);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(149, 24);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Product Price    :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(65, 142);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(150, 24);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity            :";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(65, 180);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(149, 24);
            this.lblProductId.TabIndex = 3;
            this.lblProductId.Text = "Product Id         :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(216, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(216, 100);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(200, 22);
            this.txtProductPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(216, 144);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(216, 182);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 22);
            this.txtProductId.TabIndex = 7;
            // 
            // btnAddViewInventory
            // 
            this.btnAddViewInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddViewInventory.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddViewInventory.Location = new System.Drawing.Point(443, 165);
            this.btnAddViewInventory.Name = "btnAddViewInventory";
            this.btnAddViewInventory.Size = new System.Drawing.Size(100, 30);
            this.btnAddViewInventory.TabIndex = 8;
            this.btnAddViewInventory.Text = "Add";
            this.btnAddViewInventory.UseVisualStyleBackColor = false;
            this.btnAddViewInventory.Click += new System.EventHandler(this.btnAddViewInventory_Click);
            // 
            // btnUpdateViewInventory
            // 
            this.btnUpdateViewInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateViewInventory.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateViewInventory.Location = new System.Drawing.Point(618, 165);
            this.btnUpdateViewInventory.Name = "btnUpdateViewInventory";
            this.btnUpdateViewInventory.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateViewInventory.TabIndex = 9;
            this.btnUpdateViewInventory.Text = "Update";
            this.btnUpdateViewInventory.UseVisualStyleBackColor = false;
            this.btnUpdateViewInventory.Click += new System.EventHandler(this.btnUpdateViewInventory_Click);
            // 
            // btnRemoveViewInventory
            // 
            this.btnRemoveViewInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveViewInventory.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveViewInventory.Location = new System.Drawing.Point(778, 165);
            this.btnRemoveViewInventory.Name = "btnRemoveViewInventory";
            this.btnRemoveViewInventory.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveViewInventory.TabIndex = 10;
            this.btnRemoveViewInventory.Text = "Remove";
            this.btnRemoveViewInventory.UseVisualStyleBackColor = false;
            this.btnRemoveViewInventory.Click += new System.EventHandler(this.btnRemoveViewInventory_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductId,
            this.dgvProductName,
            this.dgvQuantity,
            this.dgvPrice});
            this.dgvProducts.Location = new System.Drawing.Point(80, 240);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(564, 200);
            this.dgvProducts.TabIndex = 12;
            // 
            // dgvProductId
            // 
            this.dgvProductId.HeaderText = "Product Id";
            this.dgvProductId.MinimumWidth = 6;
            this.dgvProductId.Name = "dgvProductId";
            this.dgvProductId.ReadOnly = true;
            this.dgvProductId.Width = 125;
            // 
            // dgvProductName
            // 
            this.dgvProductName.HeaderText = "Product Name";
            this.dgvProductName.MinimumWidth = 6;
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            this.dgvProductName.Width = 125;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.HeaderText = "Quantity";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            this.dgvQuantity.Width = 125;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 125;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(650, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(562, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(82, 24);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search  :";
            // 
            // btnBackViewInventory
            // 
            this.btnBackViewInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackViewInventory.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackViewInventory.Location = new System.Drawing.Point(12, 12);
            this.btnBackViewInventory.Name = "btnBackViewInventory";
            this.btnBackViewInventory.Size = new System.Drawing.Size(100, 30);
            this.btnBackViewInventory.TabIndex = 15;
            this.btnBackViewInventory.Text = "Back";
            this.btnBackViewInventory.UseVisualStyleBackColor = false;
            this.btnBackViewInventory.Click += new System.EventHandler(this.btnBackViewInventory_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(750, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAllViewInventory
            // 
            this.btnAllViewInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllViewInventory.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllViewInventory.Location = new System.Drawing.Point(544, 446);
            this.btnAllViewInventory.Name = "btnAllViewInventory";
            this.btnAllViewInventory.Size = new System.Drawing.Size(100, 30);
            this.btnAllViewInventory.TabIndex = 17;
            this.btnAllViewInventory.Text = "Show All";
            this.btnAllViewInventory.UseVisualStyleBackColor = false;
            this.btnAllViewInventory.Click += new System.EventHandler(this.btnAllViewInventory_Click);
            // 
            // ViewInventoryForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 479);
            this.Controls.Add(this.btnAllViewInventory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBackViewInventory);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnRemoveViewInventory);
            this.Controls.Add(this.btnUpdateViewInventory);
            this.Controls.Add(this.btnAddViewInventory);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnAddViewInventory;
        private System.Windows.Forms.Button btnUpdateViewInventory;
        private System.Windows.Forms.Button btnRemoveViewInventory;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnBackViewInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAllViewInventory;
    }
}
