namespace Lyra.WinUI.Administrator
{
    partial class frmAdminPanel
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
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnUserCRUD = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ucAppControl = new Lyra.WinUI.UserControlls.Shared.ucAppControl();
            this.pnlNavbar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(182)))));
            this.pnlNavbar.Controls.Add(this.btnPlaylist);
            this.pnlNavbar.Controls.Add(this.btnTrack);
            this.pnlNavbar.Controls.Add(this.btnAlbum);
            this.pnlNavbar.Controls.Add(this.btnArtist);
            this.pnlNavbar.Controls.Add(this.btnUserCRUD);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavbar.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(294, 731);
            this.pnlNavbar.TabIndex = 0;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.Location = new System.Drawing.Point(12, 333);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(267, 47);
            this.btnPlaylist.TabIndex = 7;
            this.btnPlaylist.TabStop = false;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.FlatAppearance.BorderSize = 0;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrack.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrack.Location = new System.Drawing.Point(12, 280);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(267, 47);
            this.btnTrack.TabIndex = 6;
            this.btnTrack.TabStop = false;
            this.btnTrack.Text = "Track";
            this.btnTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.FlatAppearance.BorderSize = 0;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbum.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.Location = new System.Drawing.Point(12, 227);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(267, 47);
            this.btnAlbum.TabIndex = 5;
            this.btnAlbum.TabStop = false;
            this.btnAlbum.Text = "Album";
            this.btnAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.FlatAppearance.BorderSize = 0;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtist.Location = new System.Drawing.Point(12, 174);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(267, 47);
            this.btnArtist.TabIndex = 4;
            this.btnArtist.TabStop = false;
            this.btnArtist.Text = "Artist";
            this.btnArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnUserCRUD
            // 
            this.btnUserCRUD.FlatAppearance.BorderSize = 0;
            this.btnUserCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserCRUD.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCRUD.Location = new System.Drawing.Point(12, 121);
            this.btnUserCRUD.Name = "btnUserCRUD";
            this.btnUserCRUD.Size = new System.Drawing.Size(267, 47);
            this.btnUserCRUD.TabIndex = 3;
            this.btnUserCRUD.TabStop = false;
            this.btnUserCRUD.Text = "User";
            this.btnUserCRUD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCRUD.UseVisualStyleBackColor = true;
            this.btnUserCRUD.Click += new System.EventHandler(this.btnUserCRUD_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(294, 41);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(796, 690);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.ucAppControl);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(294, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(796, 37);
            this.pnlHeader.TabIndex = 2;
            // 
            // ucAppControl
            // 
            this.ucAppControl.Location = new System.Drawing.Point(726, 0);
            this.ucAppControl.Name = "ucAppControl";
            this.ucAppControl.Size = new System.Drawing.Size(70, 35);
            this.ucAppControl.TabIndex = 0;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 731);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminPanel";
            this.Text = "frmAdminPanel";
            this.Load += new System.EventHandler(this.btnUserCRUD_Click);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnUserCRUD;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private UserControlls.Shared.ucAppControl ucAppControl;
    }
}