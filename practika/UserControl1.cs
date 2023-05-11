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
using System.Xml.Linq;

namespace practika
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        DB db = new DB();
        DataTable dt = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();


        private void UserControl1_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `product` (`ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductManufacturer` , `ProductCategory` , `ProductCost` , `Maximum possible discount` , `Product supplier` , `ProductDiscountAmount` , `ProductQuantityInStock` , `Product Description`) VALUES (@Artic, @Name1, @Description1, @Manufacturer , @Category ,@Cost , @discount , @supplier , @Amount, @Stock , @Description);", db.GetConnection());

      
            command.Parameters.Add("@Name1", MySqlDbType.VarChar).Value = NameUon.Text;
            command.Parameters.Add("@Description1", MySqlDbType.VarChar).Value = Description12.Text;
            command.Parameters.Add("@Manufacturer", MySqlDbType.VarChar).Value = Manufacturer1.Text;   
            command.Parameters.Add("@Cost", MySqlDbType.VarChar).Value = Cost1.Text;


            db.openConnection();
            db.CloseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
