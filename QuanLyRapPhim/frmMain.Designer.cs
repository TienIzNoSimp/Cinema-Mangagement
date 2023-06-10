namespace QuanLyRapPhim
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnScreenings = new System.Windows.Forms.Button();
            this.btnAuditoriums = new System.Windows.Forms.Button();
            this.btnCenters = new System.Windows.Forms.Button();
            this.pnlUI = new System.Windows.Forms.Panel();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(55)))));
            this.pnlNavBar.Controls.Add(this.picLogo);
            this.pnlNavBar.Controls.Add(this.btnScreenings);
            this.pnlNavBar.Controls.Add(this.btnAuditoriums);
            this.pnlNavBar.Controls.Add(this.btnCenters);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(154, 809);
            this.pnlNavBar.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(154, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnScreenings
            // 
            this.btnScreenings.FlatAppearance.BorderSize = 0;
            this.btnScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenings.ForeColor = System.Drawing.Color.White;
            this.btnScreenings.Location = new System.Drawing.Point(0, 216);
            this.btnScreenings.Name = "btnScreenings";
            this.btnScreenings.Size = new System.Drawing.Size(154, 46);
            this.btnScreenings.TabIndex = 2;
            this.btnScreenings.Text = "Screenings";
            this.btnScreenings.UseVisualStyleBackColor = true;
            this.btnScreenings.Click += new System.EventHandler(this.btnScreenings_Click);
            // 
            // btnAuditoriums
            // 
            this.btnAuditoriums.FlatAppearance.BorderSize = 0;
            this.btnAuditoriums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoriums.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditoriums.ForeColor = System.Drawing.Color.White;
            this.btnAuditoriums.Location = new System.Drawing.Point(0, 164);
            this.btnAuditoriums.Name = "btnAuditoriums";
            this.btnAuditoriums.Size = new System.Drawing.Size(154, 46);
            this.btnAuditoriums.TabIndex = 1;
            this.btnAuditoriums.Text = "Auditoriums";
            this.btnAuditoriums.UseVisualStyleBackColor = true;
            this.btnAuditoriums.Click += new System.EventHandler(this.btnAuditoriums_Click);
            // 
            // btnCenters
            // 
            this.btnCenters.FlatAppearance.BorderSize = 0;
            this.btnCenters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCenters.ForeColor = System.Drawing.Color.White;
            this.btnCenters.Location = new System.Drawing.Point(0, 119);
            this.btnCenters.Name = "btnCenters";
            this.btnCenters.Size = new System.Drawing.Size(154, 46);
            this.btnCenters.TabIndex = 0;
            this.btnCenters.Text = "Centers";
            this.btnCenters.UseVisualStyleBackColor = true;
            this.btnCenters.Click += new System.EventHandler(this.btnCenters_Click);
            // 
            // pnlUI
            // 
            this.pnlUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUI.Location = new System.Drawing.Point(154, 0);
            this.pnlUI.Name = "pnlUI";
            this.pnlUI.Size = new System.Drawing.Size(1030, 809);
            this.pnlUI.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 809);
            this.Controls.Add(this.pnlUI);
            this.Controls.Add(this.pnlNavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CinePOS";
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel pnlUI;
        private System.Windows.Forms.Button btnScreenings;
        private System.Windows.Forms.Button btnAuditoriums;
        private System.Windows.Forms.Button btnCenters;
        private System.Windows.Forms.PictureBox picLogo;
    }
}