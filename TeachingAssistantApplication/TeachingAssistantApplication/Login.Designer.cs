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
            this.uxUsername.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsername.Location = new System.Drawing.Point(107, 240);
            this.uxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxUsername.Multiline = true;
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(232, 36);
            this.uxUsername.TabIndex = 2;
            // 
            // uxLogin
            // 
            this.uxLogin.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogin.Location = new System.Drawing.Point(79, 357);
            this.uxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(133, 49);
            this.uxLogin.TabIndex = 9;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.UxLoginButton_Click);
            // 
            // uxInstructorSelection
            // 
            this.uxInstructorSelection.AutoSize = true;
            this.uxInstructorSelection.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInstructorSelection.Location = new System.Drawing.Point(107, 193);
            this.uxInstructorSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxInstructorSelection.Name = "uxInstructorSelection";
            this.uxInstructorSelection.Size = new System.Drawing.Size(109, 21);
            this.uxInstructorSelection.TabIndex = 4;
            this.uxInstructorSelection.TabStop = true;
            this.uxInstructorSelection.Text = "Instructor";
            this.uxInstructorSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxInstructorSelection.UseVisualStyleBackColor = true;
            // 
            // uxStudentSelection
            // 
            this.uxStudentSelection.AutoSize = true;
            this.uxStudentSelection.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStudentSelection.Location = new System.Drawing.Point(259, 193);
            this.uxStudentSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxStudentSelection.Name = "uxStudentSelection";
            this.uxStudentSelection.Size = new System.Drawing.Size(85, 21);
            this.uxStudentSelection.TabIndex = 5;
            this.uxStudentSelection.TabStop = true;
            this.uxStudentSelection.Text = "Student";
            this.uxStudentSelection.UseVisualStyleBackColor = true;
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(221, 357);
            this.uxExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(133, 49);
            this.uxExit.TabIndex = 7;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.UxExit_Click);
            // 
            // uxUsernameLbl
            // 
            this.uxUsernameLbl.AutoSize = true;
            this.uxUsernameLbl.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameLbl.Location = new System.Drawing.Point(21, 250);
            this.uxUsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(80, 17);
            this.uxUsernameLbl.TabIndex = 8;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(107, 284);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxPassword.Multiline = true;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '•';
            this.uxPassword.Size = new System.Drawing.Size(232, 36);
            this.uxPassword.TabIndex = 3;
            // 
            // uxPasswordLbl
            // 
            this.uxPasswordLbl.AutoSize = true;
            this.uxPasswordLbl.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPasswordLbl.Location = new System.Drawing.Point(21, 294);
            this.uxPasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPasswordLbl.Name = "uxPasswordLbl";
            this.uxPasswordLbl.Size = new System.Drawing.Size(80, 17);
            this.uxPasswordLbl.TabIndex = 10;
            this.uxPasswordLbl.Text = "Password:";
            // 
            // uxRegisterLink
            // 
            this.uxRegisterLink.AutoSize = true;
            this.uxRegisterLink.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRegisterLink.Location = new System.Drawing.Point(181, 410);
            this.uxRegisterLink.Name = "uxRegisterLink";
            this.uxRegisterLink.Size = new System.Drawing.Size(72, 17);
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
            this.pictureBox1.Location = new System.Drawing.Point(121, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // uxErrorLabel
            // 
            this.uxErrorLabel.AutoSize = true;
            this.uxErrorLabel.Location = new System.Drawing.Point(197, 324);
            this.uxErrorLabel.Name = "uxErrorLabel";
            this.uxErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.uxErrorLabel.TabIndex = 12;
            this.uxErrorLabel.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 439);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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