using System.Data;
using System.Data.SqlClient;

namespace cinema_mgmt.DB_Layer
{
    internal class DBMain
    {
        private readonly SqlConnection conn_;

        public DBMain()
        {
            conn_ = new SqlConnection(Utility.connStr);
        }

        private SqlConnection OpenConn()
        {
            if (conn_.State == ConnectionState.Closed || conn_.State == ConnectionState.Broken)
                conn_.Open();
            return conn_;
        }

        public DataSet ExecuteLoadQuery(string query, CommandType commandType = CommandType.Text)
        {
            using (var cmd = new SqlCommand(query, OpenConn()))
            {
                cmd.CommandType = commandType;

                var dataSet = new DataSet();
                using (var dataAdapter = new SqlDataAdapter(cmd))
                {
                    dataAdapter.Fill(dataSet);
                }

                conn_.Close();
                return dataSet;
            }
        }

        public void ExecuteNonQuery(string query, SqlParameter[] paras = null,
            CommandType commandType = CommandType.Text)
        {
            using (var cmd = new SqlCommand(query, OpenConn()))
            {
                cmd.CommandType = commandType;

                if (paras != null)
                    cmd.Parameters.AddRange(paras);

                cmd.ExecuteNonQuery();

                conn_.Close();
            }
        }

        public object ExecuteScalar(string query, CommandType commandType = CommandType.Text)
        {
            using (var cmd = new SqlCommand(query, OpenConn()))
            {
                cmd.CommandType = commandType;

                var res = cmd.ExecuteScalar();

                conn_.Close();

                return res;
            }
        }
    }
}