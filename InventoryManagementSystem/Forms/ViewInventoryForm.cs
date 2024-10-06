using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ViewInventoryForm : Form
    {
        User user;
        bool IsBackInitiated { get; set; }

        public ViewInventoryForm(User user)
        {
            this.user = user;
            InitializeComponent();
            LoadProducts();
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
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

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                txtProductId.Text = selectedRow.Cells["dgvProductId"].Value.ToString();
                txtProductName.Text = selectedRow.Cells["dgvProductName"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["dgvQuantity"].Value.ToString();
                txtProductPrice.Text = selectedRow.Cells["dgvPrice"].Value.ToString();
            }
        }

        private void ClearTextboxes()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtProductPrice.Clear();
        }

        private void ClearSelection()
        {
            dgvProducts.ClearSelection();
        }

        private void btnAddViewInventory_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal productPrice = decimal.Parse(txtProductPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            if (string.IsNullOrEmpty(productName) || productPrice <= 0 || quantity <= 0)
            {
                MessageBox.Show("Please enter valid details.");
                return;
            }

            Product product = new Product
            {
                ProductName = productName,
                Price = productPrice,
                Quantity = quantity
            };

            try
            {
                product.CreateProduct();
                MessageBox.Show("Product added successfully!");
                LoadProducts();
                ClearTextboxes();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateViewInventory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            int productId = int.Parse(txtProductId.Text);
            string productName = txtProductName.Text;
            decimal productPrice = decimal.Parse(txtProductPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

            string originalProductName = selectedRow.Cells["dgvProductName"].Value.ToString();
            decimal originalPrice = decimal.Parse(selectedRow.Cells["dgvPrice"].Value.ToString());
            int originalQuantity = int.Parse(selectedRow.Cells["dgvQuantity"].Value.ToString());

            Product product = new Product { ProductId = productId };

            bool isUpdated = false;

            if (productName != originalProductName)
            {
                product.ProductName = productName;
                product.UpdateProductName(productId);
                isUpdated = true;
            }

            if (productPrice != originalPrice)
            {
                product.Price = productPrice;
                product.UpdateProductPrice(productId);
                isUpdated = true;
            }

            if (quantity != originalQuantity)
            {
                product.Quantity = quantity;
                product.UpdateProductQuantity(productId);
                isUpdated = true;
            }

            if (!isUpdated)
            {
                MessageBox.Show("No changes were made.");
                return;
            }

            try
            {
                MessageBox.Show("Product updated successfully!");
                LoadProducts();
                ClearTextboxes();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the product: " + ex.Message);
            }
        }

        private void btnRemoveViewInventory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            int productId = int.Parse(txtProductId.Text);

            try
            {
                Product.DeleteProduct(productId);
                MessageBox.Show("Product removed successfully!");
                LoadProducts();
                ClearTextboxes();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a product name to search.");
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

        private void btnBackViewInventory_Click(object sender, EventArgs e)
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

        private void btnAllViewInventory_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}