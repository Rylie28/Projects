using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace real_loginForm
{
    [Table("ValidUsers")] //maps class to table
    public class clsUser
    {
        [Key] //primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto-incre ID
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(50)]
        public string userPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string userRole { get; set; }


        [StringLength(50)]
        public string userEmail { get; set; }

        //constructor
        public clsUser(int id, string username, string password, string firstName, string lastName, string role, string userEmail)
        {
            UserID = id;
            userName = username;
            userPassword = password;
            this.firstName = firstName;
            this.lastName = lastName;
            userRole = role;
            this.userEmail = userEmail;
        }

        public clsUser(string username, string password, string firstName, string lastName, string role, string userEmail)
        {
            userName = username;
            userPassword = password;
            this.firstName = firstName;
            this.lastName = lastName;
            userRole = role;
            this.userEmail = userEmail;
        }

        public clsUser(int id, string firstname, string lastname)
        {
            UserID = id;
            firstName = firstname;
            lastName = lastname;
        }

        // default constructor
        public clsUser() { }

        public bool Register() 
        {
            bool isRegistered = false;
            clsDBmanager dBmanager = new clsDBmanager();
            isRegistered = dBmanager.RegisterUser(userName, userPassword, firstName, lastName, userRole, userEmail);

            return isRegistered;
        }

        public bool Validate(string username, string password, out clsUser user)
        {
            clsDBmanager dbmanager = new clsDBmanager();
            return dbmanager.ValidateUser(username, password, out user);
        }

        public string getName(int id)
        {
            clsDBmanager dBmanager = new clsDBmanager();
            return dBmanager.GetUserFullNameById(id);
        }
        public string getAssignedITName(int id)
        {
            clsDBmanager dBmanager = new clsDBmanager();
            return dBmanager.GetUserITNameById(id);
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Username: {1}, First Name: {2}, Last Name: {3}, Role: {4}",
                UserID, userName, firstName, lastName, userRole, userEmail);
        }
    }
}
