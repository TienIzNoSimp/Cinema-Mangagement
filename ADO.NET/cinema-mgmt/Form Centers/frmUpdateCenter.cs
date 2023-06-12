using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Centers
{
    public partial class frmUpdateCenter : Form
    {
        private readonly BLCenter dbCenter_;

        public frmUpdateCenter(string centerId)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            AcceptButton = btnUpdate;

            txtId.Text = centerId;
            dbCenter_ = new BLCenter();
        }

        private void frmUpdateCenter_Load(object sender, EventArgs e)
        {
            FillByCenterId(txtId.Text);
        }

        private void FillByCenterId(string centerId)
        {
            var center = dbCenter_.GetCenterById(centerId);
            txtName.Text = center.Name;
            txtAddress.Text = center.Address;
            txtContact.Text = center.Contact;
            nudAuditoriumCount.Value = Convert.ToDecimal(center.AuditoriumCount);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var center = new Center
            {
                Id = txtId.Text,
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                AuditoriumCount = Convert.ToInt16(nudAuditoriumCount.Value)
            };

            if (center.DoesViolateNullConstraint())
            {
                Utility.Error("Please fill out all required fields!");
                return;
            }

            try
            {
                dbCenter_.UpdateCenter(center);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected error: " + ex.Number);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}