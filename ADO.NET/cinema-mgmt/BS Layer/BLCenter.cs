using System;
using System.Data;
using System.Data.SqlClient;
using cinema_mgmt.DB_Layer;

namespace cinema_mgmt.BS_Layer
{
    internal class Center
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int AuditoriumCount { get; set; }

        public bool DoesViolateNullConstraint()
        {
            return Id.Equals(string.Empty)
                   || Name.Equals(string.Empty)
                   || Address.Equals(string.Empty)
                   || Contact.Equals(string.Empty);
        }
    }

    internal class BLCenter
    {
        private readonly DBMain db_;

        public BLCenter()
        {
            db_ = new DBMain();
        }

        public Center GetCenterById(string centerId)
        {
            var query = "SELECT * " +
                        "FROM dbo.tblCenter " +
                        "WHERE [center_id] = '" + centerId + "'";
            var res = db_.ExecuteLoadQuery(query).Tables[0].Rows[0];
            var center = new Center
            {
                Id = centerId,
                Name = res["center_name"].ToString(),
                Address = res["center_address"].ToString(),
                Contact = res["center_contact"].ToString(),
                AuditoriumCount = Convert.ToInt16(res["center_auditorium_count"])
            };
            return center;
        }

        public DataSet Search(string str)
        {
            var query = "SELECT * " +
                        "FROM dbo.tblCenter " +
                        "WHERE [center_id] LIKE '%" + str + "%' " +
                        "OR [center_name] LIKE N'%" + str + "%' " +
                        "OR [center_address] LIKE N'%" + str + "%'";
            return db_.ExecuteLoadQuery(query);
        }

        public void AddCenter(Center center)
        {
            const string query =
                "INSERT INTO dbo.tblCenter " +
                "VALUES(" +
                "@center_id, " +
                "@center_name, " +
                "@center_address, " +
                "@center_contact, " +
                "@center_auditorium_count" +
                ")";

            var paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@center_id", SqlDbType.VarChar)
            {
                Value = center.Id
            };
            paras[1] = new SqlParameter("@center_name", SqlDbType.NVarChar)
            {
                Value = center.Name
            };
            paras[2] = new SqlParameter("@center_address", SqlDbType.NVarChar)
            {
                Value = center.Address
            };
            paras[3] = new SqlParameter("@center_contact", SqlDbType.VarChar)
            {
                Value = center.Contact
            };
            paras[4] = new SqlParameter("@center_auditorium_count", SqlDbType.SmallInt)
            {
                Value = center.AuditoriumCount
            };

            db_.ExecuteNonQuery(query, paras);
        }

        public void UpdateCenter(Center center)
        {
            var query = "UPDATE dbo.tblCenter " +
                        "SET [center_name] = N'" + center.Name + "', " +
                        "[center_address] = N'" + center.Address + "', " +
                        "[center_contact] = '" + center.Contact + "', " +
                        "[center_auditorium_count] = " + center.AuditoriumCount +
                        " WHERE [center_id] = '" + center.Id + "'";
            db_.ExecuteNonQuery(query);
        }

        public void DeleteCenter(string centerId)
        {
            var query = "DELETE " +
                        "FROM dbo.tblCenter " +
                        "WHERE [center_id] = '" + centerId + "'";
            db_.ExecuteNonQuery(query);
        }
    }
}