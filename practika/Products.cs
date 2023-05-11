using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        DB db = new DB();
        DataTable dt = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();



        private void Products_Load(object sender, EventArgs e)
        {

        }
    }
}
