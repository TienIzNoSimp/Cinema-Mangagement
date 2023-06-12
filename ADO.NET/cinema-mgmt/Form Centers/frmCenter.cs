using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;
using cinema_mgmt.Properties;

namespace cinema_mgmt.Form_Centers
{
    public partial class frmCenter : Form
    {
        private readonly BLCenter dbCenter_;

        public frmCenter()
        {
            InitializeComponent();
            AcceptButton = btnSearch;

            dbCenter_ = new BLCenter();
        }

        private void frmCenter_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            tblCenterTableAdapter.Fill(cinemaDBDataSet.tblCenter);
            dgvCenter.DataSource = cinemaDBDataSet.tblCenter;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Equals(string.Empty))
                RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Equals(string.Empty))
                RefreshData();
            else dgvCenter.DataSource = dbCenter_.Search(txtSearch.Text.Trim()).Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addCenterForm = new frmAddCenter())
            {
                var res = addCenterForm.ShowDialog();
                if (res == DialogResult.Cancel) return;
                RefreshData();
                Utility.Notification("Center added!");
            }
        }

        private void dgvCenter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (e.ColumnIndex)
            {
                case 5:
                {
                    var centerId = dgvCenter[0, e.RowIndex].Value.ToString();
                    using (var updateCenterForm = new frmUpdateCenter(centerId))
                    {
                        var res = updateCenterForm.ShowDialog();
                        if (res == DialogResult.Cancel) return;
                        RefreshData();
                        Utility.Notification("Center " + centerId + " updated!");
                    }

                    break;
                }
                case 6:
                {
                    try
                    {
                        var centerId = dgvCenter[0, e.RowIndex].Value.ToString();
                        var centerName = dgvCenter[1, e.RowIndex].Value.ToString();
                        if (Utility.Confirm("Delete center " + centerName + " with ID: " + centerId + "?") ==
                            DialogResult.No) return;
                        dbCenter_.DeleteCenter(centerId);
                        RefreshData();
                        Utility.Notification("Center " + centerId + " deleted!");
                    }
                    catch (SqlException ex)
                    {
                        Utility.Error("Unexpected error: " + ex.Number);
                    }

                    break;
                }
            }
        }

        private void dgvCenter_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (e.ColumnIndex)
            {
                case 5:
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = Resources.edit.Width;
                    var h = Resources.edit.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Resources.edit, new Rectangle(x, y, w, h));
                    e.Handled = true;
                    break;
                }
                case 6:
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = Resources.delete.Width;
                    var h = Resources.delete.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Resources.delete, new Rectangle(x, y, w, h));
                    e.Handled = true;
                    break;
                }
            }
        }
    }
}