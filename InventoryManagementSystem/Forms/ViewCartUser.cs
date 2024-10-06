using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ViewCartUser : Form
    {
        private Order currentOrder;
        User user;

        bool IsBackInitiated { get; set; }

        public ViewCartUser(Order currentOrder, User user)
        {
            InitializeComponent();
            this.user = user;
            this.currentOrder = currentOrder;
            LoadCartItems();
            CalculateSubTotal();
        }

        
        private void LoadCartItems()
        {
            dgvViewCartUser.Rows.Clear();

            foreach (OrderProduct item in currentOrder.Products)
            {
                dgvViewCartUser.Rows.Add(
                    item.ProductId,
                    item.ProductName,
                    item.Quantity,
                    item.UnitPrice.ToString("F2"),  
                    item.TotalPrice.ToString("F2")
                );
            }

            dgvViewCartUser.Refresh();
        }

        
        private void CalculateSubTotal()
        {
            decimal subTotal = 0;

            foreach (OrderProduct item in currentOrder.Products)
            {
                subTotal += item.Quantity * item.UnitPrice;
            }

            currentOrder.TotalAmount = subTotal;
            txtSubTotal.Text = subTotal.ToString("C2");  
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvViewCartUser.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvViewCartUser.SelectedRows[0];
                int productId = int.Parse(selectedRow.Cells["dgvProductIdViewCartUser"].Value.ToString());
                int quantity = int.Parse(selectedRow.Cells["dgvQuantityViewCartUser"].Value.ToString());
                decimal unitPrice = decimal.Parse(selectedRow.Cells["dgvUnitPriceViewCartUser"].Value.ToString());

                dgvViewCartUser.Rows.Remove(selectedRow);

                var productToRemove = currentOrder.Products.FirstOrDefault(p =>
                    p.ProductId == productId &&
                    p.Quantity == quantity &&
                    p.UnitPrice == unitPrice
                );

                if (productToRemove != null)
                {
                    currentOrder.Products.Remove(productToRemove);
                    MessageBox.Show($"Product '{productToRemove.ProductId}' removed from cart.");
                    LoadCartItems();
                    CalculateSubTotal();
                }
                else
                {
                    MessageBox.Show("Product not found in the order.");
                }
            }
            else if (dgvViewCartUser.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only a single item to remove.");
            }
            else
            {
                MessageBox.Show("Please select a single item to remove.");
            }
        }

        
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentOrder.Products == null || !currentOrder.Products.Any())
                {
                    MessageBox.Show("No items in the order. Please add products to the cart before confirming the order.",
                                    "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentOrder.UserId = user.UserId;
                currentOrder.UserName = user.Username;
                currentOrder.OrderStatus = "Confirmed";

                currentOrder.CreateOrder();
                currentOrder.InsertOrderDetails();

                foreach (OrderProduct item in currentOrder.Products)
                {
                    Product.DecreaseQuantity(item.ProductId, item.Quantity);
                }

                MessageBox.Show("Order confirmed successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentOrder.Products.Clear();
                IsBackInitiated = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder.Products == null || !currentOrder.Products.Any())
            {
                MessageBox.Show("No items in the order. Order cannot be cancelled.",
                                "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    currentOrder.UserId = user.UserId;
                    currentOrder.UserName = user.Username;
                    currentOrder.TotalAmount = 0;
                    currentOrder.OrderStatus = "Canceled";

                    currentOrder.CreateOrder();
                    currentOrder.InsertOrderDetails();

                    currentOrder.Products.Clear();
                    MessageBox.Show("Order canceled.", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsBackInitiated = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error canceling order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewCartBack_Click(object sender, EventArgs e)
        {
            IsBackInitiated = true;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            
            if (!IsBackInitiated)
            {
                Application.Exit();  
            }
        }

    }   
}