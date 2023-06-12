using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyRapPhim.BS_layer
{
    internal class BLPhongChieu
    {

        public DataTable LayThongTinRap()
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã rạp");
            dt.Columns.Add("Tên rạp");
            
            var MaRapQuery = from p in qlrpEntities.tblCenters select p;
            
            foreach (var m in MaRapQuery)
            {
                dt.Rows.Add(m.center_id, m.center_name);
            }
            return dt;
        }

        public string LayTenRap (string MaRap)
        {
            string name;
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
    

            var MaRapQuery = (from p in qlrpEntities.tblCenters where p.center_id == MaRap select p).SingleOrDefault();

            if(MaRapQuery != null)
            {
                name = MaRapQuery.center_name;
                return name;
            }
            else
            {
                return "NULL";
            }
               
        }

        public string LayMaRap (string TenRap)
        {
            string name;
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            DataTable dt = new DataTable();

            

            var MaRapQuery = (from p in qlrpEntities.tblCenters where p.center_name == TenRap select p).SingleOrDefault();

            if (MaRapQuery != null)
            {
                name = MaRapQuery.center_id;
                return name;
            }
            else
            {
                return "NULL";
            }
        }
        

        public DataTable LayMaPhong(string MaRap)
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phòng");

            var MaPhongQuery = from p in qlrpEntities.tblAuditoriums where p.center_id == MaRap select p;
            foreach (var m in MaPhongQuery)
            {
                dt.Rows.Add(m.auditorium_id);
            }
            return dt;
        }

        public int LaySoGhe(string MaPhong)
        {
            int seats = 0;
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            DataTable dt = new DataTable();
            dt.Columns.Add("số ghế");

            var MaPhongQuery = from p in qlrpEntities.tblAuditoriums where p.auditorium_id == MaPhong select p;
            foreach (var m in MaPhongQuery)
            {
                dt.Rows.Add(m.seat_count);
            }
            seats = Int16.Parse(dt.Rows[0][0].ToString());
            return seats;
        }

        public int LayTongSoGhe(string MaRap)
        {
            int count = 0;
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            var PhongChieuQuery =
                from p in qlrpEntities.tblAuditoriums where p.center_id == MaRap
                select p;

            DataTable dt = new DataTable();

            dt.Columns.Add("Số ghế");

            foreach (var p in PhongChieuQuery)
            {
                count += p.seat_count;
            }
            return count;
        }

        public DataTable LayPhongChieu ()
        {

            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            var PhongChieuQuery =
                from p in qlrpEntities.tblAuditoriums
                select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Phòng");
            dt.Columns.Add("Mã Rạp");
            dt.Columns.Add("Số ghế");

            foreach (var p in PhongChieuQuery)
            {
                dt.Rows.Add(p.auditorium_id, p.center_id, p.seat_count);
            }
            return dt;
        }

        public DataTable LayPhongChieuTheoMa(string MaRap)
        {

            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            var PhongChieuQuery =
                from p in qlrpEntities.tblAuditoriums where p.center_id == MaRap
                select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Phòng");
            dt.Columns.Add("Mã Rạp");
            dt.Columns.Add("Số ghế");

            foreach (var p in PhongChieuQuery)
            {
                dt.Rows.Add(p.auditorium_id, p.center_id, p.seat_count);
            }
            return dt;
        }
        public bool ThemPhongChieu (string MaPhong, string MaRap, int SoGhe, ref string err)
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            tblAuditorium phongChieu = new tblAuditorium();

            phongChieu.auditorium_id = MaPhong;
            phongChieu.center_id = MaRap;
            phongChieu.seat_count = (short)SoGhe;
            qlrpEntities.tblAuditoriums.Add(phongChieu);
            qlrpEntities.SaveChanges();
            return true;
        }

        public bool CapNhatPhongChieu (string MaRap, string MaPhong, int SoGhe, ref string err)
        {
            QLRapPhimEntities qlRapPhim = new QLRapPhimEntities();
            var PhongChieuQuery = (from p in qlRapPhim.tblAuditoriums where p.auditorium_id == MaPhong select p).SingleOrDefault();
            if (PhongChieuQuery != null)
            {
                PhongChieuQuery.center_id = MaRap;
                PhongChieuQuery.auditorium_id = MaPhong;
                PhongChieuQuery.seat_count = (short)SoGhe;
                qlRapPhim.SaveChanges();
            }
            return true;
        }

        public bool XoaPhongChieu(string MaPhong, ref string err)
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            tblAuditorium PC = new tblAuditorium();

            PC.auditorium_id = MaPhong;
            qlrpEntities.tblAuditoriums.Attach(PC);
            qlrpEntities.tblAuditoriums.Remove(PC);
            qlrpEntities.SaveChanges();
            return true;
        }
    }
}
