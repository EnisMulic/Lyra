namespace Lyra.WinUI.UserControlls.Administrator.Artist
{
    partial class ucArtistList
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
            this.dgvArtists = new System.Windows.Forms.DataGridView();
            this.btnDeleteArtist = new System.Windows.Forms.Button();
            this.btnEditArtist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtists
            // 
            this.dgvArtists.AllowUserToAddRows = false;
            this.dgvArtists.AllowUserToDeleteRows = false;
            this.dgvArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtists.Location = new System.Drawing.Point(16, 82);
            this.dgvArtists.Name = "dgvArtists";
            this.dgvArtists.ReadOnly = true;
            this.dgvArtists.Size = new System.Drawing.Size(763, 526);
            this.dgvArtists.TabIndex = 1;
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.Location = new System.Drawing.Point(84, 53);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteArtist.TabIndex = 7;
            this.btnDeleteArtist.Text = "D";
            this.btnDeleteArtist.UseVisualStyleBackColor = true;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.Location = new System.Drawing.Point(50, 53);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Size = new System.Drawing.Size(28, 23);
            this.btnEditArtist.TabIndex = 6;
            this.btnEditArtist.Text = "E";
            this.btnEditArtist.UseVisualStyleBackColor = true;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(16, 53);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(28, 23);
            this.btnAddArtist.TabIndex = 5;
            this.btnAddArtist.Text = "A";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // ucArtistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteArtist);
            this.Controls.Add(this.btnEditArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.dgvArtists);
            this.Name = "ucArtistList";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucArtistList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtists;
        private System.Windows.Forms.Button btnDeleteArtist;
        private System.Windows.Forms.Button btnEditArtist;
        private System.Windows.Forms.Button btnAddArtist;
    }
}
