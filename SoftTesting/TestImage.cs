using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftTesting
{
    public class TestImage : Test
    {
        private string[] imagesPaths;
        private Bitmap[] images;
        private int selectedIndex = -1;

        public TestImage(string title, string task, string[] imagesPaths, string[] allVariants, AnswerInfo correctAnswer)
        {
            this.testType = TestType.Image;
            this.title = title;
            this.task = task;
            this.imagesPaths = imagesPaths;
            this.allVariants = allVariants;
            this.correctAnswer = correctAnswer;

            this.images = new Bitmap[imagesPaths.Length];
            for (int i = 0; i < imagesPaths.Length; i++)
            {
                images[i] = new Bitmap(Bitmap.FromFile(@"Resources/" + imagesPaths[i]));
            }
        }

        public string[] ImagesPaths
        {
            get
            {
                return imagesPaths;
            }
        }

        public override void ConstructLayoutPanel(Panel parentPanel)
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Top;
            tableLayout.Location = new System.Drawing.Point(0, 0);

            this.userControlPanel = new ImageAnswerTestPanel(tableLayout);

            parentPanel.Controls.Add(this.userControlPanel);
            this.userControlPanel.Size = parentPanel.Size;
            this.userControlPanel.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.AutoScroll = true;

            tableLayout.AutoScroll = true;
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Margin = new Padding(0, 0, 0, 0);
            PopulateImageAnswerPanel((ImageAnswerTestPanel)this.userControlPanel);
        }
        private void PopulateImageAnswerPanel(ImageAnswerTestPanel imageAnswerTestPanel)
        {
            imageAnswerTestPanel.TableLayoutPanel.ColumnCount = imageAnswerTestPanel.ColumnsCount;

            for (int i = 0; i < allVariants.Length; i++)
            {
                string str = allVariants[i];
                CustomRadioButton rb = new CustomRadioButton(i);
                imageAnswerTestPanel.TableLayoutPanel.Controls.Add(rb);
                rb.Text = (i + 1) + ")";
                rb.Font = new System.Drawing.Font(rb.Font.FontFamily, 16, System.Drawing.FontStyle.Regular);
                rb.BackColor = System.Drawing.Color.White;
                rb.Size = new System.Drawing.Size(imageAnswerTestPanel.RowWidth - rb.Margin.Horizontal, imageAnswerTestPanel.RowHeight - rb.Margin.Vertical);
                rb.BackgroundImage = images[i];
                rb.BackgroundImageLayout = ImageLayout.Zoom;
                rb.CheckAlign = ContentAlignment.BottomCenter;
                rb.TextAlign = ContentAlignment.BottomCenter;
                rb.ForeColor = Color.Black;

                rb.CheckedChangedEvent += OnButtonChecked;
                this.ResetControlEvent += rb.ResetState;
                rb.Padding = new Padding(0, 0, 0, 4);
                rb.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            }
        }

        private void OnButtonChecked(int index)
        {
            this.selectedIndex = index;
            Console.WriteLine("New index of image: " + index);
        }

        public override void ApplyAnswer()
        {
            if (selectedIndex == -1)
                System.Media.SystemSounds.Hand.Play();
            else this.GiveAnswer(new AnswerInfo(TestType.Image, (this.selectedIndex + 1).ToString(), new string[] { }));
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