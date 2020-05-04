namespace Lyra.WinUI.UserControls.Administrator.Track
{
    partial class ucTrackList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.btnDeleteTrack = new System.Windows.Forms.Button();
            this.btnEditTrack = new System.Windows.Forms.Button();
            this.btnAddTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Location = new System.Drawing.Point(16, 82);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.ReadOnly = true;
            this.dgvTracks.Size = new System.Drawing.Size(763, 526);
            this.dgvTracks.TabIndex = 1;
            // 
            // btnDeleteTrack
            // 
            this.btnDeleteTrack.BackgroundImage = global::Lyra.WinUI.Properties.Resources.delete;
            this.btnDeleteTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTrack.FlatAppearance.BorderSize = 0;
            this.btnDeleteTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrack.Location = new System.Drawing.Point(104, 53);
            this.btnDeleteTrack.Name = "btnDeleteTrack";
            this.btnDeleteTrack.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteTrack.TabIndex = 10;
            this.btnDeleteTrack.UseVisualStyleBackColor = true;
            this.btnDeleteTrack.Click += new System.EventHandler(this.btnDeleteTrack_Click);
            // 
            // btnEditTrack
            // 
            this.btnEditTrack.BackgroundImage = global::Lyra.WinUI.Properties.Resources.edit;
            this.btnEditTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditTrack.FlatAppearance.BorderSize = 0;
            this.btnEditTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrack.Location = new System.Drawing.Point(60, 53);
            this.btnEditTrack.Name = "btnEditTrack";
            this.btnEditTrack.Size = new System.Drawing.Size(28, 23);
            this.btnEditTrack.TabIndex = 9;
            this.btnEditTrack.UseVisualStyleBackColor = true;
            this.btnEditTrack.Click += new System.EventHandler(this.btnEditTrack_Click);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.BackgroundImage = global::Lyra.WinUI.Properties.Resources.add;
            this.btnAddTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTrack.FlatAppearance.BorderSize = 0;
            this.btnAddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTrack.Location = new System.Drawing.Point(16, 53);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(28, 23);
            this.btnAddTrack.TabIndex = 8;
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // ucTrackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteTrack);
            this.Controls.Add(this.btnEditTrack);
            this.Controls.Add(this.btnAddTrack);
            this.Controls.Add(this.dgvTracks);
            this.Name = "ucTrackList";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucTrackList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.Button btnDeleteTrack;
        private System.Windows.Forms.Button btnEditTrack;
        private System.Windows.Forms.Button btnAddTrack;
    }
}
