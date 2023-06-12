using System;
using System.Windows.Forms;

namespace cinema_mgmt.Reports
{
    public partial class frmScreeningPremiere : Form
    {
        public frmScreeningPremiere()
        {
            InitializeComponent();
        }

        private void frmScreeningPremiere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDBDataSet.tblScreening' table. You can move, or remove it, as needed.
            tblScreeningTableAdapter.Fill(cinemaDBDataSet.tblScreening);

            rpvScreeningPremiere.RefreshReport();
        }
    }
}