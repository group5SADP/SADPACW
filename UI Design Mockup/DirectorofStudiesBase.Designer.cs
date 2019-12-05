namespace UI_Design_Mockup
{
    partial class DirectorofStudiesBase
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
            this.CourseDropDown = new System.Windows.Forms.ComboBox();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.ModuleDropDown = new System.Windows.Forms.ComboBox();
            this.ModuleList = new System.Windows.Forms.Label();
            this.ModuleTeamList = new System.Windows.Forms.ListBox();
            this.RemoveMember = new System.Windows.Forms.Button();
            this.AddNewMember = new System.Windows.Forms.Button();
            this.TeamListLabel = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.ModuleACWList = new System.Windows.Forms.ListBox();
            this.ModuleACWsLabel = new System.Windows.Forms.Label();
            this.ACWDetail = new System.Windows.Forms.Button();
            this.FlagACW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseDropDown
            // 
            this.CourseDropDown.FormattingEnabled = true;
            this.CourseDropDown.Location = new System.Drawing.Point(15, 50);
            this.CourseDropDown.Name = "CourseDropDown";
            this.CourseDropDown.Size = new System.Drawing.Size(121, 21);
            this.CourseDropDown.TabIndex = 0;
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(12, 34);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(40, 13);
            this.ModuleLabel.TabIndex = 1;
            this.ModuleLabel.Text = "Course";
            this.ModuleLabel.Click += new System.EventHandler(this.ModuleLabel_Click);
            // 
            // ModuleDropDown
            // 
            this.ModuleDropDown.FormattingEnabled = true;
            this.ModuleDropDown.Location = new System.Drawing.Point(142, 50);
            this.ModuleDropDown.Name = "ModuleDropDown";
            this.ModuleDropDown.Size = new System.Drawing.Size(121, 21);
            this.ModuleDropDown.TabIndex = 2;
            // 
            // ModuleList
            // 
            this.ModuleList.AutoSize = true;
            this.ModuleList.Location = new System.Drawing.Point(139, 34);
            this.ModuleList.Name = "ModuleList";
            this.ModuleList.Size = new System.Drawing.Size(42, 13);
            this.ModuleList.TabIndex = 3;
            this.ModuleList.Text = "Module";
            // 
            // ModuleTeamList
            // 
            this.ModuleTeamList.FormattingEnabled = true;
            this.ModuleTeamList.Items.AddRange(new object[] {
            "ModuleTeamList"});
            this.ModuleTeamList.Location = new System.Drawing.Point(15, 112);
            this.ModuleTeamList.Name = "ModuleTeamList";
            this.ModuleTeamList.Size = new System.Drawing.Size(247, 238);
            this.ModuleTeamList.TabIndex = 4;
            // 
            // RemoveMember
            // 
            this.RemoveMember.Location = new System.Drawing.Point(15, 356);
            this.RemoveMember.Name = "RemoveMember";
            this.RemoveMember.Size = new System.Drawing.Size(98, 40);
            this.RemoveMember.TabIndex = 5;
            this.RemoveMember.Text = "Remove Team\r\nMember\r\n";
            this.RemoveMember.UseVisualStyleBackColor = true;
            // 
            // AddNewMember
            // 
            this.AddNewMember.Location = new System.Drawing.Point(164, 356);
            this.AddNewMember.Name = "AddNewMember";
            this.AddNewMember.Size = new System.Drawing.Size(98, 40);
            this.AddNewMember.TabIndex = 6;
            this.AddNewMember.Text = "Add Team Member";
            this.AddNewMember.UseVisualStyleBackColor = true;
            // 
            // TeamListLabel
            // 
            this.TeamListLabel.AutoSize = true;
            this.TeamListLabel.Location = new System.Drawing.Point(17, 96);
            this.TeamListLabel.Name = "TeamListLabel";
            this.TeamListLabel.Size = new System.Drawing.Size(72, 13);
            this.TeamListLabel.TabIndex = 7;
            this.TeamListLabel.Text = "Module Team";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(15, 412);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(98, 23);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // ModuleACWList
            // 
            this.ModuleACWList.FormattingEnabled = true;
            this.ModuleACWList.Location = new System.Drawing.Point(272, 112);
            this.ModuleACWList.Name = "ModuleACWList";
            this.ModuleACWList.Size = new System.Drawing.Size(247, 238);
            this.ModuleACWList.TabIndex = 9;
            // 
            // ModuleACWsLabel
            // 
            this.ModuleACWsLabel.AutoSize = true;
            this.ModuleACWsLabel.Location = new System.Drawing.Point(269, 96);
            this.ModuleACWsLabel.Name = "ModuleACWsLabel";
            this.ModuleACWsLabel.Size = new System.Drawing.Size(75, 13);
            this.ModuleACWsLabel.TabIndex = 10;
            this.ModuleACWsLabel.Text = "Module ACWs";
            // 
            // ACWDetail
            // 
            this.ACWDetail.Location = new System.Drawing.Point(272, 356);
            this.ACWDetail.Name = "ACWDetail";
            this.ACWDetail.Size = new System.Drawing.Size(98, 40);
            this.ACWDetail.TabIndex = 11;
            this.ACWDetail.Text = "View ACW Details";
            this.ACWDetail.UseVisualStyleBackColor = true;
            // 
            // FlagACW
            // 
            this.FlagACW.Location = new System.Drawing.Point(421, 356);
            this.FlagACW.Name = "FlagACW";
            this.FlagACW.Size = new System.Drawing.Size(98, 40);
            this.FlagACW.TabIndex = 12;
            this.FlagACW.Text = "Flag for \r\nRewrite";
            this.FlagACW.UseVisualStyleBackColor = true;
            // 
            // DirectorofStudiesBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 472);
            this.Controls.Add(this.FlagACW);
            this.Controls.Add(this.ACWDetail);
            this.Controls.Add(this.ModuleACWsLabel);
            this.Controls.Add(this.ModuleACWList);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.TeamListLabel);
            this.Controls.Add(this.AddNewMember);
            this.Controls.Add(this.RemoveMember);
            this.Controls.Add(this.ModuleTeamList);
            this.Controls.Add(this.ModuleList);
            this.Controls.Add(this.ModuleDropDown);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.CourseDropDown);
            this.Name = "DirectorofStudiesBase";
            this.Text = "DirectorofStudiesBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseDropDown;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.ComboBox ModuleDropDown;
        private System.Windows.Forms.Label ModuleList;
        private System.Windows.Forms.ListBox ModuleTeamList;
        private System.Windows.Forms.Button RemoveMember;
        private System.Windows.Forms.Button AddNewMember;
        private System.Windows.Forms.Label TeamListLabel;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ListBox ModuleACWList;
        private System.Windows.Forms.Label ModuleACWsLabel;
        private System.Windows.Forms.Button ACWDetail;
        private System.Windows.Forms.Button FlagACW;
    }
}