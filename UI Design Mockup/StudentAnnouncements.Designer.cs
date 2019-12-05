namespace UI_Design_Mockup
{
    partial class StudentAnnouncements
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
            this.AnnouncementDisplay = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnnouncementDisplay
            // 
            this.AnnouncementDisplay.FormattingEnabled = true;
            this.AnnouncementDisplay.Location = new System.Drawing.Point(6, 12);
            this.AnnouncementDisplay.Name = "AnnouncementDisplay";
            this.AnnouncementDisplay.Size = new System.Drawing.Size(433, 173);
            this.AnnouncementDisplay.TabIndex = 0;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(6, 191);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 1;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(364, 191);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // StudentAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 234);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.AnnouncementDisplay);
            this.Name = "StudentAnnouncements";
            this.Text = "StudentAnnouncements";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AnnouncementDisplay;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button LogOut;
    }
}