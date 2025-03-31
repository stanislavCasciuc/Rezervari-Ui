using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class MainForm : Form
    {
        private List<Restaurant> restaurants;

        public MainForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
        }

        private void LoadSampleData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Bella Italia", "123 Main St, New York, NY 10001"),
                new Restaurant(2, "Sushi Express", "456 Park Ave, Boston, MA 02108"),
                new Restaurant(3, "Taste of India", "789 Oak Dr, Chicago, IL 60007"),
                new Restaurant(4, "Le Petit Café", "321 Maple Rd, San Francisco, CA 94102"),
                new Restaurant(5, "El Mariachi", "555 Pine Ln, Miami, FL 33101"),
                new Restaurant(6, "Golden Dragon", "888 Cedar Blvd, Seattle, WA 98101"),
                new Restaurant(7, "Burger Haven", "777 Elm St, Austin, TX 78701"),
                new Restaurant(8, "Mediterranean Delight", "444 Olive Way, Philadelphia, PA 19102")
            };

            RestaurantDataGridView.DataSource = restaurants;
        }

        private void SetupEventHandlers()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                RestaurantDataGridView.DataSource = restaurants;
                return;
            }

            var searchTerm = txtSearch.Text.ToLower();
            var filteredList = restaurants.FindAll(r =>
                r.Name.ToLower().Contains(searchTerm) ||
                r.Address.ToLower().Contains(searchTerm));

            RestaurantDataGridView.DataSource = null;
            RestaurantDataGridView.DataSource = filteredList;
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Restaurant(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}