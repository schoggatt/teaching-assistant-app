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
            this.uxErrorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxRegisterLink = new LollipopButton();
            this.uxExit = new LollipopButton();
            this.uxLogin = new LollipopButton();
            this.uxPassword = new LollipopTextBox();
            this.uxUsername = new LollipopTextBox();
            this.uxPasswordLbl = new LollipopLabel();
            this.uxUsernameLbl = new LollipopLabel();
            this.uxStudentSelection = new LollipopRadioButton();
            this.uxInstructorSelection = new LollipopRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uxErrorLabel
            // 
            this.uxErrorLabel.AutoSize = true;
            this.uxErrorLabel.Location = new System.Drawing.Point(149, 289);
            this.uxErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxErrorLabel.Name = "uxErrorLabel";
            this.uxErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.uxErrorLabel.TabIndex = 12;
            this.uxErrorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // uxRegisterLink
            // 
            this.uxRegisterLink.BackColor = System.Drawing.Color.Transparent;
            this.uxRegisterLink.BGColor = "#ff0033";
            this.uxRegisterLink.FontColor = "#ffffff";
            this.uxRegisterLink.Location = new System.Drawing.Point(108, 327);
            this.uxRegisterLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxRegisterLink.Name = "uxRegisterLink";
            this.uxRegisterLink.Size = new System.Drawing.Size(107, 33);
            this.uxRegisterLink.TabIndex = 22;
            this.uxRegisterLink.Text = "Register";
            this.uxRegisterLink.Click += new System.EventHandler(this.UxRegisterLink_Clicked);
            // 
            // uxExit
            // 
            this.uxExit.BackColor = System.Drawing.Color.Transparent;
            this.uxExit.BGColor = "#ff0033";
            this.uxExit.FontColor = "#ffffff";
            this.uxExit.Location = new System.Drawing.Point(167, 289);
            this.uxExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(107, 33);
            this.uxExit.TabIndex = 21;
            this.uxExit.Text = "Exit";
            this.uxExit.Click += new System.EventHandler(this.UxExit_Click);
            // 
            // uxLogin
            // 
            this.uxLogin.BackColor = System.Drawing.Color.Transparent;
            this.uxLogin.BGColor = "#ff0033";
            this.uxLogin.FontColor = "#ffffff";
            this.uxLogin.Location = new System.Drawing.Point(50, 289);
            this.uxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(107, 33);
            this.uxLogin.TabIndex = 20;
            this.uxLogin.Text = "Login";
            this.uxLogin.Click += new System.EventHandler(this.UxLoginButton_Click);
            // 
            // uxPassword
            // 
            this.uxPassword.FocusedColor = "#ff0033";
            this.uxPassword.FontColor = "#999999";
            this.uxPassword.IsEnabled = true;
            this.uxPassword.Location = new System.Drawing.Point(82, 246);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPassword.MaxLength = 32767;
            this.uxPassword.Multiline = false;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.ReadOnly = false;
            this.uxPassword.Size = new System.Drawing.Size(200, 24);
            this.uxPassword.TabIndex = 18;
            this.uxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxPassword.UseSystemPasswordChar = true;
            // 
            // uxUsername
            // 
            this.uxUsername.FocusedColor = "#ff0033";
            this.uxUsername.FontColor = "#999999";
            this.uxUsername.IsEnabled = true;
            this.uxUsername.Location = new System.Drawing.Point(82, 212);
            this.uxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxUsername.MaxLength = 32767;
            this.uxUsername.Multiline = false;
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.ReadOnly = false;
            this.uxUsername.Size = new System.Drawing.Size(200, 24);
            this.uxUsername.TabIndex = 17;
            this.uxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxUsername.UseSystemPasswordChar = false;
            // 
            // uxPasswordLbl
            // 
            this.uxPasswordLbl.AutoSize = true;
            this.uxPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.uxPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxPasswordLbl.Location = new System.Drawing.Point(8, 248);
            this.uxPasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPasswordLbl.Name = "uxPasswordLbl";
            this.uxPasswordLbl.Size = new System.Drawing.Size(73, 17);
            this.uxPasswordLbl.TabIndex = 16;
            this.uxPasswordLbl.Text = "Password:";
            // 
            // uxUsernameLbl
            // 
            this.uxUsernameLbl.AutoSize = true;
            this.uxUsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.uxUsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxUsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxUsernameLbl.Location = new System.Drawing.Point(8, 212);
            this.uxUsernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(77, 17);
            this.uxUsernameLbl.TabIndex = 15;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxStudentSelection
            // 
            this.uxStudentSelection.AutoSize = true;
            this.uxStudentSelection.CheckColor = "#ff0033";
            this.uxStudentSelection.Location = new System.Drawing.Point(167, 172);
            this.uxStudentSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxStudentSelection.Name = "uxStudentSelection";
            this.uxStudentSelection.Size = new System.Drawing.Size(72, 19);
            this.uxStudentSelection.TabIndex = 14;
            this.uxStudentSelection.TabStop = true;
            this.uxStudentSelection.Text = "Student";
            this.uxStudentSelection.UseVisualStyleBackColor = true;
            // 
            // uxInstructorSelection
            // 
            this.uxInstructorSelection.AutoSize = true;
            this.uxInstructorSelection.CheckColor = "#ff0033";
            this.uxInstructorSelection.Location = new System.Drawing.Point(82, 172);
            this.uxInstructorSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInstructorSelection.Name = "uxInstructorSelection";
            this.uxInstructorSelection.Size = new System.Drawing.Size(84, 19);
            this.uxInstructorSelection.TabIndex = 13;
            this.uxInstructorSelection.TabStop = true;
            this.uxInstructorSelection.Text = "Instructor";
            this.uxInstructorSelection.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 380);
            this.Controls.Add(this.uxRegisterLink);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPasswordLbl);
            this.Controls.Add(this.uxUsernameLbl);
            this.Controls.Add(this.uxStudentSelection);
            this.Controls.Add(this.uxInstructorSelection);
            this.Controls.Add(this.uxErrorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label uxErrorLabel;
        private LollipopRadioButton uxInstructorSelection;
        private LollipopRadioButton uxStudentSelection;
        private LollipopLabel uxUsernameLbl;
        private LollipopLabel uxPasswordLbl;
        private LollipopTextBox uxUsername;
        private LollipopButton uxLogin;
        private LollipopButton uxExit;
        private LollipopButton uxRegisterLink;
        private LollipopTextBox uxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}