using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public delegate void ResetControl();

    public class TestSingleAnswer : Test
    {
        private int selectedIndex = -1;

        public TestSingleAnswer(string title, string task, string[] allVariants, AnswerInfo correctAnswer)
        {
            this.testType = TestType.SingleAnswer;
            this.title = title;
            this.task = task;
            this.allVariants = allVariants;
            this.correctAnswer = correctAnswer;
        }


        public override void ConstructLayoutPanel(Panel parentPanel)
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Top;
            tableLayout.Location = new System.Drawing.Point(0, 0);

            this.userControlPanel = new SingleAnswerTestPanel(tableLayout);

            parentPanel.Controls.Add(this.userControlPanel);
            this.userControlPanel.Size = parentPanel.Size;
            this.userControlPanel.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.AutoScroll = true;

            tableLayout.AutoSize = true;
            tableLayout.Margin = new Padding(0, 0, 0, 0);
            PopulateSingleAnswerPanel((SingleAnswerTestPanel)this.userControlPanel);
        }

        private void PopulateSingleAnswerPanel(SingleAnswerTestPanel singleAnswerPanel)
        {
            singleAnswerPanel.TableLayoutPanel.ColumnCount = singleAnswerPanel.ColumnsCount;

            for (int i = 0; i < allVariants.Length; i++)
            {
                string str = allVariants[i];
                CustomRadioButton rb = new CustomRadioButton(i);
                rb.CheckedChangedEvent += OnButtonChecked;
                this.ResetControlEvent += rb.ResetState;
                rb.Text = str;
                rb.Font = new System.Drawing.Font(rb.Font.FontFamily, 16, System.Drawing.FontStyle.Regular);
                rb.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
                rb.Size = new System.Drawing.Size(singleAnswerPanel.RowWidth - rb.Margin.Horizontal, singleAnswerPanel.RowHeight - rb.Margin.Vertical);

                rb.Padding = new Padding(70, 0, 0, 0);
                rb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                singleAnswerPanel.TableLayoutPanel.Controls.Add(rb);

            }
        }

        private void OnButtonChecked(int index)
        {
            this.selectedIndex = index;
            Console.WriteLine("New index of single: " + index);
        }

        public override void ApplyAnswer()
        {
            if (this.selectedIndex == -1)
                System.Media.SystemSounds.Hand.Play();
            else this.GiveAnswer(new AnswerInfo(TestType.SingleAnswer, allVariants[this.selectedIndex], new string[] { }));
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
            this.ResetControlEvent?.Invoke();
        }
    }
}