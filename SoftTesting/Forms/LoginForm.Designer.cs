namespace SoftTesting
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.logoPuctureBox = new System.Windows.Forms.PictureBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.creatorsInfoLabelIFMIT = new System.Windows.Forms.Label();
            this.programmLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LogoHAI = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPuctureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHAI)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LoginButton.Location = new System.Drawing.Point(504, 296);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(156, 52);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logoPuctureBox
            // 
            this.logoPuctureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPuctureBox.Image")));
            this.logoPuctureBox.InitialImage = null;
            this.logoPuctureBox.Location = new System.Drawing.Point(32, 29);
            this.logoPuctureBox.Name = "logoPuctureBox";
            this.logoPuctureBox.Size = new System.Drawing.Size(376, 356);
            this.logoPuctureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPuctureBox.TabIndex = 1;
            this.logoPuctureBox.TabStop = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.loginTextBox.Location = new System.Drawing.Point(558, 192);
            this.loginTextBox.MaxLength = 24;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(154, 35);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Text = "admin";
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(558, 233);
            this.passwordTextBox.MaxLength = 24;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(154, 35);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "admin";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(462, 195);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(90, 29);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(445, 236);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 29);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creatorsInfoLabelIFMIT
            // 
            this.creatorsInfoLabelIFMIT.AutoSize = true;
            this.creatorsInfoLabelIFMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.creatorsInfoLabelIFMIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.creatorsInfoLabelIFMIT.Location = new System.Drawing.Point(218, 395);
            this.creatorsInfoLabelIFMIT.Name = "creatorsInfoLabelIFMIT";
            this.creatorsInfoLabelIFMIT.Size = new System.Drawing.Size(376, 32);
            this.creatorsInfoLabelIFMIT.TabIndex = 6;
            this.creatorsInfoLabelIFMIT.Text = "Крютченко Никита ИПЗ-2 (мс), Козаков Артём ИПЗ-2 (мс)\r\n2020 ИФМИТ ЛНУ";
            this.creatorsInfoLabelIFMIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creatorsInfoLabelIFMIT.Visible = false;
            // 
            // programmLabel
            // 
            this.programmLabel.AutoSize = true;
            this.programmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.programmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.programmLabel.Location = new System.Drawing.Point(414, 75);
            this.programmLabel.Name = "programmLabel";
            this.programmLabel.Size = new System.Drawing.Size(339, 62);
            this.programmLabel.TabIndex = 7;
            this.programmLabel.Text = "Программа оценивания\r\n успеваемости студентов \r\n";
            this.programmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LogoHAI
            // 
            this.LogoHAI.Image = ((System.Drawing.Image)(resources.GetObject("LogoHAI.Image")));
            this.LogoHAI.InitialImage = null;
            this.LogoHAI.Location = new System.Drawing.Point(32, 29);
            this.LogoHAI.Name = "LogoHAI";
            this.LogoHAI.Size = new System.Drawing.Size(376, 356);
            this.LogoHAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoHAI.TabIndex = 8;
            this.LogoHAI.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(311, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Зайцев Александр 515-ст 2\r\n2020 ХАИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginFormIFMIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoHAI);
            this.Controls.Add(this.programmLabel);
            this.Controls.Add(this.creatorsInfoLabelIFMIT);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.logoPuctureBox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFormIFMIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patterns Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.logoPuctureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox logoPuctureBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label creatorsInfoLabelIFMIT;
        private System.Windows.Forms.Label programmLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox LogoHAI;
        private System.Windows.Forms.Label label1;
    }
}