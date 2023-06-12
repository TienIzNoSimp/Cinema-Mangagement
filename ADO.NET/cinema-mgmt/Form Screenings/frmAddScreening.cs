using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Screenings
{
    public partial class frmAddScreening : Form
    {
        private readonly BLScreening dbScreening_;

        public frmAddScreening()
        {
            InitializeComponent();

            dbScreening_ = new BLScreening();
        }

        private void frmAddScreening_Load(object sender, EventArgs e)
        {
            cmbGenre.DataSource = dbScreening_.LoadGenre().Tables[0];
            cmbGenre.DisplayMember = "genre_name";
            cmbGenre.SelectedIndex = -1;

            cmbStudio.DataSource = dbScreening_.LoadStudio().Tables[0];
            cmbStudio.DisplayMember = "studio_name";
            cmbStudio.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var screening = new Screening
            {
                Name = txtName.Text.Trim(),
                Genre = cmbGenre.Text,
                Studio = cmbStudio.Text,
                StartDate = dtpStartDate.Value.Date,
                EndDate = dtpEndDate.Value.Date
            };

            if (screening.DoesViolateNullConstraint())
            {
                Utility.Error("Please fill out all required fields!");
                return;
            }

            try
            {
                dbScreening_.AddScreening(screening);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected Error: " + ex.Number);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}