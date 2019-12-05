namespace UI_Design_Mockup
{
    partial class Panel
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
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.ACWList = new System.Windows.Forms.ListBox();
            this.ACWLabel = new System.Windows.Forms.Label();
            this.ACWDeadList = new System.Windows.Forms.ListBox();
            this.ACWDeadLabel = new System.Windows.Forms.Label();
            this.SubmittedFeedback = new System.Windows.Forms.ListBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.ViewFeed = new System.Windows.Forms.Button();
            this.FlagButton = new System.Windows.Forms.Button();
            this.MeetingLabel = new System.Windows.Forms.Label();
            this.MeetingDates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(12, 29);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(45, 13);
            this.CoursesLabel.TabIndex = 0;
            this.CoursesLabel.Text = "Courses";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(12, 88);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(47, 13);
            this.ModuleLabel.TabIndex = 2;
            this.ModuleLabel.Text = "Modules";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(12, 146);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(51, 13);
            this.SemesterLabel.TabIndex = 4;
            this.SemesterLabel.Text = "Semester";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 162);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(12, 216);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // ACWList
            // 
            this.ACWList.FormattingEnabled = true;
            this.ACWList.Items.AddRange(new object[] {
            "80038-SE-1"});
            this.ACWList.Location = new System.Drawing.Point(152, 45);
            this.ACWList.Name = "ACWList";
            this.ACWList.Size = new System.Drawing.Size(136, 56);
            this.ACWList.TabIndex = 7;
            // 
            // ACWLabel
            // 
            this.ACWLabel.AutoSize = true;
            this.ACWLabel.Location = new System.Drawing.Point(149, 29);
            this.ACWLabel.Name = "ACWLabel";
            this.ACWLabel.Size = new System.Drawing.Size(37, 13);
            this.ACWLabel.TabIndex = 8;
            this.ACWLabel.Text = "ACWs";
            // 
            // ACWDeadList
            // 
            this.ACWDeadList.FormattingEnabled = true;
            this.ACWDeadList.Items.AddRange(new object[] {
            "--/--/--"});
            this.ACWDeadList.Location = new System.Drawing.Point(294, 45);
            this.ACWDeadList.Name = "ACWDeadList";
            this.ACWDeadList.Size = new System.Drawing.Size(136, 17);
            this.ACWDeadList.TabIndex = 9;
            // 
            // ACWDeadLabel
            // 
            this.ACWDeadLabel.AutoSize = true;
            this.ACWDeadLabel.Location = new System.Drawing.Point(291, 29);
            this.ACWDeadLabel.Name = "ACWDeadLabel";
            this.ACWDeadLabel.Size = new System.Drawing.Size(122, 13);
            this.ACWDeadLabel.TabIndex = 10;
            this.ACWDeadLabel.Text = "Selected ACW Deadline";
            // 
            // SubmittedFeedback
            // 
            this.SubmittedFeedback.FormattingEnabled = true;
            this.SubmittedFeedback.Location = new System.Drawing.Point(294, 84);
            this.SubmittedFeedback.Name = "SubmittedFeedback";
            this.SubmittedFeedback.Size = new System.Drawing.Size(136, 95);
            this.SubmittedFeedback.TabIndex = 11;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(294, 68);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(55, 13);
            this.FeedbackLabel.TabIndex = 12;
            this.FeedbackLabel.Text = "Feedback";
            // 
            // ViewFeed
            // 
            this.ViewFeed.Location = new System.Drawing.Point(294, 185);
            this.ViewFeed.Name = "ViewFeed";
            this.ViewFeed.Size = new System.Drawing.Size(66, 35);
            this.ViewFeed.TabIndex = 13;
            this.ViewFeed.Text = "View Feedback";
            this.ViewFeed.UseVisualStyleBackColor = true;
            // 
            // FlagButton
            // 
            this.FlagButton.Location = new System.Drawing.Point(361, 185);
            this.FlagButton.Name = "FlagButton";
            this.FlagButton.Size = new System.Drawing.Size(69, 35);
            this.FlagButton.TabIndex = 14;
            this.FlagButton.Text = "Flag Feedback";
            this.FlagButton.UseVisualStyleBackColor = true;
            // 
            // MeetingLabel
            // 
            this.MeetingLabel.AutoSize = true;
            this.MeetingLabel.Location = new System.Drawing.Point(151, 112);
            this.MeetingLabel.Name = "MeetingLabel";
            this.MeetingLabel.Size = new System.Drawing.Size(76, 13);
            this.MeetingLabel.TabIndex = 15;
            this.MeetingLabel.Text = "Meeting Dates";
            // 
            // MeetingDates
            // 
            this.MeetingDates.FormattingEnabled = true;
            this.MeetingDates.Items.AddRange(new object[] {
            "--/--/--",
            "--/--/--",
            "--/--/--"});
            this.MeetingDates.Location = new System.Drawing.Point(154, 128);
            this.MeetingDates.Name = "MeetingDates";
            this.MeetingDates.Size = new System.Drawing.Size(134, 56);
            this.MeetingDates.TabIndex = 16;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.MeetingDates);
            this.Controls.Add(this.MeetingLabel);
            this.Controls.Add(this.FlagButton);
            this.Controls.Add(this.ViewFeed);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.SubmittedFeedback);
            this.Controls.Add(this.ACWDeadLabel);
            this.Controls.Add(this.ACWDeadList);
            this.Controls.Add(this.ACWLabel);
            this.Controls.Add(this.ACWList);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CoursesLabel);
            this.Name = "Panel";
            this.Text = "Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ListBox ACWList;
        private System.Windows.Forms.Label ACWLabel;
        private System.Windows.Forms.ListBox ACWDeadList;
        private System.Windows.Forms.Label ACWDeadLabel;
        private System.Windows.Forms.ListBox SubmittedFeedback;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Button ViewFeed;
        private System.Windows.Forms.Button FlagButton;
        private System.Windows.Forms.Label MeetingLabel;
        private System.Windows.Forms.ListBox MeetingDates;
    }
}