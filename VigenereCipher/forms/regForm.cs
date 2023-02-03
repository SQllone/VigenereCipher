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

namespace VigenereCipher
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
            regLogBox.Text = "Введите логин";
            regLogBox.ForeColor = Color.Gray;
            regPassBox.Text = "Введите пароль";
            regPassBox.ForeColor = Color.Gray;
            regPassBox.UseSystemPasswordChar = false;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (regLogBox.Text == "Введите логин")
            {
                regLogBox.ForeColor = Color.Red;
                return;
            }

            if (regPassBox.Text == "Введите пароль")
            {
                regPassBox.ForeColor = Color.Red;
                return;
            }

            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand checkUserLogin = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @newUserL", dataBase.GetConnection());
            checkUserLogin.Parameters.Add("@newUserL", MySqlDbType.VarChar).Value = regLogBox.Text;
            adapter.SelectCommand = checkUserLogin;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                regErrorText.Visible = true;
                return;
            }
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`, `password`) VALUES (@newUserL,@newUserP)", dataBase.GetConnection());
            command.Parameters.Add("@newUserL", MySqlDbType.VarChar).Value = regLogBox.Text;
            command.Parameters.Add("@newUserP", MySqlDbType.VarChar).Value = regPassBox.Text;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация успешна!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации!");
                Application.Exit();
            }
            dataBase.CloseConnection();

        }

        private void regLogBox_Enter(object sender, EventArgs e)
        {
            if (regLogBox.Text == "Введите логин")
                regLogBox.Text = "";
            regLogBox.ForeColor = Color.Black;
        }

        private void regLogBox_Leave(object sender, EventArgs e)
        {
            if (regLogBox.Text == "")
            {
                regLogBox.Text = "Введите логин";
                regLogBox.ForeColor = Color.Gray;
            }
        }

        private void regPassBox_Enter(object sender, EventArgs e)
        {
            if (regPassBox.Text == "Введите пароль")
                regPassBox.Text = "";
            regPassBox.UseSystemPasswordChar = true;
            regPassBox.ForeColor = Color.Black;
        }

        private void regPassBox_Leave(object sender, EventArgs e)
        {
            if (regPassBox.Text == "")
            {
                regPassBox.Text = "Введите пароль";
                regPassBox.UseSystemPasswordChar = false;
                regPassBox.ForeColor = Color.Gray;
            }
        }
    }
}
