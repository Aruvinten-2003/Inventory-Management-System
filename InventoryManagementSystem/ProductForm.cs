using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductForm : Form
    {
        private Label lblTitle;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblPrice;

        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtPrice;

        private Button btnSave;
        private Button btnClear;
        private DataGridView dgvProducts;

        public ProductForm()
        {
            InitializeComponent();
            BuildProductUI();
        }

        private void BuildProductUI()
        {
            this.Text = "Product Management";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 650);
            this.BackColor = Color.Black;
            this.ForeColor = Color.DeepSkyBlue;

            lblTitle = new Label();
            lblTitle.Text = "Product Management";
            lblTitle.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(350, 30);

            lblProductName = new Label();
            lblProductName.Text = "Product Name";
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(80, 110);

            txtProductName = new TextBox();
            txtProductName.Size = new Size(220, 30);
            txtProductName.Location = new Point(220, 105);

            lblCategory = new Label();
            lblCategory.Text = "Category";
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(80, 160);

            txtCategory = new TextBox();
            txtCategory.Size = new Size(220, 30);
            txtCategory.Location = new Point(220, 155);

            lblQuantity = new Label();
            lblQuantity.Text = "Quantity";
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(80, 210);

            txtQuantity = new TextBox();
            txtQuantity.Size = new Size(220, 30);
            txtQuantity.Location = new Point(220, 205);

            lblPrice = new Label();
            lblPrice.Text = "Unit Price";
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(80, 260);

            txtPrice = new TextBox();
            txtPrice.Size = new Size(220, 30);
            txtPrice.Location = new Point(220, 255);

            btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Size = new Size(100, 40);
            btnSave.Location = new Point(220, 320);
            btnSave.Click += btnSave_Click;

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Size = new Size(100, 40);
            btnClear.Location = new Point(340, 320);
            btnClear.Click += btnClear_Click;

            dgvProducts = new DataGridView();
            dgvProducts.Location = new Point(80, 400);
            dgvProducts.Size = new Size(800, 180);
            dgvProducts.ColumnCount = 4;
            dgvProducts.Columns[0].Name = "Product Name";
            dgvProducts.Columns[1].Name = "Category";
            dgvProducts.Columns[2].Name = "Quantity";
            dgvProducts.Columns[3].Name = "Unit Price";

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblProductName);
            this.Controls.Add(txtProductName);
            this.Controls.Add(lblCategory);
            this.Controls.Add(txtCategory);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(lblPrice);
            this.Controls.Add(txtPrice);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnClear);
            this.Controls.Add(dgvProducts);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Add(
                txtProductName.Text,
                txtCategory.Text,
                txtQuantity.Text,
                txtPrice.Text
            );

            MessageBox.Show("Product added successfully.");
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtProductName.Focus();
        }
    }
}