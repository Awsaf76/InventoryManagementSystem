namespace InventoryManagementSystem
{
    partial class ViewCartUser
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
            this.dgvViewCartUser = new System.Windows.Forms.DataGridView();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnViewCartBack = new System.Windows.Forms.Button();
            this.dgvProductIdViewCartUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductNameViewCartUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantityViewCartUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitPriceViewCartUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPriceViewCartUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCartUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewCartUser
            // 
            this.dgvViewCartUser.AllowUserToAddRows = false;
            this.dgvViewCartUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewCartUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCartUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductIdViewCartUser,
            this.dgvProductNameViewCartUser,
            this.dgvQuantityViewCartUser,
            this.dgvUnitPriceViewCartUser,
            this.dgvTotalPriceViewCartUser});
            this.dgvViewCartUser.Location = new System.Drawing.Point(12, 65);
            this.dgvViewCartUser.Name = "dgvViewCartUser";
            this.dgvViewCartUser.ReadOnly = true;
            this.dgvViewCartUser.RowHeadersWidth = 51;
            this.dgvViewCartUser.RowTemplate.Height = 24;
            this.dgvViewCartUser.Size = new System.Drawing.Size(955, 250);
            this.dgvViewCartUser.TabIndex = 0;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(12, 375);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(138, 32);
            this.btnConfirmOrder.TabIndex = 1;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(475, 375);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(138, 32);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(233, 375);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(138, 32);
            this.btnCancelOrder.TabIndex = 3;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSubTotal.Location = new System.Drawing.Point(119, 336);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(162, 22);
            this.txtSubTotal.TabIndex = 4;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(21, 339);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(80, 19);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Sub Total :";
            // 
            // btnViewCartBack
            // 
            this.btnViewCartBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewCartBack.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCartBack.Location = new System.Drawing.Point(12, 12);
            this.btnViewCartBack.Name = "btnViewCartBack";
            this.btnViewCartBack.Size = new System.Drawing.Size(138, 32);
            this.btnViewCartBack.TabIndex = 6;
            this.btnViewCartBack.Text = "Back";
            this.btnViewCartBack.UseVisualStyleBackColor = false;
            this.btnViewCartBack.Click += new System.EventHandler(this.btnViewCartBack_Click);
            // 
            // dgvProductIdViewCartUser
            // 
            this.dgvProductIdViewCartUser.HeaderText = "Product ID";
            this.dgvProductIdViewCartUser.MinimumWidth = 6;
            this.dgvProductIdViewCartUser.Name = "dgvProductIdViewCartUser";
            this.dgvProductIdViewCartUser.ReadOnly = true;
            this.dgvProductIdViewCartUser.Width = 125;
            // 
            // dgvProductNameViewCartUser
            // 
            this.dgvProductNameViewCartUser.HeaderText = "Product Name";
            this.dgvProductNameViewCartUser.MinimumWidth = 6;
            this.dgvProductNameViewCartUser.Name = "dgvProductNameViewCartUser";
            this.dgvProductNameViewCartUser.ReadOnly = true;
            this.dgvProductNameViewCartUser.Width = 125;
            // 
            // dgvQuantityViewCartUser
            // 
            this.dgvQuantityViewCartUser.HeaderText = "Quantity";
            this.dgvQuantityViewCartUser.MinimumWidth = 6;
            this.dgvQuantityViewCartUser.Name = "dgvQuantityViewCartUser";
            this.dgvQuantityViewCartUser.ReadOnly = true;
            this.dgvQuantityViewCartUser.Width = 125;
            // 
            // dgvUnitPriceViewCartUser
            // 
            this.dgvUnitPriceViewCartUser.HeaderText = "Unit Price";
            this.dgvUnitPriceViewCartUser.MinimumWidth = 6;
            this.dgvUnitPriceViewCartUser.Name = "dgvUnitPriceViewCartUser";
            this.dgvUnitPriceViewCartUser.ReadOnly = true;
            this.dgvUnitPriceViewCartUser.Width = 125;
            // 
            // dgvTotalPriceViewCartUser
            // 
            this.dgvTotalPriceViewCartUser.HeaderText = "Total Price";
            this.dgvTotalPriceViewCartUser.MinimumWidth = 6;
            this.dgvTotalPriceViewCartUser.Name = "dgvTotalPriceViewCartUser";
            this.dgvTotalPriceViewCartUser.ReadOnly = true;
            this.dgvTotalPriceViewCartUser.Width = 125;
            // 
            // ViewCartUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 412);
            this.Controls.Add(this.btnViewCartBack);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.dgvViewCartUser);
            this.Name = "ViewCartUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCartUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewCartUser;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnViewCartBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductIdViewCartUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductNameViewCartUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantityViewCartUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitPriceViewCartUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPriceViewCartUser;
    }
}