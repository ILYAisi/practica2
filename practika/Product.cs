using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practika
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable dt = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        public Product(string Name, string Surname)
        {
            InitializeComponent();
            IsLogin.Text = Name;
            IsPass.Text = Surname;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `product`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Артикул";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Категория";
            dataGridView1.Columns[3].HeaderText = "Расходы";
            dataGridView1.Columns[4].HeaderText = "Максимальная скидка";
            dataGridView1.Columns[5].HeaderText = "Производитель";
            dataGridView1.Columns[6].HeaderText = "Компания";
            dataGridView1.Columns[7].HeaderText = "Категория";
            dataGridView1.Columns[8].HeaderText = "Кол-во скидок";
            dataGridView1.Columns[9].HeaderText = "Наличие шт";
            dataGridView1.Columns[10].HeaderText = "Описание";
            dataGridView1.Columns[11].HeaderText = "Фото";


        }

        private void add_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel2 form1 =new Panel2();
            form1.ShowDialog();

           
        }
    }
}
