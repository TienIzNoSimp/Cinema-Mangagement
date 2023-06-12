namespace cinema_mgmt.Form_Auditoriums
{
    partial class frmAuditoriums
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAuditorium = new System.Windows.Forms.DataGridView();
            this.auditoriumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.center_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.center_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblAuditoriumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDBDataSet = new cinema_mgmt.CinemaDBDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCenterName = new System.Windows.Forms.ComboBox();
            this.tblCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalSeatCount = new System.Windows.Forms.Label();
            this.txtTotalSeatCount = new System.Windows.Forms.TextBox();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.tblAuditoriumTableAdapter = new cinema_mgmt.CinemaDBDataSetTableAdapters.tblAuditoriumTableAdapter();
            this.tblCenterTableAdapter = new cinema_mgmt.CinemaDBDataSetTableAdapters.tblCenterTableAdapter();
            this.nudSeatCount = new System.Windows.Forms.NumericUpDown();
            this.lblTheaterCount = new System.Windows.Forms.Label();
            this.cmbAuditoriumId = new System.Windows.Forms.ComboBox();
            this.lblAuditoriumId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAuditoriumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditorium
            // 
            this.dgvAuditorium.AllowUserToAddRows = false;
            this.dgvAuditorium.AllowUserToDeleteRows = false;
            this.dgvAuditorium.AutoGenerateColumns = false;
            this.dgvAuditorium.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditorium.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAuditorium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditorium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditorium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auditoriumidDataGridViewTextBoxColumn,
            this.centeridDataGridViewTextBoxColumn,
            this.center_name,
            this.center_address,
            this.seatcountDataGridViewTextBoxColumn,
            this.Delete});
            this.dgvAuditorium.DataSource = this.tblAuditoriumBindingSource;
            this.dgvAuditorium.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAuditorium.Location = new System.Drawing.Point(0, 66);
            this.dgvAuditorium.Name = "dgvAuditorium";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAuditorium.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditorium.Size = new System.Drawing.Size(1030, 743);
            this.dgvAuditorium.TabIndex = 0;
            this.dgvAuditorium.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditorium_CellClick);
            this.dgvAuditorium.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAuditorium_CellPainting);
            this.dgvAuditorium.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditorium_CellValueChanged);
            // 
            // auditoriumidDataGridViewTextBoxColumn
            // 
            this.auditoriumidDataGridViewTextBoxColumn.DataPropertyName = "auditorium_id";
            this.auditoriumidDataGridViewTextBoxColumn.FillWeight = 86.57787F;
            this.auditoriumidDataGridViewTextBoxColumn.HeaderText = "Auditorium ID";
            this.auditoriumidDataGridViewTextBoxColumn.Name = "auditoriumidDataGridViewTextBoxColumn";
            // 
            // centeridDataGridViewTextBoxColumn
            // 
            this.centeridDataGridViewTextBoxColumn.DataPropertyName = "center_id";
            this.centeridDataGridViewTextBoxColumn.FillWeight = 67.95146F;
            this.centeridDataGridViewTextBoxColumn.HeaderText = "Center ID";
            this.centeridDataGridViewTextBoxColumn.Name = "centeridDataGridViewTextBoxColumn";
            // 
            // center_name
            // 
            this.center_name.DataPropertyName = "center_name";
            this.center_name.FillWeight = 117.1189F;
            this.center_name.HeaderText = "Center Name";
            this.center_name.Name = "center_name";
            // 
            // center_address
            // 
            this.center_address.DataPropertyName = "center_address";
            this.center_address.FillWeight = 312.1161F;
            this.center_address.HeaderText = "Center Address";
            this.center_address.Name = "center_address";
            // 
            // seatcountDataGridViewTextBoxColumn
            // 
            this.seatcountDataGridViewTextBoxColumn.DataPropertyName = "seat_count";
            this.seatcountDataGridViewTextBoxColumn.FillWeight = 81.3021F;
            this.seatcountDataGridViewTextBoxColumn.HeaderText = "No. Seat";
            this.seatcountDataGridViewTextBoxColumn.Name = "seatcountDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 17.7665F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            // 
            // tblAuditoriumBindingSource
            // 
            this.tblAuditoriumBindingSource.DataMember = "tblAuditorium";
            this.tblAuditoriumBindingSource.DataSource = this.cinemaDBDataSet;
            // 
            // cinemaDBDataSet
            // 
            this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
            this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(940, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCenterName
            // 
            this.cmbCenterName.DataSource = this.tblCenterBindingSource;
            this.cmbCenterName.DisplayMember = "center_name";
            this.cmbCenterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCenterName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCenterName.FormattingEnabled = true;
            this.cmbCenterName.Location = new System.Drawing.Point(17, 31);
            this.cmbCenterName.Name = "cmbCenterName";
            this.cmbCenterName.Size = new System.Drawing.Size(181, 28);
            this.cmbCenterName.TabIndex = 2;
            this.cmbCenterName.SelectedIndexChanged += new System.EventHandler(this.cmbCenterName_SelectedIndexChanged);
            // 
            // tblCenterBindingSource
            // 
            this.tblCenterBindingSource.DataMember = "tblCenter";
            this.tblCenterBindingSource.DataSource = this.cinemaDBDataSet;
            // 
            // lblTotalSeatCount
            // 
            this.lblTotalSeatCount.AutoSize = true;
            this.lblTotalSeatCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeatCount.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSeatCount.Location = new System.Drawing.Point(200, 9);
            this.lblTotalSeatCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSeatCount.Name = "lblTotalSeatCount";
            this.lblTotalSeatCount.Size = new System.Drawing.Size(103, 19);
            this.lblTotalSeatCount.TabIndex = 3;
            this.lblTotalSeatCount.Text = "Total No. Seat";
            this.lblTotalSeatCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalSeatCount
            // 
            this.txtTotalSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSeatCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSeatCount.Location = new System.Drawing.Point(204, 31);
            this.txtTotalSeatCount.Name = "txtTotalSeatCount";
            this.txtTotalSeatCount.ReadOnly = true;
            this.txtTotalSeatCount.Size = new System.Drawing.Size(100, 27);
            this.txtTotalSeatCount.TabIndex = 4;
            this.txtTotalSeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterName.ForeColor = System.Drawing.Color.Gray;
            this.lblCenterName.Location = new System.Drawing.Point(13, 9);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(97, 19);
            this.lblCenterName.TabIndex = 1;
            this.lblCenterName.Text = "Center Name";
            this.lblCenterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblAuditoriumTableAdapter
            // 
            this.tblAuditoriumTableAdapter.ClearBeforeFill = true;
            // 
            // tblCenterTableAdapter
            // 
            this.tblCenterTableAdapter.ClearBeforeFill = true;
            // 
            // nudSeatCount
            // 
            this.nudSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSeatCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeatCount.Location = new System.Drawing.Point(420, 30);
            this.nudSeatCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSeatCount.Name = "nudSeatCount";
            this.nudSeatCount.Size = new System.Drawing.Size(77, 27);
            this.nudSeatCount.TabIndex = 8;
            this.nudSeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTheaterCount
            // 
            this.lblTheaterCount.AutoSize = true;
            this.lblTheaterCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheaterCount.ForeColor = System.Drawing.Color.Gray;
            this.lblTheaterCount.Location = new System.Drawing.Point(416, 9);
            this.lblTheaterCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheaterCount.Name = "lblTheaterCount";
            this.lblTheaterCount.Size = new System.Drawing.Size(66, 19);
            this.lblTheaterCount.TabIndex = 7;
            this.lblTheaterCount.Text = "No. Seat";
            this.lblTheaterCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAuditoriumId
            // 
            this.cmbAuditoriumId.DataSource = this.tblAuditoriumBindingSource;
            this.cmbAuditoriumId.DisplayMember = "auditorium_id";
            this.cmbAuditoriumId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuditoriumId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAuditoriumId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuditoriumId.FormattingEnabled = true;
            this.cmbAuditoriumId.Location = new System.Drawing.Point(310, 30);
            this.cmbAuditoriumId.Name = "cmbAuditoriumId";
            this.cmbAuditoriumId.Size = new System.Drawing.Size(104, 28);
            this.cmbAuditoriumId.TabIndex = 6;
            this.cmbAuditoriumId.SelectedIndexChanged += new System.EventHandler(this.cmbAuditoriumId_SelectedIndexChanged);
            // 
            // lblAuditoriumId
            // 
            this.lblAuditoriumId.AutoSize = true;
            this.lblAuditoriumId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriumId.ForeColor = System.Drawing.Color.Gray;
            this.lblAuditoriumId.Location = new System.Drawing.Point(306, 9);
            this.lblAuditoriumId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuditoriumId.Name = "lblAuditoriumId";
            this.lblAuditoriumId.Size = new System.Drawing.Size(103, 19);
            this.lblAuditoriumId.TabIndex = 5;
            this.lblAuditoriumId.Text = "Auditorium ID";
            this.lblAuditoriumId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAuditoriums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 809);
            this.Controls.Add(this.lblCenterName);
            this.Controls.Add(this.cmbCenterName);
            this.Controls.Add(this.lblAuditoriumId);
            this.Controls.Add(this.lblTotalSeatCount);
            this.Controls.Add(this.cmbAuditoriumId);
            this.Controls.Add(this.txtTotalSeatCount);
            this.Controls.Add(this.lblTheaterCount);
            this.Controls.Add(this.nudSeatCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAuditorium);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAuditoriums";
            this.Text = "frmAuditoriums";
            this.Load += new System.EventHandler(this.frmAuditoriums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAuditoriumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAuditorium;
        private CinemaDBDataSet cinemaDBDataSet;
        private System.Windows.Forms.BindingSource tblAuditoriumBindingSource;
        private CinemaDBDataSetTableAdapters.tblAuditoriumTableAdapter tblAuditoriumTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCenterName;
        private System.Windows.Forms.Label lblTotalSeatCount;
        private System.Windows.Forms.TextBox txtTotalSeatCount;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditoriumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn center_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn center_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private CinemaDBDataSetTableAdapters.tblCenterTableAdapter tblCenterTableAdapter;
        private System.Windows.Forms.BindingSource tblCenterBindingSource;
        private System.Windows.Forms.NumericUpDown nudSeatCount;
        private System.Windows.Forms.Label lblTheaterCount;
        private System.Windows.Forms.ComboBox cmbAuditoriumId;
        private System.Windows.Forms.Label lblAuditoriumId;
    }
}