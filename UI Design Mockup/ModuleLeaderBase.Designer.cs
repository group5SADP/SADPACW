namespace UI_Design_Mockup
{
    partial class ModuleLeaderBase
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
            this.ModuleTeamButton = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.ViewFeedback = new System.Windows.Forms.Button();
            this.DeadlineView = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModuleTeamButton
            // 
            this.ModuleTeamButton.Location = new System.Drawing.Point(11, 57);
            this.ModuleTeamButton.Name = "ModuleTeamButton";
            this.ModuleTeamButton.Size = new System.Drawing.Size(117, 23);
            this.ModuleTeamButton.TabIndex = 0;
            this.ModuleTeamButton.Text = "View Module Team";
            this.ModuleTeamButton.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(12, 22);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(117, 13);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome, [User Name]";
            // 
            // ViewFeedback
            // 
            this.ViewFeedback.Location = new System.Drawing.Point(11, 86);
            this.ViewFeedback.Name = "ViewFeedback";
            this.ViewFeedback.Size = new System.Drawing.Size(117, 23);
            this.ViewFeedback.TabIndex = 2;
            this.ViewFeedback.Text = "View Feedback ";
            this.ViewFeedback.UseVisualStyleBackColor = true;
            // 
            // DeadlineView
            // 
            this.DeadlineView.Location = new System.Drawing.Point(134, 57);
            this.DeadlineView.Name = "DeadlineView";
            this.DeadlineView.Size = new System.Drawing.Size(117, 23);
            this.DeadlineView.TabIndex = 3;
            this.DeadlineView.Text = "View Deadlines";
            this.DeadlineView.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(134, 86);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(117, 23);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // ModuleLeaderBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 134);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.DeadlineView);
            this.Controls.Add(this.ViewFeedback);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.ModuleTeamButton);
            this.Name = "ModuleLeaderBase";
            this.Text = "ModuleLeaderBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModuleTeamButton;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button ViewFeedback;
        private System.Windows.Forms.Button DeadlineView;
        private System.Windows.Forms.Button Logout;
    }
}