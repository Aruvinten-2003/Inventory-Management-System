using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;

        public LoginForm()
        {
            InitializeComponent();
            BuildLoginUI();
        }

        private void BuildLoginUI()
        {
            this.Text = "Inventory Management System - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 550);
            this.BackColor = Color.Black;
            this.ForeColor = Color.DeepSkyBlue;

            lblTitle = new Label();
            lblTitle.Text = "Inventory Management System";
            lblTitle.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(250, 70);

            lblUsername = new Label();
            lblUsername.Text = "Username";
            lblUsername.ForeColor = Color.DeepSkyBlue;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(220, 170);

            txtUsername = new TextBox();
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 30);
            txtUsername.Location = new Point(340, 165);

            lblPassword = new Label();
            lblPassword.Text = "Password";
            lblPassword.ForeColor = Color.DeepSkyBlue;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(220, 230);

            txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 30);
            txtPassword.Location = new Point(340, 225);
            txtPassword.UseSystemPasswordChar = true;

            btnLogin = new Button();
            btnLogin.Name = "btnLogin";
            btnLogin.Text = "Login";
            btnLogin.Size = new Size(100, 40);
            btnLogin.Location = new Point(340, 310);
            btnLogin.Click += btnLogin_Click;

            btnExit = new Button();
            btnExit.Name = "btnExit";
            btnExit.Text = "Exit";
            btnExit.Size = new Size(100, 40);
            btnExit.Location = new Point(460, 310);
            btnExit.Click += btnExit_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnExit);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Login successful.");

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}