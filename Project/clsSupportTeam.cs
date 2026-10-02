using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_loginForm
{
    public class clsSupportTeam : clsUser
    {
        clsDBmanager dbmanager = new clsDBmanager();
        public clsSupportTeam(int id, string username, string password, string firstName, string lastName, string userEmail)
        : base(id, username, password, firstName, lastName, userEmail, "IT Team") { }
        public bool SolveTicket(int ticketId, string solution, int id)
        {
            bool success = dbmanager.AddSolution(ticketId, solution, id);
            return success;
        }

        public bool ShareTicket(int ticketId, int userId)
        {
            bool success = dbmanager.ShareTicket(ticketId, userId);
            dbmanager.AssignTicketToUser(userId, ticketId);
            return success;
        }

        public bool assignedTickets(int id)
        {
            bool isAssigned = dbmanager.noAssignedTickets(id);
            return isAssigned;
        }
        public List<clsTicket> getUserTickets(int id)
        {
            
             List<clsTicket> myTickets = dbmanager.getMyTickets(id);
             return myTickets;
        }

        public List<clsTicket> ViewUnsolvedTickets()
        {
            List<clsTicket> t = dbmanager.GetUnsolvedTickets();
            return t;
        }

        public List<clsUser> getUserList() 
        {
            List<clsUser> users = dbmanager.GetSupportUsers();
            return users;
        }
    }
}