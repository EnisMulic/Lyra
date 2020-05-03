namespace Lyra.WinUI.SignUp
{
    partial class ucSignUp
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPasswordConfirm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPasswordConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(35, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(322, 26);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.Username_Validating);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(35, 469);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(322, 39);
            this.btnSignUp.TabIndex = 29;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(32, 383);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(91, 13);
            this.lblPasswordConfirm.TabIndex = 28;
            this.lblPasswordConfirm.Text = "Confirm Password";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(35, 399);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(322, 26);
            this.txtPasswordConfirm.TabIndex = 27;
            this.txtPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordConfirm_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 323);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(35, 339);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(322, 26);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Password_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(32, 265);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(35, 281);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(322, 26);
            this.txtPhone.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 207);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(35, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 26);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(32, 88);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(35, 104);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(322, 26);
            this.txtLastName.TabIndex = 17;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(32, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(35, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(322, 26);
            this.txtFirstName.TabIndex = 15;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderPasswordConfirm
            // 
            this.errorProviderPasswordConfirm.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // ucSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "ucSignUp";
            this.Size = new System.Drawing.Size(387, 542);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPasswordConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderPasswordConfirm;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
    }
}
