using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_loginForm
{
    public partial class SupportTeamForm : Form
    {
        loginForm loginForm;
        private clsSupportTeam loggedInUser;
        public SupportTeamForm(clsUser supportTeam)
        {
            InitializeComponent();



            //skip logic if we're in the Designer
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            if (supportTeam != null)
            {
                loggedInUser = new clsSupportTeam(supportTeam.UserID, supportTeam.userName, supportTeam.userPassword,
                                                  supportTeam.firstName, supportTeam.lastName, supportTeam.userEmail);
                welcomeLbl.Text = $"Welcome, IT Support Member {loggedInUser.firstName}!";
            }
            else
            {
                MessageBox.Show("Error: User is not IT Support Team.");
                this.Close();
                return;
            }


            try
            {
                UnsolvedTicketsControl unsolvedCtrl = new UnsolvedTicketsControl(loggedInUser);
                unsolvedCtrl.Dock = DockStyle.Fill;
                tabUnsolved.Controls.Add(unsolvedCtrl);

                MyTicketsControl myTicketCtrl = new MyTicketsControl(loggedInUser);
                myTicketCtrl.Dock = DockStyle.Fill;
                tabTickets.Controls.Add(myTicketCtrl);

                ShareTicketControl shareCtrl = new ShareTicketControl(loggedInUser);
                shareCtrl.Dock = DockStyle.Fill;
                tabShare.Controls.Add(shareCtrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading controls: {ex.Message}");
            }

                LoadTabPages();


        }

        private void LoadTabPages()
        {
            //ensurse user is properly initialized
            if (loggedInUser != null)
            {
                UnsolvedTicketsControl unsolvedCtrl = new UnsolvedTicketsControl(loggedInUser);
                unsolvedCtrl.Dock = DockStyle.Fill;
                tabUnsolved.Controls.Add(unsolvedCtrl);

                MyTicketsControl myTicketCtrl = new MyTicketsControl(loggedInUser);
                myTicketCtrl.Dock = DockStyle.Fill;
                tabTickets.Controls.Add(myTicketCtrl);

                ShareTicketControl shareCtrl = new ShareTicketControl(loggedInUser);
                shareCtrl.Dock = DockStyle.Fill;
                tabShare.Controls.Add(shareCtrl);
            }
            else
            {
                MessageBox.Show("Logged in user is not initialized correctly.");
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
    }
}
