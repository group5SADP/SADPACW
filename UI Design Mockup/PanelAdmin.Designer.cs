namespace UI_Design_Mockup
{
    partial class PanelAdmin
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
            this.CourseLabel = new System.Windows.Forms.Label();
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.ModBox = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.SemesterBox = new System.Windows.Forms.ComboBox();
            this.ListBoxACW = new System.Windows.Forms.ListBox();
            this.ACWList = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DeadLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ACWDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(12, 25);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(45, 13);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Courses";
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(12, 41);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(121, 21);
            this.CourseBox.TabIndex = 1;
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(12, 82);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(47, 13);
            this.ModuleLabel.TabIndex = 2;
            this.ModuleLabel.Text = "Modules";
            // 
            // ModBox
            // 
            this.ModBox.FormattingEnabled = true;
            this.ModBox.Location = new System.Drawing.Point(12, 98);
            this.ModBox.Name = "ModBox";
            this.ModBox.Size = new System.Drawing.Size(121, 21);
            this.ModBox.TabIndex = 3;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(12, 141);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(51, 13);
            this.labelSemester.TabIndex = 4;
            this.labelSemester.Text = "Semester";
            // 
            // SemesterBox
            // 
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.Location = new System.Drawing.Point(12, 157);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(121, 21);
            this.SemesterBox.TabIndex = 5;
            // 
            // ListBoxACW
            // 
            this.ListBoxACW.FormattingEnabled = true;
            this.ListBoxACW.Items.AddRange(new object[] {
            "80038-SE-19/20",
            "80048-SE-20/21"});
            this.ListBoxACW.Location = new System.Drawing.Point(139, 41);
            this.ListBoxACW.Name = "ListBoxACW";
            this.ListBoxACW.Size = new System.Drawing.Size(236, 134);
            this.ListBoxACW.TabIndex = 6;
            // 
            // ACWList
            // 
            this.ACWList.AutoSize = true;
            this.ACWList.Location = new System.Drawing.Point(139, 25);
            this.ACWList.Name = "ACWList";
            this.ACWList.Size = new System.Drawing.Size(37, 13);
            this.ACWList.TabIndex = 7;
            this.ACWList.Text = "ACWs";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(12, 209);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "--/--/--"});
            this.listBox1.Location = new System.Drawing.Point(381, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 17);
            this.listBox1.TabIndex = 9;
            // 
            // DeadLabel
            // 
            this.DeadLabel.AutoSize = true;
            this.DeadLabel.Location = new System.Drawing.Point(378, 25);
            this.DeadLabel.Name = "DeadLabel";
            this.DeadLabel.Size = new System.Drawing.Size(122, 13);
            this.DeadLabel.TabIndex = 10;
            this.DeadLabel.Text = "Selected ACW Deadline";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "--/--/--",
            "--/--/--",
            "--/--/--"});
            this.listBox2.Location = new System.Drawing.Point(381, 80);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(123, 95);
            this.listBox2.TabIndex = 11;
            // 
            // ACWDate
            // 
            this.ACWDate.AutoSize = true;
            this.ACWDate.Location = new System.Drawing.Point(381, 64);
            this.ACWDate.Name = "ACWDate";
            this.ACWDate.Size = new System.Drawing.Size(108, 13);
            this.ACWDate.TabIndex = 12;
            this.ACWDate.Text = "ACW Review Date(s)";
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 259);
            this.Controls.Add(this.ACWDate);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.DeadLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ACWList);
            this.Controls.Add(this.ListBoxACW);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.ModBox);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.CourseLabel);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.ComboBox ModBox;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox SemesterBox;
        private System.Windows.Forms.ListBox ListBoxACW;
        private System.Windows.Forms.Label ACWList;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label DeadLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label ACWDate;
    }
}