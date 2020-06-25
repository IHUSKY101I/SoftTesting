using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftTesting
{
    public class TestMultyAnswer : Test
    {
        private bool[] selectedIndeces;

        public TestMultyAnswer(string title, string task, string[] allVariants, AnswerInfo correctAnswer)
        {
            this.testType = TestType.MultyAnswer;
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

            this.userControlPanel = new MultyAnswerTestPanel(tableLayout);

            parentPanel.Controls.Add(this.userControlPanel);
            this.userControlPanel.Size = parentPanel.Size;
            this.userControlPanel.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.AutoScroll = true;

            tableLayout.AutoSize = true;
            tableLayout.Margin = new Padding(0, 0, 0, 0);
            PopulateMultyAnswerPanel((MultyAnswerTestPanel)this.userControlPanel);
        }

        private void PopulateMultyAnswerPanel(MultyAnswerTestPanel multyAnswerPanel)
        {
            multyAnswerPanel.TableLayoutPanel.ColumnCount = 1;
            selectedIndeces = new bool[allVariants.Length];

            for (int i = 0; i < allVariants.Length; i++)
            {
                selectedIndeces[i] = false;
                string str = allVariants[i];

                CustomCheckBox cb = new CustomCheckBox(i);
                cb.CheckedChangedEvent += OnButtonChecked;
                this.ResetControlEvent += cb.ResetState;
                cb.Text = str;
                cb.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
                cb.Font = new System.Drawing.Font(cb.Font.FontFamily, 16, System.Drawing.FontStyle.Regular);
                cb.Size = new System.Drawing.Size(multyAnswerPanel.Width - cb.Margin.Horizontal, multyAnswerPanel.RowHeight - cb.Margin.Vertical);
                cb.Padding = new Padding(15, 0, 0, 0);

                multyAnswerPanel.TableLayoutPanel.Controls.Add(cb);
            }
        }

        private void OnButtonChecked(int index, bool isChecked)
        {
            this.selectedIndeces[index] = isChecked;
            Console.WriteLine("New index of multi anser: " + index + " is " + isChecked);
        }

        public override void ApplyAnswer()
        {
            List<string> answers = new List<string>();
            for (int i = 0; i < selectedIndeces.Length; i++)
            {
                if (selectedIndeces[i] == true)
                {
                    answers.Add(allVariants[i]);
                }
            }
            if (answers.Count != 0)
                GiveAnswer(new AnswerInfo(TestType.MultyAnswer, "", answers.ToArray()));
            else System.Media.SystemSounds.Hand.Play();
        }

        public override bool IsAnswerCorrect()
        {
            if (isAnswerGiven)
            {
                string[] given = givenAnswer.MultyAnswer;
                string[] correct = correctAnswer.MultyAnswer;
                if (given.Length != correct.Length)
                    return false;

                for (int i = 0; i < correct.Length; i++)
                {
                    bool correctAnswerFound = false;
                    string c = correct[i].ToUpperInvariant();
                    for (int x = 0; x < given.Length; x++)
                    {
                        string g = given[x].ToUpperInvariant();
                        if (g == c)
                        {
                            correctAnswerFound = true;
                            break;
                        }
                    }

                    if (correctAnswerFound)
                        continue;
                    else return false;
                }
                return true;
            }
            else return false;
        }

        public override void ResetTest()
        {
            givenAnswer = new AnswerInfo();
            isAnswerGiven = false;
            this.ResetControlEvent.Invoke();
        }
    }
}