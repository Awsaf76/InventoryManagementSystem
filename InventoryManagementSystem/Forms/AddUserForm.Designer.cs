namespace InventoryManagementSystem
{
    partial class AddUserForm
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
            this.lblNameAddUser = new System.Windows.Forms.Label();
            this.lblUsernameAddUser = new System.Windows.Forms.Label();
            this.lblPasswordAddUser = new System.Windows.Forms.Label();
            this.lblConfirmPasswordAddUser = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdAddUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameAddUser
            // 
            this.lblNameAddUser.AutoSize = true;
            this.lblNameAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAddUser.Location = new System.Drawing.Point(82, 108);
            this.lblNameAddUser.Name = "lblNameAddUser";
            this.lblNameAddUser.Size = new System.Drawing.Size(176, 24);
            this.lblNameAddUser.TabIndex = 0;
            this.lblNameAddUser.Text = "Name                      :";
            // 
            // lblUsernameAddUser
            // 
            this.lblUsernameAddUser.AutoSize = true;
            this.lblUsernameAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameAddUser.Location = new System.Drawing.Point(82, 141);
            this.lblUsernameAddUser.Name = "lblUsernameAddUser";
            this.lblUsernameAddUser.Size = new System.Drawing.Size(176, 24);
            this.lblUsernameAddUser.TabIndex = 1;
            this.lblUsernameAddUser.Text = "Username               :";
            // 
            // lblPasswordAddUser
            // 
            this.lblPasswordAddUser.AutoSize = true;
            this.lblPasswordAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAddUser.Location = new System.Drawing.Point(82, 175);
            this.lblPasswordAddUser.Name = "lblPasswordAddUser";
            this.lblPasswordAddUser.Size = new System.Drawing.Size(175, 24);
            this.lblPasswordAddUser.TabIndex = 2;
            this.lblPasswordAddUser.Text = "Password                :";
            // 
            // lblConfirmPasswordAddUser
            // 
            this.lblConfirmPasswordAddUser.AutoSize = true;
            this.lblConfirmPasswordAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordAddUser.Location = new System.Drawing.Point(82, 208);
            this.lblConfirmPasswordAddUser.Name = "lblConfirmPasswordAddUser";
            this.lblConfirmPasswordAddUser.Size = new System.Drawing.Size(174, 24);
            this.lblConfirmPasswordAddUser.TabIndex = 3;
            this.lblConfirmPasswordAddUser.Text = "Confirm Password :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(274, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(274, 143);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(407, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(273, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(407, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(272, 210);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(407, 22);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(272, 259);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(104, 39);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 34);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUserId,
            this.dgvName,
            this.dgvUsername,
            this.dgvRole});
            this.dgvUsers.Location = new System.Drawing.Point(12, 336);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(700, 262);
            this.dgvUsers.TabIndex = 10;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // dgvUserId
            // 
            this.dgvUserId.HeaderText = "UserID";
            this.dgvUserId.MinimumWidth = 6;
            this.dgvUserId.Name = "dgvUserId";
            this.dgvUserId.ReadOnly = true;
            this.dgvUserId.Width = 125;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 125;
            // 
            // dgvUsername
            // 
            this.dgvUsername.HeaderText = "Username";
            this.dgvUsername.MinimumWidth = 6;
            this.dgvUsername.Name = "dgvUsername";
            this.dgvUsername.ReadOnly = true;
            this.dgvUsername.Width = 125;
            // 
            // dgvRole
            // 
            this.dgvRole.HeaderText = "Role";
            this.dgvRole.MinimumWidth = 6;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.Width = 125;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(382, 259);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(137, 39);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(525, 259);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(128, 39);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(274, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(407, 22);
            this.txtId.TabIndex = 14;
            // 
            // lblIdAddUser
            // 
            this.lblIdAddUser.AutoSize = true;
            this.lblIdAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAddUser.Location = new System.Drawing.Point(82, 71);
            this.lblIdAddUser.Name = "lblIdAddUser";
            this.lblIdAddUser.Size = new System.Drawing.Size(174, 24);
            this.lblIdAddUser.TabIndex = 13;
            this.lblIdAddUser.Text = "ID                            :";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 631);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdAddUser);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblConfirmPasswordAddUser);
            this.Controls.Add(this.lblPasswordAddUser);
            this.Controls.Add(this.lblUsernameAddUser);
            this.Controls.Add(this.lblNameAddUser);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAddUser;
        private System.Windows.Forms.Label lblUsernameAddUser;
        private System.Windows.Forms.Label lblPasswordAddUser;
        private System.Windows.Forms.Label lblConfirmPasswordAddUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdAddUser;
    }
}