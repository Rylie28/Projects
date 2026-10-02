using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace real_loginForm
{
    public class clsDBmanager
    {
        //nick : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nickl\\source\\repos\\2-13-25\\UserDB.mdf;Integrated Security=True
        //alexis : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\Source\Repos\LoginForm\UserDB.mdf;Integrated Security=True
        //rylie : Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\rjmeyer\\LoginForm\\UserDB.mdf;Integrated Security=True
        //jack : Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\labuser\source\repos\LoginForm\UserDB.mdf;Integrated Security=True
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\labuser\\source\\repos\\RealLoginForm\\UserDB.mdf";

        //public clsDBmanager(string connectionString)
        //{
        //  this.connectionString = connectionString;
        // }

        public bool RegisterUser(string username, string password, string firstName, string lastName, string role, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO TempUsers (userName, userPassword, firstName, lastName, userRole, userEmail)  
                         VALUES (@UserName, @UserPassword, @FirstName, @LastName, @UserRole, @UserEmail)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@UserPassword", password);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@UserRole", role);
                cmd.Parameters.AddWithValue("@UserEmail", email);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Returns true if a row was inserted 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ValidateUser(string username, string password, out clsUser user)
        {
            user = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT userID, userName, userPassword, firstName, lastName, userRole, userEmail FROM ValidUsers " +
                               "WHERE LTRIM(RTRIM(userName)) = @Username AND LTRIM(RTRIM(userPassword)) = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username.Trim());
                cmd.Parameters.AddWithValue("@Password", password.Trim());
                //cmd.Parameters.AddWithValue("@Role", selectedRole.Trim());

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new clsUser(
                        reader.GetInt32(0),//userID
                        reader.GetString(1),//userName
                        reader.GetString(2), //userPassword
                        reader.GetString(3), //firstName
                        reader.GetString(4), //lastName
                        reader.GetString(5),  //userRole
                        reader.GetString(6) //userEmail
                    );
                    return true;
                }
            }

            return false;
        }

        public List<clsUser> GetPendingUsers()
        {
            List<clsUser> users = new List<clsUser>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TempUserID, userName, userPassword, firstName, lastName, userRole, userEmail FROM TempUsers";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int)reader["TempUserID"];
                        string username = reader["userName"].ToString();
                        string password = reader["userPassword"].ToString();
                        string firstName = reader["firstName"].ToString();
                        string lastName = reader["lastName"].ToString();
                        string role = reader["userRole"].ToString();
                        string email = reader["userEmail"].ToString();

                        clsUser user = new clsUser(id, username, password, firstName, lastName, role, email);
                        users.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading pending users: " + ex.Message);
                }
            }

            return users;
        }

        public bool ValidateAndMoveUser(string firstName, string lastName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO ValidUsers (userName, userPassword, firstName, lastName, userRole, userEmail)
                SELECT userName, userPassword, firstName, lastName, userRole, userEmail
                FROM TempUsers
                WHERE firstName = @firstName AND lastName = @lastName;

                DELETE FROM TempUsers WHERE firstName = @firstName AND lastName = @lastName;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName.Trim());
                cmd.Parameters.AddWithValue("@lastName", lastName.Trim());

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Validation Error: " + ex.Message);
                    return false;
                }
            }
        }
        public bool DeleteUser(int userID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TempUsers WHERE TempUserID = @userID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                //cmd.Parameters.AddWithValue("@lastname", lName);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false;
                }
            }
        }

        public List<clsTicket> GetSubmittedTickets()
        {
            List<clsTicket> tickets = new List<clsTicket>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TicketID, Description, Status, CreatedDate, UpdatedDate, Priority, CreatedByUserId, Solution FROM Tickets WHERE Status = 'Open'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int)reader["TicketID"];
                        string description = reader["Description"].ToString();
                        string status = reader["Status"].ToString();
                        DateTime created = (DateTime)reader["CreatedDate"];
                        DateTime updated = (DateTime)reader["UpdatedDate"];
                        string priority = reader["Priority"].ToString();
                        int createdBy = (int)reader["CreatedByUserId"];
                        string solution = reader["Solution"].ToString();

                        clsTicket ticket = new clsTicket(id, description, status, created, updated, priority, createdBy, solution);
                        tickets.Add(ticket);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tickets: " + ex.Message);
                }
            }

            return tickets;
        }


        public List<clsUser> GetITSupportUsers()
        {
            List<clsUser> itUsers = new List<clsUser>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, firstName, lastName FROM ValidUsers WHERE userRole = 'IT Team'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsUser user = new clsUser
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            firstName = reader["firstName"].ToString(),
                            lastName = reader["lastName"].ToString()
                        };

                        itUsers.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading IT support users: " + ex.Message);
                }
            }

            return itUsers;
        }

        public void AssignTicketToUser(int userID, int ticketId)
        {
            string insertQuery = "INSERT INTO UserTickets (UserID, TicketId) VALUES (@UserID, @TicketId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error assigning ticket to user: " + ex.Message);
                    }
                }
            }
        }

        public string GetUserFullNameById(int userId)
        {
            string fullName = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT firstName, lastName FROM ValidUsers WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["firstName"].ToString();
                        string lastName = reader["lastName"].ToString();
                        fullName = $"{firstName} {lastName}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching user name: " + ex.Message);
                }
            }

            return fullName;
        }
        public string GetUserITNameById(int ticketId)
        {
            string fullName = "No IT member assigned."; // Default fallback

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT u.firstName, u.lastName
            FROM UserTickets ut
            JOIN ValidUsers u ON ut.UserID = u.UserID
            WHERE ut.TicketID = @TicketID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TicketID", ticketId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["firstName"] != DBNull.Value ? reader["firstName"].ToString() : "";
                        string lastName = reader["lastName"] != DBNull.Value ? reader["lastName"].ToString() : "";
                        fullName = $"{firstName} {lastName}".Trim();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching assigned user name: " + ex.Message);
                }
            }

            return fullName;
        }

        public void addTicket(clsTicket ticket)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tickets (Description, Status, CreatedDate, UpdatedDate, Priority, CreatedByUserId) " +
                               "VALUES (@desc, @status, @createdDate, @updatedDate, @priority, @createdByUserId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@desc", ticket.Description);
                    cmd.Parameters.AddWithValue("@status", ticket.Status);
                    cmd.Parameters.AddWithValue("@createdDate", ticket.CreatedDate);
                    cmd.Parameters.AddWithValue("@updatedDate", ticket.UpdatedDate);
                    cmd.Parameters.AddWithValue("@priority", ticket.Priority);
                    cmd.Parameters.AddWithValue("@createdByUserId", ticket.CreatedByUserId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void reOpen(int ticketId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tickets SET Status = 'Reopened', UpdatedDate = @updatedDate WHERE TicketId = @ticketId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.Parameters.AddWithValue("@updatedDate", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsTicket> loadTickets(bool myTickets, int id)
        {
            List<clsTicket> tickets = new List<clsTicket>();
            if (myTickets)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TicketId, Description, Status, CreatedDate, UpdatedDate, Priority, CreatedByUserId " +
                        "FROM Tickets WHERE CreatedByUserId = @userId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", id);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tickets.Add(new clsTicket
                                {
                                    TicketId = reader.GetInt32(0),
                                    Description = reader.GetString(1),
                                    Status = reader.GetString(2),
                                    CreatedDate = reader.GetDateTime(3),
                                    UpdatedDate = reader.GetDateTime(4),
                                    Priority = reader.GetString(5),
                                    CreatedByUserId = reader.GetInt32(6)
                                });
                            }
                        }
                    }
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TicketId, Description, Status, CreatedDate, UpdatedDate, Priority, CreatedByUserId " +
                        "FROM Tickets";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tickets.Add(new clsTicket
                                {
                                    TicketId = reader.GetInt32(0),
                                    Description = reader.GetString(1),
                                    Status = reader.GetString(2),
                                    CreatedDate = reader.GetDateTime(3),
                                    UpdatedDate = reader.GetDateTime(4),
                                    Priority = reader.GetString(5),
                                    CreatedByUserId = reader.GetInt32(6)
                                });
                            }
                        }
                    }
                }
            }

            return tickets;
        }
        public List<clsTicket> GetUnsolvedTickets()
        {
            List<clsTicket> tickets = new List<clsTicket>();
            string query = "SELECT TicketId, Description, Status, CreatedDate FROM Tickets WHERE Status = 'Open' ORDER BY CreatedDate DESC";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming clsTicket has properties matching the column names.
                            var ticket = new clsTicket
                            {

                                TicketId = reader.GetInt32(0),
                                Description = reader.GetString(1),
                                Status = reader.GetString(2),
                                CreatedDate = reader.GetDateTime(3)

                            };

                            tickets.Add(ticket);
                        }
                    }
                }
            }

            return tickets;
        }

        public void UpdateTicketPriority(int ticketId, string priority)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tickets SET Priority = @Priority WHERE TicketId = @TicketId";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating ticket priority: " + ex.Message);
                }
            }
        }
        public string GetSolutionByTicketId(int ticketId)
        {
            string solution = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Solution FROM Tickets WHERE TicketId = @TicketId";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        solution = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving solution: " + ex.Message);
                }
            }

            return solution;
        }

        public bool ShareTicket(int ticketId, int newAssignedUserId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Tickets
                         SET AssignedToUserId = @AssignedToUserId, UpdatedDate = GETDATE()
                         WHERE TicketId = @TicketId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);
                    cmd.Parameters.AddWithValue("@AssignedToUserId", newAssignedUserId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool AddSolution(int ticketId, string solutionText, int solvedByUserId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE Tickets
                SET Solution = @Solution, SolvedByUserId = @SolvedByUserId, SolvedDate = @SolvedDate, UpdatedDate = @UpdatedDate, Status = 'Closed'
                WHERE TicketId = @TicketId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Solution", solutionText);
                        cmd.Parameters.AddWithValue("@SolvedByUserId", solvedByUserId);
                        cmd.Parameters.AddWithValue("@SolvedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TicketId", ticketId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                //log error
                Console.WriteLine("Error updating ticket: " + ex.Message);
                return false;
            }
        }

        public int getNumTickets(bool unsolved)
        {
            if (unsolved)
            {
                int numUnsolved = 0;
                List<clsTicket> list = loadTickets(false, 0);

                foreach (clsTicket ticket in list)
                {
                    if (ticket.Status == "Open" || ticket.Status == "Reopened")
                    {
                        numUnsolved++;
                    }
                }
                return numUnsolved;
            }
            else
            {
                int numSolved = 0;
                List<clsTicket> list = loadTickets(false, 0);

                foreach (clsTicket ticket in list)
                {
                    if (ticket.Solution == "Closed")
                    {
                        numSolved++;
                    }
                }
                return numSolved;
            }

        }

        public List<clsUser> GetSupportUsers()
        {
            List<clsUser> supportUsers = new List<clsUser>();

            string query = "SELECT * FROM ValidUsers WHERE userRole = 'IT Team'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new clsUser
                                {
                                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    userName = reader.GetString(reader.GetOrdinal("UserName")),
                                    firstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    lastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    userEmail = reader.GetString(reader.GetOrdinal("UserEmail")),
                                };
                                supportUsers.Add(user);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-specific errors
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Handle general errors
                MessageBox.Show($"Error: {ex.Message}");
            }

            return supportUsers;
        }




        public List<clsTicket> getMyTickets(int userID)
        {
            List<clsTicket> tickets = new List<clsTicket>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT t.TicketId, t.Description, t.Status, t.CreatedDate, t.UpdatedDate, t.Priority, t.CreatedByUserId
            FROM Tickets t
            JOIN UserTickets u ON u.TicketId = t.TicketId
            WHERE u.UserID = @userID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userID);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tickets.Add(new clsTicket()
                                {
                                    TicketId = reader.GetInt32(0),
                                    Description = reader.GetString(1),
                                    Status = reader.GetString(2),
                                    CreatedDate = reader.GetDateTime(3),
                                    UpdatedDate = reader.GetDateTime(4),
                                    Priority = reader.GetString(5),
                                    CreatedByUserId = reader.GetInt32(6)
                                });
                            }
                        }

                    }
                    conn.Close();

                }

                return tickets;
            
            }
        

        public bool noAssignedTickets(int userID)
        {
            bool assigned = true; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM UserTickets WHERE UserID = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userID);

                    conn.Open();
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        assigned = false; // there are tickets assigned to user
                    }
                    conn.Close();
                }
            }

            return assigned; 
        }
    }
}

