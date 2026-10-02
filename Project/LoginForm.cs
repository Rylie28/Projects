using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using real_loginForm;

namespace real_loginForm
{
    public partial class loginForm : Form
    {
        ProjectMemberForm projectMemberForm;
        ReportManagerForm reportManagerForm;
        SupportTeamForm supportTeamForm;
        private clsDBmanager dbmanager = new clsDBmanager();
        //nick : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nickl\\source\\repos\\2-13-25\\UserDB.mdf;Integrated Security=True
        //alexis : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\Source\Repos\LoginForm\UserDB.mdf;Integrated Security=True
        //rylie : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\rjmeyer\\LoginForm\\UserDB.mdf;Integrated Security=True
        //jack : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\source\repos\LoginForm\UserDB.mdf;Integrated Security=True
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nickl\\source\\repos\\2-13-25\\UserDB.mdf;Integrated Security=True";

        public loginForm()
        {
            InitializeComponent();

        }


        // The following is Code from chatGPT to connect the registration form through clicking the button
        private void registrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.Show();
            this.Hide(); // Hide the login form
        }
        //

        private void continueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                //string selectedRole = roleBoxLogin.SelectedItem?.ToString();
                clsUser loggedInUser;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidateUser(username, password, out loggedInUser))
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Form userForm = null;

                if (loggedInUser.userRole == "Project Member")
                {
                    userForm = new ProjectMemberForm(loggedInUser);
                }
                else if (loggedInUser.userRole == "Report Manager")
                {
                    userForm = new ReportManagerForm(loggedInUser);
                }
                else if (loggedInUser.userRole == "IT Team")
                {
                    try
                    {
                        userForm = new SupportTeamForm(loggedInUser);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SupportTeamForm crash: " + ex.Message);
                    }
                }

                if (userForm != null)
                {
                    userForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User role not recognized: " + loggedInUser.userRole, "Error");
                }


                userForm?.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error logging in!");
            }

        }

        private bool ValidateUser(string username, string password, out clsUser user)
        {
            clsUser temp = new clsUser();
            return temp.Validate(username, password, out user);
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {

                string adminUsername = "admin";
                string adminPassword = "admin123";

                if (usernameBox.Text.Trim() == adminUsername && passwordBox.Text.Trim() == adminPassword)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide(); //hides form
                }
                else
                {
                    MessageBox.Show("Incorrect admin credentials.");
                }


        }


        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                passwordBox.PasswordChar = '\0';  // Shows actual characters
            }
            else
            {
                passwordBox.PasswordChar = '*';   // Masks with '*'
            }
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
