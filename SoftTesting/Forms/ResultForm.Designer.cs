namespace SoftTesting
{ 
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.retryButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retryButton
            // 
            this.retryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.retryButton.Location = new System.Drawing.Point(19, 265);
            this.retryButton.Margin = new System.Windows.Forms.Padding(10);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(175, 65);
            this.retryButton.TabIndex = 0;
            this.retryButton.Text = "Повторить";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loginButton.Location = new System.Drawing.Point(214, 265);
            this.loginButton.Margin = new System.Windows.Forms.Padding(10);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(175, 65);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Сменить пользователя";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.exitButton.Location = new System.Drawing.Point(409, 265);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(175, 65);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(19, 46);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(565, 61);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "aleksandr, ваш результат:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.25F);
            this.resultTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resultTextLabel.Location = new System.Drawing.Point(12, 154);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(579, 65);
            this.resultTextLabel.TabIndex = 5;
            this.resultTextLabel.Text = "5/10(50%)";
            this.resultTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(603, 350);
            this.ControlBox = false;
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.retryButton);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат теста";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label resultTextLabel;
    }
}