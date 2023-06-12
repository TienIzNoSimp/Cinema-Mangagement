using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmAddCenter : Form
    {
        string err;
        

        public frmAddCenter()
        {
            InitializeComponent();
            lblIdAlreadyExists.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BLRap bLRap = new BLRap();
            try
            {
                bLRap.ThemRap(txtId.Text, txtName.Text, txtAddress.Text, txtContact.Text, Convert.ToInt32(nudTheaterCount.Value), ref err);
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
    }
}