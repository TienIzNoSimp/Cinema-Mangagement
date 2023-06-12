namespace cinema_mgmt.Form_Centers
{
    partial class frmCenter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDBDataSet = new cinema_mgmt.CinemaDBDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblCenterTableAdapter = new cinema_mgmt.CinemaDBDataSetTableAdapters.tblCenterTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.centerauditoriumcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centercontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCenter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCenterBindingSource
            // 
            this.tblCenterBindingSource.DataMember = "tblCenter";
            this.tblCenterBindingSource.DataSource = this.cinemaDBDataSet;
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
            this.btnAdd.Location = new System.Drawing.Point(940, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblCenterTableAdapter
            // 
            this.tblCenterTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(463, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 17.7665F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 20.67374F;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            // 
            // centerauditoriumcountDataGridViewTextBoxColumn
            // 
            this.centerauditoriumcountDataGridViewTextBoxColumn.DataPropertyName = "center_auditorium_count";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.centerauditoriumcountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.centerauditoriumcountDataGridViewTextBoxColumn.FillWeight = 86.64448F;
            this.centerauditoriumcountDataGridViewTextBoxColumn.HeaderText = "Auditoriums";
            this.centerauditoriumcountDataGridViewTextBoxColumn.Name = "centerauditoriumcountDataGridViewTextBoxColumn";
            this.centerauditoriumcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centercontactDataGridViewTextBoxColumn
            // 
            this.centercontactDataGridViewTextBoxColumn.DataPropertyName = "center_contact";
            this.centercontactDataGridViewTextBoxColumn.FillWeight = 86.64448F;
            this.centercontactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.centercontactDataGridViewTextBoxColumn.Name = "centercontactDataGridViewTextBoxColumn";
            this.centercontactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centeraddressDataGridViewTextBoxColumn
            // 
            this.centeraddressDataGridViewTextBoxColumn.DataPropertyName = "center_address";
            this.centeraddressDataGridViewTextBoxColumn.FillWeight = 282.825F;
            this.centeraddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.centeraddressDataGridViewTextBoxColumn.Name = "centeraddressDataGridViewTextBoxColumn";
            this.centeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centernameDataGridViewTextBoxColumn
            // 
            this.centernameDataGridViewTextBoxColumn.DataPropertyName = "center_name";
            this.centernameDataGridViewTextBoxColumn.FillWeight = 138.2823F;
            this.centernameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.centernameDataGridViewTextBoxColumn.Name = "centernameDataGridViewTextBoxColumn";
            this.centernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centeridDataGridViewTextBoxColumn
            // 
            this.centeridDataGridViewTextBoxColumn.DataPropertyName = "center_id";
            this.centeridDataGridViewTextBoxColumn.FillWeight = 67.16344F;
            this.centeridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.centeridDataGridViewTextBoxColumn.Name = "centeridDataGridViewTextBoxColumn";
            this.centeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvCenter
            // 
            this.dgvCenter.AllowUserToAddRows = false;
            this.dgvCenter.AllowUserToDeleteRows = false;
            this.dgvCenter.AutoGenerateColumns = false;
            this.dgvCenter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCenter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCenter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.centeridDataGridViewTextBoxColumn,
            this.centernameDataGridViewTextBoxColumn,
            this.centeraddressDataGridViewTextBoxColumn,
            this.centercontactDataGridViewTextBoxColumn,
            this.centerauditoriumcountDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dgvCenter.DataSource = this.tblCenterBindingSource;
            this.dgvCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCenter.Location = new System.Drawing.Point(0, 47);
            this.dgvCenter.Name = "dgvCenter";
            this.dgvCenter.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCenter.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCenter.Size = new System.Drawing.Size(1030, 762);
            this.dgvCenter.TabIndex = 0;
            this.dgvCenter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCenter_CellClick);
            this.dgvCenter.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCenter_CellPainting);
            // 
            // frmCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 809);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCenter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCenter";
            this.Load += new System.EventHandler(this.frmCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private CinemaDBDataSet cinemaDBDataSet;
        private System.Windows.Forms.BindingSource tblCenterBindingSource;
        private CinemaDBDataSetTableAdapters.tblCenterTableAdapter tblCenterTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerauditoriumcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centercontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCenter;
    }
}