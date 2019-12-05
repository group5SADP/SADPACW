namespace UI_Design_Mockup
{
    partial class StudentSchedule
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
            this.CourseSelect = new System.Windows.Forms.ComboBox();
            this.ScheduleDisplay = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseSelect
            // 
            this.CourseSelect.FormattingEnabled = true;
            this.CourseSelect.Location = new System.Drawing.Point(12, 12);
            this.CourseSelect.Name = "CourseSelect";
            this.CourseSelect.Size = new System.Drawing.Size(103, 21);
            this.CourseSelect.TabIndex = 0;
            this.CourseSelect.Text = "Choose Course";
            // 
            // ScheduleDisplay
            // 
            this.ScheduleDisplay.FormattingEnabled = true;
            this.ScheduleDisplay.Location = new System.Drawing.Point(121, 12);
            this.ScheduleDisplay.Name = "ScheduleDisplay";
            this.ScheduleDisplay.Size = new System.Drawing.Size(227, 303);
            this.ScheduleDisplay.TabIndex = 1;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(121, 321);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 2;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(273, 321);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // StudentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ScheduleDisplay);
            this.Controls.Add(this.CourseSelect);
            this.Name = "StudentSchedule";
            this.Text = "StudentSchedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseSelect;
        private System.Windows.Forms.ListBox ScheduleDisplay;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button LogOut;
    }
}