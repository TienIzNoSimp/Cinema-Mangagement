using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmAddAuditorium : Form
    {

        public frmAddAuditorium()
        {
            InitializeComponent();
        }
        BLPhongChieu bLPC = new BLPhongChieu();
        string err;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                bLPC.ThemPhongChieu(txtId.Text, cmbCenterId.Text, (int) nudSeatCount.Value, ref err);
                
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                lblIdAlreadyExists.Visible = true;

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbCenterId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCenterName.Text = bLPC.LayTenRap(cmbCenterId.Text);
        }

        private void cmbCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCenterId.Text = bLPC.LayMaRap(cmbCenterName.Text);
 
        }

        private void frmAddAuditorium_Load(object sender, EventArgs e)
        {
            cmbCenterName.DataSource = bLPC.LayThongTinRap();
            cmbCenterName.DisplayMember = "Tên rạp";
            cmbCenterName.ValueMember = "Tên rạp";

            cmbCenterId.DataSource = bLPC.LayThongTinRap();
            cmbCenterId.DisplayMember = "Mã rạp";
            cmbCenterId.ValueMember = "Mã rạp";
        }
    }
}