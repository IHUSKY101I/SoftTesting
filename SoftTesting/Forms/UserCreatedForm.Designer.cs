namespace SoftTesting
{
    partial class UserCreatedForm
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
            this.startTestCheckBox = new System.Windows.Forms.CheckBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordText = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userAddedLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTestCheckBox
            // 
            this.startTestCheckBox.AutoSize = true;
            this.startTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.startTestCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.startTestCheckBox.Location = new System.Drawing.Point(110, 218);
            this.startTestCheckBox.Name = "startTestCheckBox";
            this.startTestCheckBox.Size = new System.Drawing.Size(149, 21);
            this.startTestCheckBox.TabIndex = 16;
            this.startTestCheckBox.Text = "Сразу начать тест";
            this.startTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.showPasswordCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(110, 191);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(140, 21);
            this.showPasswordCheckBox.TabIndex = 15;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.passwordText.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordText.Location = new System.Drawing.Point(166, 146);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(118, 24);
            this.passwordText.TabIndex = 14;
            this.passwordText.Text = "PASSWORD";
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loginText.ForeColor = System.Drawing.SystemColors.Control;
            this.loginText.Location = new System.Drawing.Point(166, 122);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(67, 24);
            this.loginText.TabIndex = 13;
            this.loginText.Text = "LOGIN";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(91, 122);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(69, 24);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(79, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 24);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Пароль:";
            // 
            // userAddedLabel
            // 
            this.userAddedLabel.AutoSize = true;
            this.userAddedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.userAddedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userAddedLabel.Location = new System.Drawing.Point(68, 26);
            this.userAddedLabel.Name = "userAddedLabel";
            this.userAddedLabel.Size = new System.Drawing.Size(231, 62);
            this.userAddedLabel.TabIndex = 10;
            this.userAddedLabel.Text = "Добавлен новый \r\nпользователь!";
            this.userAddedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.okButton.Location = new System.Drawing.Point(30, 263);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(300, 53);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // UserCreatedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(358, 339);
            this.Controls.Add(this.startTestCheckBox);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userAddedLabel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCreatedForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь добавлен";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startTestCheckBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userAddedLabel;
        private System.Windows.Forms.Button okButton;
    }
}