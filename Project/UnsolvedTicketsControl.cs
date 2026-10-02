using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace real_loginForm
{
    public partial class UnsolvedTicketsControl : UserControl
    {
        private clsSupportTeam loggedInUser;
        public UnsolvedTicketsControl(clsSupportTeam user)
        {
            InitializeComponent();
           

            if (user == null)
            {
                MessageBox.Show("Error: loggedInUser is null.");
                return;
            }

            loggedInUser = user;
            
        }
        



        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTicketID.Text, out int ticketId))
            {
                //string solution = dbManager.GetSolutionByTicketId(ticketId);
                string solution = txtSolution.Text;
                MessageBox.Show(solution);
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
                        
                        UnsolvedTicketsControl_Load(sender, e);
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

        private void lstUnsolvedTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsTicket ticket = (clsTicket)lstUnsolvedTickets.SelectedItem;
                txtTicketID.Clear();
                txtDescription.Clear();
                txtSolution.Clear();
                txtUpdatedDate.Clear();
                txtCreatedDate.Clear();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UnsolvedTicketsControl_Load(object sender, EventArgs e)
        {
            lstUnsolvedTickets.Items.Clear();
            List<clsTicket> unsolvedTickets = loggedInUser.ViewUnsolvedTickets();

            lstUnsolvedTickets.Items.AddRange(unsolvedTickets.ToArray());
        }
    }
}

