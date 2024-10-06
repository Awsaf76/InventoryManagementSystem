using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ViewOrders : Form
    {
        User user;
        bool IsBackInitiated { get; set; }

        public ViewOrders(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                dgvViewOrders.Rows.Clear();

                List<Order> orders;

                if (user.IsAdmin)
                {
                    orders = Order.GetAllOrders();
                }
                else
                {
                    orders = Order.GetOrdersByUserId(user.UserId);
                }

                if (orders == null || !orders.Any())
                {
                    MessageBox.Show("No orders found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var order in orders)
                {
                    decimal totalPrice = order.TotalAmount;

                    string orderDetails = string.Join(Environment.NewLine,
                        order.Products.Select(p => $"Product Name: {p.ProductName}, Quantity: {p.Quantity}"));

                    dgvViewOrders.Rows.Add(
                        order.OrderId,
                        orderDetails,
                        totalPrice.ToString("C"),
                        order.UserName,
                        order.OrderStatus,
                        order.OrderDate
                    );
                }
                AdjustRowHeights();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBackViewOrders_Click(object sender, EventArgs e)
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
