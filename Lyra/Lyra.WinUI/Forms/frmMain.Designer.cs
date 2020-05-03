namespace Lyra.WinUI
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSignInUC = new System.Windows.Forms.Button();
            this.btnSingUpUC = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ucAppControl = new Lyra.WinUI.UserControls.Shared.ucAppControl();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(90)))), ((int)(((byte)(182)))));
            this.pnlEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmpty.Location = new System.Drawing.Point(0, 0);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(384, 652);
            this.pnlEmpty.TabIndex = 0;
            this.pnlEmpty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pnlEmpty.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(384, 98);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(402, 554);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btnSignInUC
            // 
            this.btnSignInUC.FlatAppearance.BorderSize = 0;
            this.btnSignInUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInUC.Location = new System.Drawing.Point(402, 51);
            this.btnSignInUC.Name = "btnSignInUC";
            this.btnSignInUC.Size = new System.Drawing.Size(96, 34);
            this.btnSignInUC.TabIndex = 2;
            this.btnSignInUC.TabStop = false;
            this.btnSignInUC.Text = "Sign In";
            this.btnSignInUC.UseVisualStyleBackColor = true;
            this.btnSignInUC.Click += new System.EventHandler(this.btnSignInUC_Click);
            // 
            // btnSingUpUC
            // 
            this.btnSingUpUC.FlatAppearance.BorderSize = 0;
            this.btnSingUpUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUpUC.Location = new System.Drawing.Point(504, 51);
            this.btnSingUpUC.Name = "btnSingUpUC";
            this.btnSingUpUC.Size = new System.Drawing.Size(96, 34);
            this.btnSingUpUC.TabIndex = 3;
            this.btnSingUpUC.TabStop = false;
            this.btnSingUpUC.Text = "Sign Up";
            this.btnSingUpUC.UseVisualStyleBackColor = true;
            this.btnSingUpUC.Click += new System.EventHandler(this.btnSingUpUC_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.ucAppControl);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(384, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(402, 37);
            this.pnlHeader.TabIndex = 4;
            // 
            // ucAppControl
            // 
            this.ucAppControl.Location = new System.Drawing.Point(331, 0);
            this.ucAppControl.Name = "ucAppControl";
            this.ucAppControl.Size = new System.Drawing.Size(71, 35);
            this.ucAppControl.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 652);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnSingUpUC);
            this.Controls.Add(this.btnSignInUC);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlEmpty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.btnSignInUC_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpty;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSignInUC;
        private System.Windows.Forms.Button btnSingUpUC;
        private System.Windows.Forms.Panel pnlHeader;
        private UserControls.Shared.ucAppControl ucAppControl;
    }
}