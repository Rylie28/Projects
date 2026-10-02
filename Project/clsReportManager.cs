using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_loginForm
{
    public class clsReportManager :clsUser
    {
        //constructor
        public clsReportManager(int id, string username, string password, string firstName, string lastName, string userEmail)
        : base(id, username, password, firstName, lastName, userEmail, "ReportManager") { }

        public List<clsTicket> getTickets()
        {
            clsDBmanager dBmanager = new clsDBmanager();
            return dBmanager.GetSubmittedTickets(); 
        }

        public List<clsUser> getItTeam()
        {
            clsDBmanager dbmanager = new clsDBmanager();
            return dbmanager.GetITSupportUsers();
        }

        public void AssignTicket( int userID, int ticketId)
        {
            clsDBmanager dbmanager = new clsDBmanager();
            dbmanager.AssignTicketToUser(userID, ticketId);
        }

        public List<clsTicket> ViewReport()
        {

            return new List<clsTicket>();
        }

        public void SetTicketPriority(int ticketId, string priority)
        {
            clsDBmanager dbmanager = new clsDBmanager();
            dbmanager.UpdateTicketPriority(ticketId, priority);
        }
    }
}
