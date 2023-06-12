using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using cinema_mgmt.DB_Layer;

namespace cinema_mgmt.BS_Layer
{
    internal class Screening
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool DoesViolateNullConstraint()
        {
            return Name == string.Empty
                   || Genre == string.Empty
                   || Studio == string.Empty;
        }
    }

    internal class BLScreening
    {
        private readonly DBMain db_;
        private readonly Dictionary<string, int> genre_;
        private readonly Dictionary<string, int> studio_;

        public BLScreening()
        {
            db_ = new DBMain();

            genre_ = new Dictionary<string, int>();
            LoadGenreToDict();

            studio_ = new Dictionary<string, int>();
            LoadStudioToDict();
        }

        private void LoadGenreToDict()
        {
            const string query = "SELECT * FROM dbo.tblGenre";
            var dataSet = db_.ExecuteLoadQuery(query);

            foreach (var row in dataSet.Tables[0].AsEnumerable())
                genre_.Add(row["genre_name"].ToString(), Convert.ToInt16(row["genre_id"]));
        }

        private void LoadStudioToDict()
        {
            const string query = "SELECT * FROM dbo.tblStudio";
            var dataSet = db_.ExecuteLoadQuery(query);

            foreach (var row in dataSet.Tables[0].AsEnumerable())
                studio_.Add(row["studio_name"].ToString(), Convert.ToInt16(row["studio_id"]));
        }

        public DataSet LoadAvailableGenre()
        {
            const string query =
                "SELECT DISTINCT [genre_name] FROM dbo.tblGenre INNER JOIN dbo.tblScreening ON dbo.tblGenre.[genre_id] = dbo.tblScreening.[genre_id]";
            var dataSet = db_.ExecuteLoadQuery(query);

            return dataSet;
        }

        public DataSet LoadGenre()
        {
            const string query = "SELECT * FROM dbo.tblGenre";
            return db_.ExecuteLoadQuery(query);
        }

        public DataSet LoadStudio()
        {
            const string query = "SELECT * FROM dbo.tblStudio";
            return db_.ExecuteLoadQuery(query);
        }

        public DataSet LoadScreening()
        {
            const string query =
                "SELECT [screening_name], [genre_name], [studio_name], [screening_start], [screening_end] " +
                "FROM (dbo.tblGenre INNER JOIN dbo.tblScreening ON dbo.tblGenre.[genre_id] = dbo.tblScreening.[genre_id]) " +
                "INNER JOIN dbo.tblStudio ON dbo.tblStudio.[studio_id] = dbo.tblScreening.[studio_id]";
            return db_.ExecuteLoadQuery(query);
        }

        public DataSet LoadScreeningByGenre(string genreName)
        {
            var query = "SELECT [screening_name], [genre_name], [studio_name], [screening_start], [screening_end] " +
                        "FROM (dbo.tblGenre INNER JOIN dbo.tblScreening ON dbo.tblGenre.[genre_id] = dbo.tblScreening.[genre_id]) " +
                        "INNER JOIN dbo.tblStudio ON dbo.tblStudio.[studio_id] = dbo.tblScreening.[studio_id] " +
                        "WHERE [genre_name] = N'" + genreName + "'";
            return db_.ExecuteLoadQuery(query);
        }

        public Screening LoadScreeningByName(string screeningName)
        {
            var query =
                "SELECT [screening_name], [genre_name], [studio_name], [screening_start], [screening_end] " +
                "FROM (dbo.tblGenre INNER JOIN dbo.tblScreening ON dbo.tblGenre.[genre_id] = dbo.tblScreening.[genre_id]) " +
                "INNER JOIN dbo.tblStudio ON dbo.tblStudio.[studio_id] = dbo.tblScreening.[studio_id] " +
                "WHERE [screening_name] = N'" + screeningName + "'";
            var res = db_.ExecuteLoadQuery(query).Tables[0].Rows[0];
            var screening = new Screening
            {
                Name = screeningName,
                Genre = res["genre_name"].ToString(),
                Studio = res["studio_name"].ToString(),
                StartDate = Convert.ToDateTime(res["screening_start"]),
                EndDate = Convert.ToDateTime(res["screening_end"])
            };
            return screening;
        }

        public void AddScreening(Screening screening)
        {
            const string query =
                "INSERT INTO dbo.tblScreening VALUES (@screening_name, @genre_id, @studio_id, @screening_start, @screening_end)";

            var paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@screening_name", SqlDbType.NVarChar)
            {
                Value = screening.Name
            };
            paras[1] = new SqlParameter("@genre_id", SqlDbType.TinyInt)
            {
                Value = genre_[screening.Genre]
            };
            paras[2] = new SqlParameter("@studio_id", SqlDbType.SmallInt)
            {
                Value = studio_[screening.Studio]
            };
            paras[3] = new SqlParameter("@screening_start", SqlDbType.Date)
            {
                Value = screening.StartDate
            };
            paras[4] = new SqlParameter("@screening_end", SqlDbType.Date)
            {
                Value = screening.EndDate
            };

            db_.ExecuteNonQuery(query, paras);
        }

        public void UpdateScreening(Screening screening)
        {
            var query = "UPDATE dbo.tblScreening SET [genre_id] = " +
                        genre_[screening.Genre] + ", [studio_id] = " + studio_[screening.Studio] +
                        ", [screening_start] = '" + screening.StartDate.Date + "', [screening_end] = '" +
                        screening.EndDate.Date + "' WHERE [screening_name] = N'" + screening.Name + "'";
            db_.ExecuteNonQuery(query);
        }

        public void DeleteScreening(string screeningName)
        {
            var query = "DELETE FROM dbo.tblScreening WHERE [screening_name] = N'" + screeningName + "'";
            db_.ExecuteNonQuery(query);
        }
    }
}