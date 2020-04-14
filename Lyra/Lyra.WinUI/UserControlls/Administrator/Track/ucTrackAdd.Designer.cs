namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    partial class ucTrackAdd
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
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbFeaturedArtists = new System.Windows.Forms.ListBox();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblTrackInfo = new System.Windows.Forms.Label();
            this.cbMainArtist = new System.Windows.Forms.ComboBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblFeaturedArtist = new System.Windows.Forms.Label();
            this.cbFeaturedArtist = new System.Windows.Forms.ComboBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnRemoveArtist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(285, 92);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 28;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(288, 108);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(188, 22);
            this.txtLength.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 622);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(51, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 24;
            // 
            // lbFeaturedArtists
            // 
            this.lbFeaturedArtists.FormattingEnabled = true;
            this.lbFeaturedArtists.Location = new System.Drawing.Point(51, 315);
            this.lbFeaturedArtists.Name = "lbFeaturedArtists";
            this.lbFeaturedArtists.Size = new System.Drawing.Size(188, 225);
            this.lbFeaturedArtists.TabIndex = 29;
            // 
            // lblLine1
            // 
            this.lblLine1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblLine1.AutoSize = true;
            this.lblLine1.BackColor = System.Drawing.Color.Transparent;
            this.lblLine1.Location = new System.Drawing.Point(39, 61);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(691, 13);
            this.lblLine1.TabIndex = 56;
            this.lblLine1.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // lblTrackInfo
            // 
            this.lblTrackInfo.AutoSize = true;
            this.lblTrackInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackInfo.Location = new System.Drawing.Point(37, 36);
            this.lblTrackInfo.Name = "lblTrackInfo";
            this.lblTrackInfo.Size = new System.Drawing.Size(51, 25);
            this.lblTrackInfo.TabIndex = 55;
            this.lblTrackInfo.Text = "Info";
            // 
            // cbMainArtist
            // 
            this.cbMainArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMainArtist.FormattingEnabled = true;
            this.cbMainArtist.Location = new System.Drawing.Point(51, 183);
            this.cbMainArtist.Name = "cbMainArtist";
            this.cbMainArtist.Size = new System.Drawing.Size(188, 24);
            this.cbMainArtist.TabIndex = 57;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(48, 167);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 58;
            this.lblArtist.Text = "Artist";
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(48, 299);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(35, 13);
            this.lblArtists.TabIndex = 59;
            this.lblArtists.Text = "Artists";
            // 
            // lblLine2
            // 
            this.lblLine2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblLine2.AutoSize = true;
            this.lblLine2.BackColor = System.Drawing.Color.Transparent;
            this.lblLine2.Location = new System.Drawing.Point(39, 274);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(691, 13);
            this.lblLine2.TabIndex = 61;
            this.lblLine2.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // lblFeaturedArtist
            // 
            this.lblFeaturedArtist.AutoSize = true;
            this.lblFeaturedArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeaturedArtist.Location = new System.Drawing.Point(37, 249);
            this.lblFeaturedArtist.Name = "lblFeaturedArtist";
            this.lblFeaturedArtist.Size = new System.Drawing.Size(180, 25);
            this.lblFeaturedArtist.TabIndex = 60;
            this.lblFeaturedArtist.Text = "Featured Artists";
            // 
            // cbFeaturedArtist
            // 
            this.cbFeaturedArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFeaturedArtist.FormattingEnabled = true;
            this.cbFeaturedArtist.Location = new System.Drawing.Point(285, 316);
            this.cbFeaturedArtist.Name = "cbFeaturedArtist";
            this.cbFeaturedArtist.Size = new System.Drawing.Size(188, 24);
            this.cbFeaturedArtist.TabIndex = 62;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(285, 362);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(188, 23);
            this.btnAddArtist.TabIndex = 63;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnRemoveArtist
            // 
            this.btnRemoveArtist.Location = new System.Drawing.Point(51, 563);
            this.btnRemoveArtist.Name = "btnRemoveArtist";
            this.btnRemoveArtist.Size = new System.Drawing.Size(188, 23);
            this.btnRemoveArtist.TabIndex = 64;
            this.btnRemoveArtist.Text = "Remove Artist";
            this.btnRemoveArtist.UseVisualStyleBackColor = true;
            this.btnRemoveArtist.Click += new System.EventHandler(this.btnRemoveArtist_Click);
            // 
            // ucTrackAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.cbFeaturedArtist);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblFeaturedArtist);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.cbMainArtist);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.lblTrackInfo);
            this.Controls.Add(this.lbFeaturedArtists);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "ucTrackAdd";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucTrackAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbFeaturedArtists;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblTrackInfo;
        private System.Windows.Forms.ComboBox cbMainArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblFeaturedArtist;
        private System.Windows.Forms.ComboBox cbFeaturedArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnRemoveArtist;
    }
}
