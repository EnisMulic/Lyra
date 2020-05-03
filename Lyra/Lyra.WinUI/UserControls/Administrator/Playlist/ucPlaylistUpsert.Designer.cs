namespace Lyra.WinUI.UserControls.Administrator.Playlist
{
    partial class ucPlaylistUpsert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTracks = new System.Windows.Forms.GroupBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.lblAllTracks = new System.Windows.Forms.Label();
            this.lblPlaylistTracks = new System.Windows.Forms.Label();
            this.dgvAllTracks = new System.Windows.Forms.DataGridView();
            this.dgvPlaylistTracks = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.pbPlaylistImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistTracks)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylistImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTracks
            // 
            this.gbTracks.Controls.Add(this.btnAddTrack);
            this.gbTracks.Controls.Add(this.btnRemoveTrack);
            this.gbTracks.Controls.Add(this.lblAllTracks);
            this.gbTracks.Controls.Add(this.lblPlaylistTracks);
            this.gbTracks.Controls.Add(this.dgvAllTracks);
            this.gbTracks.Controls.Add(this.dgvPlaylistTracks);
            this.gbTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTracks.Location = new System.Drawing.Point(32, 347);
            this.gbTracks.Name = "gbTracks";
            this.gbTracks.Size = new System.Drawing.Size(719, 260);
            this.gbTracks.TabIndex = 28;
            this.gbTracks.TabStop = false;
            this.gbTracks.Text = "Tracks";
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrack.Location = new System.Drawing.Point(364, 62);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(89, 23);
            this.btnAddTrack.TabIndex = 7;
            this.btnAddTrack.Text = "Add";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTrack.Location = new System.Drawing.Point(16, 62);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveTrack.TabIndex = 6;
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
            // lblPlaylistTracks
            // 
            this.lblPlaylistTracks.AutoSize = true;
            this.lblPlaylistTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistTracks.Location = new System.Drawing.Point(16, 41);
            this.lblPlaylistTracks.Name = "lblPlaylistTracks";
            this.lblPlaylistTracks.Size = new System.Drawing.Size(84, 15);
            this.lblPlaylistTracks.TabIndex = 2;
            this.lblPlaylistTracks.Text = "Playlist Tracks";
            // 
            // dgvAllTracks
            // 
            this.dgvAllTracks.AllowUserToAddRows = false;
            this.dgvAllTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllTracks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllTracks.Location = new System.Drawing.Point(364, 91);
            this.dgvAllTracks.Name = "dgvAllTracks";
            this.dgvAllTracks.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAllTracks.Size = new System.Drawing.Size(338, 150);
            this.dgvAllTracks.TabIndex = 1;
            this.dgvAllTracks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAllTracks_RowsAdded);
            // 
            // dgvPlaylistTracks
            // 
            this.dgvPlaylistTracks.AllowUserToAddRows = false;
            this.dgvPlaylistTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylistTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPlaylistTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlaylistTracks.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPlaylistTracks.Location = new System.Drawing.Point(16, 91);
            this.dgvPlaylistTracks.Name = "dgvPlaylistTracks";
            this.dgvPlaylistTracks.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylistTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPlaylistTracks.Size = new System.Drawing.Size(332, 150);
            this.dgvPlaylistTracks.TabIndex = 0;
            this.dgvPlaylistTracks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPlaylistTracks_RowsAdded);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtCreatedAt);
            this.gbInfo.Controls.Add(this.lblCreatedAt);
            this.gbInfo.Controls.Add(this.pbPlaylistImage);
            this.gbInfo.Controls.Add(this.btnUploadImage);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.txtOwner);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.lblOwner);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(32, 28);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(719, 303);
            this.gbInfo.TabIndex = 27;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedAt.Location = new System.Drawing.Point(270, 129);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.ReadOnly = true;
            this.txtCreatedAt.Size = new System.Drawing.Size(188, 21);
            this.txtCreatedAt.TabIndex = 24;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedAt.Location = new System.Drawing.Point(267, 113);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(63, 15);
            this.lblCreatedAt.TabIndex = 25;
            this.lblCreatedAt.Text = "Created At";
            // 
            // pbPlaylistImage
            // 
            this.pbPlaylistImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlaylistImage.Location = new System.Drawing.Point(27, 44);
            this.pbPlaylistImage.Name = "pbPlaylistImage";
            this.pbPlaylistImage.Size = new System.Drawing.Size(188, 184);
            this.pbPlaylistImage.TabIndex = 22;
            this.pbPlaylistImage.TabStop = false;
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(270, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 21);
            this.txtName.TabIndex = 5;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.Location = new System.Drawing.Point(270, 207);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(188, 21);
            this.txtOwner.TabIndex = 6;
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
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(267, 191);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(43, 15);
            this.lblOwner.TabIndex = 8;
            this.lblOwner.Text = "Owner";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(57, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // ucPlaylistUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTracks);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnSave);
            this.Name = "ucPlaylistUpsert";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucPlaylistUpsert_Load);
            this.gbTracks.ResumeLayout(false);
            this.gbTracks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistTracks)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylistImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTracks;
        private System.Windows.Forms.Label lblAllTracks;
        private System.Windows.Forms.Label lblPlaylistTracks;
        private System.Windows.Forms.DataGridView dgvAllTracks;
        private System.Windows.Forms.DataGridView dgvPlaylistTracks;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.PictureBox pbPlaylistImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}
