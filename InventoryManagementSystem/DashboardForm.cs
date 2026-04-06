using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class DashboardForm : Form
    {
        private Label lblTitle;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnSuppliers;
        private Button btnStockIn;
        private Button btnStockOut;
        private Button btnLogout;

        public DashboardForm()
        {
            InitializeComponent();
            BuildDashboardUI();
        }

        private void BuildDashboardUI()
        {
            this.Text = "Inventory Management Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.BackColor = Color.Black;
            this.ForeColor = Color.DeepSkyBlue;

            lblTitle = new Label();
            lblTitle.Text = "Inventory Management Dashboard";
            lblTitle.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(250, 50);

            btnProducts = new Button();
            btnProducts.Text = "Manage Products";
            btnProducts.Size = new Size(180, 50);
            btnProducts.Location = new Point(180, 150);
            btnProducts.Click += btnProducts_Click;

            btnCategories = new Button();
            btnCategories.Text = "Manage Categories";
            btnCategories.Size = new Size(180, 50);
            btnCategories.Location = new Point(420, 150);
            btnCategories.Click += btnCategories_Click;

            btnSuppliers = new Button();
            btnSuppliers.Text = "Manage Suppliers";
            btnSuppliers.Size = new Size(180, 50);
            btnSuppliers.Location = new Point(660, 150);
            btnSuppliers.Click += btnSuppliers_Click;

            btnStockIn = new Button();
            btnStockIn.Text = "Stock In";
            btnStockIn.Size = new Size(180, 50);
            btnStockIn.Location = new Point(180, 250);
            btnStockIn.Click += btnStockIn_Click;

            btnStockOut = new Button();
            btnStockOut.Text = "Stock Out";
            btnStockOut.Size = new Size(180, 50);
            btnStockOut.Location = new Point(420, 250);
            btnStockOut.Click += btnStockOut_Click;

            btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new Size(180, 50);
            btnLogout.Location = new Point(660, 250);
            btnLogout.Click += btnLogout_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(btnProducts);
            this.Controls.Add(btnCategories);
            this.Controls.Add(btnSuppliers);
            this.Controls.Add(btnStockIn);
            this.Controls.Add(btnStockOut);
            this.Controls.Add(btnLogout);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Category form will be created next.");
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supplier form will be created next.");
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock In form will be created next.");
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock Out form will be created next.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}