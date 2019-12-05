namespace UI_Design_Mockup
{
    partial class TeamPopup
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
            this.CourseMemberLabel = new System.Windows.Forms.Label();
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.SelectButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseMemberLabel
            // 
            this.CourseMemberLabel.AutoSize = true;
            this.CourseMemberLabel.Location = new System.Drawing.Point(12, 21);
            this.CourseMemberLabel.Name = "CourseMemberLabel";
            this.CourseMemberLabel.Size = new System.Drawing.Size(104, 13);
            this.CourseMemberLabel.TabIndex = 0;
            this.CourseMemberLabel.Text = "Find Course Member";
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(15, 37);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(101, 21);
            this.CourseBox.TabIndex = 1;
            // 
            // SelectButt
            // 
            this.SelectButt.Location = new System.Drawing.Point(131, 37);
            this.SelectButt.Name = "SelectButt";
            this.SelectButt.Size = new System.Drawing.Size(101, 21);
            this.SelectButt.TabIndex = 2;
            this.SelectButt.Text = "Add to Team";
            this.SelectButt.UseVisualStyleBackColor = true;
            // 
            // TeamPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 98);
            this.Controls.Add(this.SelectButt);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.CourseMemberLabel);
            this.Name = "TeamPopup";
            this.Text = "TeamPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseMemberLabel;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.Button SelectButt;
    }
}