using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public class TestText : Test
    {
        private TextBox textBox;
        public TestText(string title, string task, string[] allVariants, AnswerInfo correctAnswer)
        {
            this.testType = TestType.Text;
            this.title = title;
            this.task = task;
            this.allVariants = allVariants;
            this.correctAnswer = correctAnswer;

            // Установка размера шрифта
            this.fontSize = 32;
        }

        public override void ConstructLayoutPanel(Panel parentPanel)
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new System.Drawing.Point(0, 0);

            this.userControlPanel = new SingleAnswerTestPanel(tableLayout);

            parentPanel.Controls.Add(this.userControlPanel);
            this.userControlPanel.Size = parentPanel.Size;
            this.userControlPanel.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.AutoScroll = true;

            tableLayout.AutoSize = true;
            tableLayout.Margin = new Padding(0, 0, 0, 0);

            TextBox textBox = new TextBox();
            this.textBox = textBox;
            tableLayout.Controls.Add(textBox);
            tableLayout.ColumnCount = 1;

            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Font = new System.Drawing.Font(textBox.Font.FontFamily, this.fontSize);
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            textBox.MaxLength = 100;
        }

        public override void ApplyAnswer()
        {
            if (this.textBox.Text != "")
                this.GiveAnswer(new AnswerInfo(TestType.Text, this.textBox.Text, new string[] { }));
            else System.Media.SystemSounds.Hand.Play();
        }

        public override bool IsAnswerCorrect()
        {
            if (isAnswerGiven)
            {
                string given = givenAnswer.SingleAnswer.ToUpperInvariant();
                string correct = correctAnswer.SingleAnswer.ToUpperInvariant();
                if (given == correct)
                    return true;
                else return false;
            }
            else return false;
        }

        public override void ResetTest()
        {
            givenAnswer = new AnswerInfo();
            isAnswerGiven = false;
            this.textBox.Text = "";
        }
    }
}