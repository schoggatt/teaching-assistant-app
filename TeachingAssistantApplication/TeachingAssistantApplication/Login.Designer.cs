namespace TeachingAssistantApplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.uxUsername = new System.Windows.Forms.TextBox();
            this.uxLogin = new System.Windows.Forms.Button();
            this.uxInstructorSelection = new System.Windows.Forms.RadioButton();
            this.uxStudentSelection = new System.Windows.Forms.RadioButton();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxUsernameLbl = new System.Windows.Forms.Label();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxPasswordLbl = new System.Windows.Forms.Label();
            this.uxRegisterLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxUsername
            // 
            this.uxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsername.Location = new System.Drawing.Point(80, 195);
            this.uxUsername.Multiline = true;
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(175, 30);
            this.uxUsername.TabIndex = 2;
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(59, 290);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(100, 40);
            this.uxLogin.TabIndex = 9;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.UxLoginButton_Click);
            // 
            // uxInstructorSelection
            // 
            this.uxInstructorSelection.AutoSize = true;
            this.uxInstructorSelection.Location = new System.Drawing.Point(80, 157);
            this.uxInstructorSelection.Name = "uxInstructorSelection";
            this.uxInstructorSelection.Size = new System.Drawing.Size(69, 17);
            this.uxInstructorSelection.TabIndex = 4;
            this.uxInstructorSelection.TabStop = true;
            this.uxInstructorSelection.Text = "Instructor";
            this.uxInstructorSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxInstructorSelection.UseVisualStyleBackColor = true;
            // 
            // uxStudentSelection
            // 
            this.uxStudentSelection.AutoSize = true;
            this.uxStudentSelection.Location = new System.Drawing.Point(194, 157);
            this.uxStudentSelection.Name = "uxStudentSelection";
            this.uxStudentSelection.Size = new System.Drawing.Size(62, 17);
            this.uxStudentSelection.TabIndex = 5;
            this.uxStudentSelection.TabStop = true;
            this.uxStudentSelection.Text = "Student";
            this.uxStudentSelection.UseVisualStyleBackColor = true;
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(166, 290);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(100, 40);
            this.uxExit.TabIndex = 7;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.UxExit_Click);
            // 
            // uxUsernameLbl
            // 
            this.uxUsernameLbl.AutoSize = true;
            this.uxUsernameLbl.Location = new System.Drawing.Point(16, 203);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(58, 13);
            this.uxUsernameLbl.TabIndex = 8;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(80, 231);
            this.uxPassword.Multiline = true;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '•';
            this.uxPassword.Size = new System.Drawing.Size(175, 30);
            this.uxPassword.TabIndex = 3;
            // 
            // uxPasswordLbl
            // 
            this.uxPasswordLbl.AutoSize = true;
            this.uxPasswordLbl.Location = new System.Drawing.Point(16, 239);
            this.uxPasswordLbl.Name = "uxPasswordLbl";
            this.uxPasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.uxPasswordLbl.TabIndex = 10;
            this.uxPasswordLbl.Text = "Password:";
            // 
            // uxRegisterLink
            // 
            this.uxRegisterLink.AutoSize = true;
            this.uxRegisterLink.Location = new System.Drawing.Point(136, 333);
            this.uxRegisterLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxRegisterLink.Name = "uxRegisterLink";
            this.uxRegisterLink.Size = new System.Drawing.Size(46, 13);
            this.uxRegisterLink.TabIndex = 11;
            this.uxRegisterLink.TabStop = true;
            this.uxRegisterLink.Text = "Register";
            this.uxRegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UxRegisterLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // uxErrorLabel
            // 
            this.uxErrorLabel.AutoSize = true;
            this.uxErrorLabel.Location = new System.Drawing.Point(148, 263);
            this.uxErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxErrorLabel.Name = "uxErrorLabel";
            this.uxErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.uxErrorLabel.TabIndex = 12;
            this.uxErrorLabel.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 357);
            this.Controls.Add(this.uxErrorLabel);
            this.Controls.Add(this.uxRegisterLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uxPasswordLbl);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsernameLbl);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxStudentSelection);
            this.Controls.Add(this.uxInstructorSelection);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.RadioButton uxInstructorSelection;
        private System.Windows.Forms.RadioButton uxStudentSelection;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Label uxUsernameLbl;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label uxPasswordLbl;
        private System.Windows.Forms.LinkLabel uxRegisterLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label uxErrorLabel;
    }
}