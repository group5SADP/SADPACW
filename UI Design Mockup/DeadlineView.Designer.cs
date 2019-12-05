namespace UI_Design_Mockup
{
    partial class DeadlineView
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Select = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Location = new System.Drawing.Point(12, 20);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(65, 13);
            this.Select.TabIndex = 1;
            this.Select.Text = "Select ACW";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.Location = new System.Drawing.Point(139, 20);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(49, 13);
            this.DeadlineLabel.TabIndex = 2;
            this.DeadlineLabel.Text = "Deadline";
            this.DeadlineLabel.Click += new System.EventHandler(this.DeadlineLabel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(142, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 17);
            this.listBox1.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(12, 80);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // DeadlineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 119);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeadlineLabel);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.comboBox1);
            this.Name = "DeadlineView";
            this.Text = "DeadlineView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Select;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Return;
    }
}