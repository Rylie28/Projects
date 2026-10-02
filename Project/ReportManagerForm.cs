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
    public partial class ReportManagerForm : Form
    {
        loginForm loginForm;
        private clsReportManager loggedInUser;

        //private clsDBmanager dbmanager = new clsDBmanager();
        public ReportManagerForm(clsUser reportManager)
        {
            InitializeComponent();
            //loggedInUser = projectMember as clsProjectMember;
            if (reportManager != null)
            {
                loggedInUser = new clsReportManager(reportManager.UserID, reportManager.userName, reportManager.userPassword, reportManager.firstName, reportManager.lastName, reportManager.userEmail);
                welcomeLbl.Text = $"Welcome, Report Manager {loggedInUser.firstName}!";
            }
            else
            {
                MessageBox.Show("Error: User is not Report Manager.");
                this.Close();
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

        private void monitorTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstTickets.Items.Clear();
            txtTicketID.Clear();
            txtDescription.Clear();
            txtStatus.Clear();
            txtCreatedDate.Clear();
            txtUpdatedDate.Clear();
            txtPriority.Clear();
            txtUser.Clear();
            txtSolution.Clear();
            txtAssigned.Clear();


            List<clsTicket> submittedTickets = loggedInUser.getTickets();

            foreach (clsTicket ticket in submittedTickets)
            {
                lstTickets.Items.Add(ticket); 
            }

            lstTickets.Visible = true;
            pnlMonitor.Visible = true;
            pnlAssign.Visible = false;
            lstUsers.Visible = false;
            
        }

        private void assignTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            lstUsers.Visible = true;
            lstTickets.Visible = true;
            pnlMonitor.Visible = true;
            pnlAssign.Visible=true;
            
          

            lstTickets.Items.Clear();
            txtTicketID.Clear();
            txtDescription.Clear();
            txtStatus.Clear();
            txtCreatedDate.Clear();
            txtUpdatedDate.Clear();
            txtPriority.Clear();
            txtUser.Clear();
            txtSolution.Clear();
            txtAssigned.Clear();
            txtSelectedUser.Clear();
            lstTickets.Items.AddRange(loggedInUser.getTickets().ToArray());
            try
            {
                List<clsUser> itUsers = loggedInUser.getItTeam();
                lstUsers.Items.Clear();
                lstUsers.Items.AddRange(itUsers.ToArray());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstTickets.SelectedIndex == -1)
                {
                    return; 
                }
                clsTicket ticket = (clsTicket)lstTickets.SelectedItem;

                txtTicketID.Text = ticket.TicketId.ToString();
                txtDescription.Text = ticket.Description;
                txtStatus.Text = ticket.Status;
                txtCreatedDate.Text = ticket.CreatedDate.ToString();
                txtUpdatedDate.Text = ticket.UpdatedDate.ToString();
                txtPriority.Text = ticket.Priority.ToString();
                string creatorName = loggedInUser.getName(ticket.CreatedByUserId);
                txtUser.Text = creatorName;
                txtSolution.Text = ticket.Solution.ToString();
                string assignedName = loggedInUser.getAssignedITName(ticket.TicketId);
                txtAssigned.Text = assignedName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAssignTicket_Click(object sender, EventArgs e)
        {
            try 
            { 

                if (lstTickets.SelectedItem == null || lstUsers.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a ticket and a user.");
                    return;
                }

                int selectedTicketID = ((clsTicket)lstTickets.SelectedItem).TicketId;
                int selectedUserID = ((clsUser)lstUsers.SelectedItem).UserID;

            
                loggedInUser.AssignTicket(selectedUserID, selectedTicketID);

                lstTickets.Items.Clear();
                lstTickets.Items.AddRange(loggedInUser.getTickets().ToArray());
                txtAssigned.Text = string.Empty;

                assignTicketToolStripMenuItem_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser user = (clsUser)lstUsers.SelectedItem;

            txtSelectedUser.Text = user.firstName.ToString();
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            if (cbxPriority.SelectedItem == null || string.IsNullOrWhiteSpace(txtTicketID.Text))
            {
                MessageBox.Show("Please select a priority and ensure a ticket is selected.");
                return;
            }

            if (int.TryParse(txtTicketID.Text.Trim(), out int ticketId))
            {
                string priority = cbxPriority.SelectedItem.ToString();
                loggedInUser.SetTicketPriority(ticketId, priority);
                assignTicketToolStripMenuItem_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Invalid Ticket ID in the textbox.");
            }
        }
    }


}

