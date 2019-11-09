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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxLogin = new System.Windows.Forms.TextBox();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.uxInstructor = new System.Windows.Forms.RadioButton();
            this.uxStudentSelection = new System.Windows.Forms.RadioButton();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxUsernameLbl = new System.Windows.Forms.Label();
            this.uxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).BeginInit();
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
            this.uxLogin.Location = new System.Drawing.Point(71, 231);
            this.uxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLogin.Multiline = true;
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(232, 36);
            this.uxLogin.TabIndex = 2;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(49, 289);
            this.uxLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(133, 49);
            this.uxLoginButton.TabIndex = 3;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            // 
            // uxInstructor
            // 
            this.uxInstructor.AutoSize = true;
            this.uxInstructor.Location = new System.Drawing.Point(71, 161);
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
            this.uxStudentSelection.Location = new System.Drawing.Point(221, 161);
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
            this.uxExit.Location = new System.Drawing.Point(191, 289);
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
            this.uxUsernameLbl.Location = new System.Drawing.Point(144, 212);
            this.uxUsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUsernameLbl.Name = "uxUsernameLbl";
            this.uxUsernameLbl.Size = new System.Drawing.Size(77, 17);
            this.uxUsernameLbl.TabIndex = 8;
            this.uxUsernameLbl.Text = "Username:";
            // 
            // uxLogo
            // 
            this.uxLogo.Image = ((System.Drawing.Image)(resources.GetObject("uxLogo.Image")));
            this.uxLogo.Location = new System.Drawing.Point(134, 30);
            this.uxLogo.Name = "uxLogo";
            this.uxLogo.Size = new System.Drawing.Size(114, 100);
            this.uxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uxLogo.TabIndex = 9;
            this.uxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 369);
            this.Controls.Add(this.uxLogo);
            this.Controls.Add(this.uxUsernameLbl);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxStudentSelection);
            this.Controls.Add(this.uxInstructor);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox uxLogin;
        private System.Windows.Forms.Button uxLoginButton;
        private System.Windows.Forms.RadioButton uxInstructor;
        private System.Windows.Forms.RadioButton uxStudentSelection;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Label uxUsernameLbl;
        private System.Windows.Forms.PictureBox uxLogo;
    }
}