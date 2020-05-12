namespace Lyra.WinUI.UserControls.Administrator.Genre
{
    partial class ucGenreList
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPageNumber = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 22);
            this.txtSearch.TabIndex = 34;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(747, 611);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 30);
            this.btnNext.TabIndex = 33;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPageNumber
            // 
            this.btnPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumber.Location = new System.Drawing.Point(708, 611);
            this.btnPageNumber.Name = "btnPageNumber";
            this.btnPageNumber.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumber.TabIndex = 32;
            this.btnPageNumber.Text = "1";
            this.btnPageNumber.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(669, 611);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(33, 30);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Location = new System.Drawing.Point(17, 79);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            this.dgvGenres.Size = new System.Drawing.Size(763, 526);
            this.dgvGenres.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Lyra.WinUI.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(192, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.BackgroundImage = global::Lyra.WinUI.Properties.Resources.delete;
            this.btnDeleteGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteGenre.FlatAppearance.BorderSize = 0;
            this.btnDeleteGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGenre.Location = new System.Drawing.Point(321, 50);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteGenre.TabIndex = 30;
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.BackgroundImage = global::Lyra.WinUI.Properties.Resources.edit;
            this.btnEditGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditGenre.FlatAppearance.BorderSize = 0;
            this.btnEditGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGenre.Location = new System.Drawing.Point(277, 50);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(28, 23);
            this.btnEditGenre.TabIndex = 29;
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackgroundImage = global::Lyra.WinUI.Properties.Resources.add;
            this.btnAddGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGenre.FlatAppearance.BorderSize = 0;
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddGenre.Location = new System.Drawing.Point(233, 50);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(28, 23);
            this.btnAddGenre.TabIndex = 28;
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // ucGenreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageNumber);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnEditGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.dgvGenres);
            this.Name = "ucGenreList";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucGenreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPageNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.DataGridView dgvGenres;
    }
}
