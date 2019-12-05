namespace UI_Design_Mockup
{
    partial class ModuleTeamView
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
            this.ModuleListLabel = new System.Windows.Forms.Label();
            this.TeamList = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModuleListLabel
            // 
            this.ModuleListLabel.AutoSize = true;
            this.ModuleListLabel.Location = new System.Drawing.Point(12, 21);
            this.ModuleListLabel.Name = "ModuleListLabel";
            this.ModuleListLabel.Size = new System.Drawing.Size(91, 13);
            this.ModuleListLabel.TabIndex = 0;
            this.ModuleListLabel.Text = "Module Team List";
            // 
            // TeamList
            // 
            this.TeamList.FormattingEnabled = true;
            this.TeamList.Items.AddRange(new object[] {
            "A. Smith",
            "B. Ellis",
            "C. Temp"});
            this.TeamList.Location = new System.Drawing.Point(15, 47);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(178, 82);
            this.TeamList.TabIndex = 1;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(15, 145);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 2;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // ModuleTeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 206);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.TeamList);
            this.Controls.Add(this.ModuleListLabel);
            this.Name = "ModuleTeamView";
            this.Text = "ModuleTeamView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModuleListLabel;
        private System.Windows.Forms.ListBox TeamList;
        private System.Windows.Forms.Button Return;
    }
}