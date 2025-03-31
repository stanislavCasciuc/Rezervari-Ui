using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Restaurant> restaurants = FetchRestaurantData();
            dataGridView1.DataSource = restaurants;
        }

        private List<Restaurant> FetchRestaurantData()
        {
           
            return new List<Restaurant>
            {
                new Restaurant { Name = "Restaurant A", Address = "123 Main St", Rating = 4.5 },
                new Restaurant { Name = "Restaurant B", Address = "456 Elm St", Rating = 4.0 },
                new Restaurant { Name = "Restaurant C", Address = "789 Oak St", Rating = 4.2 },
            };
        }
    }

    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
    }
}