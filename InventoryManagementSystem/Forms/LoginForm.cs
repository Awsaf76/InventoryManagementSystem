using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeLoginForm();
        }

        User user;

        private bool isDashboardOpen = false;
        private bool isDashboardUserOpen = false;

        private void InitializeLoginForm()
        {
            
            lblUsername.Text = "Username:";
            lblPassword.Text = "Password:";

            
            txtUsername.Name = "txtUsername";
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';

           
            btnLogin.Text = "Login";
            btnLogin.Click += new EventHandler(btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            btnLogin.Enabled = false;


            try
            {
                if (isDashboardOpen || isDashboardUserOpen)
                {
                    btnLogin.Enabled = true;
                    return;
                }

                if (AuthenticateUser(username, password) == 1)
                {
                    isDashboardOpen = true;

                    this.Hide(); 

                    DashboardForm dashboardForm = new DashboardForm(this.user);

                    dashboardForm.FormClosed += (s, args) =>
                    {
                        isDashboardOpen = false;  
                        this.Show();  
                        btnLogin.Enabled = true;  
                        txtPassword.Clear();
                        txtUsername.Focus();
                    };

                    dashboardForm.Show();

                }
                else if (AuthenticateUser(username, password) == 0)
                {
                    isDashboardUserOpen = true;

                    this.Hide(); 

                    DashboardUserForm dashboardUserForm = new DashboardUserForm(this.user);

                    dashboardUserForm.FormClosed += (s, args) =>
                    {
                        isDashboardUserOpen = false;  
                        this.Show();  
                        btnLogin.Enabled = true;  
                        txtPassword.Clear();
                        txtUsername.Focus();
                    };

                    dashboardUserForm.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Focus();
                    btnLogin.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLogin.Enabled = true;
            }
        }

        private int AuthenticateUser(string username, string password)
        {
            this.user = User.GetUserByUsername(username);

            if (this.user != null)
            {
                if (password == this.user.Password)
                {

                    return this.user.IsAdmin ? 1 : 0;
                }
            }

            return 100;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
