namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    partial class ucTrackEdit
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(83, 129);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 148);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(188, 20);
            this.txtID.TabIndex = 20;
            this.txtID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 187);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(83, 260);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(188, 20);
            this.txtLength.TabIndex = 22;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(83, 244);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 23;
            this.lblLength.Text = "Length";
            // 
            // ucTrackEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "ucTrackEdit";
            this.Size = new System.Drawing.Size(617, 578);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
    }
}
