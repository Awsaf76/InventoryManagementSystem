using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class DashboardForm : Form
    {
        public bool IsLogoutInitiated { get; private set; }

        User user;

        public DashboardForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            AddUserForm addUserForm = new AddUserForm(this.user);

            addUserForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            addUserForm.ShowDialog();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInventoryForm viewInventoryForm = new ViewInventoryForm(this.user);

            viewInventoryForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            viewInventoryForm.ShowDialog();
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