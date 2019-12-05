namespace UI_Design_Mockup
{
    partial class ModuleTeam
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
            this.ACWListLabel = new System.Windows.Forms.Label();
            this.ACWList = new System.Windows.Forms.ListBox();
            this.DeadlineBox = new System.Windows.Forms.ListBox();
            this.DeadlineDisplay = new System.Windows.Forms.Label();
            this.ExistingFeedback = new System.Windows.Forms.Label();
            this.FeedbackBox = new System.Windows.Forms.ListBox();
            this.Feedback = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ACWListLabel
            // 
            this.ACWListLabel.AutoSize = true;
            this.ACWListLabel.Location = new System.Drawing.Point(12, 31);
            this.ACWListLabel.Name = "ACWListLabel";
            this.ACWListLabel.Size = new System.Drawing.Size(37, 13);
            this.ACWListLabel.TabIndex = 0;
            this.ACWListLabel.Text = "ACWs";
            // 
            // ACWList
            // 
            this.ACWList.FormattingEnabled = true;
            this.ACWList.Items.AddRange(new object[] {
            "80038-SE-Term 2 2019",
            "80034-SE-Term 1 2019"});
            this.ACWList.Location = new System.Drawing.Point(12, 47);
            this.ACWList.Name = "ACWList";
            this.ACWList.Size = new System.Drawing.Size(137, 82);
            this.ACWList.TabIndex = 1;
            // 
            // DeadlineBox
            // 
            this.DeadlineBox.FormattingEnabled = true;
            this.DeadlineBox.Items.AddRange(new object[] {
            "--/--/--"});
            this.DeadlineBox.Location = new System.Drawing.Point(155, 47);
            this.DeadlineBox.Name = "DeadlineBox";
            this.DeadlineBox.Size = new System.Drawing.Size(137, 17);
            this.DeadlineBox.TabIndex = 2;
            this.DeadlineBox.SelectedIndexChanged += new System.EventHandler(this.DeadlineBox_SelectedIndexChanged);
            // 
            // DeadlineDisplay
            // 
            this.DeadlineDisplay.AutoSize = true;
            this.DeadlineDisplay.Location = new System.Drawing.Point(152, 31);
            this.DeadlineDisplay.Name = "DeadlineDisplay";
            this.DeadlineDisplay.Size = new System.Drawing.Size(86, 13);
            this.DeadlineDisplay.TabIndex = 3;
            this.DeadlineDisplay.Text = "Deadline Display";
            // 
            // ExistingFeedback
            // 
            this.ExistingFeedback.AutoSize = true;
            this.ExistingFeedback.Location = new System.Drawing.Point(155, 67);
            this.ExistingFeedback.Name = "ExistingFeedback";
            this.ExistingFeedback.Size = new System.Drawing.Size(69, 13);
            this.ExistingFeedback.TabIndex = 4;
            this.ExistingFeedback.Text = "All Feedback";
            // 
            // FeedbackBox
            // 
            this.FeedbackBox.FormattingEnabled = true;
            this.FeedbackBox.Items.AddRange(new object[] {
            "[Submitted Feedback",
            "Appears Here]"});
            this.FeedbackBox.Location = new System.Drawing.Point(155, 83);
            this.FeedbackBox.Name = "FeedbackBox";
            this.FeedbackBox.Size = new System.Drawing.Size(137, 43);
            this.FeedbackBox.TabIndex = 5;
            // 
            // Feedback
            // 
            this.Feedback.Location = new System.Drawing.Point(155, 132);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(137, 31);
            this.Feedback.TabIndex = 6;
            this.Feedback.Text = "View Selected Feedback";
            this.Feedback.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 136);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 27);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // ModuleTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.FeedbackBox);
            this.Controls.Add(this.ExistingFeedback);
            this.Controls.Add(this.DeadlineDisplay);
            this.Controls.Add(this.DeadlineBox);
            this.Controls.Add(this.ACWList);
            this.Controls.Add(this.ACWListLabel);
            this.Name = "ModuleTeam";
            this.Text = "ModuleTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ACWListLabel;
        private System.Windows.Forms.ListBox ACWList;
        private System.Windows.Forms.ListBox DeadlineBox;
        private System.Windows.Forms.Label DeadlineDisplay;
        private System.Windows.Forms.Label ExistingFeedback;
        private System.Windows.Forms.ListBox FeedbackBox;
        private System.Windows.Forms.Button Feedback;
        private System.Windows.Forms.Button Logout;
    }
}