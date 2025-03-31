using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView RestaurantDataGridView;
        private Panel topPanel;
        private Label lblTitle;
        private TextBox txtSearch;
        private Label lblSearch;
        private Panel bottomPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Restaurant Manager";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Top Panel
            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = Color.FromArgb(41, 128, 185)
            };

            lblTitle = new Label
            {
                Text = "RESTAURANT DIRECTORY",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 20)
            };

            lblSearch = new Label
            {
                Text = "Search:",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 70)
            };

            txtSearch = new TextBox
            {
                Width = 250,
                Height = 30,
                Font = new Font("Segoe UI", 12),
                Location = new Point(90, 66),
                BorderStyle = BorderStyle.FixedSingle
            };

            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(lblSearch);
            topPanel.Controls.Add(txtSearch);

            // DataGridView
            RestaurantDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Configure the appearance of the DataGridView
            RestaurantDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            RestaurantDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            RestaurantDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            RestaurantDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            RestaurantDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            RestaurantDataGridView.ColumnHeadersHeight = 40;
            RestaurantDataGridView.RowTemplate.Height = 30;

            // Bottom Panel
            bottomPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = Color.FromArgb(41, 128, 185)
            };

            // Add controls to form
            this.Controls.Add(RestaurantDataGridView);
            this.Controls.Add(bottomPanel);
            this.Controls.Add(topPanel);
        }
    }
}