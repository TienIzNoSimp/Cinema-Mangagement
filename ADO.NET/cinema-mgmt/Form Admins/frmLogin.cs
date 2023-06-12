using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Admins
{
    public partial class frmLogin : Form
    {
        private readonly frmAdmins adminsForm_;
        private readonly BLUser dbLogin_;

        public frmLogin(frmAdmins adminsForm)
        {
            InitializeComponent();
            AcceptButton = btnLogin;

            dbLogin_ = new BLUser();
            adminsForm_ = adminsForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblInvalidUsername.Visible = lblInvalidPassword.Visible = false;

            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            try
            {
                if (dbLogin_.IsValidUser(user))
                {
                    adminsForm_.DialogResult = DialogResult.OK;
                    adminsForm_.Close();
                }
                else
                {
                    lblInvalidUsername.Visible = lblInvalidPassword.Visible = true;
                    txtUsername.Focus();
                }
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected error: " + ex.Number);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (Utility.Confirm("Are you sure you want to quit logging in?") == DialogResult.Yes)
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
    }
}