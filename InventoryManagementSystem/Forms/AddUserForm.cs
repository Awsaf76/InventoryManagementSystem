using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddUserForm : Form
    {
        User user;
        bool IsBackInitiated { get; set; }

        public AddUserForm(User user)
        {
            InitializeComponent();
            this.Load += new EventHandler(AddUserForm_Load);
            this.user = user;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            List<User> users = User.GetAllUsers();

            dgvUsers.Rows.Clear();  // Clear any previous data

            // Loop through the list of users and add them to the DataGridView
            foreach (var user in users)
            {
                dgvUsers.Rows.Add(
                    user.UserId.ToString(),
                    user.Name,
                    user.Username,
                    user.IsAdmin ? "Admin" : "User"
                );
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                txtId.Text = selectedRow.Cells["dgvUserId"].Value.ToString();
                txtName.Text = selectedRow.Cells["dgvName"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["dgvUsername"].Value.ToString();
            }
        }

        private void ClearTextboxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

        }

        private void ClearSelection()
        {
            dgvUsers.ClearSelection();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User newUser = new User
            {
                Name = name,
                Username = username,
                Password = password,
                IsAdmin = false
            };

            try
            {
                newUser.CreateUser();
                MessageBox.Show("User added successfully!");
                LoadUsers();
                ClearSelection();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];

            string originalName = selectedRow.Cells["dgvName"].Value.ToString();
            string originalUsername = selectedRow.Cells["dgvUsername"].Value.ToString();

            User user = new User { UserId = id };

            bool isUpdated = false;

            try
            {
                if (name != originalName)
                {
                    user.Name = name;
                    user.UpdateName(id);
                    isUpdated = true;
                }

                if (username != originalUsername)
                {
                    user.Username = username;
                    user.UpdateUsername(id);
                    isUpdated = true;
                }

                if (!string.IsNullOrEmpty(password))
                {
                    user.Password = password;
                    user.UpdatePassword(id);
                    isUpdated = true;
                }

                if (!isUpdated)
                {
                    MessageBox.Show("No changes were made.");
                    return;
                }

                MessageBox.Show("User updated successfully!");
                LoadUsers();
                ClearTextboxes();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the User: " + ex.Message);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select a user to remove.");
                return;
            }

            int userId = int.Parse(txtId.Text);

            try
            {
                User.DeleteUser(userId);
                MessageBox.Show("User removed successfully!");
                LoadUsers();
                ClearTextboxes();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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
