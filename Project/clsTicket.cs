using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace real_loginForm
{
    [Table("Tickets")] //maps to ticket table
    public class clsTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Open"; //default

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        [Required]
        [Range(1, 5)] //priority scale of 1-5
        public string Priority { get; set; }

        [Required]
        public int CreatedByUserId { get; set; }

        public int? SolvedByUserId { get; set; }

        public int? AssignedToUserId { get; set; }

        public string Solution { get; set; }

        public DateTime? SolvedDate { get; set; }

        //constructor
        public clsTicket(int ticketID, string description, string status, DateTime createdDate, DateTime updatedDate, string priority, int createdByUserId,
            int? solvedByUserId = null, int? assignedToUserId = null, string solution = null, DateTime? solvedDate = null)
        {
            TicketId = ticketID;
            Description = description;
            Status = status;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            Priority = priority;
            CreatedByUserId = createdByUserId;
            SolvedByUserId = solvedByUserId;
            AssignedToUserId = assignedToUserId;
            Solution = solution;
            SolvedDate = solvedDate;
        }
        public clsTicket(int ticketID, string description, string status, DateTime createdDate, DateTime updatedDate, string priority, int createdByUserId, string solution = null, int? assignedToUserId = null)
        {
            TicketId = ticketID;
            Description = description;
            Status = status;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            Priority = priority;
            CreatedByUserId = createdByUserId;
            Solution = solution;
            AssignedToUserId = assignedToUserId;
        }

        public clsTicket(string description, string priority, int createdByUserId)
        {
            this.Description = description;
            this.Status = "Open";
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = DateTime.Now;
            this.Priority = priority;
            this.CreatedByUserId = createdByUserId;
        }

        //default constructor
        public clsTicket() { }

        public override string ToString()
        {
            return string.Format("Ticket ID: {0}, Problem Description: {1},    Created Date: {2} - Updated Date: {3}, User ID: {4}",
                TicketId, Description, CreatedDate, UpdatedDate, CreatedByUserId);
            //return string.Format("Ticket ID: {0}, Description: {1}, Created: {2}, Updated: {3}, Priority: {4}, Created By: {5}, Assigned To: {6}, Solved By: {7}",
            //TicketId, Description, CreatedDate, UpdatedDate, Priority, CreatedByUserId, AssignedToUserId, SolvedByUserId);
        }

        public void LoadSolution(clsDBmanager dbmanager)
        {
            this.Solution = dbmanager.GetSolutionByTicketId(this.TicketId);
        }
    }
}