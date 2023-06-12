using System.Data;
using System.Data.SqlClient;
using cinema_mgmt.DB_Layer;

namespace cinema_mgmt.BS_Layer
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    internal class BLUser
    {
        private readonly DBMain db_;

        public BLUser()
        {
            db_ = new DBMain();
        }

        public bool IsValidUser(User user)
        {
            var query = "SELECT * " +
                        "FROM dbo.tblUser " +
                        "WHERE [username] = '" + user.Username + "' " +
                        "AND [password] = '" + user.Password + "'";
            var users = db_.ExecuteLoadQuery(query);
            return users != null && users.Tables[0].Rows.Count > 0;
        }

        public void CreateUser(User user)
        {
            var paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@username", SqlDbType.VarChar)
            {
                Value = user.Username
            };
            paras[1] = new SqlParameter("@password", SqlDbType.VarChar)
            {
                Value = user.Password
            };

            const string query = "INSERT INTO dbo.tblUser VALUES(@username, @password)";
            db_.ExecuteNonQuery(query, paras);
        }
    }
}