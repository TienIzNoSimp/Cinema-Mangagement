using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmAddScreening : Form
    {
        string err;
        public bool HasClosed;
        BLPhim blPhim = new BLPhim();
        public frmAddScreening()
        {
            InitializeComponent();
            HasClosed = false;

        }

        private void frmAddScreening_Load(object sender, EventArgs e)
        {
            
            cmbGenre.DataSource = blPhim.LayTheLoai();
            cmbGenre.DisplayMember = "Tên thể loại";
            cmbGenre.ValueMember = "Tên thể loại";

            cmbStudio.DataSource = blPhim.LayNSX();
            cmbStudio.DisplayMember = "Tên studio";
            cmbStudio.ValueMember = "Tên studio";

            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpStartDate.Value < dtpEndDate.Value)
                {
                    blPhim.ThemPhim(txtName.Text, cmbGenre.Text, cmbStudio.Text, dtpStartDate.Value, dtpEndDate.Value, ref err);
                    MessageBox.Show("Thêm thành công");
                    
                }
                else
                    MessageBox.Show("Ngày công chiếu phải trước ngày kết thúc");
            }
            catch
            {
                MessageBox.Show("Phim này đã có sẵn", "Thông báo");

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            HasClosed = true;
            
            Close();
        }
    }
}