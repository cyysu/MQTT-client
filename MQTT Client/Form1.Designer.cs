namespace MQTT_Client
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.connButton = new System.Windows.Forms.Button();
            this.subTextBox = new System.Windows.Forms.TextBox();
            this.pubTextBox = new System.Windows.Forms.TextBox();
            this.pubButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.subButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(53, 10);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(240, 20);
            this.IPTextBox.TabIndex = 1;
            // 
            // connButton
            // 
            this.connButton.Location = new System.Drawing.Point(299, 10);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(75, 23);
            this.connButton.TabIndex = 4;
            this.connButton.Text = "Connect";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // subTextBox
            // 
            this.subTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.subTextBox.Location = new System.Drawing.Point(16, 59);
            this.subTextBox.Multiline = true;
            this.subTextBox.Name = "subTextBox";
            this.subTextBox.ReadOnly = true;
            this.subTextBox.Size = new System.Drawing.Size(359, 229);
            this.subTextBox.TabIndex = 5;
            // 
            // pubTextBox
            // 
            this.pubTextBox.Location = new System.Drawing.Point(16, 294);
            this.pubTextBox.Name = "pubTextBox";
            this.pubTextBox.Size = new System.Drawing.Size(277, 20);
            this.pubTextBox.TabIndex = 6;
            // 
            // pubButton
            // 
            this.pubButton.Location = new System.Drawing.Point(299, 292);
            this.pubButton.Name = "pubButton";
            this.pubButton.Size = new System.Drawing.Size(75, 23);
            this.pubButton.TabIndex = 7;
            this.pubButton.Text = "Publish";
            this.pubButton.UseVisualStyleBackColor = true;
            this.pubButton.Click += new System.EventHandler(this.pubButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Topic : ";
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(53, 33);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(240, 20);
            this.topicTextBox.TabIndex = 9;
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(299, 33);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 10;
            this.subButton.Text = "Subscribe";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 326);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pubButton);
            this.Controls.Add(this.pubTextBox);
            this.Controls.Add(this.subTextBox);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button connButton;
        private System.Windows.Forms.TextBox subTextBox;
        private System.Windows.Forms.TextBox pubTextBox;
        private System.Windows.Forms.Button pubButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Button subButton;
    }
}

