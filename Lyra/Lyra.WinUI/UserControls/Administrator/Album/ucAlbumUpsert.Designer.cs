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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlAlbumTracksPageButtons = new System.Windows.Forms.Panel();
            this.btnNextAlbumTracks = new System.Windows.Forms.Button();
            this.btnPreviousAlbumTracks = new System.Windows.Forms.Button();
            this.btnPageNumberAlbumTracks = new System.Windows.Forms.Button();
            this.pnlAllTracksPageButtons = new System.Windows.Forms.Panel();
            this.btnNextAllTracks = new System.Windows.Forms.Button();
            this.btnPreviousAllTracks = new System.Windows.Forms.Button();
            this.btnPageNumberAllTracks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReleaseYear)).BeginInit();
            this.pnlAlbumTracksPageButtons.SuspendLayout();
            this.pnlAllTracksPageButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 655);
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
            this.gbTracks.Controls.Add(this.pnlAllTracksPageButtons);
            this.gbTracks.Controls.Add(this.pnlAlbumTracksPageButtons);
            this.gbTracks.Controls.Add(this.btnAddTrack);
            this.gbTracks.Controls.Add(this.btnRemoveTrack);
            this.gbTracks.Controls.Add(this.lblAllTracks);
            this.gbTracks.Controls.Add(this.lblAlbumTracks);
            this.gbTracks.Controls.Add(this.dgvAllTracks);
            this.gbTracks.Controls.Add(this.dgvAlbumTracks);
            this.gbTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTracks.Location = new System.Drawing.Point(31, 343);
            this.gbTracks.Name = "gbTracks";
            this.gbTracks.Size = new System.Drawing.Size(719, 306);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvAllTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllTracks.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvAllTracks.Location = new System.Drawing.Point(364, 93);
            this.dgvAllTracks.Name = "dgvAllTracks";
            this.dgvAllTracks.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvAllTracks.Size = new System.Drawing.Size(338, 150);
            this.dgvAllTracks.TabIndex = 1;
            // 
            // dgvAlbumTracks
            // 
            this.dgvAlbumTracks.AllowUserToAddRows = false;
            this.dgvAlbumTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbumTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvAlbumTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlbumTracks.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvAlbumTracks.Location = new System.Drawing.Point(16, 93);
            this.dgvAlbumTracks.Name = "dgvAlbumTracks";
            this.dgvAlbumTracks.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbumTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvAlbumTracks.Size = new System.Drawing.Size(332, 150);
            this.dgvAlbumTracks.TabIndex = 0;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderReleaseYear
            // 
            this.errorProviderReleaseYear.ContainerControl = this;
            // 
            // pnlAlbumTracksPageButtons
            // 
            this.pnlAlbumTracksPageButtons.Controls.Add(this.btnNextAlbumTracks);
            this.pnlAlbumTracksPageButtons.Controls.Add(this.btnPreviousAlbumTracks);
            this.pnlAlbumTracksPageButtons.Controls.Add(this.btnPageNumberAlbumTracks);
            this.pnlAlbumTracksPageButtons.Location = new System.Drawing.Point(221, 246);
            this.pnlAlbumTracksPageButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAlbumTracksPageButtons.Name = "pnlAlbumTracksPageButtons";
            this.pnlAlbumTracksPageButtons.Size = new System.Drawing.Size(127, 40);
            this.pnlAlbumTracksPageButtons.TabIndex = 29;
            // 
            // btnNextAlbumTracks
            // 
            this.btnNextAlbumTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAlbumTracks.Location = new System.Drawing.Point(85, 6);
            this.btnNextAlbumTracks.Name = "btnNextAlbumTracks";
            this.btnNextAlbumTracks.Size = new System.Drawing.Size(33, 30);
            this.btnNextAlbumTracks.TabIndex = 27;
            this.btnNextAlbumTracks.Text = ">";
            this.btnNextAlbumTracks.UseVisualStyleBackColor = true;
            this.btnNextAlbumTracks.Click += new System.EventHandler(this.btnNextAlbumTracks_Click);
            // 
            // btnPreviousAlbumTracks
            // 
            this.btnPreviousAlbumTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousAlbumTracks.Location = new System.Drawing.Point(7, 6);
            this.btnPreviousAlbumTracks.Name = "btnPreviousAlbumTracks";
            this.btnPreviousAlbumTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPreviousAlbumTracks.TabIndex = 25;
            this.btnPreviousAlbumTracks.Text = "<";
            this.btnPreviousAlbumTracks.UseVisualStyleBackColor = true;
            this.btnPreviousAlbumTracks.Click += new System.EventHandler(this.btnPreviousAlbumTracks_Click);
            // 
            // btnPageNumberAlbumTracks
            // 
            this.btnPageNumberAlbumTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumberAlbumTracks.Location = new System.Drawing.Point(46, 6);
            this.btnPageNumberAlbumTracks.Name = "btnPageNumberAlbumTracks";
            this.btnPageNumberAlbumTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumberAlbumTracks.TabIndex = 26;
            this.btnPageNumberAlbumTracks.Text = "1";
            this.btnPageNumberAlbumTracks.UseVisualStyleBackColor = true;
            // 
            // pnlAllTracksPageButtons
            // 
            this.pnlAllTracksPageButtons.Controls.Add(this.btnNextAllTracks);
            this.pnlAllTracksPageButtons.Controls.Add(this.btnPreviousAllTracks);
            this.pnlAllTracksPageButtons.Controls.Add(this.btnPageNumberAllTracks);
            this.pnlAllTracksPageButtons.Location = new System.Drawing.Point(575, 246);
            this.pnlAllTracksPageButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAllTracksPageButtons.Name = "pnlAllTracksPageButtons";
            this.pnlAllTracksPageButtons.Size = new System.Drawing.Size(127, 40);
            this.pnlAllTracksPageButtons.TabIndex = 30;
            // 
            // btnNextAllTracks
            // 
            this.btnNextAllTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAllTracks.Location = new System.Drawing.Point(85, 6);
            this.btnNextAllTracks.Name = "btnNextAllTracks";
            this.btnNextAllTracks.Size = new System.Drawing.Size(33, 30);
            this.btnNextAllTracks.TabIndex = 27;
            this.btnNextAllTracks.Text = ">";
            this.btnNextAllTracks.UseVisualStyleBackColor = true;
            this.btnNextAllTracks.Click += new System.EventHandler(this.btnNextAllTracks_Click);
            // 
            // btnPreviousAllTracks
            // 
            this.btnPreviousAllTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousAllTracks.Location = new System.Drawing.Point(7, 6);
            this.btnPreviousAllTracks.Name = "btnPreviousAllTracks";
            this.btnPreviousAllTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPreviousAllTracks.TabIndex = 25;
            this.btnPreviousAllTracks.Text = "<";
            this.btnPreviousAllTracks.UseVisualStyleBackColor = true;
            this.btnPreviousAllTracks.Click += new System.EventHandler(this.btnPreviousAllTracks_Click);
            // 
            // btnPageNumberAllTracks
            // 
            this.btnPageNumberAllTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumberAllTracks.Location = new System.Drawing.Point(46, 6);
            this.btnPageNumberAllTracks.Name = "btnPageNumberAllTracks";
            this.btnPageNumberAllTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumberAllTracks.TabIndex = 26;
            this.btnPageNumberAllTracks.Text = "1";
            this.btnPageNumberAllTracks.UseVisualStyleBackColor = true;
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
            this.pnlAlbumTracksPageButtons.ResumeLayout(false);
            this.pnlAllTracksPageButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlAllTracksPageButtons;
        private System.Windows.Forms.Button btnNextAllTracks;
        private System.Windows.Forms.Button btnPreviousAllTracks;
        private System.Windows.Forms.Button btnPageNumberAllTracks;
        private System.Windows.Forms.Panel pnlAlbumTracksPageButtons;
        private System.Windows.Forms.Button btnNextAlbumTracks;
        private System.Windows.Forms.Button btnPreviousAlbumTracks;
        private System.Windows.Forms.Button btnPageNumberAlbumTracks;
    }
}
