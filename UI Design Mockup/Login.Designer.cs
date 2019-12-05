namespace UI_Design_Mockup
{
    partial class Login
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
            this.UsernameEnter = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordEnter = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameEnter
            // 
            this.UsernameEnter.Location = new System.Drawing.Point(12, 35);
            this.UsernameEnter.Name = "UsernameEnter";
            this.UsernameEnter.Size = new System.Drawing.Size(151, 20);
            this.UsernameEnter.TabIndex = 0;
            this.UsernameEnter.TextChanged += new System.EventHandler(this.UsernameEnter_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(9, 19);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordEnter
            // 
            this.PasswordEnter.Location = new System.Drawing.Point(12, 95);
            this.PasswordEnter.Name = "PasswordEnter";
            this.PasswordEnter.Size = new System.Drawing.Size(151, 20);
            this.PasswordEnter.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 79);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(46, 139);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(82, 23);
            this.Enter.TabIndex = 4;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 202);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordEnter);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameEnter);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameEnter;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordEnter;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button Enter;
    }
}