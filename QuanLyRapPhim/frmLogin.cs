using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmLogin : Form
    {
        BLLogin BLLogin = new BLLogin();
        private readonly frmAdmins adminsForm_;
        

        public frmLogin(frmAdmins adminsForm)
        {
            InitializeComponent();
            adminsForm_ = adminsForm;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool temp = BLLogin.KiemTra(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (temp == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain frm = new frmMain();
                frm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            adminsForm_.LoadChildForm(new frmSignUp(adminsForm_));

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblDontHaveAccount_Click(object sender, EventArgs e)
        {

        }
    }
}