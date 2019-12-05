namespace UI_Design_Mockup
{
    partial class ModeratorBase
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
            this.Courses = new System.Windows.Forms.Label();
            this.CourseSelectBox = new System.Windows.Forms.ComboBox();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.ModuleBox = new System.Windows.Forms.ComboBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.SemesterBox = new System.Windows.Forms.ComboBox();
            this.CourseworkList = new System.Windows.Forms.ListBox();
            this.ViewACW = new System.Windows.Forms.Button();
            this.LogOUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Courses
            // 
            this.Courses.AutoSize = true;
            this.Courses.Location = new System.Drawing.Point(12, 24);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(45, 13);
            this.Courses.TabIndex = 0;
            this.Courses.Text = "Courses";
            // 
            // CourseSelectBox
            // 
            this.CourseSelectBox.FormattingEnabled = true;
            this.CourseSelectBox.Location = new System.Drawing.Point(12, 40);
            this.CourseSelectBox.Name = "CourseSelectBox";
            this.CourseSelectBox.Size = new System.Drawing.Size(121, 21);
            this.CourseSelectBox.TabIndex = 1;
            this.CourseSelectBox.Text = "Select Course";
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(12, 79);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModuleLabel.Size = new System.Drawing.Size(47, 13);
            this.ModuleLabel.TabIndex = 2;
            this.ModuleLabel.Text = "Modules";
            // 
            // ModuleBox
            // 
            this.ModuleBox.FormattingEnabled = true;
            this.ModuleBox.Location = new System.Drawing.Point(12, 95);
            this.ModuleBox.Name = "ModuleBox";
            this.ModuleBox.Size = new System.Drawing.Size(121, 21);
            this.ModuleBox.TabIndex = 3;
            this.ModuleBox.Text = "Select Module";
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(12, 134);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(51, 13);
            this.SemesterLabel.TabIndex = 4;
            this.SemesterLabel.Text = "Semester";
            // 
            // SemesterBox
            // 
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.Location = new System.Drawing.Point(12, 150);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(121, 21);
            this.SemesterBox.TabIndex = 5;
            this.SemesterBox.Text = "Select Semester";
            // 
            // CourseworkList
            // 
            this.CourseworkList.FormattingEnabled = true;
            this.CourseworkList.Items.AddRange(new object[] {
            "80038-Year 2-Software Engineering",
            "80084-Year 3-Artificial Intelligence"});
            this.CourseworkList.Location = new System.Drawing.Point(159, 40);
            this.CourseworkList.Name = "CourseworkList";
            this.CourseworkList.Size = new System.Drawing.Size(346, 134);
            this.CourseworkList.TabIndex = 6;
            // 
            // ViewACW
            // 
            this.ViewACW.Location = new System.Drawing.Point(431, 180);
            this.ViewACW.Name = "ViewACW";
            this.ViewACW.Size = new System.Drawing.Size(74, 32);
            this.ViewACW.TabIndex = 7;
            this.ViewACW.Text = "View ACW";
            this.ViewACW.UseVisualStyleBackColor = true;
            // 
            // LogOUt
            // 
            this.LogOUt.Location = new System.Drawing.Point(159, 180);
            this.LogOUt.Name = "LogOUt";
            this.LogOUt.Size = new System.Drawing.Size(75, 32);
            this.LogOUt.TabIndex = 8;
            this.LogOUt.Text = "Log Out";
            this.LogOUt.UseVisualStyleBackColor = true;
            // 
            // ModeratorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 229);
            this.Controls.Add(this.LogOUt);
            this.Controls.Add(this.ViewACW);
            this.Controls.Add(this.CourseworkList);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.ModuleBox);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.CourseSelectBox);
            this.Controls.Add(this.Courses);
            this.Name = "ModeratorBase";
            this.Text = "ModeratorBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Courses;
        private System.Windows.Forms.ComboBox CourseSelectBox;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.ComboBox ModuleBox;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox SemesterBox;
        private System.Windows.Forms.ListBox CourseworkList;
        private System.Windows.Forms.Button ViewACW;
        private System.Windows.Forms.Button LogOUt;
    }
}