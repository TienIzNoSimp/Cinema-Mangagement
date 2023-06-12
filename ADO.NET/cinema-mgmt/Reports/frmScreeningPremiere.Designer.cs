namespace cinema_mgmt.Reports
{
    partial class frmScreeningPremiere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvScreeningPremiere = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cinemaDBDataSet = new cinema_mgmt.CinemaDBDataSet();
            this.tblScreeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblScreeningTableAdapter = new cinema_mgmt.CinemaDBDataSetTableAdapters.tblScreeningTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScreeningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvScreeningPremiere
            // 
            this.rpvScreeningPremiere.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ScreeningPremiereDataSet";
            reportDataSource1.Value = this.tblScreeningBindingSource;
            this.rpvScreeningPremiere.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvScreeningPremiere.LocalReport.ReportEmbeddedResource = "cinema_mgmt.Reports.rptScreeningPremiere.rdlc";
            this.rpvScreeningPremiere.Location = new System.Drawing.Point(0, 0);
            this.rpvScreeningPremiere.Name = "rpvScreeningPremiere";
            this.rpvScreeningPremiere.ServerReport.BearerToken = null;
            this.rpvScreeningPremiere.Size = new System.Drawing.Size(1030, 809);
            this.rpvScreeningPremiere.TabIndex = 0;
            // 
            // cinemaDBDataSet
            // 
            this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
            this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblScreeningBindingSource
            // 
            this.tblScreeningBindingSource.DataMember = "tblScreening";
            this.tblScreeningBindingSource.DataSource = this.cinemaDBDataSet;
            // 
            // tblScreeningTableAdapter
            // 
            this.tblScreeningTableAdapter.ClearBeforeFill = true;
            // 
            // frmScreeningPremiere
            // 
            this.ClientSize = new System.Drawing.Size(1030, 809);
            this.Controls.Add(this.rpvScreeningPremiere);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreeningPremiere";
            this.Load += new System.EventHandler(this.frmScreeningPremiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScreeningBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvScreeningPremiere;
        private CinemaDBDataSet cinemaDBDataSet;
        private System.Windows.Forms.BindingSource tblScreeningBindingSource;
        private CinemaDBDataSetTableAdapters.tblScreeningTableAdapter tblScreeningTableAdapter;
    }
}