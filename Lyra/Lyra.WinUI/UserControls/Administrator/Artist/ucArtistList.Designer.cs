namespace Lyra.WinUI.UserControls.Administrator.Artist
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageNumber = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
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
            this.btnDeleteArtist.BackgroundImage = global::Lyra.WinUI.Properties.Resources.delete;
            this.btnDeleteArtist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteArtist.FlatAppearance.BorderSize = 0;
            this.btnDeleteArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArtist.Location = new System.Drawing.Point(104, 53);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteArtist.TabIndex = 7;
            this.btnDeleteArtist.UseVisualStyleBackColor = true;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.BackgroundImage = global::Lyra.WinUI.Properties.Resources.edit;
            this.btnEditArtist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditArtist.FlatAppearance.BorderSize = 0;
            this.btnEditArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditArtist.Location = new System.Drawing.Point(60, 53);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Size = new System.Drawing.Size(28, 23);
            this.btnEditArtist.TabIndex = 6;
            this.btnEditArtist.UseVisualStyleBackColor = true;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.BackgroundImage = global::Lyra.WinUI.Properties.Resources.add;
            this.btnAddArtist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddArtist.FlatAppearance.BorderSize = 0;
            this.btnAddArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddArtist.Location = new System.Drawing.Point(16, 53);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(28, 23);
            this.btnAddArtist.TabIndex = 5;
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
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
            // ucArtistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
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
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
    }
}
