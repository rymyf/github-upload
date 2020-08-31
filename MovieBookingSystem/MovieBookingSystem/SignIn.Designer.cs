namespace MovieBookingSystem
{
    partial class SignIn
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
            this.SignButton = new System.Windows.Forms.Button();
            this.SigninLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.Qlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignButton
            // 
            this.SignButton.Location = new System.Drawing.Point(87, 121);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(75, 23);
            this.SignButton.TabIndex = 0;
            this.SignButton.Text = "SignIn";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // SigninLabel
            // 
            this.SigninLabel.AutoSize = true;
            this.SigninLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninLabel.Location = new System.Drawing.Point(136, 9);
            this.SigninLabel.Name = "SigninLabel";
            this.SigninLabel.Size = new System.Drawing.Size(61, 19);
            this.SigninLabel.TabIndex = 1;
            this.SigninLabel.Text = "SignIn";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AcceptsTab = true;
            this.EmailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailTextBox.Location = new System.Drawing.Point(87, 50);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(162, 20);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(87, 76);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(162, 20);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.Blue;
            this.SignUpLabel.Location = new System.Drawing.Point(206, 158);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(40, 13);
            this.SignUpLabel.TabIndex = 7;
            this.SignUpLabel.Text = "SignUp";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(200, 121);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(49, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Qlabel
            // 
            this.Qlabel.AutoSize = true;
            this.Qlabel.Location = new System.Drawing.Point(84, 158);
            this.Qlabel.Name = "Qlabel";
            this.Qlabel.Size = new System.Drawing.Size(121, 13);
            this.Qlabel.TabIndex = 9;
            this.Qlabel.Text = "Don\'t have an Account?";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 204);
            this.Controls.Add(this.Qlabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SigninLabel);
            this.Controls.Add(this.SignButton);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Label SigninLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Qlabel;
    }
}