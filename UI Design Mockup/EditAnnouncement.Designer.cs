namespace UI_Design_Mockup
{
    partial class EditAnnouncement
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
            this.EditAnnouncementBox = new System.Windows.Forms.RichTextBox();
            this.CurrentRecipientList = new System.Windows.Forms.ListBox();
            this.EditText = new System.Windows.Forms.Label();
            this.CurrentRecipients = new System.Windows.Forms.Label();
            this.NewRecipientList = new System.Windows.Forms.CheckedListBox();
            this.NewRecipientLabel = new System.Windows.Forms.Label();
            this.Deselect = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.EditCancel = new System.Windows.Forms.Button();
            this.AnnounceUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditAnnouncementBox
            // 
            this.EditAnnouncementBox.Location = new System.Drawing.Point(219, 39);
            this.EditAnnouncementBox.Name = "EditAnnouncementBox";
            this.EditAnnouncementBox.Size = new System.Drawing.Size(396, 283);
            this.EditAnnouncementBox.TabIndex = 0;
            this.EditAnnouncementBox.Text = "";
            // 
            // CurrentRecipientList
            // 
            this.CurrentRecipientList.FormattingEnabled = true;
            this.CurrentRecipientList.Items.AddRange(new object[] {
            "Admins",
            "Students",
            "Director of Studies"});
            this.CurrentRecipientList.Location = new System.Drawing.Point(12, 39);
            this.CurrentRecipientList.Name = "CurrentRecipientList";
            this.CurrentRecipientList.Size = new System.Drawing.Size(201, 108);
            this.CurrentRecipientList.TabIndex = 1;
            // 
            // EditText
            // 
            this.EditText.AutoSize = true;
            this.EditText.Location = new System.Drawing.Point(216, 23);
            this.EditText.Name = "EditText";
            this.EditText.Size = new System.Drawing.Size(103, 13);
            this.EditText.TabIndex = 2;
            this.EditText.Text = "Edit Announcement ";
            // 
            // CurrentRecipients
            // 
            this.CurrentRecipients.AutoSize = true;
            this.CurrentRecipients.Location = new System.Drawing.Point(12, 23);
            this.CurrentRecipients.Name = "CurrentRecipients";
            this.CurrentRecipients.Size = new System.Drawing.Size(94, 13);
            this.CurrentRecipients.TabIndex = 3;
            this.CurrentRecipients.Text = "Current Recipients";
            // 
            // NewRecipientList
            // 
            this.NewRecipientList.FormattingEnabled = true;
            this.NewRecipientList.Items.AddRange(new object[] {
            "Module Leaders",
            "Module Teams",
            "Moderators",
            "Panel Admin",
            "Panel"});
            this.NewRecipientList.Location = new System.Drawing.Point(12, 198);
            this.NewRecipientList.Name = "NewRecipientList";
            this.NewRecipientList.Size = new System.Drawing.Size(200, 124);
            this.NewRecipientList.TabIndex = 4;
            // 
            // NewRecipientLabel
            // 
            this.NewRecipientLabel.AutoSize = true;
            this.NewRecipientLabel.Location = new System.Drawing.Point(12, 182);
            this.NewRecipientLabel.Name = "NewRecipientLabel";
            this.NewRecipientLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewRecipientLabel.Size = new System.Drawing.Size(110, 13);
            this.NewRecipientLabel.TabIndex = 5;
            this.NewRecipientLabel.Text = "Add New Recipients?";
            // 
            // Deselect
            // 
            this.Deselect.Location = new System.Drawing.Point(12, 328);
            this.Deselect.Name = "Deselect";
            this.Deselect.Size = new System.Drawing.Size(93, 23);
            this.Deselect.TabIndex = 6;
            this.Deselect.Text = "Deselect All";
            this.Deselect.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(12, 357);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(93, 23);
            this.Return.TabIndex = 7;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // EditCancel
            // 
            this.EditCancel.Location = new System.Drawing.Point(219, 328);
            this.EditCancel.Name = "EditCancel";
            this.EditCancel.Size = new System.Drawing.Size(140, 23);
            this.EditCancel.TabIndex = 8;
            this.EditCancel.Text = "Cancel Edit";
            this.EditCancel.UseVisualStyleBackColor = true;
            // 
            // AnnounceUpdate
            // 
            this.AnnounceUpdate.Location = new System.Drawing.Point(475, 328);
            this.AnnounceUpdate.Name = "AnnounceUpdate";
            this.AnnounceUpdate.Size = new System.Drawing.Size(140, 23);
            this.AnnounceUpdate.TabIndex = 9;
            this.AnnounceUpdate.Text = "Update Announcement";
            this.AnnounceUpdate.UseVisualStyleBackColor = true;
            // 
            // EditAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 406);
            this.Controls.Add(this.AnnounceUpdate);
            this.Controls.Add(this.EditCancel);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Deselect);
            this.Controls.Add(this.NewRecipientLabel);
            this.Controls.Add(this.NewRecipientList);
            this.Controls.Add(this.CurrentRecipients);
            this.Controls.Add(this.EditText);
            this.Controls.Add(this.CurrentRecipientList);
            this.Controls.Add(this.EditAnnouncementBox);
            this.Name = "EditAnnouncement";
            this.Text = "EditAnnouncement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox EditAnnouncementBox;
        private System.Windows.Forms.ListBox CurrentRecipientList;
        private System.Windows.Forms.Label EditText;
        private System.Windows.Forms.Label CurrentRecipients;
        private System.Windows.Forms.CheckedListBox NewRecipientList;
        private System.Windows.Forms.Label NewRecipientLabel;
        private System.Windows.Forms.Button Deselect;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button EditCancel;
        private System.Windows.Forms.Button AnnounceUpdate;
    }
}