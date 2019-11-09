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
            this.uxLogo = new System.Windows.Forms.PictureBox();
            this.uxErrorLabel = new System.Windows.Forms.Label();
            this.uxLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uxExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uxStudentSelection = new LollipopRadioButton();
            this.uxInstructorSelection = new LollipopRadioButton();
            this.uxPassword = new LollipopTextBox();
            this.uxUsername = new LollipopTextBox();
            this.uxPasswordLbl = new LollipopLabel();
            this.uxUsernameLbl = new LollipopLabel();
            this.uxRegisterLink = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLogo
            // 
            this.uxLogo.Image = ((System.Drawing.Image)(resources.GetObject("uxLogo.Image")));
            this.uxLogo.Location = new System.Drawing.Point(136, 86);
            this.uxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxLogo.Name = "uxLogo";
            this.uxLogo.Size = new System.Drawing.Size(132, 104);
            this.uxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uxLogo.TabIndex = 11;
            this.uxLogo.TabStop = false;
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
            // uxLogin
            // 
            this.uxLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxLogin.Depth = 0;
            this.uxLogin.Icon = null;
            this.uxLogin.Location = new System.Drawing.Point(85, 337);
            this.uxLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Primary = true;
            this.uxLogin.Size = new System.Drawing.Size(112, 50);
            this.uxLogin.TabIndex = 19;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // uxExit
            // 
            this.uxExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxExit.Depth = 0;
            this.uxExit.Icon = null;
            this.uxExit.Location = new System.Drawing.Point(203, 337);
            this.uxExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxExit.Name = "uxExit";
            this.uxExit.Primary = true;
            this.uxExit.Size = new System.Drawing.Size(105, 50);
            this.uxExit.TabIndex = 20;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxStudentSelection
            // 
            this.uxStudentSelection.AutoSize = true;
            this.uxStudentSelection.CheckColor = "#ff0033";
            this.uxStudentSelection.Location = new System.Drawing.Point(240, 195);
            this.uxStudentSelection.Name = "uxStudentSelection";
            this.uxStudentSelection.Size = new System.Drawing.Size(85, 19);
            this.uxStudentSelection.TabIndex = 18;
            this.uxStudentSelection.TabStop = true;
            this.uxStudentSelection.Text = "Student";
            this.uxStudentSelection.UseVisualStyleBackColor = true;
            // 
            // uxInstructorSelection
            // 
            this.uxInstructorSelection.AutoSize = true;
            this.uxInstructorSelection.CheckColor = "#ff0033";
            this.uxInstructorSelection.Location = new System.Drawing.Point(112, 195);
            this.uxInstructorSelection.Name = "uxInstructorSelection";
            this.uxInstructorSelection.Size = new System.Drawing.Size(100, 19);
            this.uxInstructorSelection.TabIndex = 17;
            this.uxInstructorSelection.TabStop = true;
            this.uxInstructorSelection.Text = "Instructor";
            this.uxInstructorSelection.UseVisualStyleBackColor = true;
            // 
            // uxPassword
            // 
            this.uxPassword.FocusedColor = "#ff0033";
            this.uxPassword.FontColor = "#999999";
            this.uxPassword.IsEnabled = true;
            this.uxPassword.Location = new System.Drawing.Point(106, 286);
            this.uxPassword.MaxLength = 32767;
            this.uxPassword.Multiline = false;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.ReadOnly = false;
            this.uxPassword.Size = new System.Drawing.Size(265, 24);
            this.uxPassword.TabIndex = 16;
            this.uxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxPassword.UseSystemPasswordChar = false;
            // 
            // uxUsername
            // 
            this.uxUsername.FocusedColor = "#ff0033";
            this.uxUsername.FontColor = "#999999";
            this.uxUsername.IsEnabled = true;
            this.uxUsername.Location = new System.Drawing.Point(106, 244);
            this.uxUsername.MaxLength = 32767;
            this.uxUsername.Multiline = false;
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.ReadOnly = false;
            this.uxUsername.Size = new System.Drawing.Size(265, 24);
            this.uxUsername.TabIndex = 15;
            this.uxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxUsername.UseSystemPasswordChar = false;
            // 
            // uxPasswordLbl
            // 
            this.uxPasswordLbl.AutoSize = true;
            this.uxPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.uxPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxPasswordLbl.Location = new System.Drawing.Point(8, 288);
            this.uxPasswordLbl.Name = "uxPasswordLbl";
            this.uxPasswordLbl.Size = new System.Drawing.Size(93, 20);
            this.uxPasswordLbl.TabIndex = 14;
            this.uxPasswordLbl.Text = "Password: ";
            // 
            // uxUsernameLbl
            // 
            this.uxUsernameLbl.AutoSize = true;
            this.uxUsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.uxUsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxUsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxUsernameLbl.Location = new System.Drawing.Point(8, 244);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(91, 20);
            this.uxUsernameLbl.TabIndex = 13;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxRegisterLink
            // 
            this.uxRegisterLink.AutoSize = true;
            this.uxRegisterLink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxRegisterLink.Depth = 0;
            this.uxRegisterLink.Icon = null;
            this.uxRegisterLink.Location = new System.Drawing.Point(145, 402);
            this.uxRegisterLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxRegisterLink.Name = "uxRegisterLink";
            this.uxRegisterLink.Primary = true;
            this.uxRegisterLink.Size = new System.Drawing.Size(100, 36);
            this.uxRegisterLink.TabIndex = 21;
            this.uxRegisterLink.Text = "Register";
            this.uxRegisterLink.UseVisualStyleBackColor = true;
            this.uxRegisterLink.Click += new System.EventHandler(this.uxRegisterLink_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.uxRegisterLink);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxStudentSelection);
            this.Controls.Add(this.uxInstructorSelection);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPasswordLbl);
            this.Controls.Add(this.uxUsernameLbl);
            this.Controls.Add(this.uxErrorLabel);
            this.Controls.Add(this.uxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox uxLogo;
        private System.Windows.Forms.Label uxErrorLabel;
        private LollipopLabel uxUsernameLbl;
        private LollipopLabel uxPasswordLbl;
        private LollipopTextBox uxUsername;
        private LollipopTextBox uxPassword;
        private LollipopRadioButton uxInstructorSelection;
        private LollipopRadioButton uxStudentSelection;
        private MaterialSkin.Controls.MaterialRaisedButton uxLogin;
        private MaterialSkin.Controls.MaterialRaisedButton uxExit;
        private MaterialSkin.Controls.MaterialRaisedButton uxRegisterLink;
    }
}