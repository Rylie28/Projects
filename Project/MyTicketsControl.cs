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
    public partial class MyTicketsControl : UserControl
    {
        private clsSupportTeam loggedInUser;
        
        public MyTicketsControl(clsSupportTeam user)
        {
            InitializeComponent();
            

            if (user == null)
            {
                MessageBox.Show("Error: loggedInUser is null.");
                return;
            }

            loggedInUser = user;
            LoadMyTickets();
        }

        public void LoadMyTickets()
        {

            lstTickets.Items.Clear();

            try
            {
                bool assigned = loggedInUser.assignedTickets(loggedInUser.UserID);
                if (assigned)
                {
                    //MessageBox.Show("No Tickets have been assigned to you");
                    return;
                }
                else
                {
                    List<clsTicket> myTickets = loggedInUser.getUserTickets(loggedInUser.UserID);
                    lstTickets.Items.AddRange(myTickets.ToArray());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtTicketID.Text, out int ticketId))
            {
                string solution = txtSolution.Text;
                if (string.IsNullOrEmpty(solution))
                {
                    MessageBox.Show("Please provide a solution for the ticket.");
                    return;
                }
                else
                {
                    bool success = loggedInUser.SolveTicket(ticketId, solution, loggedInUser.UserID);


                    if (success)
                    {
                        LoadMyTickets();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update ticket.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid Ticket.");
            }
        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsTicket ticket = (clsTicket)lstTickets.SelectedItem;
            txtTicketID.Clear();
            txtDescription.Clear();
            txtSolution.Clear();
            txtUpdatedDate.Clear();
            txtCreatedDate.Clear();
            //used to be a try-catch here
            if (ticket == null)
            {
                MessageBox.Show("Please select a ticket");
            }
            else
            {
                txtTicketID.Text = ticket.TicketId.ToString();
                txtDescription.Text = ticket.Description.ToString();

                txtSolution.Text = " ";

                txtCreatedDate.Text = ticket.CreatedDate.ToString();
                txtUpdatedDate.Text = ticket.UpdatedDate.ToString();

            }
            



        }
    }
}

