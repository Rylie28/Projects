using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace real_loginForm
{
    public partial class AdminForm : Form
    {
        loginForm loginForm;

        //nick : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nickl\\source\\repos\\2-13-25\\UserDB.mdf;Integrated Security=True
        //alexis : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\Source\Repos\LoginForm\UserDB.mdf;Integrated Security=True
        //rylie : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\rjmeyer\\LoginForm\\UserDB.mdf;Integrated Security=True
        //jack : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\source\repos\LoginForm\UserDB.mdf;Integrated Security=True
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\LoginForm\\UserDB.mdf;Integrated Security=True";

        //private clsDBmanager dbManager = new clsDBmanager();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadPendingUsers();
            // MessageBox.Show("AdminForm_Load triggered.");
        }

        private void LoadPendingUsers()
        {
            try
            {
                clsAdmin loggedInUser = new clsAdmin();
                List<clsUser> tempUsers = loggedInUser.GetTempUsers();

                lstUsers.Items.Clear();
                lstUsers.Items.AddRange(tempUsers.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading users");
            }
        }



        /*private void btnValidateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUsers.SelectedItem != null)
                {
                    clsUser tempUser = (clsUser)lstUsers.SelectedItem;
                    string firstname = tempUser.firstName;
                    string lastname = tempUser.lastName;

                    if (ValidateAndMoveUser(firstname, lastname))
                    {
                        MessageBox.Show($"{firstname} {lastname} has been validated.");
                        LoadPendingUsers();
                    }
                    else
                    {
                        MessageBox.Show("Error validating user.");
                    }
                }
                else
                {
                    MessageBox.Show("No item selected.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Validating User"); 
            }
        }*/
        private void btnValidateUser_Click(object sender, EventArgs e)
{
    try
    {
        if (lstUsers.SelectedItem != null)
        {
            clsUser tempUser = (clsUser)lstUsers.SelectedItem;
            string firstname = tempUser.firstName;
            string lastname = tempUser.lastName;
            string email = tempUser.userEmail; // 📧 Pull user email

            if (ValidateAndMoveUser(firstname, lastname))
            {
                // ✅ Send welcome email
                SendWelcomeEmail(email, firstname);

                MessageBox.Show($"{firstname} {lastname} has been validated and notified via email.");
                LoadPendingUsers();
            }
            else
            {
                MessageBox.Show("Error validating user.");
            }
        }
        else
        {
            MessageBox.Show("No item selected.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error Validating User");
    }
}

        public void SendWelcomeEmail(string recipientEmail, string userName)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ithelpdesk787@gmail.com");
            mail.To.Add(recipientEmail);
            mail.Subject = "Welcome to the System!";
            mail.Body = $"Hi {userName},\n\nYour account has been validated. You can now log in to the system.";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("ithelpdesk787@gmail.com", "czdl rlld vxnc hnej");
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private bool ValidateAndMoveUser(string firstName, string lastName)
        {
            clsAdmin temp = new clsAdmin();
            return temp.Validate(firstName, lastName);
        }

       
        private void btsDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUsers.SelectedItem != null)
                {
                    clsAdmin temp = new clsAdmin();
                    clsUser tempUser = (clsUser)lstUsers.SelectedItem;
                    string firstname = tempUser.firstName;
                    string lastname = tempUser.lastName;
                    int id = tempUser.UserID; 

                    if (temp.Delete(id))
                    {
                        MessageBox.Show($"{firstname} {lastname} has been deleted.");
                        LoadPendingUsers(); // refresh list
                    }
                    else
                    {
                        MessageBox.Show("Error deleting user.");
                    }
                }
                else
                {
                    MessageBox.Show("No item selected.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting User"); 
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new loginForm(); //dont need to create a new instance everytime
            }

            loginForm.Show();
            this.Close();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser user = (clsUser)lstUsers.SelectedItem;

            txtFirst.Text = user.firstName;
            txtLast.Text = user.lastName;
            txtUsername.Text = user.userName;
            txtPassword.Text = user.userPassword;
            txtRole.Text = user.userRole;
            txtEmail.Text = user.userEmail;

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            clsAdmin loggedInUser = new clsAdmin();
            lstReport.Items.Add(loggedInUser.GenerateReport());
        }
    }
}
