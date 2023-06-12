using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;
namespace QuanLyRapPhim
{
    public partial class frmScreening : Form
    {
        BLPhim plPhim = new BLPhim();
        string err;
        
        public frmScreening()
        {
            InitializeComponent();

            

        }

        private void frmScreening_Load(object sender, EventArgs e)
        {
            cmbAvailableGenre.DataSource = plPhim.LayTheLoai();
            cmbAvailableGenre.DisplayMember = "Tên thể loại";
            cmbAvailableGenre.ValueMember = "Tên thể loại";

            cmbGenre.DataSource = plPhim.LayTheLoai();
            cmbGenre.DisplayMember = "Tên thể loại";
            cmbGenre.ValueMember = "Tên thể loại";

            cmbStudio.DataSource = plPhim.LayNSX();
            cmbStudio.DisplayMember = "Tên studio";
            cmbStudio.ValueMember = "Tên studio";
            LoadDataSet();
        }

        public void LoadDataSet()
        {
            cmbScreeningName.DataSource = plPhim.LayTenPhim();
            cmbScreeningName.DisplayMember = "Tên phim";
            cmbScreeningName.ValueMember = "Tên phim";

            dgvScreening.DataSource = plPhim.LayPhim();

        }

        private void cmbAvailableGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbScreeningName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGenre.Text = plPhim.TimTheLoai(cmbScreeningName.Text);
            cmbStudio.Text =    plPhim.TimStudio(cmbScreeningName.Text);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddScreening frmScreening = new frmAddScreening();
            frmScreening.ShowDialog();
            
        }
        private void cmbScreeningName_TextChanged(object sender, EventArgs e)
        {
            //string temp = cmbScreeningName.SelectedText;
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Ngày khởi chiếu không được sau ngày kết thúc", "Thông báo");
                return;
            }
            plPhim.CapNhatPhim(cmbScreeningName.Text, cmbGenre.Text, cmbStudio.Text, dtpStartDate.Value, dtpEndDate.Value, ref err);
            LoadDataSet();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            plPhim.XoaPhim(cmbScreeningName.Text, ref err);
            LoadDataSet();
        }

        private void cmbAvailableGenre_TextChanged(object sender, EventArgs e)
        {
            dgvScreening.DataSource = plPhim.LayTheLoaiCuThe(cmbAvailableGenre.Text);
        }

        private void cmbScreeningName_MouseClick(object sender, MouseEventArgs e)
        {
            string temp = cmbScreeningName.SelectedText;
        }
    }
}