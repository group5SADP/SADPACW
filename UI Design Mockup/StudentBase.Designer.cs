namespace UI_Design_Mockup
{
    partial class StudentBase
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Announcements = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(82, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(132, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome, [Student Name]";
            // 
            // Announcements
            // 
            this.Announcements.Location = new System.Drawing.Point(54, 43);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(93, 42);
            this.Announcements.TabIndex = 1;
            this.Announcements.Text = "View \r\nAnnouncements";
            this.Announcements.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "View\r\nSchedule";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(111, 91);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // StudentBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 137);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Announcements);
            this.Controls.Add(this.TitleLabel);
            this.Name = "StudentBase";
            this.Text = "StudentBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button Announcements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LogOut;
    }
}