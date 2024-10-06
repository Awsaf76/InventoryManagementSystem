using System.Drawing;
using System.Windows.Forms;
using System;

namespace InventoryManagementSystem
{
    partial class ViewOrders
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



        private void AdjustRowHeights()
        {
            foreach (DataGridViewRow row in dgvViewOrders.Rows)
            {
                // Get the cell value for the "OrderDetails" column (assuming it's at index 1)
                string cellValue = row.Cells[1].Value?.ToString();  // Adjust the column index as needed

                if (!string.IsNullOrEmpty(cellValue))
                {
                    // Count the number of lines by counting newline characters
                    int lineCount = cellValue.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;

                    // Set the row height based on the number of lines (increase the multiplier if needed)
                    row.Height = lineCount * dgvViewOrders.Font.Height + 10;  // Add some padding
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBackViewOrders = new System.Windows.Forms.Button();
            this.dgvViewOrders = new System.Windows.Forms.DataGridView();
            this.dgvOrderIdViewOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderDetailsViewOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalAmountViewOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserNameViewOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderStatusViewOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderDateViewOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackViewOrders
            // 
            this.btnBackViewOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackViewOrders.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackViewOrders.Location = new System.Drawing.Point(13, 33);
            this.btnBackViewOrders.Name = "btnBackViewOrders";
            this.btnBackViewOrders.Size = new System.Drawing.Size(120, 37);
            this.btnBackViewOrders.TabIndex = 1;
            this.btnBackViewOrders.Text = "Back";
            this.btnBackViewOrders.UseVisualStyleBackColor = false;
            this.btnBackViewOrders.Click += new System.EventHandler(this.btnBackViewOrders_Click);
            // 
            // dgvViewOrders
            // 
            this.dgvViewOrders.AllowUserToAddRows = false;
            this.dgvViewOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrderIdViewOrders,
            this.dgvOrderDetailsViewOrders,
            this.dgvTotalAmountViewOrders,
            this.dgvUserNameViewOrders,
            this.dgvOrderStatusViewOrders,
            this.dgvOrderDateViewOrders});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewOrders.Location = new System.Drawing.Point(13, 85);
            this.dgvViewOrders.Name = "dgvViewOrders";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewOrders.RowHeadersWidth = 51;
            this.dgvViewOrders.RowTemplate.Height = 24;
            this.dgvViewOrders.Size = new System.Drawing.Size(982, 323);
            this.dgvViewOrders.TabIndex = 2;
            // 
            // dgvOrderIdViewOrders
            // 
            this.dgvOrderIdViewOrders.HeaderText = "ID";
            this.dgvOrderIdViewOrders.MinimumWidth = 6;
            this.dgvOrderIdViewOrders.Name = "dgvOrderIdViewOrders";
            this.dgvOrderIdViewOrders.ReadOnly = true;
            this.dgvOrderIdViewOrders.Width = 49;
            // 
            // dgvOrderDetailsViewOrders
            // 
            this.dgvOrderDetailsViewOrders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetailsViewOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetailsViewOrders.HeaderText = "Details";
            this.dgvOrderDetailsViewOrders.MinimumWidth = 6;
            this.dgvOrderDetailsViewOrders.Name = "dgvOrderDetailsViewOrders";
            this.dgvOrderDetailsViewOrders.ReadOnly = true;
            this.dgvOrderDetailsViewOrders.Width = 78;
            // 
            // dgvTotalAmountViewOrders
            // 
            this.dgvTotalAmountViewOrders.HeaderText = "Total Amount";
            this.dgvTotalAmountViewOrders.MinimumWidth = 6;
            this.dgvTotalAmountViewOrders.Name = "dgvTotalAmountViewOrders";
            this.dgvTotalAmountViewOrders.ReadOnly = true;
            this.dgvTotalAmountViewOrders.Width = 115;
            // 
            // dgvUserNameViewOrders
            // 
            this.dgvUserNameViewOrders.HeaderText = "User Name";
            this.dgvUserNameViewOrders.MinimumWidth = 6;
            this.dgvUserNameViewOrders.Name = "dgvUserNameViewOrders";
            this.dgvUserNameViewOrders.ReadOnly = true;
            this.dgvUserNameViewOrders.Width = 105;
            // 
            // dgvOrderStatusViewOrders
            // 
            this.dgvOrderStatusViewOrders.HeaderText = "Status";
            this.dgvOrderStatusViewOrders.MinimumWidth = 6;
            this.dgvOrderStatusViewOrders.Name = "dgvOrderStatusViewOrders";
            this.dgvOrderStatusViewOrders.ReadOnly = true;
            this.dgvOrderStatusViewOrders.Width = 73;
            // 
            // dgvOrderDateViewOrders
            // 
            this.dgvOrderDateViewOrders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDateViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDateViewOrders.HeaderText = "Date";
            this.dgvOrderDateViewOrders.MinimumWidth = 6;
            this.dgvOrderDateViewOrders.Name = "dgvOrderDateViewOrders";
            this.dgvOrderDateViewOrders.ReadOnly = true;
            this.dgvOrderDateViewOrders.Width = 65;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.dgvViewOrders);
            this.Controls.Add(this.btnBackViewOrders);
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackViewOrders;
        private System.Windows.Forms.DataGridView dgvViewOrders;
        private DataGridViewTextBoxColumn dgvOrderIdViewOrders;
        private DataGridViewTextBoxColumn dgvOrderDetailsViewOrders;
        private DataGridViewTextBoxColumn dgvTotalAmountViewOrders;
        private DataGridViewTextBoxColumn dgvUserNameViewOrders;
        private DataGridViewTextBoxColumn dgvOrderStatusViewOrders;
        private DataGridViewTextBoxColumn dgvOrderDateViewOrders;
    }
}