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
    public partial class ShareTicketControl : UserControl
    {
        private clsSupportTeam loggedInUser;
        public ShareTicketControl(clsSupportTeam user)
        {
            InitializeComponent();
            lstUnsolvedTickets.SelectionMode = SelectionMode.MultiExtended;
            loggedInUser = user;
            LoadUnsolvedTickets();
            LoadSupportUsers();
        }

        public void LoadUnsolvedTickets()
        {
            lstUnsolvedTickets.Items.Clear();
            List<clsTicket> unsolvedTickets = loggedInUser.ViewUnsolvedTickets(); 

            lstUnsolvedTickets.Items.AddRange(unsolvedTickets.ToArray());
        }
        private void LoadSupportUsers()
        {
            List<clsUser> users = loggedInUser.getUserList();

            if (users == null || users.Count == 0)
            {
                MessageBox.Show("No support users found.");
                return;
            }

            List<clsUser> otherUsers = users
                .Where(u => u.UserID != loggedInUser.UserID)
                .ToList();

            if (otherUsers.Count == 0)
            {
                MessageBox.Show("No users available to share tickets with.");
            }

            cmbShare.DataSource = otherUsers;
            cmbShare.DisplayMember = "userName";
            
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if (lstUnsolvedTickets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one ticket to share.");
                return;
            }

            if (cmbShare.SelectedItem == null)
            {
                MessageBox.Show("Please select a user to assign the tickets to.");
                return;
            }
            clsUser temp = cmbShare.SelectedItem as clsUser;
            int assignedUserId = temp.UserID;
            bool allShared = true;

            foreach (var item in lstUnsolvedTickets.SelectedItems)
            {
                string itemText = item.ToString();

                int ticketId = -1;
                try
                {
                    string id = itemText.Split(',')[0];
                    ticketId = int.Parse(id.Replace("Ticket ID:", "").Trim());
                }
                catch
                {
                    MessageBox.Show("Failed to parse ticket ID for one of the selected tickets.");
                    continue;
                }

                bool success = loggedInUser.ShareTicket(ticketId, assignedUserId);
                if (!success)
                {
                    allShared = false;
                }
            }

            if (!allShared)
            {
                MessageBox.Show("Some tickets failed to share.");
            }

            lstUnsolvedTickets.Items.Clear();
            LoadUnsolvedTickets();

        }
    }
}
