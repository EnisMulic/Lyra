namespace Lyra.WinUI.UserControls.Administrator.Album
{
    partial class ucAlbumUpsert
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbAlbumImage = new System.Windows.Forms.PictureBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.gbTracks = new System.Windows.Forms.GroupBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.lblAllTracks = new System.Windows.Forms.Label();
            this.lblAlbumTracks = new System.Windows.Forms.Label();
            this.dgvAllTracks = new System.Windows.Forms.DataGridView();
            this.dgvAlbumTracks = new System.Windows.Forms.DataGridView();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderReleaseYear = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReleaseYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.Location = new System.Drawing.Point(267, 116);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(81, 15);
            this.lblReleaseYear.TabIndex = 8;
            this.lblReleaseYear.Text = "Release Year";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(267, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseYear.Location = new System.Drawing.Point(270, 132);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(188, 21);
            this.txtReleaseYear.TabIndex = 6;
            this.txtReleaseYear.Validating += new System.ComponentModel.CancelEventHandler(this.ReleaseYear_Validating);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(270, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 21);
            this.txtName.TabIndex = 5;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(27, 253);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(188, 23);
            this.btnUploadImage.TabIndex = 23;
            this.btnUploadImage.Text = "Upload image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbAlbumImage
            // 
            this.pbAlbumImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAlbumImage.Location = new System.Drawing.Point(27, 44);
            this.pbAlbumImage.Name = "pbAlbumImage";
            this.pbAlbumImage.Size = new System.Drawing.Size(188, 184);
            this.pbAlbumImage.TabIndex = 22;
            this.pbAlbumImage.TabStop = false;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblArtist);
            this.gbInfo.Controls.Add(this.cbArtist);
            this.gbInfo.Controls.Add(this.pbAlbumImage);
            this.gbInfo.Controls.Add(this.btnUploadImage);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.txtReleaseYear);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.lblReleaseYear);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(31, 24);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(719, 303);
            this.gbInfo.TabIndex = 24;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(267, 187);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 15);
            this.lblArtist.TabIndex = 25;
            this.lblArtist.Text = "Artist";
            // 
            // cbArtist
            // 
            this.cbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(270, 205);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(188, 23);
            this.cbArtist.TabIndex = 24;
            // 
            // gbTracks
            // 
            this.gbTracks.Controls.Add(this.btnAddTrack);
            this.gbTracks.Controls.Add(this.btnRemoveTrack);
            this.gbTracks.Controls.Add(this.lblAllTracks);
            this.gbTracks.Controls.Add(this.lblAlbumTracks);
            this.gbTracks.Controls.Add(this.dgvAllTracks);
            this.gbTracks.Controls.Add(this.dgvAlbumTracks);
            this.gbTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTracks.Location = new System.Drawing.Point(31, 343);
            this.gbTracks.Name = "gbTracks";
            this.gbTracks.Size = new System.Drawing.Size(719, 288);
            this.gbTracks.TabIndex = 25;
            this.gbTracks.TabStop = false;
            this.gbTracks.Text = "Tracks";
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrack.Location = new System.Drawing.Point(364, 64);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(89, 23);
            this.btnAddTrack.TabIndex = 5;
            this.btnAddTrack.Text = "Add";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTrack.Location = new System.Drawing.Point(16, 64);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveTrack.TabIndex = 4;
            this.btnRemoveTrack.Text = "Remove";
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // lblAllTracks
            // 
            this.lblAllTracks.AutoSize = true;
            this.lblAllTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTracks.Location = new System.Drawing.Point(361, 41);
            this.lblAllTracks.Name = "lblAllTracks";
            this.lblAllTracks.Size = new System.Drawing.Size(59, 15);
            this.lblAllTracks.TabIndex = 3;
            this.lblAllTracks.Text = "All Tracks";
            // 
            // lblAlbumTracks
            // 
            this.lblAlbumTracks.AutoSize = true;
            this.lblAlbumTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumTracks.Location = new System.Drawing.Point(16, 41);
            this.lblAlbumTracks.Name = "lblAlbumTracks";
            this.lblAlbumTracks.Size = new System.Drawing.Size(81, 15);
            this.lblAlbumTracks.TabIndex = 2;
            this.lblAlbumTracks.Text = "Album Tracks";
            // 
            // dgvAllTracks
            // 
            this.dgvAllTracks.AllowUserToAddRows = false;
            this.dgvAllTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllTracks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllTracks.Location = new System.Drawing.Point(364, 93);
            this.dgvAllTracks.Name = "dgvAllTracks";
            this.dgvAllTracks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllTracks.Size = new System.Drawing.Size(338, 150);
            this.dgvAllTracks.TabIndex = 1;
            this.dgvAllTracks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAllTracks_RowsAdded);
            // 
            // dgvAlbumTracks
            // 
            this.dgvAlbumTracks.AllowUserToAddRows = false;
            this.dgvAlbumTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbumTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlbumTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlbumTracks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlbumTracks.Location = new System.Drawing.Point(16, 93);
            this.dgvAlbumTracks.Name = "dgvAlbumTracks";
            this.dgvAlbumTracks.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbumTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAlbumTracks.Size = new System.Drawing.Size(332, 150);
            this.dgvAlbumTracks.TabIndex = 0;
            this.dgvAlbumTracks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAlbumTracks_RowsAdded);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderReleaseYear
            // 
            this.errorProviderReleaseYear.ContainerControl = this;
            // 
            // ucAlbumUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTracks);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnSave);
            this.Name = "ucAlbumUpsert";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucAlbumUpsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbTracks.ResumeLayout(false);
            this.gbTracks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReleaseYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pbAlbumImage;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbTracks;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.Label lblAllTracks;
        private System.Windows.Forms.Label lblAlbumTracks;
        private System.Windows.Forms.DataGridView dgvAllTracks;
        private System.Windows.Forms.DataGridView dgvAlbumTracks;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderReleaseYear;
    }
}
