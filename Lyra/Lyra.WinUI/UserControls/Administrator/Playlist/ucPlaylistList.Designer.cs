﻿namespace Lyra.WinUI.UserControls.Administrator.Playlist
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageNumber = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
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
            this.btnDeletePlaylist.BackgroundImage = global::Lyra.WinUI.Properties.Resources.delete;
            this.btnDeletePlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePlaylist.FlatAppearance.BorderSize = 0;
            this.btnDeletePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlaylist.Location = new System.Drawing.Point(104, 53);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(28, 23);
            this.btnDeletePlaylist.TabIndex = 10;
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.BackgroundImage = global::Lyra.WinUI.Properties.Resources.edit;
            this.btnEditPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPlaylist.FlatAppearance.BorderSize = 0;
            this.btnEditPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPlaylist.Location = new System.Drawing.Point(60, 53);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.Size = new System.Drawing.Size(28, 23);
            this.btnEditPlaylist.TabIndex = 9;
            this.btnEditPlaylist.UseVisualStyleBackColor = true;
            this.btnEditPlaylist.Click += new System.EventHandler(this.btnEditPlaylist_Click);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.BackgroundImage = global::Lyra.WinUI.Properties.Resources.add;
            this.btnAddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPlaylist.FlatAppearance.BorderSize = 0;
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPlaylist.Location = new System.Drawing.Point(16, 53);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(28, 23);
            this.btnAddPlaylist.TabIndex = 8;
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(746, 614);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(33, 30);
            this.btnLast.TabIndex = 25;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(707, 614);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 30);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageNumber
            // 
            this.btnPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumber.Location = new System.Drawing.Point(668, 614);
            this.btnPageNumber.Name = "btnPageNumber";
            this.btnPageNumber.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumber.TabIndex = 23;
            this.btnPageNumber.Text = "0";
            this.btnPageNumber.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(629, 614);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 30);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(590, 614);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(33, 30);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // ucPlaylistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDeletePlaylist);
            this.Controls.Add(this.btnEditPlaylist);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.dgvPlaylists);
            this.Name = "ucPlaylistList";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucPlaylistList_Load);
            this.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Button btnEditPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
    }
}
