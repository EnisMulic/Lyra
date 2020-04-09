namespace Lyra.WinUI.UserControlls.Administrator.Track
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
            this.dgvTracks.Size = new System.Drawing.Size(584, 414);
            this.dgvTracks.TabIndex = 1;
            // 
            // btnDeleteTrack
            // 
            this.btnDeleteTrack.Location = new System.Drawing.Point(84, 53);
            this.btnDeleteTrack.Name = "btnDeleteTrack";
            this.btnDeleteTrack.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteTrack.TabIndex = 10;
            this.btnDeleteTrack.Text = "D";
            this.btnDeleteTrack.UseVisualStyleBackColor = true;
            this.btnDeleteTrack.Click += new System.EventHandler(this.btnDeleteTrack_Click);
            // 
            // btnEditTrack
            // 
            this.btnEditTrack.Location = new System.Drawing.Point(50, 53);
            this.btnEditTrack.Name = "btnEditTrack";
            this.btnEditTrack.Size = new System.Drawing.Size(28, 23);
            this.btnEditTrack.TabIndex = 9;
            this.btnEditTrack.Text = "E";
            this.btnEditTrack.UseVisualStyleBackColor = true;
            this.btnEditTrack.Click += new System.EventHandler(this.btnEditTrack_Click);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(16, 53);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(28, 23);
            this.btnAddTrack.TabIndex = 8;
            this.btnAddTrack.Text = "A";
            this.btnAddTrack.UseVisualStyleBackColor = true;
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
            this.Size = new System.Drawing.Size(617, 578);
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
