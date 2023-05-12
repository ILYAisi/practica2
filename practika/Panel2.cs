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
    public partial class Panel2 : Form
    {
        public Panel2()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable dt = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();


        private void Panel2_Load(object sender, EventArgs e)
        {
           

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ArticleNumber.Text != "" && Name1.Text != "" && Description1.Text != "" && Manufacturer.Text != "" && Category.Text != ""
                && Cost.Text != "" && Category.Text != "" && discount.Text != "" && Amount.Text != "" && supplier.Text != "")
            {
                double price;
                int maxDiscount;
                int amount;
                if (double.TryParse(Cost.Text, out price) && int.TryParse(discount.Text, out maxDiscount) && int.TryParse(Amount.Text, out amount))
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `product` WHERE ProductArticleNumber = '" + ArticleNumber.Text + "'", db.GetConnection());
                    db.openConnection();
                    MySqlDataReader mySqlDataReader = command.ExecuteReader();
                    db.CloseConnection();
                    if (!mySqlDataReader.HasRows)
                    {
                        command = new MySqlCommand("INSERT INTO `product` (`ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductManufacturer` , `ProductCategory` , `ProductCost` , `Maximum possible discount` , `Product supplier` , `ProductDiscountAmount` , `ProductQuantityInStock` , `Product Description`) VALUES (@Artic, @Name1, @Description1, @Manufacturer , @Category ,@Cost , @discount , @supplier , @Amount, @Stock , @Description);", db.GetConnection());

                        command.Parameters.Add("@Artic", MySqlDbType.VarChar).Value = ArticleNumber.Text;
                        command.Parameters.Add("@Name1", MySqlDbType.VarChar).Value = Name1.Text;
                        command.Parameters.Add("@Description1", MySqlDbType.VarChar).Value = Description1.Text;
                        command.Parameters.Add("@Manufacturer", MySqlDbType.VarChar).Value = Manufacturer.Text;
                        command.Parameters.Add("@Category", MySqlDbType.VarChar).Value = Category.Text;
                        command.Parameters.Add("@Cost", MySqlDbType.VarChar).Value = Cost.Text;
                        command.Parameters.Add("@discount", MySqlDbType.VarChar).Value = discount.Text;
                        command.Parameters.Add("@supplier", MySqlDbType.VarChar).Value = supplier.Text;
                        command.Parameters.Add("@Amount", MySqlDbType.VarChar).Value = Amount.Text;

                        db.openConnection();

                        MessageBox.Show("Товар добавлен");

                        db.CloseConnection();
                        return;
                    }
                }
                MessageBox.Show(
                    "Поля скидки и цен должны быть числовыми!"
                    );
                return;
            }
            MessageBox.Show(
                    "Все поля должны быть заполненны!"
                    );
            return;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
