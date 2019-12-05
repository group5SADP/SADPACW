namespace UI_Design_Mockup
{
    partial class NewAnnouncement
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RecipientGroupsLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AnnouncementText = new System.Windows.Forms.Label();
            this.DeselectAll = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SendAnnouncement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(160, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 272);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // RecipientGroupsLabel
            // 
            this.RecipientGroupsLabel.AutoSize = true;
            this.RecipientGroupsLabel.Location = new System.Drawing.Point(8, 34);
            this.RecipientGroupsLabel.Name = "RecipientGroupsLabel";
            this.RecipientGroupsLabel.Size = new System.Drawing.Size(89, 13);
            this.RecipientGroupsLabel.TabIndex = 1;
            this.RecipientGroupsLabel.Text = "Recipient Groups";
            this.RecipientGroupsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Admins",
            "Students",
            "Module Leaders",
            "Module Teams",
            "Director of Studies",
            "Moderators",
            "Panel Admin",
            "Panel",
            "All Users"});
            this.checkedListBox1.Location = new System.Drawing.Point(11, 50);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(143, 199);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // AnnouncementText
            // 
            this.AnnouncementText.AutoSize = true;
            this.AnnouncementText.Location = new System.Drawing.Point(157, 34);
            this.AnnouncementText.Name = "AnnouncementText";
            this.AnnouncementText.Size = new System.Drawing.Size(126, 13);
            this.AnnouncementText.TabIndex = 3;
            this.AnnouncementText.Text = "Compose Announcement";
            this.AnnouncementText.Click += new System.EventHandler(this.AnnouncementText_Click);
            // 
            // DeselectAll
            // 
            this.DeselectAll.Location = new System.Drawing.Point(12, 262);
            this.DeselectAll.Name = "DeselectAll";
            this.DeselectAll.Size = new System.Drawing.Size(142, 27);
            this.DeselectAll.TabIndex = 4;
            this.DeselectAll.Text = "Deselect All";
            this.DeselectAll.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(12, 295);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(143, 27);
            this.Return.TabIndex = 5;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear Announcement";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SendAnnouncement
            // 
            this.SendAnnouncement.Location = new System.Drawing.Point(422, 328);
            this.SendAnnouncement.Name = "SendAnnouncement";
            this.SendAnnouncement.Size = new System.Drawing.Size(125, 23);
            this.SendAnnouncement.TabIndex = 7;
            this.SendAnnouncement.Text = "Send Announcement";
            this.SendAnnouncement.UseVisualStyleBackColor = true;
            // 
            // NewAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 384);
            this.Controls.Add(this.SendAnnouncement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.DeselectAll);
            this.Controls.Add(this.AnnouncementText);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.RecipientGroupsLabel);
            this.Controls.Add(this.richTextBox1);
            this.Name = "NewAnnouncement";
            this.Text = "NewAnnouncement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label RecipientGroupsLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label AnnouncementText;
        private System.Windows.Forms.Button DeselectAll;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendAnnouncement;
    }
}