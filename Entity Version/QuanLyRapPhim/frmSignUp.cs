using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmSignUp : Form
    {
        BLSignUp BLSignUp = new BLSignUp();
        private readonly frmAdmins adminsForm_;
        public frmSignUp(frmAdmins adminsForm)
        {
            InitializeComponent();
            this.adminsForm_ = adminsForm;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                if (BLSignUp.ThemUser(txtUsername.Text.Trim(), txtPassword.Text.Trim())) 
                {
                    MessageBox.Show("Success");
                }
                
            }
            else
            {
                lblPasswordDoesNotMatch.Visible = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked
                ? txtConfirmPassword.PasswordChar = '\0'
                : txtConfirmPassword.PasswordChar = '*';
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            adminsForm_.LoadChildForm(new frmLogin(adminsForm_));
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}