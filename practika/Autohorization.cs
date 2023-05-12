using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace practika
{
    public partial class Autohorization : Form
    {
        public Autohorization()
        {
            InitializeComponent();
        }

    

        private void GuestButton_Click(object sender, EventArgs e) //Кнопка гостя, которая после нажатия перенаправляет в другую форму
        {
            Products form=new Products();
            form.Show();
            this.Hide();
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            
            string loginUser = login.Text;
            string passUser = password.Text;
            
            


            DB db = new DB(); 
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();//Подключение к базе данных
           
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `UserLogin`= @uL AND `UserPassword` = @uP ", db.GetConnection()); //Задаем команду для взаимодействия с базой данных

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser; //Заглушка для пользования 
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser; //Заглушка для пользования 




            adapter.SelectCommand = command; // Выполнение заданной команды для базы данных
            adapter.Fill(dt); // Заполнение таблицы
            if (dt.Rows.Count > 0)
            {
                // Кладём в переменные информацию из базы
                string login = dt.Rows[0]["UserLogin"].ToString();
                string pass = dt.Rows[0]["UserPassword"].ToString();
                string Name = dt.Rows[0]["UserName"].ToString();
                string Surname = dt.Rows[0]["UserSurname"].ToString();
            

                this.Hide();
                Product form = new Product(Name, Surname); //Передаем "Имя", "Фамилию" в форму "Product" 
                form.Show();
            }
            else
                MessageBox.Show("Ошибка"); //Исключение если неудалось подключится к базе
            
        }

        private void CloseButton_Click(object sender, EventArgs e) //Кнопка закрытия программы
        {
            this.Close(); //Закрытие окна
        }
    }
}
