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
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
            logLogBox.Text = "Введите логин";
            logLogBox.ForeColor = Color.Gray;
            logPassBox.Text = "Введите пароль";
            logPassBox.ForeColor = Color.Gray;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (logLogBox.Text == "Введите логин")
            {
                logLogBox.ForeColor = Color.Red;
                return;
            }

            if (logPassBox.Text == "Введите пароль")
            {
                logPassBox.ForeColor = Color.Red;
                return;
            }
            string userLogin = logLogBox.Text;
            string userPassword = logPassBox.Text;

            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userL AND `password` = @userP", dataBase.GetConnection());
            command.Parameters.Add("@userL", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userP", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                logErrorText.ForeColor = Color.Red;
                logErrorText.Visible = true;
            }
            else
            {
                this.Hide();
            }
        }

        private void logLogBox_Enter(object sender, EventArgs e)
        {
            if (logLogBox.Text == "Введите логин")
                logLogBox.Text = "";
            logLogBox.ForeColor = Color.Black;
        }

        private void logLogBox_Leave(object sender, EventArgs e)
        {
            if (logLogBox.Text == "")
            { 
                logLogBox.Text = "Введите логин";
                logLogBox.ForeColor = Color.Gray;
            }
        }

        private void logPassBox_Enter(object sender, EventArgs e)
        {
            if (logPassBox.Text == "Введите пароль")
                logPassBox.Text = "";
            logPassBox.UseSystemPasswordChar = true;
            logPassBox.ForeColor = Color.Black;
        }

        private void logPassBox_Leave(object sender, EventArgs e)
        {
            if (logPassBox.Text == "")
            {
                logPassBox.Text = "Введите пароль";
                logPassBox.UseSystemPasswordChar = false;
                logPassBox.ForeColor = Color.Gray;
            }
        }

        private void goRegButton_Click(object sender, EventArgs e)
        {
            regForm regForm = new regForm();
            regForm.ShowDialog();
        }

        private void logForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
