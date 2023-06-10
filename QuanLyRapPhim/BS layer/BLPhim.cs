using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyRapPhim.BS_layer
{
    internal class BLPhim
    {
        public string TimTheLoai (string TenPhim)
        {
            QLRapPhimEntities qLRapPhimEntities = new QLRapPhimEntities();
            var tl_id = (from p in qLRapPhimEntities.tblScreenings where p.screening_name == TenPhim select p).SingleOrDefault();
            var tl_name = (from q in qLRapPhimEntities.tblGenres where q.genre_id == tl_id.genre_id select q).SingleOrDefault();
            return tl_name.genre_name;
           
        }

        public string TimStudio (string TenPhim)
        {
            QLRapPhimEntities qLRapPhimEntities = new QLRapPhimEntities();
            var nsx_id = (from p in qLRapPhimEntities.tblScreenings where p.screening_name == TenPhim select p).SingleOrDefault();
            var nsx_name = (from q in qLRapPhimEntities.tblStudios where q.studio_id == nsx_id.studio_id select q).SingleOrDefault();
            return nsx_name.studio_name;
        }
        public DataTable LayTheLoai ()
        {
            QLRapPhimEntities qlrpEntity = new QLRapPhimEntities();
            var tl = from p in qlrpEntity.tblGenres select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã thể loại");
            dt.Columns.Add("Tên thể loại");
            foreach (var p in tl)
            {
                dt.Rows.Add(p.genre_id, p.genre_name);
            }
            return dt;
        }

        public DataTable LayNSX ()
        {
            QLRapPhimEntities qlrpEntity = new QLRapPhimEntities();
            var nsx = from p in qlrpEntity.tblStudios select p;
            DataTable dt = new DataTable ();
            dt.Columns.Add("Tên studio");
            foreach (var p in nsx)
            {
                dt.Rows.Add(p.studio_name);
            }
            return dt;
        }

        public DataTable LayTheLoaiCuThe (string TenTheLoai)
        {
            QLRapPhimEntities qlrpEntity = new QLRapPhimEntities();
            var ps =
                from p in qlrpEntity.tblScreenings
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên phim");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Studio");
            dt.Columns.Add("Start date");
            dt.Columns.Add("End date");

            foreach (var p in ps)
            {
                var tl = from q in qlrpEntity.tblGenres select q;
                foreach (var q in tl)
                {
                    if (p.genre_id == q.genre_id && q.genre_name == TenTheLoai)
                    {
                        var nsx = from t in qlrpEntity.tblStudios select t;
                        foreach (var t in nsx)
                        {
                            if (p.studio_id == t.studio_id)
                            {
                                dt.Rows.Add(p.screening_name, q.genre_name, t.studio_name, p.screening_start, p.screening_end);
                            }
                        }
                    }

                }
            }
            return dt;

        }
        public DataTable LayTenPhim ()
        {
            QLRapPhimEntities qlrpEntity = new QLRapPhimEntities();
            var tp = from p in qlrpEntity.tblScreenings select p;
            DataTable dt = new DataTable ();
            dt.Columns.Add("Tên phim");
            foreach ( var p in tp)
            {
                dt.Rows.Add(p.screening_name);
            }
            return dt;
        }

        public DataTable LayPhim()
        {
            QLRapPhimEntities qlrpEntity = new QLRapPhimEntities();
            var ps =
                from p in qlrpEntity.tblScreenings
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên phim");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Studio");
            dt.Columns.Add("Start date");
            dt.Columns.Add("End date");

            foreach (var p in ps)
            {
                var tl = from q in qlrpEntity.tblGenres select q;
                foreach (var q in tl)
                {
                    if (p.genre_id == q.genre_id)
                    {
                        var nsx = from t in qlrpEntity.tblStudios select t;
                        foreach (var t in nsx)
                        {
                            if (p.studio_id == t.studio_id)
                            {
                                dt.Rows.Add(p.screening_name, q.genre_name, t.studio_name, p.screening_start, p.screening_end);
                            }
                        }
                    }
                    
                }
            }
            return dt;
        }

      

        public bool CapNhatPhim (string TenPhim, string TenTheLoai, string TenStudio, 
            DateTime NgayBatDau, DateTime NgayKetThuc, ref string err)

        {
            QLRapPhimEntities qlRapPhim = new QLRapPhimEntities();
            var PhimQuery = (from p in qlRapPhim.tblScreenings where p.screening_name == TenPhim select p).SingleOrDefault();
        
            if (PhimQuery != null)
            {
                var tl = (from q in qlRapPhim.tblGenres where q.genre_name == TenTheLoai select q).SingleOrDefault();

                var nsx = (from t in qlRapPhim.tblStudios where TenStudio == t.studio_name select t).SingleOrDefault();

                 PhimQuery.screening_name = TenPhim;
                 PhimQuery.genre_id = tl.genre_id;
                 PhimQuery.studio_id = nsx.studio_id;
                 PhimQuery.screening_start = NgayBatDau;
                 PhimQuery.screening_end = NgayKetThuc;
                 qlRapPhim.SaveChanges();
             
            }
            return true;
        }
                
        public bool XoaPhim(string MaPhim, ref string err)
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            tblScreening phim = new tblScreening();

            phim.screening_name = MaPhim;
            qlrpEntities.tblScreenings.Attach(phim);
            qlrpEntities.tblScreenings.Remove(phim);
            qlrpEntities.SaveChanges();
            return true;
        }

        public bool ThemPhim (string TenPhim, string TenTheLoai, string TenNSX, DateTime NgayBatDau, DateTime NgayKetThuc, ref string err)
        {
            QLRapPhimEntities qlRapPhim = new QLRapPhimEntities();
            tblScreening phim = new tblScreening();
            var tl = (from q in qlRapPhim.tblGenres where q.genre_name == TenTheLoai select q).SingleOrDefault();

            var nsx = (from t in qlRapPhim.tblStudios where TenNSX == t.studio_name select t).SingleOrDefault();

            phim.screening_name = TenPhim;
            phim.genre_id = tl.genre_id;
            phim.studio_id = nsx.studio_id;
            phim.screening_start = NgayBatDau;
            phim.screening_end = NgayKetThuc;
            qlRapPhim.tblScreenings.Add(phim);
            qlRapPhim.SaveChanges();
            return true;
        }

    }
        
    
}
