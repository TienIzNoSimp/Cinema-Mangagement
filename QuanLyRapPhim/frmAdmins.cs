using System.Windows.Forms;

namespace QuanLyRapPhim
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

        private void pnlUI_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}