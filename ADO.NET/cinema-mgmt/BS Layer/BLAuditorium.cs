using System;
using System.Data;
using System.Data.SqlClient;
using cinema_mgmt.DB_Layer;

namespace cinema_mgmt.BS_Layer
{
    internal class Auditorium
    {
        public string Id { get; set; }
        public string CenterId { get; set; }
        public int SeatCount { get; set; }

        public bool DoesViolateNullConstraint()
        {
            return Id.Equals(string.Empty)
                   || CenterId.Equals(string.Empty)
                   || SeatCount == 0;
        }
    }

    internal class BLAuditorium
    {
        private readonly DBMain db_;

        public BLAuditorium()
        {
            db_ = new DBMain();
        }

        private int GetMaxAuditorium(string centerId)
        {
            var query = "SELECT SUM([center_auditorium_count]) " +
                        "FROM dbo.tblCenter " +
                        "WHERE [center_id] = '" + centerId + "'";
            return Convert.ToInt16(db_.ExecuteScalar(query));
        }

        private int CountCurrentAuditorium(string centerId)
        {
            var query = "SELECT COUNT(*) " +
                        "FROM dbo.tblAuditorium " +
                        "WHERE [center_id] = '" + centerId + "'";
            return Convert.ToInt16(db_.ExecuteScalar(query));
        }

        public bool DoesReachMaxAuditorium(string centerId)
        {
            return CountCurrentAuditorium(centerId) == GetMaxAuditorium(centerId);
        }

        public int CountSeatByCenter(string centerName)
        {
            var query1 = "SELECT [center_id] " +
                         "FROM dbo.tblCenter " +
                         "WHERE [center_name] = N'" + centerName + "'";
            var centerId = db_.ExecuteLoadQuery(query1).Tables[0].Rows[0]["center_id"].ToString();

            var query2 = "SELECT SUM([seat_count]) " +
                         "FROM dbo.tblAuditorium " +
                         "WHERE [center_id] = '" + centerId + "'";
            var res = db_.ExecuteScalar(query2);
            return res == DBNull.Value ? 0 : Convert.ToInt16(res);
        }

        public int CountSeatByAuditorium(string auditoriumId)
        {
            var query = "SELECT SUM([seat_count]) " +
                        "FROM dbo.tblAuditorium " +
                        "WHERE [auditorium_id] = '" + auditoriumId + "'";
            var res = db_.ExecuteScalar(query);
            return res == DBNull.Value ? 0 : Convert.ToInt16(res);
        }

        public void AddAuditorium(Auditorium auditorium)
        {
            const string query = "INSERT INTO dbo.tblAuditorium VALUES(@auditorium_id, @center_id, @seat_count)";

            var paras = new SqlParameter[3];
            paras[0] = new SqlParameter("@auditorium_id", SqlDbType.VarChar)
            {
                Value = auditorium.Id
            };
            paras[1] = new SqlParameter("@center_id", SqlDbType.VarChar)
            {
                Value = auditorium.CenterId
            };
            paras[2] = new SqlParameter("@seat_count", SqlDbType.SmallInt)
            {
                Value = auditorium.SeatCount
            };

            db_.ExecuteNonQuery(query, paras);
        }

        public void UpdateAuditorium(Auditorium auditorium)
        {
            var query = "UPDATE dbo.tblAuditorium " +
                        "SET [seat_count] = " + auditorium.SeatCount +
                        " WHERE [auditorium_id] = '" + auditorium.Id + "'";
            db_.ExecuteNonQuery(query);
        }

        public void DeleteAuditorium(string auditoriumId)
        {
            var query = "DELETE " +
                        "FROM dbo.tblAuditorium " +
                        "WHERE [auditorium_id] = '" + auditoriumId + "'";
            db_.ExecuteNonQuery(query);
        }
    }
}