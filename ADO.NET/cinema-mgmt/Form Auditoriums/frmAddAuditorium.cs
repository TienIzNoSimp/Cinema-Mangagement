using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Auditoriums
{
    public partial class frmAddAuditorium : Form
    {
        private readonly BLAuditorium dbAuditorium_;

        public frmAddAuditorium()
        {
            InitializeComponent();
            AcceptButton = btnAdd;

            dbAuditorium_ = new BLAuditorium();
        }

        private void frmAddAuditorium_Load(object sender, EventArgs e)
        {
            tblCenterTableAdapter.Fill(cinemaDBDataSet.tblCenter);
            cmbCenterId.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var auditorium = new Auditorium
            {
                Id = txtId.Text.Trim(),
                CenterId = cmbCenterId.Text.Trim(),
                SeatCount = Convert.ToInt16(nudSeatCount.Value)
            };

            try
            {
                if (dbAuditorium_.DoesReachMaxAuditorium(auditorium.CenterId))
                {
                    Utility.Notification("Maximum Auditoriums Reached!");
                    return;
                }

                if (auditorium.DoesViolateNullConstraint())
                {
                    Utility.Error("Please fill out all required fields!");
                    return;
                }

                dbAuditorium_.AddAuditorium(auditorium);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    lblIdAlreadyExists.Visible = true;
                    txtId.Focus();
                }
                else
                {
                    Utility.Error("Unexpected Error: " + ex.Number);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbCenterId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = cmbCenterId.Text + '_';
        }
    }
}