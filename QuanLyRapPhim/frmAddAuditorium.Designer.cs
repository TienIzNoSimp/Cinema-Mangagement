namespace QuanLyRapPhim
{
    partial class frmAddAuditorium
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
            this.nudSeatCount = new System.Windows.Forms.NumericUpDown();
            this.lblSeatCount = new System.Windows.Forms.Label();
            this.lblIdAlreadyExists = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.cmbCenterId = new System.Windows.Forms.ComboBox();
            this.tblCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCenterId = new System.Windows.Forms.Label();
            this.cmbCenterName = new System.Windows.Forms.ComboBox();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSeatCount
            // 
            this.nudSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSeatCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeatCount.Location = new System.Drawing.Point(191, 31);
            this.nudSeatCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSeatCount.Name = "nudSeatCount";
            this.nudSeatCount.Size = new System.Drawing.Size(77, 37);
            this.nudSeatCount.TabIndex = 4;
            this.nudSeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSeatCount
            // 
            this.lblSeatCount.AutoSize = true;
            this.lblSeatCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatCount.ForeColor = System.Drawing.Color.Gray;
            this.lblSeatCount.Location = new System.Drawing.Point(187, 8);
            this.lblSeatCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatCount.Name = "lblSeatCount";
            this.lblSeatCount.Size = new System.Drawing.Size(92, 28);
            this.lblSeatCount.TabIndex = 3;
            this.lblSeatCount.Text = "No. Seat";
            this.lblSeatCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdAlreadyExists
            // 
            this.lblIdAlreadyExists.AutoSize = true;
            this.lblIdAlreadyExists.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAlreadyExists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(131)))), ((int)(((byte)(189)))));
            this.lblIdAlreadyExists.Location = new System.Drawing.Point(44, 14);
            this.lblIdAlreadyExists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAlreadyExists.Name = "lblIdAlreadyExists";
            this.lblIdAlreadyExists.Size = new System.Drawing.Size(193, 21);
            this.lblIdAlreadyExists.TabIndex = 2;
            this.lblIdAlreadyExists.Text = "Auditorium Already Exists!";
            this.lblIdAlreadyExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIdAlreadyExists.Visible = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(17, 31);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(167, 37);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(13, 8);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 28);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(146, 118);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterName.ForeColor = System.Drawing.Color.Gray;
            this.lblCenterName.Location = new System.Drawing.Point(123, 61);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(136, 28);
            this.lblCenterName.TabIndex = 7;
            this.lblCenterName.Text = "Center Name";
            this.lblCenterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCenterId
            // 
            this.cmbCenterId.DataSource = this.tblCenterBindingSource;
            this.cmbCenterId.DisplayMember = "center_id";
            this.cmbCenterId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenterId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCenterId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCenterId.FormattingEnabled = true;
            this.cmbCenterId.Location = new System.Drawing.Point(17, 84);
            this.cmbCenterId.Name = "cmbCenterId";
            this.cmbCenterId.Size = new System.Drawing.Size(104, 38);
            this.cmbCenterId.TabIndex = 6;
            this.cmbCenterId.SelectedIndexChanged += new System.EventHandler(this.cmbCenterId_SelectedIndexChanged);
            // 
            // tblCenterBindingSource
            // 
            this.tblCenterBindingSource.DataMember = "tblCenter";
            // 
            // lblCenterId
            // 
            this.lblCenterId.AutoSize = true;
            this.lblCenterId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterId.ForeColor = System.Drawing.Color.Gray;
            this.lblCenterId.Location = new System.Drawing.Point(13, 62);
            this.lblCenterId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterId.Name = "lblCenterId";
            this.lblCenterId.Size = new System.Drawing.Size(101, 28);
            this.lblCenterId.TabIndex = 5;
            this.lblCenterId.Text = "Center ID";
            this.lblCenterId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCenterName
            // 
            this.cmbCenterName.DataSource = this.tblCenterBindingSource;
            this.cmbCenterName.DisplayMember = "center_name";
            this.cmbCenterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCenterName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCenterName.FormattingEnabled = true;
            this.cmbCenterName.Location = new System.Drawing.Point(127, 83);
            this.cmbCenterName.Name = "cmbCenterName";
            this.cmbCenterName.Size = new System.Drawing.Size(181, 38);
            this.cmbCenterName.TabIndex = 8;
            this.cmbCenterName.SelectedIndexChanged += new System.EventHandler(this.cmbCenterName_SelectedIndexChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.btnQuit.Location = new System.Drawing.Point(231, 118);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 27);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmAddAuditorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 160);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblCenterName);
            this.Controls.Add(this.cmbCenterId);
            this.Controls.Add(this.lblCenterId);
            this.Controls.Add(this.cmbCenterName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudSeatCount);
            this.Controls.Add(this.lblSeatCount);
            this.Controls.Add(this.lblIdAlreadyExists);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddAuditorium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddAuditorium";
            this.Load += new System.EventHandler(this.frmAddAuditorium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSeatCount;
        private System.Windows.Forms.Label lblSeatCount;
        private System.Windows.Forms.Label lblIdAlreadyExists;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.ComboBox cmbCenterId;
        private System.Windows.Forms.Label lblCenterId;
        private System.Windows.Forms.ComboBox cmbCenterName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.BindingSource tblCenterBindingSource;
    }
}