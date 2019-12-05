namespace UI_Design_Mockup
{
    partial class FeedbackPage
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
            this.ACWID = new System.Windows.Forms.Label();
            this.ExistFeedback = new System.Windows.Forms.Label();
            this.FeedList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FeedbackUp = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ACWID
            // 
            this.ACWID.AutoSize = true;
            this.ACWID.Location = new System.Drawing.Point(12, 23);
            this.ACWID.Name = "ACWID";
            this.ACWID.Size = new System.Drawing.Size(106, 13);
            this.ACWID.TabIndex = 0;
            this.ACWID.Text = "[ACW ID Goes Here]";
            // 
            // ExistFeedback
            // 
            this.ExistFeedback.AutoSize = true;
            this.ExistFeedback.Location = new System.Drawing.Point(12, 90);
            this.ExistFeedback.Name = "ExistFeedback";
            this.ExistFeedback.Size = new System.Drawing.Size(94, 13);
            this.ExistFeedback.TabIndex = 1;
            this.ExistFeedback.Text = "Existing Feedback";
            // 
            // FeedList
            // 
            this.FeedList.FormattingEnabled = true;
            this.FeedList.Items.AddRange(new object[] {
            "[Feedback].txt",
            "[Feedback].pdf"});
            this.FeedList.Location = new System.Drawing.Point(15, 119);
            this.FeedList.Name = "FeedList";
            this.FeedList.Size = new System.Drawing.Size(259, 134);
            this.FeedList.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Download Selected\r\nFeedback\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FeedbackUp
            // 
            this.FeedbackUp.Location = new System.Drawing.Point(160, 259);
            this.FeedbackUp.Name = "FeedbackUp";
            this.FeedbackUp.Size = new System.Drawing.Size(114, 52);
            this.FeedbackUp.TabIndex = 4;
            this.FeedbackUp.Text = "Upload New Feedback";
            this.FeedbackUp.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(15, 332);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(69, 26);
            this.Return.TabIndex = 5;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // FeedbackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 367);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.FeedbackUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeedList);
            this.Controls.Add(this.ExistFeedback);
            this.Controls.Add(this.ACWID);
            this.Name = "FeedbackPage";
            this.Text = "FeedbackPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ACWID;
        private System.Windows.Forms.Label ExistFeedback;
        private System.Windows.Forms.ListBox FeedList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FeedbackUp;
        private System.Windows.Forms.Button Return;
    }
}