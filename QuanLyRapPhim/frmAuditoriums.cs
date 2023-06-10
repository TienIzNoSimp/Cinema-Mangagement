using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmAuditoriums : Form
    {
        BLPhongChieu bLPC = new BLPhongChieu();
        string err;
        public frmAuditoriums()
        {
            InitializeComponent();

        }

        void LoadData ()
        {
            dgvAuditorium.DataSource = bLPC.LayPhongChieu();
            dgvAuditorium.AutoResizeColumns();

        }

        private void frmAuditoriums_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                cmbCenterId.DataSource = bLPC.LayThongTinRap();
                cmbCenterId.DisplayMember = "Mã rạp";
                cmbCenterId.ValueMember = "Mã rạp";

                cmbCenterName.DataSource = bLPC.LayThongTinRap();
                cmbCenterName.DisplayMember = "Tên rạp";
                cmbCenterName.ValueMember = "Tên rạp";

            }
            catch
            {
                MessageBox.Show("không lấy được");
            }

        }

        private void FillCenterCmb()
        {
        }

        private void ValidateAuditorium()
        {
            
        }

        private void cmbCenterId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCenterName.Text = bLPC.LayTenRap(cmbCenterId.Text);
            txtSeatCount.Text = bLPC.LayTongSoGhe(cmbCenterId.Text).ToString();

            //dgvAuditorium.DataSource=bLPC.LayPhongChieuTheoMa(cmbCenterId.Text);
            

            cmbAuditoriumId.DataSource = bLPC.LayMaPhong(cmbCenterId.Text);
            cmbAuditoriumId.DisplayMember = "Mã phòng";
            cmbAuditoriumId.ValueMember = "Mã phòng";

            


        }
        private void cmbCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCenterId.Text = bLPC.LayMaRap(cmbCenterName.Text);
            txtSeatCount.Text = bLPC.LayTongSoGhe(cmbCenterId.Text).ToString();
            //dgvAuditorium.DataSource = bLPC.LayPhongChieuTheoMa(cmbCenterId.Text);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAuditorium frmAdd = new frmAddAuditorium();
            frmAdd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bLPC.CapNhatPhongChieu(cmbCenterId.Text, cmbAuditoriumId.Text, (int)nudSeatCount.Value, ref err);
            LoadData();

 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bLPC.XoaPhongChieu(cmbAuditoriumId.Text, ref err);
            LoadData();
        }

        private void cmbAuditoriumId_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudSeatCount.Text = bLPC.LaySoGhe(cmbAuditoriumId.Text).ToString();
        }

        private void cmbCenterId_TextChanged(object sender, EventArgs e)
        {
            dgvAuditorium.DataSource = bLPC.LayPhongChieuTheoMa(cmbCenterId.Text);
        }

        private void cmbCenterName_TextChanged(object sender, EventArgs e)
        {
            dgvAuditorium.DataSource = bLPC.LayPhongChieuTheoMa(cmbCenterId.Text);
        }
    }
}