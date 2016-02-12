namespace loginPage
{
    partial class loginInputPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userName = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.failedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(3, 13);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(115, 29);
            this.userName.TabIndex = 0;
            this.userName.Text = "User Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(3, 76);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(101, 29);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(125, 21);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(124, 20);
            this.userNameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(125, 76);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(124, 20);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(125, 114);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // failedLabel
            // 
            this.failedLabel.AutoSize = true;
            this.failedLabel.Font = new System.Drawing.Font("Minion Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedLabel.ForeColor = System.Drawing.Color.White;
            this.failedLabel.Location = new System.Drawing.Point(5, 155);
            this.failedLabel.Name = "failedLabel";
            this.failedLabel.Size = new System.Drawing.Size(124, 18);
            this.failedLabel.TabIndex = 5;
            this.failedLabel.Text = "Login Attempt Failed";
            this.failedLabel.Visible = false;
            // 
            // loginInputPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.failedLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userName);
            this.Name = "loginInputPage";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label failedLabel;
    }
}
