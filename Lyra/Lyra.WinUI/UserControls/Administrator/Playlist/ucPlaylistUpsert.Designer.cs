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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTracks = new System.Windows.Forms.GroupBox();
            this.pnlAllTracksPageButtons = new System.Windows.Forms.Panel();
            this.btnNextAllTracks = new System.Windows.Forms.Button();
            this.btnPreviousAllTracks = new System.Windows.Forms.Button();
            this.btnPageNumberAllTracks = new System.Windows.Forms.Button();
            this.pnlPlaylistTracksPageButtons = new System.Windows.Forms.Panel();
            this.btnNextPlaylistTracks = new System.Windows.Forms.Button();
            this.btnPreviousPlaylistTracks = new System.Windows.Forms.Button();
            this.btnPageNumberPlaylistTracks = new System.Windows.Forms.Button();
            this.lblAllTracks = new System.Windows.Forms.Label();
            this.lblPlaylistTracks = new System.Windows.Forms.Label();
            this.dgvAllTracks = new System.Windows.Forms.DataGridView();
            this.dgvPlaylistTracks = new System.Windows.Forms.DataGridView();
            this.pbPlaylistImage = new System.Windows.Forms.PictureBox();
            this.btnSearchPlaylistTracks = new System.Windows.Forms.Button();
            this.txtSearchPlaylistTracks = new System.Windows.Forms.TextBox();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.btnSearchAllTracks = new System.Windows.Forms.Button();
            this.txtSearchAllTracks = new System.Windows.Forms.TextBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.gbTracks.SuspendLayout();
            this.pnlAllTracksPageButtons.SuspendLayout();
            this.pnlPlaylistTracksPageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylistImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(59, 664);
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
            // gbTracks
            // 
            this.gbTracks.Controls.Add(this.btnSearchAllTracks);
            this.gbTracks.Controls.Add(this.txtSearchAllTracks);
            this.gbTracks.Controls.Add(this.btnAddTrack);
            this.gbTracks.Controls.Add(this.btnSearchPlaylistTracks);
            this.gbTracks.Controls.Add(this.pnlAllTracksPageButtons);
            this.gbTracks.Controls.Add(this.txtSearchPlaylistTracks);
            this.gbTracks.Controls.Add(this.btnRemoveTrack);
            this.gbTracks.Controls.Add(this.pnlPlaylistTracksPageButtons);
            this.gbTracks.Controls.Add(this.lblAllTracks);
            this.gbTracks.Controls.Add(this.lblPlaylistTracks);
            this.gbTracks.Controls.Add(this.dgvAllTracks);
            this.gbTracks.Controls.Add(this.dgvPlaylistTracks);
            this.gbTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTracks.Location = new System.Drawing.Point(32, 352);
            this.gbTracks.Name = "gbTracks";
            this.gbTracks.Size = new System.Drawing.Size(719, 286);
            this.gbTracks.TabIndex = 28;
            this.gbTracks.TabStop = false;
            this.gbTracks.Text = "Tracks";
            // 
            // pnlAllTracksPageButtons
            // 
            this.pnlAllTracksPageButtons.Controls.Add(this.btnNextAllTracks);
            this.pnlAllTracksPageButtons.Controls.Add(this.btnPreviousAllTracks);
            this.pnlAllTracksPageButtons.Controls.Add(this.btnPageNumberAllTracks);
            this.pnlAllTracksPageButtons.Location = new System.Drawing.Point(575, 235);
            this.pnlAllTracksPageButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAllTracksPageButtons.Name = "pnlAllTracksPageButtons";
            this.pnlAllTracksPageButtons.Size = new System.Drawing.Size(127, 40);
            this.pnlAllTracksPageButtons.TabIndex = 38;
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
            // pnlPlaylistTracksPageButtons
            // 
            this.pnlPlaylistTracksPageButtons.Controls.Add(this.btnNextPlaylistTracks);
            this.pnlPlaylistTracksPageButtons.Controls.Add(this.btnPreviousPlaylistTracks);
            this.pnlPlaylistTracksPageButtons.Controls.Add(this.btnPageNumberPlaylistTracks);
            this.pnlPlaylistTracksPageButtons.Location = new System.Drawing.Point(221, 235);
            this.pnlPlaylistTracksPageButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlaylistTracksPageButtons.Name = "pnlPlaylistTracksPageButtons";
            this.pnlPlaylistTracksPageButtons.Size = new System.Drawing.Size(127, 40);
            this.pnlPlaylistTracksPageButtons.TabIndex = 37;
            // 
            // btnNextPlaylistTracks
            // 
            this.btnNextPlaylistTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPlaylistTracks.Location = new System.Drawing.Point(85, 6);
            this.btnNextPlaylistTracks.Name = "btnNextPlaylistTracks";
            this.btnNextPlaylistTracks.Size = new System.Drawing.Size(33, 30);
            this.btnNextPlaylistTracks.TabIndex = 27;
            this.btnNextPlaylistTracks.Text = ">";
            this.btnNextPlaylistTracks.UseVisualStyleBackColor = true;
            this.btnNextPlaylistTracks.Click += new System.EventHandler(this.btnNextPlaylistTracks_Click);
            // 
            // btnPreviousPlaylistTracks
            // 
            this.btnPreviousPlaylistTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPlaylistTracks.Location = new System.Drawing.Point(7, 6);
            this.btnPreviousPlaylistTracks.Name = "btnPreviousPlaylistTracks";
            this.btnPreviousPlaylistTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPreviousPlaylistTracks.TabIndex = 25;
            this.btnPreviousPlaylistTracks.Text = "<";
            this.btnPreviousPlaylistTracks.UseVisualStyleBackColor = true;
            this.btnPreviousPlaylistTracks.Click += new System.EventHandler(this.btnPreviousPlaylistTracks_Click);
            // 
            // btnPageNumberPlaylistTracks
            // 
            this.btnPageNumberPlaylistTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumberPlaylistTracks.Location = new System.Drawing.Point(46, 6);
            this.btnPageNumberPlaylistTracks.Name = "btnPageNumberPlaylistTracks";
            this.btnPageNumberPlaylistTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumberPlaylistTracks.TabIndex = 26;
            this.btnPageNumberPlaylistTracks.Text = "1";
            this.btnPageNumberPlaylistTracks.UseVisualStyleBackColor = true;
            // 
            // lblAllTracks
            // 
            this.lblAllTracks.AutoSize = true;
            this.lblAllTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTracks.Location = new System.Drawing.Point(361, 30);
            this.lblAllTracks.Name = "lblAllTracks";
            this.lblAllTracks.Size = new System.Drawing.Size(59, 15);
            this.lblAllTracks.TabIndex = 34;
            this.lblAllTracks.Text = "All Tracks";
            // 
            // lblPlaylistTracks
            // 
            this.lblPlaylistTracks.AutoSize = true;
            this.lblPlaylistTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistTracks.Location = new System.Drawing.Point(16, 30);
            this.lblPlaylistTracks.Name = "lblPlaylistTracks";
            this.lblPlaylistTracks.Size = new System.Drawing.Size(84, 15);
            this.lblPlaylistTracks.TabIndex = 33;
            this.lblPlaylistTracks.Text = "Playlist Tracks";
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
            this.dgvAllTracks.Location = new System.Drawing.Point(364, 82);
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
            this.dgvAllTracks.TabIndex = 32;
            // 
            // dgvPlaylistTracks
            // 
            this.dgvPlaylistTracks.AllowUserToAddRows = false;
            this.dgvPlaylistTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylistTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlaylistTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlaylistTracks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlaylistTracks.Location = new System.Drawing.Point(16, 82);
            this.dgvPlaylistTracks.Name = "dgvPlaylistTracks";
            this.dgvPlaylistTracks.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylistTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlaylistTracks.Size = new System.Drawing.Size(332, 150);
            this.dgvPlaylistTracks.TabIndex = 31;
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
            // btnSearchPlaylistTracks
            // 
            this.btnSearchPlaylistTracks.BackgroundImage = global::Lyra.WinUI.Properties.Resources.search;
            this.btnSearchPlaylistTracks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPlaylistTracks.FlatAppearance.BorderSize = 0;
            this.btnSearchPlaylistTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPlaylistTracks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchPlaylistTracks.Location = new System.Drawing.Point(191, 53);
            this.btnSearchPlaylistTracks.Name = "btnSearchPlaylistTracks";
            this.btnSearchPlaylistTracks.Size = new System.Drawing.Size(28, 23);
            this.btnSearchPlaylistTracks.TabIndex = 35;
            this.btnSearchPlaylistTracks.UseVisualStyleBackColor = true;
            this.btnSearchPlaylistTracks.Click += new System.EventHandler(this.btnSearchPlaylistTracks_Click);
            // 
            // txtSearchPlaylistTracks
            // 
            this.txtSearchPlaylistTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPlaylistTracks.Location = new System.Drawing.Point(16, 53);
            this.txtSearchPlaylistTracks.Name = "txtSearchPlaylistTracks";
            this.txtSearchPlaylistTracks.Size = new System.Drawing.Size(167, 22);
            this.txtSearchPlaylistTracks.TabIndex = 34;
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.BackgroundImage = global::Lyra.WinUI.Properties.Resources.delete;
            this.btnRemoveTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveTrack.FlatAppearance.BorderSize = 0;
            this.btnRemoveTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTrack.Location = new System.Drawing.Point(228, 53);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(33, 24);
            this.btnRemoveTrack.TabIndex = 33;
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // btnSearchAllTracks
            // 
            this.btnSearchAllTracks.BackgroundImage = global::Lyra.WinUI.Properties.Resources.search;
            this.btnSearchAllTracks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAllTracks.FlatAppearance.BorderSize = 0;
            this.btnSearchAllTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAllTracks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchAllTracks.Location = new System.Drawing.Point(539, 53);
            this.btnSearchAllTracks.Name = "btnSearchAllTracks";
            this.btnSearchAllTracks.Size = new System.Drawing.Size(28, 23);
            this.btnSearchAllTracks.TabIndex = 41;
            this.btnSearchAllTracks.UseVisualStyleBackColor = true;
            this.btnSearchAllTracks.Click += new System.EventHandler(this.btnSearchAllTracks_Click);
            // 
            // txtSearchAllTracks
            // 
            this.txtSearchAllTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAllTracks.Location = new System.Drawing.Point(364, 53);
            this.txtSearchAllTracks.Name = "txtSearchAllTracks";
            this.txtSearchAllTracks.Size = new System.Drawing.Size(167, 22);
            this.txtSearchAllTracks.TabIndex = 40;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.BackgroundImage = global::Lyra.WinUI.Properties.Resources.add;
            this.btnAddTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTrack.FlatAppearance.BorderSize = 0;
            this.btnAddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrack.Location = new System.Drawing.Point(575, 51);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(28, 25);
            this.btnAddTrack.TabIndex = 39;
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
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
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.gbTracks.ResumeLayout(false);
            this.gbTracks.PerformLayout();
            this.pnlAllTracksPageButtons.ResumeLayout(false);
            this.pnlPlaylistTracksPageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylistImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.GroupBox gbTracks;
        private System.Windows.Forms.Panel pnlAllTracksPageButtons;
        private System.Windows.Forms.Button btnNextAllTracks;
        private System.Windows.Forms.Button btnPreviousAllTracks;
        private System.Windows.Forms.Button btnPageNumberAllTracks;
        private System.Windows.Forms.Panel pnlPlaylistTracksPageButtons;
        private System.Windows.Forms.Button btnNextPlaylistTracks;
        private System.Windows.Forms.Button btnPreviousPlaylistTracks;
        private System.Windows.Forms.Button btnPageNumberPlaylistTracks;
        private System.Windows.Forms.Label lblAllTracks;
        private System.Windows.Forms.Label lblPlaylistTracks;
        private System.Windows.Forms.DataGridView dgvAllTracks;
        private System.Windows.Forms.DataGridView dgvPlaylistTracks;
        private System.Windows.Forms.Button btnSearchPlaylistTracks;
        private System.Windows.Forms.TextBox txtSearchPlaylistTracks;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.Button btnSearchAllTracks;
        private System.Windows.Forms.TextBox txtSearchAllTracks;
        private System.Windows.Forms.Button btnAddTrack;
    }
}
