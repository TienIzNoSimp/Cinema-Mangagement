using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Centers
{
    public partial class frmAddCenter : Form
    {
        private readonly BLCenter dbCenter_;

        public frmAddCenter()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            AcceptButton = btnAdd;

            dbCenter_ = new BLCenter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var center = new Center
            {
                Id = txtId.Text.Trim(),
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
                dbCenter_.AddCenter(center);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    lblDuplicateId.Visible = true;
                    txtId.Focus();
                }
                else
                {
                    Utility.Error("Unexpected error: " + ex.Number);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}