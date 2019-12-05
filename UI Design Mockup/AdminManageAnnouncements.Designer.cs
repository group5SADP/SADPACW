namespace UI_Design_Mockup
{
    partial class AdminManageAnnouncements
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
            this.AddAnnouncement = new System.Windows.Forms.Button();
            this.EditAnnouncement = new System.Windows.Forms.Button();
            this.AnnouncementList = new System.Windows.Forms.ListBox();
            this.DeleteAnnouncement = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.AnnouncementListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddAnnouncement
            // 
            this.AddAnnouncement.Location = new System.Drawing.Point(12, 29);
            this.AddAnnouncement.Name = "AddAnnouncement";
            this.AddAnnouncement.Size = new System.Drawing.Size(132, 23);
            this.AddAnnouncement.TabIndex = 0;
            this.AddAnnouncement.Text = "Add Announcement";
            this.AddAnnouncement.UseVisualStyleBackColor = true;
            this.AddAnnouncement.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAnnouncement
            // 
            this.EditAnnouncement.Location = new System.Drawing.Point(12, 58);
            this.EditAnnouncement.Name = "EditAnnouncement";
            this.EditAnnouncement.Size = new System.Drawing.Size(132, 23);
            this.EditAnnouncement.TabIndex = 1;
            this.EditAnnouncement.Text = "Edit Announcement";
            this.EditAnnouncement.UseVisualStyleBackColor = true;
            // 
            // AnnouncementList
            // 
            this.AnnouncementList.FormattingEnabled = true;
            this.AnnouncementList.Location = new System.Drawing.Point(150, 29);
            this.AnnouncementList.Name = "AnnouncementList";
            this.AnnouncementList.Size = new System.Drawing.Size(291, 251);
            this.AnnouncementList.TabIndex = 2;
            // 
            // DeleteAnnouncement
            // 
            this.DeleteAnnouncement.Location = new System.Drawing.Point(12, 87);
            this.DeleteAnnouncement.Name = "DeleteAnnouncement";
            this.DeleteAnnouncement.Size = new System.Drawing.Size(132, 23);
            this.DeleteAnnouncement.TabIndex = 3;
            this.DeleteAnnouncement.Text = "Delete Announcement";
            this.DeleteAnnouncement.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(12, 257);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(132, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // AnnouncementListLabel
            // 
            this.AnnouncementListLabel.AutoSize = true;
            this.AnnouncementListLabel.Location = new System.Drawing.Point(147, 13);
            this.AnnouncementListLabel.Name = "AnnouncementListLabel";
            this.AnnouncementListLabel.Size = new System.Drawing.Size(98, 13);
            this.AnnouncementListLabel.TabIndex = 5;
            this.AnnouncementListLabel.Text = "All Announcements";
            // 
            // AdminManageAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 300);
            this.Controls.Add(this.AnnouncementListLabel);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.DeleteAnnouncement);
            this.Controls.Add(this.AnnouncementList);
            this.Controls.Add(this.EditAnnouncement);
            this.Controls.Add(this.AddAnnouncement);
            this.Name = "AdminManageAnnouncements";
            this.Text = "AdminManageAnnouncements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAnnouncement;
        private System.Windows.Forms.Button EditAnnouncement;
        private System.Windows.Forms.ListBox AnnouncementList;
        private System.Windows.Forms.Button DeleteAnnouncement;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label AnnouncementListLabel;
    }
}