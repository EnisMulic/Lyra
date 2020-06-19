namespace Lyra.WinUI.UserControls.Administrator.Analytics
{
    partial class ucAnalytics
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cbResource = new System.Windows.Forms.ComboBox();
            this.nudTopN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopN)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColorTransparent = true;
            this.cartesianChart1.ForeColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Location = new System.Drawing.Point(45, 116);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(699, 539);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // cbResource
            // 
            this.cbResource.FormattingEnabled = true;
            this.cbResource.Location = new System.Drawing.Point(45, 73);
            this.cbResource.Name = "cbResource";
            this.cbResource.Size = new System.Drawing.Size(119, 21);
            this.cbResource.TabIndex = 2;
            this.cbResource.SelectedValueChanged += new System.EventHandler(this.cbResource_SelectedValueChanged);
            // 
            // nudTopN
            // 
            this.nudTopN.Location = new System.Drawing.Point(181, 73);
            this.nudTopN.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTopN.Name = "nudTopN";
            this.nudTopN.Size = new System.Drawing.Size(119, 20);
            this.nudTopN.TabIndex = 3;
            this.nudTopN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTopN.ValueChanged += new System.EventHandler(this.nudTopN_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Views";
            // 
            // ucAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTopN);
            this.Controls.Add(this.cbResource);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "ucAnalytics";
            this.Size = new System.Drawing.Size(796, 690);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox cbResource;
        private System.Windows.Forms.NumericUpDown nudTopN;
        private System.Windows.Forms.Label label1;
    }
}
