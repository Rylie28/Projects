using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_loginForm
{
    public class clsAdmin : clsUser
    {
        //constructor
        public clsAdmin(int id, string username, string password, string firstName, string lastName, string userEmail)
        : base(id, username, password, firstName, lastName, userEmail, "Admin") { }

        public clsAdmin() { }

        public List<clsUser> GetTempUsers()
        {
            clsDBmanager dBmanager = new clsDBmanager();
            return dBmanager.GetPendingUsers(); 
        }

        public bool Validate(string firstname, string lastname)
        {
            clsDBmanager dbmanager = new clsDBmanager();
            return dbmanager.ValidateAndMoveUser(firstname, lastname);
        }

        public bool Delete(int userID)
        {
            clsDBmanager dBmanager = new clsDBmanager();
            bool deleted = dBmanager.DeleteUser(userID);
            return deleted; 
        }

        public string GenerateReport()
        {
            
            clsDBmanager dBmanager = new clsDBmanager(); 

            int solved = dBmanager.getNumTickets(false);
            int unsolved = dBmanager.getNumTickets(true);
            string report = "Number of Solved Tickets: " + solved + "       Number of Unsolved Tickets: " + unsolved; 
            return report; 
        }

        public void SendEmailAlert(string email, string message) //need to add email to db
        { }
    }
}
