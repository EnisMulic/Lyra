namespace Lyra.WinUI.UserControls.Administrator.Track
{
    partial class ucTrackUpsert
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
            this.btnRemoveArtist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.cbFeaturedArtist = new System.Windows.Forms.ComboBox();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.cbMainArtist = new System.Windows.Forms.ComboBox();
            this.lbFeaturedArtists = new System.Windows.Forms.ListBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRemoveGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbArtists = new System.Windows.Forms.GroupBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMainArtist = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInfo.SuspendLayout();
            this.gbArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMainArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveArtist
            // 
            this.btnRemoveArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveArtist.Location = new System.Drawing.Point(25, 227);
            this.btnRemoveArtist.Name = "btnRemoveArtist";
            this.btnRemoveArtist.Size = new System.Drawing.Size(188, 23);
            this.btnRemoveArtist.TabIndex = 80;
            this.btnRemoveArtist.Text = "Remove Artist";
            this.btnRemoveArtist.UseVisualStyleBackColor = true;
            this.btnRemoveArtist.Click += new System.EventHandler(this.btnRemoveArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArtist.Location = new System.Drawing.Point(259, 103);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(188, 23);
            this.btnAddArtist.TabIndex = 79;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // cbFeaturedArtist
            // 
            this.cbFeaturedArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFeaturedArtist.FormattingEnabled = true;
            this.cbFeaturedArtist.Location = new System.Drawing.Point(259, 47);
            this.cbFeaturedArtist.Name = "cbFeaturedArtist";
            this.cbFeaturedArtist.Size = new System.Drawing.Size(188, 24);
            this.cbFeaturedArtist.TabIndex = 78;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtists.Location = new System.Drawing.Point(22, 31);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(35, 13);
            this.lblArtists.TabIndex = 75;
            this.lblArtists.Text = "Artists";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(48, 203);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 74;
            this.lblArtist.Text = "Artist";
            // 
            // cbMainArtist
            // 
            this.cbMainArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMainArtist.FormattingEnabled = true;
            this.cbMainArtist.Location = new System.Drawing.Point(25, 191);
            this.cbMainArtist.Name = "cbMainArtist";
            this.cbMainArtist.Size = new System.Drawing.Size(188, 24);
            this.cbMainArtist.TabIndex = 73;
            this.cbMainArtist.Validating += new System.ComponentModel.CancelEventHandler(this.cbMainArtist_Validating);
            // 
            // lbFeaturedArtists
            // 
            this.lbFeaturedArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeaturedArtists.FormattingEnabled = true;
            this.lbFeaturedArtists.Location = new System.Drawing.Point(25, 47);
            this.lbFeaturedArtists.Name = "lbFeaturedArtists";
            this.lbFeaturedArtists.Size = new System.Drawing.Size(188, 160);
            this.lbFeaturedArtists.TabIndex = 70;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(48, 141);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 69;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(51, 157);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(188, 22);
            this.txtLength.TabIndex = 68;
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.Length_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 622);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(51, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 65;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // btnRemoveGenre
            // 
            this.btnRemoveGenre.Location = new System.Drawing.Point(285, 270);
            this.btnRemoveGenre.Name = "btnRemoveGenre";
            this.btnRemoveGenre.Size = new System.Drawing.Size(188, 23);
            this.btnRemoveGenre.TabIndex = 85;
            this.btnRemoveGenre.Text = "Remove Genre";
            this.btnRemoveGenre.UseVisualStyleBackColor = true;
            this.btnRemoveGenre.Click += new System.EventHandler(this.btnRemoveGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(519, 157);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(188, 23);
            this.btnAddGenre.TabIndex = 84;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // cbGenre
            // 
            this.cbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(519, 100);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(188, 24);
            this.cbGenre.TabIndex = 83;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(282, 83);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(41, 13);
            this.lblGenres.TabIndex = 82;
            this.lblGenres.Text = "Genres";
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(285, 99);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(188, 147);
            this.lbGenres.TabIndex = 81;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbMainArtist);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(26, 28);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(737, 286);
            this.gbInfo.TabIndex = 86;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // gbArtists
            // 
            this.gbArtists.Controls.Add(this.lbFeaturedArtists);
            this.gbArtists.Controls.Add(this.btnRemoveArtist);
            this.gbArtists.Controls.Add(this.cbFeaturedArtist);
            this.gbArtists.Controls.Add(this.lblArtists);
            this.gbArtists.Controls.Add(this.btnAddArtist);
            this.gbArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArtists.Location = new System.Drawing.Point(26, 333);
            this.gbArtists.Name = "gbArtists";
            this.gbArtists.Size = new System.Drawing.Size(737, 267);
            this.gbArtists.TabIndex = 87;
            this.gbArtists.TabStop = false;
            this.gbArtists.Text = "Featured Artists";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderLength
            // 
            this.errorProviderLength.ContainerControl = this;
            // 
            // errorProviderMainArtist
            // 
            this.errorProviderMainArtist.ContainerControl = this;
            // 
            // ucTrackUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbArtists);
            this.Name = "ucTrackUpsert";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucTrackEdit_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbArtists.ResumeLayout(false);
            this.gbArtists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMainArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.ComboBox cbFeaturedArtist;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.ComboBox cbMainArtist;
        private System.Windows.Forms.ListBox lbFeaturedArtists;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRemoveGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbArtists;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderLength;
        private System.Windows.Forms.ErrorProvider errorProviderMainArtist;
    }
}
