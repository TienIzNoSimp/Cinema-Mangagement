using System;
using System.Windows.Forms;
using QuanLyRapPhim.BS_layer;

namespace QuanLyRapPhim
{
    public partial class frmMain : Form
    {
        private Form activeForm_;

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadChildForm(Form frm)
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

        private void btnCenters_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmCenter());
        }

        private void btnAuditoriums_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmAuditoriums());
        }

        private void btnSeats_Click(object sender, EventArgs e)
        {
        }

        private void btnScreenings_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmScreening());
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
        }
    }
}