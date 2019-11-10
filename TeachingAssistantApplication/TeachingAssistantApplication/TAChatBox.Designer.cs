namespace TeachingAssistantApplication
{
    partial class TAChatBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAChatBox));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxQuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uxChatBox = new LollipopTextBox();
            this.uxRemoteLabel = new LollipopLabel();
            this.uxSubmit = new LollipopButton();
            this.uxSend = new LollipopButton();
            this.uxQuestionCount = new LollipopLabel();
            this.uxRecommended = new LollipopLabel();
            this.uxTimer = new LollipopLabel();
            this.uxNextQuestion = new LollipopButton();
            this.uxStart = new LollipopButton();
            this.uxDisconnect = new LollipopButton();
            this.uxFriendPort = new LollipopTextBox();
            this.uxLocalLabel = new LollipopLabel();
            this.uxFriendIP = new LollipopTextBox();
            this.uxLocalPort = new LollipopTextBox();
            this.uxLocalIP = new LollipopTextBox();
            this.uxInputQuestion = new LollipopTextBox();
            this.uxInputBox = new LollipopTextBox();
            this.uxQuestionLabel = new LollipopLabel();
            this.uxStudentLabel = new LollipopLabel();
            this.uxQuestionText = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxQuestionTimer
            // 
            this.uxQuestionTimer.Interval = 1000;
            this.uxQuestionTimer.Tick += new System.EventHandler(this.UxQuestionTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(567, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // uxChatBox
            // 
            this.uxChatBox.FocusedColor = "#ff0033";
            this.uxChatBox.FontColor = "#999999";
            this.uxChatBox.IsEnabled = true;
            this.uxChatBox.Location = new System.Drawing.Point(9, 263);
            this.uxChatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxChatBox.MaxLength = 32767;
            this.uxChatBox.Multiline = true;
            this.uxChatBox.Name = "uxChatBox";
            this.uxChatBox.ReadOnly = true;
            this.uxChatBox.Size = new System.Drawing.Size(524, 276);
            this.uxChatBox.TabIndex = 43;
            this.uxChatBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxChatBox.UseSystemPasswordChar = false;
            // 
            // uxRemoteLabel
            // 
            this.uxRemoteLabel.AutoSize = true;
            this.uxRemoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxRemoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxRemoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxRemoteLabel.Location = new System.Drawing.Point(179, 72);
            this.uxRemoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxRemoteLabel.Name = "uxRemoteLabel";
            this.uxRemoteLabel.Size = new System.Drawing.Size(57, 17);
            this.uxRemoteLabel.TabIndex = 32;
            this.uxRemoteLabel.Text = "Remote";
            // 
            // uxSubmit
            // 
            this.uxSubmit.BackColor = System.Drawing.Color.Transparent;
            this.uxSubmit.BGColor = "#ff0033";
            this.uxSubmit.FontColor = "#ffffff";
            this.uxSubmit.Location = new System.Drawing.Point(448, 590);
            this.uxSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(85, 41);
            this.uxSubmit.TabIndex = 41;
            this.uxSubmit.Text = "Submit Question";
            this.uxSubmit.Click += new System.EventHandler(this.UxSubmit_Click);
            // 
            // uxSend
            // 
            this.uxSend.BackColor = System.Drawing.Color.Transparent;
            this.uxSend.BGColor = "#ff0033";
            this.uxSend.FontColor = "#ffffff";
            this.uxSend.Location = new System.Drawing.Point(448, 544);
            this.uxSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSend.Name = "uxSend";
            this.uxSend.Size = new System.Drawing.Size(85, 41);
            this.uxSend.TabIndex = 40;
            this.uxSend.Text = "Send";
            this.uxSend.Click += new System.EventHandler(this.UxSend_Click);
            // 
            // uxQuestionCount
            // 
            this.uxQuestionCount.AutoSize = true;
            this.uxQuestionCount.BackColor = System.Drawing.Color.Transparent;
            this.uxQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxQuestionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxQuestionCount.Location = new System.Drawing.Point(266, 142);
            this.uxQuestionCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxQuestionCount.Name = "uxQuestionCount";
            this.uxQuestionCount.Size = new System.Drawing.Size(108, 17);
            this.uxQuestionCount.TabIndex = 39;
            this.uxQuestionCount.Text = "# of Questions: ";
            // 
            // uxRecommended
            // 
            this.uxRecommended.AutoSize = true;
            this.uxRecommended.BackColor = System.Drawing.Color.Transparent;
            this.uxRecommended.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxRecommended.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxRecommended.Location = new System.Drawing.Point(266, 167);
            this.uxRecommended.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxRecommended.Name = "uxRecommended";
            this.uxRecommended.Size = new System.Drawing.Size(80, 17);
            this.uxRecommended.TabIndex = 38;
            this.uxRecommended.Text = "Time Limit: ";
            // 
            // uxTimer
            // 
            this.uxTimer.AutoSize = true;
            this.uxTimer.BackColor = System.Drawing.Color.Transparent;
            this.uxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxTimer.Location = new System.Drawing.Point(266, 120);
            this.uxTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTimer.Name = "uxTimer";
            this.uxTimer.Size = new System.Drawing.Size(52, 17);
            this.uxTimer.TabIndex = 36;
            this.uxTimer.Text = "Timer: ";
            // 
            // uxNextQuestion
            // 
            this.uxNextQuestion.BackColor = System.Drawing.Color.Transparent;
            this.uxNextQuestion.BGColor = "#ff0033";
            this.uxNextQuestion.FontColor = "#ffffff";
            this.uxNextQuestion.Location = new System.Drawing.Point(448, 78);
            this.uxNextQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxNextQuestion.Name = "uxNextQuestion";
            this.uxNextQuestion.Size = new System.Drawing.Size(85, 36);
            this.uxNextQuestion.TabIndex = 35;
            this.uxNextQuestion.Text = "Next Question";
            this.uxNextQuestion.Click += new System.EventHandler(this.UxNextQuestion_Click);
            // 
            // uxStart
            // 
            this.uxStart.BackColor = System.Drawing.Color.Transparent;
            this.uxStart.BGColor = "#ff0033";
            this.uxStart.FontColor = "#ffffff";
            this.uxStart.Location = new System.Drawing.Point(269, 78);
            this.uxStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(85, 36);
            this.uxStart.TabIndex = 34;
            this.uxStart.Text = "Connect";
            this.uxStart.Click += new System.EventHandler(this.UxConnect_Click);
            // 
            // uxDisconnect
            // 
            this.uxDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.uxDisconnect.BGColor = "#ff0033";
            this.uxDisconnect.Enabled = false;
            this.uxDisconnect.FontColor = "#ffffff";
            this.uxDisconnect.Location = new System.Drawing.Point(358, 78);
            this.uxDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxDisconnect.Name = "uxDisconnect";
            this.uxDisconnect.Size = new System.Drawing.Size(85, 36);
            this.uxDisconnect.TabIndex = 33;
            this.uxDisconnect.Text = "Disconnect";
            this.uxDisconnect.Click += new System.EventHandler(this.UxDisconnect_Click);
            // 
            // uxFriendPort
            // 
            this.uxFriendPort.FocusedColor = "#ff0033";
            this.uxFriendPort.FontColor = "#999999";
            this.uxFriendPort.IsEnabled = true;
            this.uxFriendPort.Location = new System.Drawing.Point(163, 119);
            this.uxFriendPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxFriendPort.MaxLength = 32767;
            this.uxFriendPort.Multiline = false;
            this.uxFriendPort.Name = "uxFriendPort";
            this.uxFriendPort.ReadOnly = false;
            this.uxFriendPort.Size = new System.Drawing.Size(83, 24);
            this.uxFriendPort.TabIndex = 5;
            this.uxFriendPort.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxFriendPort.UseSystemPasswordChar = false;
            // 
            // uxLocalLabel
            // 
            this.uxLocalLabel.AutoSize = true;
            this.uxLocalLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxLocalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxLocalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxLocalLabel.Location = new System.Drawing.Point(55, 72);
            this.uxLocalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLocalLabel.Name = "uxLocalLabel";
            this.uxLocalLabel.Size = new System.Drawing.Size(42, 17);
            this.uxLocalLabel.TabIndex = 31;
            this.uxLocalLabel.Text = "Local";
            // 
            // uxFriendIP
            // 
            this.uxFriendIP.FocusedColor = "#ff0033";
            this.uxFriendIP.FontColor = "#999999";
            this.uxFriendIP.IsEnabled = true;
            this.uxFriendIP.Location = new System.Drawing.Point(163, 94);
            this.uxFriendIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxFriendIP.MaxLength = 32767;
            this.uxFriendIP.Multiline = false;
            this.uxFriendIP.Name = "uxFriendIP";
            this.uxFriendIP.ReadOnly = false;
            this.uxFriendIP.Size = new System.Drawing.Size(83, 24);
            this.uxFriendIP.TabIndex = 4;
            this.uxFriendIP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxFriendIP.UseSystemPasswordChar = false;
            // 
            // uxLocalPort
            // 
            this.uxLocalPort.FocusedColor = "#ff0033";
            this.uxLocalPort.FontColor = "#999999";
            this.uxLocalPort.IsEnabled = true;
            this.uxLocalPort.Location = new System.Drawing.Point(32, 119);
            this.uxLocalPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLocalPort.MaxLength = 32767;
            this.uxLocalPort.Multiline = false;
            this.uxLocalPort.Name = "uxLocalPort";
            this.uxLocalPort.ReadOnly = false;
            this.uxLocalPort.Size = new System.Drawing.Size(82, 24);
            this.uxLocalPort.TabIndex = 4;
            this.uxLocalPort.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxLocalPort.UseSystemPasswordChar = false;
            // 
            // uxLocalIP
            // 
            this.uxLocalIP.FocusedColor = "#ff0033";
            this.uxLocalIP.FontColor = "#999999";
            this.uxLocalIP.IsEnabled = true;
            this.uxLocalIP.Location = new System.Drawing.Point(32, 94);
            this.uxLocalIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLocalIP.MaxLength = 32767;
            this.uxLocalIP.Multiline = false;
            this.uxLocalIP.Name = "uxLocalIP";
            this.uxLocalIP.ReadOnly = false;
            this.uxLocalIP.Size = new System.Drawing.Size(82, 24);
            this.uxLocalIP.TabIndex = 3;
            this.uxLocalIP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxLocalIP.UseSystemPasswordChar = false;
            // 
            // uxInputQuestion
            // 
            this.uxInputQuestion.FocusedColor = "#ff0033";
            this.uxInputQuestion.FontColor = "#999999";
            this.uxInputQuestion.IsEnabled = true;
            this.uxInputQuestion.Location = new System.Drawing.Point(9, 590);
            this.uxInputQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInputQuestion.MaxLength = 32767;
            this.uxInputQuestion.Multiline = true;
            this.uxInputQuestion.Name = "uxInputQuestion";
            this.uxInputQuestion.ReadOnly = false;
            this.uxInputQuestion.Size = new System.Drawing.Size(434, 41);
            this.uxInputQuestion.TabIndex = 28;
            this.uxInputQuestion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxInputQuestion.UseSystemPasswordChar = false;
            // 
            // uxInputBox
            // 
            this.uxInputBox.FocusedColor = "#ff0033";
            this.uxInputBox.FontColor = "#999999";
            this.uxInputBox.IsEnabled = true;
            this.uxInputBox.Location = new System.Drawing.Point(9, 544);
            this.uxInputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInputBox.MaxLength = 32767;
            this.uxInputBox.Multiline = true;
            this.uxInputBox.Name = "uxInputBox";
            this.uxInputBox.ReadOnly = false;
            this.uxInputBox.Size = new System.Drawing.Size(434, 41);
            this.uxInputBox.TabIndex = 27;
            this.uxInputBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxInputBox.UseSystemPasswordChar = false;
            // 
            // uxQuestionLabel
            // 
            this.uxQuestionLabel.AutoSize = true;
            this.uxQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxQuestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxQuestionLabel.Location = new System.Drawing.Point(9, 171);
            this.uxQuestionLabel.Name = "uxQuestionLabel";
            this.uxQuestionLabel.Size = new System.Drawing.Size(69, 17);
            this.uxQuestionLabel.TabIndex = 26;
            this.uxQuestionLabel.Text = "Question:";
            // 
            // uxStudentLabel
            // 
            this.uxStudentLabel.AutoSize = true;
            this.uxStudentLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxStudentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uxStudentLabel.Location = new System.Drawing.Point(9, 154);
            this.uxStudentLabel.Name = "uxStudentLabel";
            this.uxStudentLabel.Size = new System.Drawing.Size(61, 17);
            this.uxStudentLabel.TabIndex = 25;
            this.uxStudentLabel.Text = "Student:";
            // 
            // uxQuestionText
            // 
            this.uxQuestionText.FocusedColor = "#ff0033";
            this.uxQuestionText.FontColor = "#999999";
            this.uxQuestionText.IsEnabled = true;
            this.uxQuestionText.Location = new System.Drawing.Point(9, 192);
            this.uxQuestionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxQuestionText.MaxLength = 32767;
            this.uxQuestionText.Multiline = true;
            this.uxQuestionText.Name = "uxQuestionText";
            this.uxQuestionText.ReadOnly = false;
            this.uxQuestionText.Size = new System.Drawing.Size(524, 50);
            this.uxQuestionText.TabIndex = 3;
            this.uxQuestionText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uxQuestionText.UseSystemPasswordChar = false;
            // 
            // TAChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 648);
            this.Controls.Add(this.uxChatBox);
            this.Controls.Add(this.uxRemoteLabel);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxSend);
            this.Controls.Add(this.uxQuestionCount);
            this.Controls.Add(this.uxRecommended);
            this.Controls.Add(this.uxTimer);
            this.Controls.Add(this.uxNextQuestion);
            this.Controls.Add(this.uxStart);
            this.Controls.Add(this.uxDisconnect);
            this.Controls.Add(this.uxFriendPort);
            this.Controls.Add(this.uxLocalLabel);
            this.Controls.Add(this.uxFriendIP);
            this.Controls.Add(this.uxLocalPort);
            this.Controls.Add(this.uxLocalIP);
            this.Controls.Add(this.uxInputQuestion);
            this.Controls.Add(this.uxInputBox);
            this.Controls.Add(this.uxQuestionLabel);
            this.Controls.Add(this.uxStudentLabel);
            this.Controls.Add(this.uxQuestionText);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "TAChatBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer uxQuestionTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private LollipopTextBox uxQuestionText;
        private LollipopLabel uxStudentLabel;
        private LollipopLabel uxQuestionLabel;
        private LollipopTextBox uxFriendPort;
        private LollipopTextBox uxFriendIP;
        private LollipopTextBox uxInputBox;
        private LollipopTextBox uxInputQuestion;
        private LollipopTextBox uxLocalIP;
        private LollipopTextBox uxLocalPort;
        private LollipopLabel uxLocalLabel;
        private LollipopLabel uxRemoteLabel;
        private LollipopButton uxDisconnect;
        private LollipopButton uxStart;
        private LollipopButton uxNextQuestion;
        private LollipopLabel uxTimer;
        private LollipopLabel uxRecommended;
        private LollipopLabel uxQuestionCount;
        private LollipopButton uxSend;
        private LollipopButton uxSubmit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LollipopTextBox uxChatBox;
    }
}

