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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxLogin = new System.Windows.Forms.TextBox();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.uxInstructor = new System.Windows.Forms.RadioButton();
            this.uxStudentSelection = new System.Windows.Forms.RadioButton();
            this.uxTitle = new System.Windows.Forms.Label();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxUsernameLbl = new System.Windows.Forms.Label();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxLogin
            // 
            this.uxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogin.Location = new System.Drawing.Point(91, 211);
            this.uxLogin.Multiline = true;
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(175, 30);
            this.uxLogin.TabIndex = 2;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(70, 294);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(100, 40);
            this.uxLoginButton.TabIndex = 3;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.UxLoginButton_Click);
            // 
            // uxInstructor
            // 
            this.uxInstructor.AutoSize = true;
            this.uxInstructor.Location = new System.Drawing.Point(91, 173);
            this.uxInstructor.Name = "uxInstructor";
            this.uxInstructor.Size = new System.Drawing.Size(69, 17);
            this.uxInstructor.TabIndex = 4;
            this.uxInstructor.TabStop = true;
            this.uxInstructor.Text = "Instructor";
            this.uxInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxInstructor.UseVisualStyleBackColor = true;
            // 
            // uxStudentSelection
            // 
            this.uxStudentSelection.AutoSize = true;
            this.uxStudentSelection.Location = new System.Drawing.Point(204, 173);
            this.uxStudentSelection.Name = "uxStudentSelection";
            this.uxStudentSelection.Size = new System.Drawing.Size(62, 17);
            this.uxStudentSelection.TabIndex = 5;
            this.uxStudentSelection.TabStop = true;
            this.uxStudentSelection.Text = "Student";
            this.uxStudentSelection.UseVisualStyleBackColor = true;
            // 
            // uxTitle
            // 
            this.uxTitle.AutoSize = true;
            this.uxTitle.Location = new System.Drawing.Point(88, 100);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(148, 13);
            this.uxTitle.TabIndex = 6;
            this.uxTitle.Text = "insert cool title mybe an image";
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(176, 294);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(100, 40);
            this.uxExit.TabIndex = 7;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            // 
            // uxUsernameLbl
            // 
            this.uxUsernameLbl.AutoSize = true;
            this.uxUsernameLbl.Location = new System.Drawing.Point(27, 219);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(58, 13);
            this.uxUsernameLbl.TabIndex = 8;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(91, 247);
            this.uxPassword.Multiline = true;
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(175, 30);
            this.uxPassword.TabIndex = 9;
            // 
            // uxPasswordLbl
            // 
            this.uxPasswordLbl.AutoSize = true;
            this.uxPasswordLbl.Location = new System.Drawing.Point(27, 255);
            this.uxPasswordLbl.Name = "uxPasswordLbl";
            this.uxPasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.uxPasswordLbl.TabIndex = 10;
            this.uxPasswordLbl.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 357);
            this.Controls.Add(this.uxPasswordLbl);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsernameLbl);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxTitle);
            this.Controls.Add(this.uxStudentSelection);
            this.Controls.Add(this.uxInstructor);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox uxLogin;
        private System.Windows.Forms.Button uxLoginButton;
        private System.Windows.Forms.RadioButton uxInstructor;
        private System.Windows.Forms.RadioButton uxStudentSelection;
        private System.Windows.Forms.Label uxTitle;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Label uxUsernameLbl;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label uxPasswordLbl;
    }
}