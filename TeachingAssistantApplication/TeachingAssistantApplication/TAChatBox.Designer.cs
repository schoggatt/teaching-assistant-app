﻿namespace TeachingAssistantApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxLocalBox = new System.Windows.Forms.GroupBox();
            this.uxLocalPort = new System.Windows.Forms.TextBox();
            this.uxLocalIP = new System.Windows.Forms.TextBox();
            this.uxRemoteGroup = new System.Windows.Forms.GroupBox();
            this.uxFriendPort = new System.Windows.Forms.TextBox();
            this.uxFriendIP = new System.Windows.Forms.TextBox();
            this.uxInputQuestion = new System.Windows.Forms.TextBox();
            this.uxStart = new System.Windows.Forms.Button();
            this.uxSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxRecommended = new System.Windows.Forms.Label();
            this.uxQuestionCount = new System.Windows.Forms.Label();
            this.uxTimer = new System.Windows.Forms.Label();
            this.uxQuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxInputBox = new System.Windows.Forms.TextBox();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.uxChatBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.uxDisconnect = new System.Windows.Forms.Button();
            this.uxNextQuestion = new System.Windows.Forms.Button();
            this.uxLocalBox.SuspendLayout();
            this.uxRemoteGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chat:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxLocalBox
            // 
            this.uxLocalBox.Controls.Add(this.uxLocalPort);
            this.uxLocalBox.Controls.Add(this.uxLocalIP);
            this.uxLocalBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLocalBox.Location = new System.Drawing.Point(15, 12);
            this.uxLocalBox.Name = "uxLocalBox";
            this.uxLocalBox.Size = new System.Drawing.Size(192, 92);
            this.uxLocalBox.TabIndex = 9;
            this.uxLocalBox.TabStop = false;
            this.uxLocalBox.Text = "Local";
            // 
            // uxLocalPort
            // 
            this.uxLocalPort.Location = new System.Drawing.Point(86, 49);
            this.uxLocalPort.Name = "uxLocalPort";
            this.uxLocalPort.Size = new System.Drawing.Size(100, 23);
            this.uxLocalPort.TabIndex = 2;
            // 
            // uxLocalIP
            // 
            this.uxLocalIP.Location = new System.Drawing.Point(86, 21);
            this.uxLocalIP.Name = "uxLocalIP";
            this.uxLocalIP.Size = new System.Drawing.Size(100, 23);
            this.uxLocalIP.TabIndex = 1;
            // 
            // uxRemoteGroup
            // 
            this.uxRemoteGroup.Controls.Add(this.uxFriendPort);
            this.uxRemoteGroup.Controls.Add(this.uxFriendIP);
            this.uxRemoteGroup.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoteGroup.Location = new System.Drawing.Point(213, 12);
            this.uxRemoteGroup.Name = "uxRemoteGroup";
            this.uxRemoteGroup.Size = new System.Drawing.Size(192, 92);
            this.uxRemoteGroup.TabIndex = 10;
            this.uxRemoteGroup.TabStop = false;
            this.uxRemoteGroup.Text = "Remote";
            // 
            // uxFriendPort
            // 
            this.uxFriendPort.Location = new System.Drawing.Point(86, 49);
            this.uxFriendPort.Name = "uxFriendPort";
            this.uxFriendPort.Size = new System.Drawing.Size(100, 23);
            this.uxFriendPort.TabIndex = 3;
            // 
            // uxFriendIP
            // 
            this.uxFriendIP.Location = new System.Drawing.Point(86, 21);
            this.uxFriendIP.Name = "uxFriendIP";
            this.uxFriendIP.Size = new System.Drawing.Size(100, 23);
            this.uxFriendIP.TabIndex = 0;
            // 
            // uxInputQuestion
            // 
            this.uxInputQuestion.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInputQuestion.Location = new System.Drawing.Point(12, 629);
            this.uxInputQuestion.Multiline = true;
            this.uxInputQuestion.Name = "uxInputQuestion";
            this.uxInputQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxInputQuestion.Size = new System.Drawing.Size(522, 50);
            this.uxInputQuestion.TabIndex = 11;
            // 
            // uxStart
            // 
            this.uxStart.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStart.Location = new System.Drawing.Point(540, 22);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(127, 44);
            this.uxStart.TabIndex = 12;
            this.uxStart.Text = "Connect";
            this.uxStart.UseVisualStyleBackColor = true;
            this.uxStart.Click += new System.EventHandler(this.UxStart_Click);
            // 
            // uxSend
            // 
            this.uxSend.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSend.Location = new System.Drawing.Point(540, 568);
            this.uxSend.Name = "uxSend";
            this.uxSend.Size = new System.Drawing.Size(127, 50);
            this.uxSend.TabIndex = 13;
            this.uxSend.Text = "Send";
            this.uxSend.UseVisualStyleBackColor = true;
            this.uxSend.Click += new System.EventHandler(this.UxSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxRecommended);
            this.groupBox1.Controls.Add(this.uxQuestionCount);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queue Statistics";
            // 
            // uxRecommended
            // 
            this.uxRecommended.AutoSize = true;
            this.uxRecommended.Location = new System.Drawing.Point(6, 35);
            this.uxRecommended.Name = "uxRecommended";
            this.uxRecommended.Size = new System.Drawing.Size(152, 17);
            this.uxRecommended.TabIndex = 16;
            this.uxRecommended.Text = "Recommended Time: ";
            // 
            // uxQuestionCount
            // 
            this.uxQuestionCount.AutoSize = true;
            this.uxQuestionCount.Location = new System.Drawing.Point(6, 18);
            this.uxQuestionCount.Name = "uxQuestionCount";
            this.uxQuestionCount.Size = new System.Drawing.Size(136, 17);
            this.uxQuestionCount.TabIndex = 15;
            this.uxQuestionCount.Text = "# of Questions: ";
            // 
            // uxTimer
            // 
            this.uxTimer.AutoSize = true;
            this.uxTimer.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTimer.Location = new System.Drawing.Point(537, 69);
            this.uxTimer.Name = "uxTimer";
            this.uxTimer.Size = new System.Drawing.Size(56, 17);
            this.uxTimer.TabIndex = 17;
            this.uxTimer.Text = "Timer:";
            // 
            // uxQuestionTimer
            // 
            this.uxQuestionTimer.Interval = 1000;
            this.uxQuestionTimer.Tick += new System.EventHandler(this.UxQuestionTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 63);
            this.textBox1.TabIndex = 4;
            // 
            // uxInputBox
            // 
            this.uxInputBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInputBox.Location = new System.Drawing.Point(12, 568);
            this.uxInputBox.Multiline = true;
            this.uxInputBox.Name = "uxInputBox";
            this.uxInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxInputBox.Size = new System.Drawing.Size(522, 50);
            this.uxInputBox.TabIndex = 20;
            // 
            // uxSubmit
            // 
            this.uxSubmit.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmit.Location = new System.Drawing.Point(540, 629);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(127, 50);
            this.uxSubmit.TabIndex = 21;
            this.uxSubmit.Text = "Submit Question";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.UxSubmit_Click);
            // 
            // uxChatBox
            // 
            this.uxChatBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxChatBox.FormattingEnabled = true;
            this.uxChatBox.ItemHeight = 15;
            this.uxChatBox.Location = new System.Drawing.Point(12, 224);
            this.uxChatBox.Name = "uxChatBox";
            this.uxChatBox.Size = new System.Drawing.Size(650, 319);
            this.uxChatBox.TabIndex = 22;
            // 
            // uxDisconnect
            // 
            this.uxDisconnect.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisconnect.Location = new System.Drawing.Point(411, 22);
            this.uxDisconnect.Name = "uxDisconnect";
            this.uxDisconnect.Size = new System.Drawing.Size(127, 44);
            this.uxDisconnect.TabIndex = 23;
            this.uxDisconnect.Text = "Disconnect";
            this.uxDisconnect.UseVisualStyleBackColor = true;
            this.uxDisconnect.Click += new System.EventHandler(this.UxDisconnect_Click);
            // 
            // uxNextQuestion
            // 
            this.uxNextQuestion.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNextQuestion.Location = new System.Drawing.Point(540, 95);
            this.uxNextQuestion.Name = "uxNextQuestion";
            this.uxNextQuestion.Size = new System.Drawing.Size(127, 44);
            this.uxNextQuestion.TabIndex = 24;
            this.uxNextQuestion.Text = "Next Question";
            this.uxNextQuestion.UseVisualStyleBackColor = true;
            // 
            // TAChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 691);
            this.Controls.Add(this.uxNextQuestion);
            this.Controls.Add(this.uxDisconnect);
            this.Controls.Add(this.uxChatBox);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxInputBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxTimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxSend);
            this.Controls.Add(this.uxStart);
            this.Controls.Add(this.uxInputQuestion);
            this.Controls.Add(this.uxRemoteGroup);
            this.Controls.Add(this.uxLocalBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TAChatBox";
            this.uxLocalBox.ResumeLayout(false);
            this.uxLocalBox.PerformLayout();
            this.uxRemoteGroup.ResumeLayout(false);
            this.uxRemoteGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox uxLocalBox;
        private System.Windows.Forms.TextBox uxLocalPort;
        private System.Windows.Forms.TextBox uxLocalIP;
        private System.Windows.Forms.GroupBox uxRemoteGroup;
        private System.Windows.Forms.TextBox uxFriendPort;
        private System.Windows.Forms.TextBox uxFriendIP;
        private System.Windows.Forms.TextBox uxInputQuestion;
        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.Button uxSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label uxRecommended;
        private System.Windows.Forms.Label uxQuestionCount;
        private System.Windows.Forms.Label uxTimer;
        private System.Windows.Forms.Timer uxQuestionTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox uxInputBox;
        private System.Windows.Forms.Button uxSubmit;
        private System.Windows.Forms.ListBox uxChatBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button uxDisconnect;
        private System.Windows.Forms.Button uxNextQuestion;
    }
}

