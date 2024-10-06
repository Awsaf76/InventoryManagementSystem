using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace InventoryManagementSystem
{
    public partial class DashboardUserForm : Form
    {
        private Order currentOrder = new Order();
        private List<OrderProduct> orderProducts = new List<OrderProduct>();
        User user;
        public bool IsLogoutInitiated { get; private set; }

        public DashboardUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.Rows.Clear();

            List<Product> products = Product.GetAllProducts();

            foreach (var product in products)
            {
                dgvProducts.Rows.Add(
                    product.ProductId.ToString(),
                    product.ProductName,
                    product.Quantity.ToString(),
                    product.Price.ToString("F2")
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a product name or ID to search.");
                LoadProducts();
                return;
            }

            try
            {
                List<Product> products = Product.GetProductByName(searchText);

                if (products.Count > 0)
                {
                    dgvProducts.Rows.Clear();
                    foreach (var product in products)
                    {
                        dgvProducts.Rows.Add(
                            product.ProductId.ToString(),
                            product.ProductName,
                            product.Quantity.ToString(),
                            product.Price.ToString("F2")  
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No product found.");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }

        }

        
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                int productId = int.Parse(selectedRow.Cells["dgvProductId"].Value.ToString());
                string productName = selectedRow.Cells["dgvProductName"].Value.ToString();
                int availableQuantity = int.Parse(selectedRow.Cells["dgvQuantity"].Value.ToString());
                decimal unitPrice = decimal.Parse(selectedRow.Cells["dgvPrice"].Value.ToString());

                
                string quantityInput = Interaction.InputBox("Enter Quantity:", "Quantity", "1");

                if (int.TryParse(quantityInput, out int addQuantity) && addQuantity > 0 && addQuantity <= availableQuantity)
                {
                    
                    OrderProduct orderProduct = new OrderProduct
                    {
                        ProductId = productId,
                        ProductName = productName,
                        Quantity = addQuantity,
                        UnitPrice = unitPrice
                    };

                    
                    orderProducts.Add(orderProduct);

                    currentOrder.Products.Add(orderProduct);

                    MessageBox.Show($"Product '{productName}' added to cart!");

                }
                else
                {
                    MessageBox.Show("Invalid quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        
        private void btnViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewCartUser viewCartUser = new ViewCartUser(this.currentOrder, this.user);

            viewCartUser.FormClosed += (s, args) =>
            {
                this.Show();
                LoadProducts();
            };

            viewCartUser.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrders viewOrders = new ViewOrders(this.user);

            viewOrders.FormClosed += (s, args) =>
            {
                this.Show();
            };
            viewOrders.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsLogoutInitiated = true;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            
            if (!IsLogoutInitiated)
            {
                Application.Exit(); 
            }
        }
    }
}