namespace TeachingAssistantApplication
{
    partial class UserInterface
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
            this.uxTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uxFriendIP = new System.Windows.Forms.TextBox();
            this.uxLocalIP = new System.Windows.Forms.TextBox();
            this.uxLocalPort = new System.Windows.Forms.TextBox();
            this.uxFriendPort = new System.Windows.Forms.TextBox();
            this.uxInputBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.uxSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(12, 141);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(655, 414);
            this.uxTextBox.TabIndex = 0;
            this.uxTextBox.Text = "";
            this.uxTextBox.TextChanged += new System.EventHandler(this.UxQuestionBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Question:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxLocalPort);
            this.groupBox1.Controls.Add(this.uxLocalIP);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxFriendPort);
            this.groupBox2.Controls.Add(this.uxFriendIP);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 92);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote";
            // 
            // uxFriendIP
            // 
            this.uxFriendIP.Location = new System.Drawing.Point(86, 21);
            this.uxFriendIP.Name = "uxFriendIP";
            this.uxFriendIP.Size = new System.Drawing.Size(100, 22);
            this.uxFriendIP.TabIndex = 0;
            // 
            // uxLocalIP
            // 
            this.uxLocalIP.Location = new System.Drawing.Point(86, 21);
            this.uxLocalIP.Name = "uxLocalIP";
            this.uxLocalIP.Size = new System.Drawing.Size(100, 22);
            this.uxLocalIP.TabIndex = 1;
            // 
            // uxLocalPort
            // 
            this.uxLocalPort.Location = new System.Drawing.Point(86, 49);
            this.uxLocalPort.Name = "uxLocalPort";
            this.uxLocalPort.Size = new System.Drawing.Size(100, 22);
            this.uxLocalPort.TabIndex = 2;
            // 
            // uxFriendPort
            // 
            this.uxFriendPort.Location = new System.Drawing.Point(86, 49);
            this.uxFriendPort.Name = "uxFriendPort";
            this.uxFriendPort.Size = new System.Drawing.Size(100, 22);
            this.uxFriendPort.TabIndex = 3;
            // 
            // uxInputBox
            // 
            this.uxInputBox.Location = new System.Drawing.Point(12, 561);
            this.uxInputBox.Name = "uxInputBox";
            this.uxInputBox.Size = new System.Drawing.Size(522, 22);
            this.uxInputBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 44);
            this.button3.TabIndex = 12;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // uxSend
            // 
            this.uxSend.Location = new System.Drawing.Point(540, 561);
            this.uxSend.Name = "uxSend";
            this.uxSend.Size = new System.Drawing.Size(127, 44);
            this.uxSend.TabIndex = 13;
            this.uxSend.Text = "Send";
            this.uxSend.UseVisualStyleBackColor = true;
            this.uxSend.Click += new System.EventHandler(this.UxSend_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 668);
            this.Controls.Add(this.uxSend);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uxInputBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxTextBox);
            this.Name = "UserInterface";
            this.Text = "Quick Question";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox uxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uxLocalPort;
        private System.Windows.Forms.TextBox uxLocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uxFriendPort;
        private System.Windows.Forms.TextBox uxFriendIP;
        private System.Windows.Forms.TextBox uxInputBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button uxSend;
    }
}

