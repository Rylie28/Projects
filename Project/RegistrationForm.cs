using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace real_loginForm
{
    public partial class RegistrationForm : Form
    {
        //nick : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nickl\\source\\repos\\2-13-25\\UserDB.mdf;Integrated Security=True
        //alexis : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\Source\Repos\LoginForm\UserDB.mdf;Integrated Security=True
        //rylie : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\rjmeyer\\LoginForm\\UserDB.mdf;Integrated Security=True
        //jack : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\source\repos\LoginForm\UserDB.mdf;Integrated Security=True
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\LoginForm\\UserDB.mdf;Integrated Security=True";

        private clsDBmanager dbManager = new clsDBmanager();

        private loginForm _loginForm;
        public RegistrationForm(loginForm login)
        {
            InitializeComponent();

            _loginForm = login;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {

                ParseRegistrationForm();

                if (_loginForm != null)
                {
                    _loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login form instance is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }
        private void ParseRegistrationForm()
        {

                string firstName = firstnameTxt.Text.Trim();
                string lastName = lastnameTxt.Text.Trim();
                string username = usernameTxt.Text.Trim();
                string password = passwordTxt.Text;
                string confirmPassword = repasswordTxt.Text;
                string email = emailTxt.Text.Trim();
                string role = roleBox.SelectedItem != null ? roleBox.SelectedItem.ToString() : "";

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username is required.");
                    return;
                }
                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required.");
                    return;
                }
                else if (string.IsNullOrEmpty(firstName))
                {
                    MessageBox.Show("First name is required.");
                    return;
                }
                else if (string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("Last name is required.");
                    return;
                }
                else if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email is required.");
                    return;
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                if (string.IsNullOrEmpty(role) || role == "Choose Role")
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                clsUser temp = new clsUser(username, password, firstName, lastName, role, email);
                bool isRegistered = temp.Register();
                //bool isRegistered = dbManager.RegisterUser(username, password, firstName, lastName, role, email);

                if (isRegistered)
                {
                    MessageBox.Show("Registration successful! Waiting for admin validation.");
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTxt.PasswordChar = '\0';  // Shows actual characters
                repasswordTxt.PasswordChar = '\0';  // Shows actual characters
            }
            else
            {
                passwordTxt.PasswordChar = '*';   // Masks with '*'
                repasswordTxt.PasswordChar = '*';   // Masks with '*'
            }
        }
    }
}

