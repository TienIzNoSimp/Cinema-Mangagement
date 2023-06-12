using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;
using cinema_mgmt.Properties;

namespace cinema_mgmt.Form_Auditoriums
{
    public partial class frmAuditoriums : Form
    {
        private readonly BLAuditorium dbAuditorium_;

        public frmAuditoriums()
        {
            InitializeComponent();

            dbAuditorium_ = new BLAuditorium();
        }

        private void frmAuditoriums_Load(object sender, EventArgs e)
        {
            RefreshData();
            cmbCenterName_SelectedIndexChanged(sender, e);
            cmbAuditoriumId_SelectedIndexChanged(sender, e);
        }

        private void RefreshData()
        {
            tblAuditoriumTableAdapter.Fill(cinemaDBDataSet.tblAuditorium);
            tblCenterTableAdapter.Fill(cinemaDBDataSet.tblCenter);
        }

        private void cmbCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCenterName.Text.Equals(string.Empty)) return;
            txtTotalSeatCount.Text = dbAuditorium_.CountSeatByCenter(cmbCenterName.Text).ToString();
        }

        private void cmbAuditoriumId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuditoriumId.Text.Equals(string.Empty)) return;
            nudSeatCount.Value = Convert.ToDecimal(dbAuditorium_.CountSeatByAuditorium(cmbAuditoriumId.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addAuditoriumForm = new frmAddAuditorium())
            {
                var res = addAuditoriumForm.ShowDialog();
                if (res == DialogResult.Cancel) return;
                RefreshData();
                Utility.Notification("Auditorium added!");
            }
        }

        private void dgvAuditorium_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5) return;

            try
            {
                var auditoriumId = dgvAuditorium[0, e.RowIndex].Value.ToString();
                if (Utility.Confirm("Delete auditorium with ID: " + auditoriumId + "?") == DialogResult.No) return;
                dbAuditorium_.DeleteAuditorium(auditoriumId);
                RefreshData();
                Utility.Notification("Auditorium " + auditoriumId + " deleted!");
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected error: " + ex.Number);
            }
        }

        private void dgvAuditorium_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4) return;

            try
            {
                if (dgvAuditorium[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals(string.Empty))
                {
                    RefreshData();
                    return;
                }

                var auditorium = new Auditorium
                {
                    Id = cmbAuditoriumId.Text,
                    CenterId = dgvAuditorium[1, e.RowIndex].Value.ToString(),
                    SeatCount = Convert.ToInt16(dgvAuditorium[e.ColumnIndex, e.RowIndex].Value.ToString().Trim())
                };

                dbAuditorium_.UpdateAuditorium(auditorium);
                RefreshData();
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected error: " + ex.Number);
            }
        }

        private void dgvAuditorium_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5) return;

            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            var w = Resources.delete.Width;
            var h = Resources.delete.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(Resources.delete, new Rectangle(x, y, w, h));
            e.Handled = true;
        }
    }
}