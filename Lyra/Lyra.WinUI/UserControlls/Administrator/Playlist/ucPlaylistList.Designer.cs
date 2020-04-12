namespace Lyra.WinUI.UserControlls.Administrator.Playlist
{
    partial class ucPlaylistList
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
            this.dgvPlaylists = new System.Windows.Forms.DataGridView();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.btnEditPlaylist = new System.Windows.Forms.Button();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlaylists
            // 
            this.dgvPlaylists.AllowUserToAddRows = false;
            this.dgvPlaylists.AllowUserToDeleteRows = false;
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Location = new System.Drawing.Point(16, 82);
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.ReadOnly = true;
            this.dgvPlaylists.Size = new System.Drawing.Size(763, 526);
            this.dgvPlaylists.TabIndex = 1;
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Location = new System.Drawing.Point(84, 53);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(28, 23);
            this.btnDeletePlaylist.TabIndex = 7;
            this.btnDeletePlaylist.Text = "D";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.Location = new System.Drawing.Point(50, 53);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.Size = new System.Drawing.Size(28, 23);
            this.btnEditPlaylist.TabIndex = 6;
            this.btnEditPlaylist.Text = "E";
            this.btnEditPlaylist.UseVisualStyleBackColor = true;
            this.btnEditPlaylist.Click += new System.EventHandler(this.btnEditPlaylist_Click);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(16, 53);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(28, 23);
            this.btnAddPlaylist.TabIndex = 5;
            this.btnAddPlaylist.Text = "A";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // ucPlaylistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeletePlaylist);
            this.Controls.Add(this.btnEditPlaylist);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.dgvPlaylists);
            this.Name = "ucPlaylistList";
            this.Size = new System.Drawing.Size(796, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Button btnEditPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
    }
}
