namespace QuanLyRapPhim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAuditorium = new System.Windows.Forms.DataGridView();
            this.tblAuditoriumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCenterName = new System.Windows.Forms.Label();
            this.cmbCenterName = new System.Windows.Forms.ComboBox();
            this.cmbCenterId = new System.Windows.Forms.ComboBox();
            this.lblCenterId = new System.Windows.Forms.Label();
            this.lblTotalSeatCount = new System.Windows.Forms.Label();
            this.txtSeatCount = new System.Windows.Forms.TextBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.cmbAuditoriumId = new System.Windows.Forms.ComboBox();
            this.lblAuditoriumId = new System.Windows.Forms.Label();
            this.nudSeatCount = new System.Windows.Forms.NumericUpDown();
            this.lblTheaterCount = new System.Windows.Forms.Label();
            this.grpCRUD = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAuditoriumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).BeginInit();
            this.grpSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).BeginInit();
            this.grpCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuditorium
            // 
            this.dgvAuditorium.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditorium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditorium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditorium.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAuditorium.Location = new System.Drawing.Point(0, 268);
            this.dgvAuditorium.Name = "dgvAuditorium";
            this.dgvAuditorium.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAuditorium.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditorium.Size = new System.Drawing.Size(1030, 541);
            this.dgvAuditorium.TabIndex = 7;
            // 
            // tblAuditoriumBindingSource
            // 
            this.tblAuditoriumBindingSource.DataMember = "tblAuditorium";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(38, 77);
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
            this.btnDelete.Location = new System.Drawing.Point(122, 77);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tblCenterBindingSource
            // 
            this.tblCenterBindingSource.DataMember = "tblCenter";
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterName.ForeColor = System.Drawing.Color.Gray;
            this.lblCenterName.Location = new System.Drawing.Point(128, 26);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(136, 28);
            this.lblCenterName.TabIndex = 12;
            this.lblCenterName.Text = "Center Name";
            this.lblCenterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCenterName
            // 
            this.cmbCenterName.DataSource = this.tblCenterBindingSource;
            this.cmbCenterName.DisplayMember = "center_name";
            this.cmbCenterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCenterName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCenterName.FormattingEnabled = true;
            this.cmbCenterName.Location = new System.Drawing.Point(132, 48);
            this.cmbCenterName.Name = "cmbCenterName";
            this.cmbCenterName.Size = new System.Drawing.Size(181, 38);
            this.cmbCenterName.TabIndex = 11;
            this.cmbCenterName.SelectedIndexChanged += new System.EventHandler(this.cmbCenterName_SelectedIndexChanged);
            this.cmbCenterName.TextChanged += new System.EventHandler(this.cmbCenterName_TextChanged);
            // 
            // cmbCenterId
            // 
            this.cmbCenterId.DataSource = this.tblCenterBindingSource;
            this.cmbCenterId.DisplayMember = "center_id";
            this.cmbCenterId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenterId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCenterId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCenterId.FormattingEnabled = true;
            this.cmbCenterId.Location = new System.Drawing.Point(22, 49);
            this.cmbCenterId.Name = "cmbCenterId";
            this.cmbCenterId.Size = new System.Drawing.Size(104, 38);
            this.cmbCenterId.TabIndex = 1;
            this.cmbCenterId.SelectedIndexChanged += new System.EventHandler(this.cmbCenterId_SelectedIndexChanged);
            this.cmbCenterId.TextChanged += new System.EventHandler(this.cmbCenterId_TextChanged);
            // 
            // lblCenterId
            // 
            this.lblCenterId.AutoSize = true;
            this.lblCenterId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterId.ForeColor = System.Drawing.Color.Gray;
            this.lblCenterId.Location = new System.Drawing.Point(18, 27);
            this.lblCenterId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterId.Name = "lblCenterId";
            this.lblCenterId.Size = new System.Drawing.Size(101, 28);
            this.lblCenterId.TabIndex = 5;
            this.lblCenterId.Text = "Center ID";
            this.lblCenterId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSeatCount
            // 
            this.lblTotalSeatCount.AutoSize = true;
            this.lblTotalSeatCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeatCount.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSeatCount.Location = new System.Drawing.Point(320, 27);
            this.lblTotalSeatCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSeatCount.Name = "lblTotalSeatCount";
            this.lblTotalSeatCount.Size = new System.Drawing.Size(168, 28);
            this.lblTotalSeatCount.TabIndex = 13;
            this.lblTotalSeatCount.Text = "Total Seat Count";
            this.lblTotalSeatCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSeatCount
            // 
            this.txtSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeatCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatCount.Location = new System.Drawing.Point(324, 49);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.ReadOnly = true;
            this.txtSeatCount.Size = new System.Drawing.Size(100, 37);
            this.txtSeatCount.TabIndex = 14;
            this.txtSeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpSort
            // 
            this.grpSort.AutoSize = true;
            this.grpSort.Controls.Add(this.lblCenterName);
            this.grpSort.Controls.Add(this.txtSeatCount);
            this.grpSort.Controls.Add(this.cmbCenterId);
            this.grpSort.Controls.Add(this.lblTotalSeatCount);
            this.grpSort.Controls.Add(this.lblCenterId);
            this.grpSort.Controls.Add(this.cmbCenterName);
            this.grpSort.Location = new System.Drawing.Point(12, 12);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(495, 130);
            this.grpSort.TabIndex = 15;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort View";
            // 
            // cmbAuditoriumId
            // 
            this.cmbAuditoriumId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuditoriumId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAuditoriumId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuditoriumId.FormattingEnabled = true;
            this.cmbAuditoriumId.Location = new System.Drawing.Point(11, 43);
            this.cmbAuditoriumId.Name = "cmbAuditoriumId";
            this.cmbAuditoriumId.Size = new System.Drawing.Size(104, 38);
            this.cmbAuditoriumId.TabIndex = 16;
            this.cmbAuditoriumId.SelectedIndexChanged += new System.EventHandler(this.cmbAuditoriumId_SelectedIndexChanged);
            // 
            // lblAuditoriumId
            // 
            this.lblAuditoriumId.AutoSize = true;
            this.lblAuditoriumId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriumId.ForeColor = System.Drawing.Color.Gray;
            this.lblAuditoriumId.Location = new System.Drawing.Point(7, 21);
            this.lblAuditoriumId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuditoriumId.Name = "lblAuditoriumId";
            this.lblAuditoriumId.Size = new System.Drawing.Size(147, 28);
            this.lblAuditoriumId.TabIndex = 17;
            this.lblAuditoriumId.Text = "Auditorium ID";
            this.lblAuditoriumId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSeatCount
            // 
            this.nudSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSeatCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeatCount.Location = new System.Drawing.Point(122, 43);
            this.nudSeatCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSeatCount.Name = "nudSeatCount";
            this.nudSeatCount.Size = new System.Drawing.Size(77, 37);
            this.nudSeatCount.TabIndex = 23;
            this.nudSeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTheaterCount
            // 
            this.lblTheaterCount.AutoSize = true;
            this.lblTheaterCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheaterCount.ForeColor = System.Drawing.Color.Gray;
            this.lblTheaterCount.Location = new System.Drawing.Point(118, 21);
            this.lblTheaterCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheaterCount.Name = "lblTheaterCount";
            this.lblTheaterCount.Size = new System.Drawing.Size(92, 28);
            this.lblTheaterCount.TabIndex = 22;
            this.lblTheaterCount.Text = "No. Seat";
            this.lblTheaterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCRUD
            // 
            this.grpCRUD.AutoSize = true;
            this.grpCRUD.Controls.Add(this.lblAuditoriumId);
            this.grpCRUD.Controls.Add(this.nudSeatCount);
            this.grpCRUD.Controls.Add(this.lblTheaterCount);
            this.grpCRUD.Controls.Add(this.btnDelete);
            this.grpCRUD.Controls.Add(this.cmbAuditoriumId);
            this.grpCRUD.Controls.Add(this.btnUpdate);
            this.grpCRUD.Location = new System.Drawing.Point(463, 13);
            this.grpCRUD.Name = "grpCRUD";
            this.grpCRUD.Size = new System.Drawing.Size(297, 138);
            this.grpCRUD.TabIndex = 24;
            this.grpCRUD.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(670, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAuditoriums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 809);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCRUD);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.dgvAuditorium);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAuditoriums";
            this.Text = "frmAuditoriums";
            this.Load += new System.EventHandler(this.frmAuditoriums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAuditoriumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).EndInit();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).EndInit();
            this.grpCRUD.ResumeLayout(false);
            this.grpCRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAuditorium;
        private System.Windows.Forms.BindingSource tblAuditoriumBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource tblCenterBindingSource;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.ComboBox cmbCenterName;
        private System.Windows.Forms.ComboBox cmbCenterId;
        private System.Windows.Forms.Label lblCenterId;
        private System.Windows.Forms.Label lblTotalSeatCount;
        private System.Windows.Forms.TextBox txtSeatCount;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.ComboBox cmbAuditoriumId;
        private System.Windows.Forms.Label lblAuditoriumId;
        private System.Windows.Forms.NumericUpDown nudSeatCount;
        private System.Windows.Forms.Label lblTheaterCount;
        private System.Windows.Forms.GroupBox grpCRUD;
        private System.Windows.Forms.Button btnAdd;
    }
}