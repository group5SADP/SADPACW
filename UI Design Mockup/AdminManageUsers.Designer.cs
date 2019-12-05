namespace UI_Design_Mockup
{
    partial class AdminManageUsers
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
            this.UserList = new System.Windows.Forms.ComboBox();
            this.UserSearch = new System.Windows.Forms.Label();
            this.PermLabel = new System.Windows.Forms.Label();
            this.PermissionsBox = new System.Windows.Forms.CheckedListBox();
            this.Return = new System.Windows.Forms.Button();
            this.ClearPerm = new System.Windows.Forms.Button();
            this.UploadedList = new System.Windows.Forms.ListBox();
            this.FilesLabel = new System.Windows.Forms.Label();
            this.DeleteFile = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.AnnouncementsList = new System.Windows.Forms.ListBox();
            this.AnnounceListLabel = new System.Windows.Forms.Label();
            this.ViewButton2 = new System.Windows.Forms.Button();
            this.DeleteButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(15, 53);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(137, 21);
            this.UserList.TabIndex = 0;
            // 
            // UserSearch
            // 
            this.UserSearch.AutoSize = true;
            this.UserSearch.Location = new System.Drawing.Point(13, 37);
            this.UserSearch.Name = "UserSearch";
            this.UserSearch.Size = new System.Drawing.Size(52, 13);
            this.UserSearch.TabIndex = 1;
            this.UserSearch.Text = "Find User";
            // 
            // PermLabel
            // 
            this.PermLabel.AutoSize = true;
            this.PermLabel.Location = new System.Drawing.Point(12, 77);
            this.PermLabel.Name = "PermLabel";
            this.PermLabel.Size = new System.Drawing.Size(87, 13);
            this.PermLabel.TabIndex = 3;
            this.PermLabel.Text = "User Permissions";
            // 
            // PermissionsBox
            // 
            this.PermissionsBox.FormattingEnabled = true;
            this.PermissionsBox.Items.AddRange(new object[] {
            "Create Announcements",
            "Edit Announcements",
            "Delete Announcements",
            "Manage Users",
            "Manage Uploads",
            "View Uploads"});
            this.PermissionsBox.Location = new System.Drawing.Point(15, 93);
            this.PermissionsBox.Name = "PermissionsBox";
            this.PermissionsBox.Size = new System.Drawing.Size(181, 244);
            this.PermissionsBox.TabIndex = 4;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(16, 372);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(83, 23);
            this.Return.TabIndex = 5;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // ClearPerm
            // 
            this.ClearPerm.Location = new System.Drawing.Point(16, 343);
            this.ClearPerm.Name = "ClearPerm";
            this.ClearPerm.Size = new System.Drawing.Size(136, 23);
            this.ClearPerm.TabIndex = 6;
            this.ClearPerm.Text = "Clear Current Permissions";
            this.ClearPerm.UseVisualStyleBackColor = true;
            // 
            // UploadedList
            // 
            this.UploadedList.FormattingEnabled = true;
            this.UploadedList.Items.AddRange(new object[] {
            "CoursePlan.txt",
            "Placeholder.pdf"});
            this.UploadedList.Location = new System.Drawing.Point(227, 93);
            this.UploadedList.Name = "UploadedList";
            this.UploadedList.Size = new System.Drawing.Size(181, 238);
            this.UploadedList.TabIndex = 7;
            // 
            // FilesLabel
            // 
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.Location = new System.Drawing.Point(223, 77);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(109, 13);
            this.FilesLabel.TabIndex = 8;
            this.FilesLabel.Text = "User\'s Uploaded Files";
            // 
            // DeleteFile
            // 
            this.DeleteFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeleteFile.Location = new System.Drawing.Point(332, 343);
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Size = new System.Drawing.Size(75, 23);
            this.DeleteFile.TabIndex = 9;
            this.DeleteFile.Text = "Delete";
            this.DeleteFile.UseVisualStyleBackColor = true;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(226, 343);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 10;
            this.ViewButton.Text = "View File";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // AnnouncementsList
            // 
            this.AnnouncementsList.FormattingEnabled = true;
            this.AnnouncementsList.Items.AddRange(new object[] {
            "27/03/20 14:32",
            "13/12/19 15:00"});
            this.AnnouncementsList.Location = new System.Drawing.Point(438, 93);
            this.AnnouncementsList.Name = "AnnouncementsList";
            this.AnnouncementsList.Size = new System.Drawing.Size(181, 238);
            this.AnnouncementsList.TabIndex = 11;
            // 
            // AnnounceListLabel
            // 
            this.AnnounceListLabel.AutoSize = true;
            this.AnnounceListLabel.Location = new System.Drawing.Point(435, 77);
            this.AnnounceListLabel.Name = "AnnounceListLabel";
            this.AnnounceListLabel.Size = new System.Drawing.Size(116, 13);
            this.AnnounceListLabel.TabIndex = 12;
            this.AnnounceListLabel.Text = "User\'s Announcements";
            // 
            // ViewButton2
            // 
            this.ViewButton2.Location = new System.Drawing.Point(438, 343);
            this.ViewButton2.Name = "ViewButton2";
            this.ViewButton2.Size = new System.Drawing.Size(75, 23);
            this.ViewButton2.TabIndex = 13;
            this.ViewButton2.Text = "View ";
            this.ViewButton2.UseVisualStyleBackColor = true;
            // 
            // DeleteButton2
            // 
            this.DeleteButton2.Location = new System.Drawing.Point(544, 343);
            this.DeleteButton2.Name = "DeleteButton2";
            this.DeleteButton2.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton2.TabIndex = 14;
            this.DeleteButton2.Text = "Delete";
            this.DeleteButton2.UseVisualStyleBackColor = true;
            // 
            // AdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 423);
            this.Controls.Add(this.DeleteButton2);
            this.Controls.Add(this.ViewButton2);
            this.Controls.Add(this.AnnounceListLabel);
            this.Controls.Add(this.AnnouncementsList);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DeleteFile);
            this.Controls.Add(this.FilesLabel);
            this.Controls.Add(this.UploadedList);
            this.Controls.Add(this.ClearPerm);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.PermissionsBox);
            this.Controls.Add(this.PermLabel);
            this.Controls.Add(this.UserSearch);
            this.Controls.Add(this.UserList);
            this.Name = "AdminManageUsers";
            this.Text = "AdminManageUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserList;
        private System.Windows.Forms.Label UserSearch;
        private System.Windows.Forms.Label PermLabel;
        private System.Windows.Forms.CheckedListBox PermissionsBox;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button ClearPerm;
        private System.Windows.Forms.ListBox UploadedList;
        private System.Windows.Forms.Label FilesLabel;
        private System.Windows.Forms.Button DeleteFile;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ListBox AnnouncementsList;
        private System.Windows.Forms.Label AnnounceListLabel;
        private System.Windows.Forms.Button ViewButton2;
        private System.Windows.Forms.Button DeleteButton2;
    }
}