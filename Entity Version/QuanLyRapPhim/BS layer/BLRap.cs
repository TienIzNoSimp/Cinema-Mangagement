using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyRapPhim.BS_layer
{
    internal class BLRap
    {
        public DataTable LayMaRap()
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            var rapQuery =
                from p in qlrpEntities.tblCenters
                select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã rạp");
            foreach (var p in rapQuery)
            {
                dt.Rows.Add(p.center_id);
            }
            return dt;
        }
        public DataTable LayRap()
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            var rapQuery =
                from p in qlrpEntities.tblCenters
                select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã rạp");
            dt.Columns.Add("Tên rạp");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Điện thoại");
            dt.Columns.Add("Tổng số phòng");

            
            foreach (var p in rapQuery)
            {
                dt.Rows.Add(p.center_id, p.center_name, p.center_address, p.center_contact, p.center_auditorium_count);
            }
            return dt;

        }
        public bool ThemRap(string MaRap, string TenRap, string DiaChi, string DienThoai,  int TongSoPhong, ref string err)
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            tblCenter rap = new tblCenter();

            rap.center_id = MaRap;
            rap.center_name = TenRap;
            rap.center_address = DiaChi;
            rap.center_contact = DienThoai;
            rap.center_auditorium_count = (short)TongSoPhong;
            qlrpEntities.tblCenters.Add(rap);
            qlrpEntities.SaveChanges();
            return true;

        }
        
        public bool CapNhatRap (string MaRap, string TenRap, string DiaChi, string DienThoai, int TongSoPhong,ref string err)
        {
            QLRapPhimEntities qlRapPhim = new QLRapPhimEntities();
            var rapQuery = (from p in qlRapPhim.tblCenters where p.center_id == MaRap select p).SingleOrDefault();

            if (rapQuery != null)
            {
                rapQuery.center_name = TenRap;
                rapQuery.center_contact = DienThoai;
                rapQuery.center_address = DiaChi;
                rapQuery.center_auditorium_count = (short)TongSoPhong;
                qlRapPhim.SaveChanges();
            }
            return true;

        }

        public bool XoaRap(string MaRap, ref string err)
        {
            QLRapPhimEntities qlrpEntities = new QLRapPhimEntities();
            tblCenter rap = new tblCenter();

            rap.center_id = MaRap;
            qlrpEntities.tblCenters.Attach(rap);
            qlrpEntities.tblCenters.Remove(rap);
            qlrpEntities.SaveChanges();
            return true;
        }
    }
}
