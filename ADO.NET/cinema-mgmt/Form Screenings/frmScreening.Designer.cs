namespace cinema_mgmt.Form_Screenings
{
    partial class frmScreening
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvScreening = new System.Windows.Forms.DataGridView();
            this.cmbAvailableGenre = new System.Windows.Forms.ComboBox();
            this.lblAvailableGenre = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblScreeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDBDataSet = new cinema_mgmt.CinemaDBDataSet();
            this.tblScreeningTableAdapter = new cinema_mgmt.CinemaDBDataSetTableAdapters.tblScreeningTableAdapter();
            this.grpSortView = new System.Windows.Forms.GroupBox();
            this.lblScreeningName = new System.Windows.Forms.Label();
            this.cmbScreeningName = new System.Windows.Forms.ComboBox();
            this.cmbStudio = new System.Windows.Forms.ComboBox();
            this.lblStudio = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.grpCRUD = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScreeningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
            this.grpSortView.SuspendLayout();
            this.grpCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScreening
            // 
            this.dgvScreening.AllowUserToAddRows = false;
            this.dgvScreening.AllowUserToDeleteRows = false;
            this.dgvScreening.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScreening.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvScreening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreening.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvScreening.Location = new System.Drawing.Point(0, 164);
            this.dgvScreening.Name = "dgvScreening";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvScreening.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScreening.Size = new System.Drawing.Size(1030, 645);
            this.dgvScreening.TabIndex = 0;
            // 
            // cmbAvailableGenre
            // 
            this.cmbAvailableGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAvailableGenre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvailableGenre.FormattingEnabled = true;
            this.cmbAvailableGenre.Location = new System.Drawing.Point(11, 65);
            this.cmbAvailableGenre.Name = "cmbAvailableGenre";
            this.cmbAvailableGenre.Size = new System.Drawing.Size(150, 28);
            this.cmbAvailableGenre.TabIndex = 4;
            this.cmbAvailableGenre.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableGenre_SelectedIndexChanged);
            // 
            // lblAvailableGenre
            // 
            this.lblAvailableGenre.AutoSize = true;
            this.lblAvailableGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableGenre.ForeColor = System.Drawing.Color.Gray;
            this.lblAvailableGenre.Location = new System.Drawing.Point(7, 43);
            this.lblAvailableGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableGenre.Name = "lblAvailableGenre";
            this.lblAvailableGenre.Size = new System.Drawing.Size(116, 19);
            this.lblAvailableGenre.TabIndex = 3;
            this.lblAvailableGenre.Text = "Available Genre";
            this.lblAvailableGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(536, 94);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 27);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(621, 94);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(940, 130);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblScreeningBindingSource
            // 
            this.tblScreeningBindingSource.DataMember = "tblScreening";
            this.tblScreeningBindingSource.DataSource = this.cinemaDBDataSet;
            // 
            // cinemaDBDataSet
            // 
            this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
            this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblScreeningTableAdapter
            // 
            this.tblScreeningTableAdapter.ClearBeforeFill = true;
            // 
            // grpSortView
            // 
            this.grpSortView.AutoSize = true;
            this.grpSortView.Controls.Add(this.lblAvailableGenre);
            this.grpSortView.Controls.Add(this.cmbAvailableGenre);
            this.grpSortView.Location = new System.Drawing.Point(12, 12);
            this.grpSortView.Name = "grpSortView";
            this.grpSortView.Size = new System.Drawing.Size(167, 146);
            this.grpSortView.TabIndex = 12;
            this.grpSortView.TabStop = false;
            this.grpSortView.Text = "Sort View";
            // 
            // lblScreeningName
            // 
            this.lblScreeningName.AutoSize = true;
            this.lblScreeningName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreeningName.ForeColor = System.Drawing.Color.Gray;
            this.lblScreeningName.Location = new System.Drawing.Point(7, 21);
            this.lblScreeningName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScreeningName.Name = "lblScreeningName";
            this.lblScreeningName.Size = new System.Drawing.Size(119, 19);
            this.lblScreeningName.TabIndex = 13;
            this.lblScreeningName.Text = "Screening Name";
            this.lblScreeningName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbScreeningName
            // 
            this.cmbScreeningName.DataSource = this.tblScreeningBindingSource;
            this.cmbScreeningName.DisplayMember = "screening_name";
            this.cmbScreeningName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScreeningName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScreeningName.FormattingEnabled = true;
            this.cmbScreeningName.Location = new System.Drawing.Point(11, 43);
            this.cmbScreeningName.Name = "cmbScreeningName";
            this.cmbScreeningName.Size = new System.Drawing.Size(325, 28);
            this.cmbScreeningName.TabIndex = 14;
            this.cmbScreeningName.SelectedIndexChanged += new System.EventHandler(this.cmbScreeningName_SelectedIndexChanged);
            // 
            // cmbStudio
            // 
            this.cmbStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStudio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudio.FormattingEnabled = true;
            this.cmbStudio.Location = new System.Drawing.Point(498, 43);
            this.cmbStudio.Name = "cmbStudio";
            this.cmbStudio.Size = new System.Drawing.Size(200, 28);
            this.cmbStudio.TabIndex = 17;
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio.ForeColor = System.Drawing.Color.Gray;
            this.lblStudio.Location = new System.Drawing.Point(494, 21);
            this.lblStudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(52, 19);
            this.lblStudio.TabIndex = 18;
            this.lblStudio.Text = "Studio";
            this.lblStudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(342, 43);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(150, 28);
            this.cmbGenre.TabIndex = 16;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gray;
            this.lblGenre.Location = new System.Drawing.Point(338, 21);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(49, 19);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCRUD
            // 
            this.grpCRUD.AutoSize = true;
            this.grpCRUD.Controls.Add(this.dtpEndDate);
            this.grpCRUD.Controls.Add(this.lblEndDate);
            this.grpCRUD.Controls.Add(this.dtpStartDate);
            this.grpCRUD.Controls.Add(this.lblStartDate);
            this.grpCRUD.Controls.Add(this.lblScreeningName);
            this.grpCRUD.Controls.Add(this.cmbStudio);
            this.grpCRUD.Controls.Add(this.btnDelete);
            this.grpCRUD.Controls.Add(this.lblStudio);
            this.grpCRUD.Controls.Add(this.btnUpdate);
            this.grpCRUD.Controls.Add(this.cmbGenre);
            this.grpCRUD.Controls.Add(this.cmbScreeningName);
            this.grpCRUD.Controls.Add(this.lblGenre);
            this.grpCRUD.Location = new System.Drawing.Point(185, 12);
            this.grpCRUD.Name = "grpCRUD";
            this.grpCRUD.Size = new System.Drawing.Size(705, 146);
            this.grpCRUD.TabIndex = 19;
            this.grpCRUD.TabStop = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(130, 96);
            this.dtpEndDate.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(113, 25);
            this.dtpEndDate.TabIndex = 22;
            this.dtpEndDate.Value = new System.DateTime(2022, 6, 22, 0, 0, 0, 0);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Gray;
            this.lblEndDate.Location = new System.Drawing.Point(126, 74);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 19);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(11, 96);
            this.dtpStartDate.MaxDate = new System.DateTime(2022, 6, 22, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(113, 25);
            this.dtpStartDate.TabIndex = 20;
            this.dtpStartDate.Value = new System.DateTime(2022, 6, 22, 0, 0, 0, 0);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Gray;
            this.lblStartDate.Location = new System.Drawing.Point(7, 74);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 19);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 809);
            this.Controls.Add(this.grpCRUD);
            this.Controls.Add(this.grpSortView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvScreening);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScreening";
            this.Text = "frmScreening";
            this.Load += new System.EventHandler(this.frmScreening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScreeningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
            this.grpSortView.ResumeLayout(false);
            this.grpSortView.PerformLayout();
            this.grpCRUD.ResumeLayout(false);
            this.grpCRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScreening;
        private System.Windows.Forms.ComboBox cmbAvailableGenre;
        private System.Windows.Forms.Label lblAvailableGenre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private CinemaDBDataSet cinemaDBDataSet;
        private System.Windows.Forms.BindingSource tblScreeningBindingSource;
        private CinemaDBDataSetTableAdapters.tblScreeningTableAdapter tblScreeningTableAdapter;
        private System.Windows.Forms.GroupBox grpSortView;
        private System.Windows.Forms.Label lblScreeningName;
        private System.Windows.Forms.ComboBox cmbScreeningName;
        private System.Windows.Forms.ComboBox cmbStudio;
        private System.Windows.Forms.Label lblStudio;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.GroupBox grpCRUD;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}