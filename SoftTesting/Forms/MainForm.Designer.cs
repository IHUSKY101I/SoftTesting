namespace SoftTesting.Forms
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionsLabel = new System.Windows.Forms.Label();
            this.questionsDoneLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.currentQuestionLabel = new System.Windows.Forms.Label();
            this.предыдущийРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текущийПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testGridHolder = new System.Windows.Forms.Panel();
            this.testsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.timeLeftLabel);
            this.panel2.Location = new System.Drawing.Point(2, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 55);
            this.panel2.TabIndex = 14;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Location = new System.Drawing.Point(5, 14);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(177, 22);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Оставшееся время:";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.timeLeftLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLeftLabel.Location = new System.Drawing.Point(178, 15);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(65, 22);
            this.timeLeftLabel.TabIndex = 10;
            this.timeLeftLabel.Text = "999:99";
            // 
            // taskLabel
            // 
            this.taskLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.taskLabel.Location = new System.Drawing.Point(270, 70);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(652, 46);
            this.taskLabel.TabIndex = 22;
            this.taskLabel.Text = "label1\r\ndfg";
            this.taskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.questionsLabel);
            this.panel1.Controls.Add(this.questionsDoneLabel);
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 46);
            this.panel1.TabIndex = 23;
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.questionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.questionsLabel.Location = new System.Drawing.Point(21, 5);
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(133, 31);
            this.questionsLabel.TabIndex = 2;
            this.questionsLabel.Text = "Вопросы:";
            // 
            // questionsDoneLabel
            // 
            this.questionsDoneLabel.AutoSize = true;
            this.questionsDoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.questionsDoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.questionsDoneLabel.Location = new System.Drawing.Point(147, 7);
            this.questionsDoneLabel.Name = "questionsDoneLabel";
            this.questionsDoneLabel.Size = new System.Drawing.Size(82, 31);
            this.questionsDoneLabel.TabIndex = 8;
            this.questionsDoneLabel.Text = "90\\10";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.nextButton.Location = new System.Drawing.Point(779, 591);
            this.nextButton.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(143, 55);
            this.nextButton.TabIndex = 20;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.ForestGreen;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.acceptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.acceptButton.Location = new System.Drawing.Point(429, 591);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(334, 55);
            this.acceptButton.TabIndex = 19;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.backButton.Location = new System.Drawing.Point(270, 591);
            this.backButton.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 55);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // currentQuestionLabel
            // 
            this.currentQuestionLabel.AutoSize = true;
            this.currentQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.currentQuestionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.currentQuestionLabel.Location = new System.Drawing.Point(507, 37);
            this.currentQuestionLabel.Name = "currentQuestionLabel";
            this.currentQuestionLabel.Size = new System.Drawing.Size(183, 26);
            this.currentQuestionLabel.TabIndex = 17;
            this.currentQuestionLabel.Text = "Текущий вопрос:";
            // 
            // предыдущийРезультатToolStripMenuItem
            // 
            this.предыдущийРезультатToolStripMenuItem.Enabled = false;
            this.предыдущийРезультатToolStripMenuItem.Name = "предыдущийРезультатToolStripMenuItem";
            this.предыдущийРезультатToolStripMenuItem.Size = new System.Drawing.Size(196, 20);
            this.предыдущийРезультатToolStripMenuItem.Text = "Предыдущий результат: 0/0(0%)";
            // 
            // текущийПользовательToolStripMenuItem
            // 
            this.текущийПользовательToolStripMenuItem.Enabled = false;
            this.текущийПользовательToolStripMenuItem.Name = "текущийПользовательToolStripMenuItem";
            this.текущийПользовательToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.текущийПользовательToolStripMenuItem.Text = "Текущий пользователь:";
            this.текущийПользовательToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Enabled = false;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // testGridHolder
            // 
            this.testGridHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testGridHolder.Location = new System.Drawing.Point(270, 127);
            this.testGridHolder.Name = "testGridHolder";
            this.testGridHolder.Size = new System.Drawing.Size(652, 446);
            this.testGridHolder.TabIndex = 21;
            // 
            // testsListBox
            // 
            this.testsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.testsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.testsListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.testsListBox.FormattingEnabled = true;
            this.testsListBox.ItemHeight = 17;
            this.testsListBox.Items.AddRange(new object[] {
            "1) Вопрос первый",
            "2) Вопрос второй",
            "3) Вопрос третий"});
            this.testsListBox.Location = new System.Drawing.Point(2, 127);
            this.testsListBox.Margin = new System.Windows.Forms.Padding(15);
            this.testsListBox.Name = "testsListBox";
            this.testsListBox.Size = new System.Drawing.Size(250, 446);
            this.testsListBox.TabIndex = 16;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.текущийПользовательToolStripMenuItem,
            this.предыдущийРезультатToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(967, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(967, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.testGridHolder);
            this.Controls.Add(this.testsListBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questionsLabel;
        private System.Windows.Forms.Label questionsDoneLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label currentQuestionLabel;
        private System.Windows.Forms.ToolStripMenuItem предыдущийРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текущийПользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.Panel testGridHolder;
        private System.Windows.Forms.ListBox testsListBox;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}