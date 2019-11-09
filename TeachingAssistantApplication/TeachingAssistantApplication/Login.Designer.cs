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
            this.uxLogin = new System.Windows.Forms.TextBox();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.uxInstructorSelection = new System.Windows.Forms.RadioButton();
            this.uxStudentSelection = new System.Windows.Forms.RadioButton();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxUsernameLbl = new System.Windows.Forms.Label();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxPasswordLbl = new System.Windows.Forms.Label();
            this.uxRegisterLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLogin
            // 
            this.uxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogin.Location = new System.Drawing.Point(88, 199);
            this.uxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogin.Location = new System.Drawing.Point(121, 260);
            this.uxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLogin.Multiline = true;
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(232, 36);
            this.uxLogin.TabIndex = 2;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(67, 282);
            this.uxLoginButton.Location = new System.Drawing.Point(93, 362);
            this.uxLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(133, 49);
            this.uxLoginButton.TabIndex = 3;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.UxLoginButton_Click);
            // 
            // uxInstructorSelection
            // 
            this.uxInstructorSelection.AutoSize = true;
            this.uxInstructorSelection.Location = new System.Drawing.Point(88, 161);
            this.uxInstructorSelection.Name = "uxInstructorSelection";
            this.uxInstructorSelection.Size = new System.Drawing.Size(69, 17);
            this.uxInstructorSelection.TabIndex = 4;
            this.uxInstructorSelection.TabStop = true;
            this.uxInstructorSelection.Text = "Instructor";
            this.uxInstructorSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxInstructorSelection.UseVisualStyleBackColor = true;
            this.uxInstructor.AutoSize = true;
            this.uxInstructor.Location = new System.Drawing.Point(121, 213);
            this.uxInstructor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxInstructor.Name = "uxInstructor";
            this.uxInstructor.Size = new System.Drawing.Size(88, 21);
            this.uxInstructor.TabIndex = 4;
            this.uxInstructor.TabStop = true;
            this.uxInstructor.Text = "Instructor";
            this.uxInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxInstructor.UseVisualStyleBackColor = true;
            // 
            // uxStudentSelection
            // 
            this.uxStudentSelection.AutoSize = true;
            this.uxStudentSelection.Location = new System.Drawing.Point(201, 161);
            this.uxStudentSelection.Location = new System.Drawing.Point(272, 213);
            this.uxStudentSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxStudentSelection.Name = "uxStudentSelection";
            this.uxStudentSelection.Size = new System.Drawing.Size(78, 21);
            this.uxStudentSelection.TabIndex = 5;
            this.uxStudentSelection.TabStop = true;
            this.uxStudentSelection.Text = "Student";
            this.uxStudentSelection.UseVisualStyleBackColor = true;
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(173, 282);
            this.uxExit.Location = new System.Drawing.Point(235, 362);
            this.uxExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(133, 49);
            this.uxExit.TabIndex = 7;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            // 
            // uxUsernameLbl
            // 
            this.uxUsernameLbl.AutoSize = true;
            this.uxUsernameLbl.Location = new System.Drawing.Point(24, 207);
            this.uxUsernameLbl.Location = new System.Drawing.Point(36, 270);
            this.uxUsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(77, 17);
            this.uxUsernameLbl.TabIndex = 8;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(88, 235);
            this.uxPassword.Multiline = true;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '•';
            this.uxPassword.Size = new System.Drawing.Size(175, 30);
            this.uxPassword.Location = new System.Drawing.Point(121, 304);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxPassword.Multiline = true;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(232, 36);
            this.uxPassword.TabIndex = 9;
            // 
            // uxPasswordLbl
            // 
            this.uxPasswordLbl.AutoSize = true;
            this.uxPasswordLbl.Location = new System.Drawing.Point(24, 243);
            this.uxPasswordLbl.Location = new System.Drawing.Point(36, 314);
            this.uxPasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPasswordLbl.Name = "uxPasswordLbl";
            this.uxPasswordLbl.Size = new System.Drawing.Size(73, 17);
            this.uxPasswordLbl.TabIndex = 10;
            this.uxPasswordLbl.Text = "Password:";
            // 
            // uxRegisterLink
            // 
            this.uxRegisterLink.AutoSize = true;
            this.uxRegisterLink.Location = new System.Drawing.Point(140, 335);
            this.uxRegisterLink.Name = "uxRegisterLink";
            this.uxRegisterLink.Size = new System.Drawing.Size(46, 13);
            this.uxRegisterLink.TabIndex = 11;
            this.uxRegisterLink.TabStop = true;
            this.uxRegisterLink.Text = "Register";
            this.uxRegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UxRegisterLink_LinkClicked);
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 357);
            this.Controls.Add(this.uxRegisterLink);
            this.ClientSize = new System.Drawing.Size(413, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uxPasswordLbl);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsernameLbl);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxStudentSelection);
            this.Controls.Add(this.uxInstructorSelection);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxLogin;
        private System.Windows.Forms.Button uxLoginButton;
        private System.Windows.Forms.RadioButton uxInstructorSelection;
        private System.Windows.Forms.RadioButton uxStudentSelection;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Label uxUsernameLbl;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label uxPasswordLbl;
        private System.Windows.Forms.LinkLabel uxRegisterLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}