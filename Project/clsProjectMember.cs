using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

namespace real_loginForm
{
    public class clsProjectMember : clsUser
    {
        private clsDBmanager dbmanager = new clsDBmanager();
        public clsProjectMember(int id, string username, string password, string firstName, string lastName, string userEmail) //, string userRole
        : base(id, username, password, firstName, lastName, userEmail, "ProjectMember") { }


        public void RaiseTicket(clsTicket ticket)
        {
            dbmanager.addTicket(ticket);
        }


        public void ReopenTicket(int ticketId)
        {
            dbmanager.reOpen(ticketId);
        }

        public List<clsTicket> ViewExistingProblems()
        {
            List<clsTicket> tickets = dbmanager.loadTickets(true, UserID);
            return tickets;
        }

        public List<clsTicket> ViewProblems()
        {
            List<clsTicket> tickets = dbmanager.loadTickets(false, UserID);
            return tickets;
        }


        public List<clsDocument> ViewOnlineHelp()
        {

            return new List<clsDocument>();
        }
    }
}