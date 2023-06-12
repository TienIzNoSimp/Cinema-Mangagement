using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using cinema_mgmt.BS_Layer;

namespace cinema_mgmt.Form_Screenings
{
    public partial class frmScreening : Form
    {
        private readonly BLScreening dbScreening_;

        public frmScreening()
        {
            InitializeComponent();

            dbScreening_ = new BLScreening();
        }

        private void frmScreening_Load(object sender, EventArgs e)
        {
            ValidateScreening();

            dgvScreening.Columns[0].HeaderText = @"Name";
            dgvScreening.Columns[1].HeaderText = @"Genre";
            dgvScreening.Columns[2].HeaderText = @"Studio";
            dgvScreening.Columns[3].HeaderText = @"Start Date";
            dgvScreening.Columns[4].HeaderText = @"End Date";
        }

        private void ValidateScreening()
        {
            if (!cmbAvailableGenre.Items.Contains(string.Empty))
                cmbAvailableGenre.Items.Insert(0, string.Empty);

            foreach (var row in dbScreening_.LoadAvailableGenre().Tables[0].AsEnumerable())
                cmbAvailableGenre.Items.Add(row["genre_name"].ToString());
            cmbAvailableGenre.SelectedIndex = -1;

            FillScreeningName();
            cmbScreeningName.SelectedIndex = -1;

            cmbGenre.DataSource = dbScreening_.LoadGenre().Tables[0];
            cmbGenre.DisplayMember = "genre_name";
            cmbGenre.SelectedIndex = -1;

            cmbStudio.DataSource = dbScreening_.LoadStudio().Tables[0];
            cmbStudio.DisplayMember = "studio_name";
            cmbStudio.SelectedIndex = -1;

            FillScreeningDgv();
        }

        private void FillScreeningName()
        {
            // TODO: This line of code loads data into the 'cinemaDBDataSet.tblScreening' table. You can move, or remove it, as needed.
            tblScreeningTableAdapter.Fill(cinemaDBDataSet.tblScreening);
        }

        private void FillScreeningDgv()
        {
            dgvScreening.DataSource = dbScreening_.LoadScreening().Tables[0];
        }

        private void cmbAvailableGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAvailableGenre.SelectedIndex)
            {
                case -1:
                    return;
                case 0:
                    ValidateScreening();
                    break;
                default:
                    dgvScreening.DataSource = dbScreening_.LoadScreeningByGenre(cmbAvailableGenre.Text).Tables[0];
                    break;
            }
        }

        private void cmbScreeningName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScreeningName.SelectedIndex == -1) return;

            var screening = dbScreening_.LoadScreeningByName(cmbScreeningName.Text);
            cmbGenre.Text = screening.Genre;
            cmbStudio.Text = screening.Studio;
            dtpStartDate.Value = screening.StartDate;
            dtpEndDate.Value = screening.EndDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addScreeningForm = new frmAddScreening())
            {
                var res = addScreeningForm.ShowDialog();
                if (res == DialogResult.Cancel) return;
                ValidateScreening();
                Utility.Notification("Screening Added!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var screening = new Screening
                {
                    Name = cmbScreeningName.Text.Trim(),
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

                dbScreening_.UpdateScreening(screening);
                ValidateScreening();
                Utility.Notification("Center " + screening.Name + " Updated!");
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected Error: " + ex.Number);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dbScreening_.DeleteScreening(cmbScreeningName.Text);
                ValidateScreening();
                Utility.Notification("Center Deleted!");
            }
            catch (SqlException ex)
            {
                Utility.Error("Unexpected Error: " + ex.Number);
            }
        }
    }
}