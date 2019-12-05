namespace UI_Design_Mockup
{
    partial class ACWView
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
            this.FullTitle = new System.Windows.Forms.Label();
            this.ACWTitle = new System.Windows.Forms.ListBox();
            this.ACWID = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ACWTypeLabel = new System.Windows.Forms.Label();
            this.ACWTypeBox = new System.Windows.Forms.ListBox();
            this.Assessor = new System.Windows.Forms.Label();
            this.AssessorBox = new System.Windows.Forms.ListBox();
            this.StudentDeadlineLabel = new System.Windows.Forms.Label();
            this.StudentDeadline = new System.Windows.Forms.ListBox();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.MarkWeightBox = new System.Windows.Forms.ListBox();
            this.FeedLabel = new System.Windows.Forms.Label();
            this.FeedbackBox = new System.Windows.Forms.ListBox();
            this.ResubLabel = new System.Windows.Forms.Label();
            this.ResubAllowed = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            this.DownloadACW = new System.Windows.Forms.Button();
            this.FeedbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullTitle
            // 
            this.FullTitle.AutoSize = true;
            this.FullTitle.Location = new System.Drawing.Point(12, 69);
            this.FullTitle.Name = "FullTitle";
            this.FullTitle.Size = new System.Drawing.Size(55, 13);
            this.FullTitle.TabIndex = 0;
            this.FullTitle.Text = "ACW Title";
            this.FullTitle.Click += new System.EventHandler(this.FullTitle_Click);
            // 
            // ACWTitle
            // 
            this.ACWTitle.FormattingEnabled = true;
            this.ACWTitle.Items.AddRange(new object[] {
            "Coursework Title Goes Here"});
            this.ACWTitle.Location = new System.Drawing.Point(15, 85);
            this.ACWTitle.Name = "ACWTitle";
            this.ACWTitle.Size = new System.Drawing.Size(149, 17);
            this.ACWTitle.TabIndex = 1;
            // 
            // ACWID
            // 
            this.ACWID.AutoSize = true;
            this.ACWID.Location = new System.Drawing.Point(12, 24);
            this.ACWID.Name = "ACWID";
            this.ACWID.Size = new System.Drawing.Size(46, 13);
            this.ACWID.TabIndex = 2;
            this.ACWID.Text = "ACW ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "SE-0833-2019"});
            this.listBox1.Location = new System.Drawing.Point(15, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 17);
            this.listBox1.TabIndex = 3;
            // 
            // ACWTypeLabel
            // 
            this.ACWTypeLabel.AutoSize = true;
            this.ACWTypeLabel.Location = new System.Drawing.Point(12, 118);
            this.ACWTypeLabel.Name = "ACWTypeLabel";
            this.ACWTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.ACWTypeLabel.TabIndex = 4;
            this.ACWTypeLabel.Text = "ACW Type\r\n";
            // 
            // ACWTypeBox
            // 
            this.ACWTypeBox.FormattingEnabled = true;
            this.ACWTypeBox.Items.AddRange(new object[] {
            "Solo/Group"});
            this.ACWTypeBox.Location = new System.Drawing.Point(15, 134);
            this.ACWTypeBox.Name = "ACWTypeBox";
            this.ACWTypeBox.Size = new System.Drawing.Size(149, 17);
            this.ACWTypeBox.TabIndex = 5;
            // 
            // Assessor
            // 
            this.Assessor.AutoSize = true;
            this.Assessor.Location = new System.Drawing.Point(12, 170);
            this.Assessor.Name = "Assessor";
            this.Assessor.Size = new System.Drawing.Size(60, 13);
            this.Assessor.TabIndex = 6;
            this.Assessor.Text = "Assessor(s)";
            // 
            // AssessorBox
            // 
            this.AssessorBox.FormattingEnabled = true;
            this.AssessorBox.Items.AddRange(new object[] {
            "[Lecturer Name(s)]"});
            this.AssessorBox.Location = new System.Drawing.Point(12, 186);
            this.AssessorBox.Name = "AssessorBox";
            this.AssessorBox.Size = new System.Drawing.Size(149, 17);
            this.AssessorBox.TabIndex = 7;
            // 
            // StudentDeadlineLabel
            // 
            this.StudentDeadlineLabel.AutoSize = true;
            this.StudentDeadlineLabel.Location = new System.Drawing.Point(167, 24);
            this.StudentDeadlineLabel.Name = "StudentDeadlineLabel";
            this.StudentDeadlineLabel.Size = new System.Drawing.Size(89, 13);
            this.StudentDeadlineLabel.TabIndex = 8;
            this.StudentDeadlineLabel.Text = "Student Deadline";
            // 
            // StudentDeadline
            // 
            this.StudentDeadline.FormattingEnabled = true;
            this.StudentDeadline.Items.AddRange(new object[] {
            "07/12/19"});
            this.StudentDeadline.Location = new System.Drawing.Point(170, 40);
            this.StudentDeadline.Name = "StudentDeadline";
            this.StudentDeadline.Size = new System.Drawing.Size(149, 17);
            this.StudentDeadline.TabIndex = 9;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(170, 69);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(82, 13);
            this.MarkLabel.TabIndex = 10;
            this.MarkLabel.Text = "Mark Weighting";
            // 
            // MarkWeightBox
            // 
            this.MarkWeightBox.FormattingEnabled = true;
            this.MarkWeightBox.Items.AddRange(new object[] {
            "30%"});
            this.MarkWeightBox.Location = new System.Drawing.Point(170, 85);
            this.MarkWeightBox.Name = "MarkWeightBox";
            this.MarkWeightBox.Size = new System.Drawing.Size(149, 17);
            this.MarkWeightBox.TabIndex = 11;
            // 
            // FeedLabel
            // 
            this.FeedLabel.AutoSize = true;
            this.FeedLabel.Location = new System.Drawing.Point(170, 118);
            this.FeedLabel.Name = "FeedLabel";
            this.FeedLabel.Size = new System.Drawing.Size(100, 13);
            this.FeedLabel.TabIndex = 12;
            this.FeedLabel.Text = "Feedback Deadline";
            // 
            // FeedbackBox
            // 
            this.FeedbackBox.FormattingEnabled = true;
            this.FeedbackBox.Items.AddRange(new object[] {
            "07/01/19"});
            this.FeedbackBox.Location = new System.Drawing.Point(173, 134);
            this.FeedbackBox.Name = "FeedbackBox";
            this.FeedbackBox.Size = new System.Drawing.Size(146, 17);
            this.FeedbackBox.TabIndex = 13;
            // 
            // ResubLabel
            // 
            this.ResubLabel.AutoSize = true;
            this.ResubLabel.Location = new System.Drawing.Point(170, 170);
            this.ResubLabel.Name = "ResubLabel";
            this.ResubLabel.Size = new System.Drawing.Size(72, 13);
            this.ResubLabel.TabIndex = 14;
            this.ResubLabel.Text = "Resubmission";
            // 
            // ResubAllowed
            // 
            this.ResubAllowed.FormattingEnabled = true;
            this.ResubAllowed.Items.AddRange(new object[] {
            "Allowed"});
            this.ResubAllowed.Location = new System.Drawing.Point(173, 186);
            this.ResubAllowed.Name = "ResubAllowed";
            this.ResubAllowed.Size = new System.Drawing.Size(146, 17);
            this.ResubAllowed.TabIndex = 15;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(12, 209);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 16;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // DownloadACW
            // 
            this.DownloadACW.Location = new System.Drawing.Point(244, 209);
            this.DownloadACW.Name = "DownloadACW";
            this.DownloadACW.Size = new System.Drawing.Size(75, 23);
            this.DownloadACW.TabIndex = 17;
            this.DownloadACW.Text = "Download ";
            this.DownloadACW.UseVisualStyleBackColor = true;
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.Location = new System.Drawing.Point(131, 209);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(75, 23);
            this.FeedbackButton.TabIndex = 18;
            this.FeedbackButton.Text = "Feedback";
            this.FeedbackButton.UseVisualStyleBackColor = true;
            // 
            // ACWView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 256);
            this.Controls.Add(this.FeedbackButton);
            this.Controls.Add(this.DownloadACW);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ResubAllowed);
            this.Controls.Add(this.ResubLabel);
            this.Controls.Add(this.FeedbackBox);
            this.Controls.Add(this.FeedLabel);
            this.Controls.Add(this.MarkWeightBox);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.StudentDeadline);
            this.Controls.Add(this.StudentDeadlineLabel);
            this.Controls.Add(this.AssessorBox);
            this.Controls.Add(this.Assessor);
            this.Controls.Add(this.ACWTypeBox);
            this.Controls.Add(this.ACWTypeLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ACWID);
            this.Controls.Add(this.ACWTitle);
            this.Controls.Add(this.FullTitle);
            this.Name = "ACWView";
            this.Text = "ACWView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullTitle;
        private System.Windows.Forms.ListBox ACWTitle;
        private System.Windows.Forms.Label ACWID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ACWTypeLabel;
        private System.Windows.Forms.ListBox ACWTypeBox;
        private System.Windows.Forms.Label Assessor;
        private System.Windows.Forms.ListBox AssessorBox;
        private System.Windows.Forms.Label StudentDeadlineLabel;
        private System.Windows.Forms.ListBox StudentDeadline;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.ListBox MarkWeightBox;
        private System.Windows.Forms.Label FeedLabel;
        private System.Windows.Forms.ListBox FeedbackBox;
        private System.Windows.Forms.Label ResubLabel;
        private System.Windows.Forms.ListBox ResubAllowed;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button DownloadACW;
        private System.Windows.Forms.Button FeedbackButton;
    }
}