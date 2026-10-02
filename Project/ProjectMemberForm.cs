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
    public partial class ProjectMemberForm : Form
    {
        loginForm loginForm;
        private clsProjectMember loggedInUser;
        private clsDBmanager dbmanager;
        public ProjectMemberForm(clsUser projectMember)
        {
            InitializeComponent();
            //loggedInUser = projectMember as clsProjectMember;
            dbmanager = new clsDBmanager();
            if (projectMember != null)
            {
                loggedInUser = new clsProjectMember(projectMember.UserID, projectMember.userName, projectMember.userPassword, projectMember.firstName, projectMember.lastName, projectMember.userEmail);
                welcomeLbl.Text = $"Welcome, Project Member {loggedInUser.firstName}!";
            }
            else
            {
                MessageBox.Show("Error: User is not a project member.");
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

        private void raiseBtn_Click(object sender, EventArgs e)
        {
            clsTicket ticket; 


                if (txtTicketID.Items.Count > 0)
                {
                    MessageBox.Show("Error Project members cannot choose ticket ID, Status, created date or Updated date");
                }
                string desc = txtDescription.Text.ToString();
                string priority = txtPriority.Text.ToString();
                int id = loggedInUser.UserID;

                ticket = new clsTicket(desc, priority, id);

                loggedInUser.RaiseTicket(ticket);



        }

        private void existingTicketsBtn_Click(object sender, EventArgs e)
        {

                lstTickets.Items.Clear();
                List<clsTicket> tickets = new List<clsTicket>();
                tickets = loggedInUser.ViewExistingProblems();
                if (tickets != null)
                {
                    lstTickets.Items.AddRange(tickets.ToArray());
                }
                else
                {
                    MessageBox.Show("Error: You have no tickets");
                }

            
        }

        private void savedTicketsBtn_Click(object sender, EventArgs e)
        {

                lstTickets.Items.Clear();
                List<clsTicket> tickets = new List<clsTicket>();
                tickets = loggedInUser.ViewProblems();
                lstTickets.Items.AddRange(tickets.ToArray());


        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsTicket ticket = (clsTicket)lstTickets.SelectedItem;
                txtTicketID.Items.Clear();
                txtStatus.Items.Clear();
                txtCreatedDate.Items.Clear();
                txtUpdatedDate.Items.Clear();
                txtUser.Items.Clear();
                if (lstTickets.SelectedIndex == -1)
                {
                    return;
                }
                txtTicketID.Items.Add(ticket.TicketId.ToString());
                txtDescription.Text = ticket.Description;
                txtStatus.Items.Add(ticket.Status);
                txtCreatedDate.Items.Add(ticket.CreatedDate.ToString());
                txtUpdatedDate.Items.Add(ticket.UpdatedDate.ToString());
                txtPriority.Text = ticket.Priority.ToString();
                string creatorName = dbmanager.GetUserFullNameById(ticket.CreatedByUserId);
                txtUser.Items.Add(creatorName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTicketID.Items.Clear();
            txtStatus.Items.Clear();
            txtCreatedDate.Items.Clear();
            txtUpdatedDate.Items.Clear();
            txtUser.Items.Clear(); 

            txtDescription.Text = string.Empty;
            txtPriority.Text = string.Empty;

            lstTickets.Items.Clear();
        }

        private void btnReOpen_Click(object sender, EventArgs e)
        {

                if (lstTickets.SelectedItems == null)
                {
                    MessageBox.Show("Please select a ticket");
                }
                else
                {
                    clsTicket t = (clsTicket)lstTickets.SelectedItem;
                    if (t.Status == "Open")
                    {
                        MessageBox.Show("The Ticket must be closed to be re-opened");
                    }else if(t.Solution != null)
                    {
                        MessageBox.Show("ticket has a solution"); 
                    }else
                    {
                        loggedInUser.ReopenTicket(t.TicketId);
                        btnClear_Click(sender, e);
                    }
                    
                }
            
            
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket.");
                return;
            }

            string selectedText = lstTickets.SelectedItem.ToString();

            // Look for "Ticket ID: " and grab the number after it
            int ticketId = -1;
            string ticketPrefix = "Ticket ID: ";
            int idStart = selectedText.IndexOf(ticketPrefix);

            if (idStart >= 0)
            {
                idStart += ticketPrefix.Length;
                int idEnd = selectedText.IndexOf(',', idStart); // stop at the comma after the ID

                if (idEnd == -1) idEnd = selectedText.Length;

                string idStr = selectedText.Substring(idStart, idEnd - idStart).Trim();

                if (!int.TryParse(idStr, out ticketId))
                {
                    MessageBox.Show("Could not extract a valid Ticket ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ticket ID not found in the selected item.");
                return;
            }

            // Load solution
            clsTicket ticket = new clsTicket { TicketId = ticketId };
            ticket.LoadSolution(dbmanager);

            string solution = string.IsNullOrWhiteSpace(ticket.Solution)
                ? "No solution has been provided for this ticket."
                : ticket.Solution;

            MessageBox.Show(solution, "Ticket Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void onlineHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently there are no Documents online");
        }

        
    }

}
