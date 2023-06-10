using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmCenter : Form
    {

        string err;
        BLRap dbRap = new BLRap();

        public frmCenter()
        {
            InitializeComponent();

          
        }
        void LoadData ()
        {
            dgvCenter.DataSource = dbRap.LayRap();
            dgvCenter.AutoResizeColumns();
        }

        private void frmCenter_Load(object sender, EventArgs e)
        {
            try
            {

                LoadData();
                cmbCenterId.DataSource = dbRap.LayMaRap();
                cmbCenterId.DisplayMember = "Mã rạp";
                cmbCenterId.ValueMember = "Mã rạp";

            }
            catch
            {
                MessageBox.Show("không lấy được");
            }
        }

        private void FillCenterDgv()
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCenter frmAdd = new frmAddCenter();
            frmAdd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BLRap bLRap = new BLRap();
            bLRap.CapNhatRap(cmbCenterId.Text, txtName.Text, txtAddress.Text, txtContact.Text, Convert.ToInt16(nudAuditoriumCount.Value), ref err);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BLRap bLRap  = new BLRap();
            bLRap.XoaRap(cmbCenterId.Text, ref err);
            LoadData();
            
        }

        private void dgvCenter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbCenterId_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbCenterId.Items.Count; i++)
            {
                if (cmbCenterId.Text == dgvCenter.Rows[i].Cells[0].Value.ToString())
                {
                    txtName.Text = dgvCenter.Rows[i].Cells[1].Value.ToString();
                    txtAddress.Text = dgvCenter.Rows[i].Cells[2].Value.ToString();
                    txtContact.Text = dgvCenter.Rows[i].Cells[3].Value.ToString();
                    nudAuditoriumCount.Value = decimal.Parse(dgvCenter.Rows[i].Cells[4].Value.ToString());
                    return;
                }
            }
        }
    }
}