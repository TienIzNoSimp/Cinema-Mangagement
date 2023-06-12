using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Admins
{
    public partial class frmSignUp : Form
    {
        private readonly frmAdmins adminsForm_;
        private readonly BLUser dbSignUp_;

        public frmSignUp(frmAdmins adminsForm)
        {
            InitializeComponent();
            AcceptButton = btnRegister;

            dbSignUp_ = new BLUser();
            adminsForm_ = adminsForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblUsernameExists.Visible = false;

            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            if (user.Username.Equals(string.Empty) || user.Password.Equals(string.Empty))
            {
                Utility.Error("Please fill out both fields!");
                return;
            }

            try
            {
                dbSignUp_.CreateUser(user);
                Utility.Notification("Registered!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    lblUsernameExists.Visible = true;
                    txtUsername.Focus();
                }
                else
                {
                    Utility.Error("Unexpected error: " + ex.Number);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (Utility.Confirm("Are you sure you want to quit signing up?") == DialogResult.Yes)
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
    }
}