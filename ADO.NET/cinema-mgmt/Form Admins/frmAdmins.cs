using System.Windows.Forms;

namespace cinema_mgmt.Form_Admins
{
    public partial class frmAdmins : Form
    {
        private Form activeForm_;

        public frmAdmins()
        {
            InitializeComponent();

            LoadChildForm(new frmLogin(this));
        }

        public void LoadChildForm(Form frm)
        {
            activeForm_?.Close();
            activeForm_ = frm;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;

            pnlUI.Controls.Add(frm);
            pnlUI.Tag = frm;
            frm.Show();
        }
    }
}