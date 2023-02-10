using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Currency_Panel
{
    public partial class LoginForm : Form
    {
        private string _login = Properties.Resources.Login;
        private string _password = Properties.Resources.Password;
        private string _salt = Properties.Resources.Salt;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;
            LoginInto(login, password);
        }

        private void LoginInto(string login, string password)
        {
            login = GetHash(login + _salt);
            password = GetHash(password + _salt);

            if ((login != _login) || (password != _password))
            {
                errorTextLabel.Visible = true;
                errorTextLabel.Text = "Неправаильный логин или пароль";
                return;
            }

            MoveToMain();
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public void MoveToMain()
        {
            var mainForm = new MainForm();
            mainForm.Location = this.Location;
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.FormClosing += delegate { this.Show(); };
            mainForm.Show();
            this.Hide();
        }
    }
}
