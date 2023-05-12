using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practika
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            Items();
        }
        DB db = new DB();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();



        private void Products_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `product`", db.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
        }
        private void Items()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `product`", db.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            ListItem[] listItems = new ListItem[2];
            if (dt.Rows.Count > 0)
            {
                for (int p = 0; p < dt.Rows.Count - 1; p++)
                {
                    string Name = dt.Rows[p]["ProductName"].ToString();
                    string December = dt.Rows[p]["ProductDescription"].ToString();
                    string Manifacture = dt.Rows[p]["ProductManufacturer"].ToString();
                    string Cost = dt.Rows[p]["ProductCost"].ToString();
                    string Store = dt.Rows[p]["ProductQuantityInStock"].ToString();
                    for (int i = 0; i < listItems.Length; i++)
                    {
                        listItems[i] = new ListItem();
                        listItems[i].PName = Name;
                        listItems[i].December = December;
                        listItems[i].Manifacture = Manifacture;
                        listItems[i].Cost = Cost;
                        listItems[i].Store = Store;
                        flowLayoutPanel1.Controls.Add(listItems[i]);
                    }
                }
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Autohorization newform = new Autohorization();
            newform.ShowDialog();
            dt.Clear();
            adapter.Fill(dt);
        }
    }
}
