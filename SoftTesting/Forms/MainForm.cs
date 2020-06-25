using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SoftTesting
{
    public partial class MainForm : Form
    {
        public const string CURRENT_USER_TEXT = "Текущий пользователь: ";
        public const string CURRENT_USER_LAST_RESULT = "Предыдущий результат: ";

        private bool hasTimer = false;
        private Timer timer;
        private TimeSpan totalTimeForTest;
        private TimeSpan timeLeft;

        private Color notAnsweredForeColor = Color.FromArgb(255, 255, 0, 80);
        private Color answeredForeColor = Color.White;

        private Color timeEnabledColor = Color.FromKnownColor(KnownColor.Control);
        private Color timeDisabledColor = Color.FromKnownColor(KnownColor.WindowFrame);

        private InfoForm infoForm;
        private ResultForm resultForm;
        private LoginForm loginForm;

        private TestLoader testLoader;



        public MainForm()
        {
            infoForm = new InfoForm(this);
            loginForm = new LoginForm(this);
            resultForm = new ResultForm(this, loginForm);


            InitializeComponent();
            testsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            testsListBox.DrawItem += TestListBox_ItemDraw;

            timeLeftLabel.Text = "00:00";

            testLoader = TestLoader.LoaderInstance;
            testLoader.MainForm = this;
            testLoader.LoadTest();
            //StartTest();

        }



        public LoginForm LoginForm
        {
            get
            {
                return loginForm;
            }
        }
        public ResultForm ResultForm
        {
            get
            {
                return this.resultForm;
            }
        }
        public InfoForm InfoForm
        {
            get
            {
                return this.infoForm;
            }
        }

        public TestLoader TestLoader
        {
            get
            {
                return this.testLoader;
            }
        }
        public Panel TestGridHolder
        {
            get
            {
                return testGridHolder;
            }
        }

        public Label TaskLabel
        {
            get => taskLabel;
        }



        public void StartTest()
        {
            if (testLoader.AllTests.Length > 0)
            {
                testLoader.RandomizeTests();
                if (testLoader.TestHasTimer)
                {
                    hasTimer = true;
                    totalTimeForTest = testLoader.TotalTimeForTest;
                }
                else
                {
                    hasTimer = false;
                    this.timeLeftLabel.Text = "00:00";
                }


                if (hasTimer)
                {
                    timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += OnTimerTick;
                    timeLeft = totalTimeForTest;
                    this.timeLeftLabel.ForeColor = timeEnabledColor;
                    this.timeLabel.ForeColor = timeEnabledColor;
                    timer.Start();
                    timer.Enabled = true;
                    UpdateTimer();
                }
                else
                {
                    this.timeLeftLabel.ForeColor = timeDisabledColor;
                    this.timeLabel.ForeColor = timeDisabledColor;
                }

                SelectTest(0);
                this.testsListBox.SelectedIndex = 0;
                UpdateAnswerdQuestionsLabel();
            }
            else Console.WriteLine("Cant start testing! No tests loaded!");
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(new TimeSpan(0, 0, 1));
            if (timeLeft.TotalSeconds <= 0)
            {
                if (timer != null)
                {
                    timer.Tick -= OnTimerTick;
                    timer.Dispose();
                    timer = null;
                }
                FinishTest();
            }
            this.Invoke(new MethodInvoker(UpdateTimer));
        }


        private void UpdateTimer()
        {
            this.timeLeftLabel.Text = ((long)(timeLeft.TotalMinutes)).ToString("D2") + ":" + timeLeft.Seconds.ToString("D2");
        }

        public void FinishTest()
        {
            this.Hide();
            int correctAnswers = 0;
            for (int i = 0; i < TestLoader.AllTests.Length; i++)
            {
                if (TestLoader.AllTests[i].IsAnswerCorrect())
                    correctAnswers++;
            }
            string lastResult = correctAnswers.ToString() + "/" + TestLoader.AllTests.Length + "("
                + (int)(((float)correctAnswers / (float)TestLoader.AllTests.Length) * 100) + "%)";
            LoginForm.CurrentUser.LastResult = lastResult;
            LoginForm.SaveAllUsers();

            for (int i = 0; i < testLoader.AllTests.Length; i++)
            {
                testLoader.AllTests[i].ResetTest();
            }

            resultForm.ShowUserResult(loginForm.CurrentUser);
            resultForm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoForm.ShowDialog();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Login()
        {
            this.Hide();
            loginForm.ResetLogin();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (LoginForm.CurrentUser != null)
            {
                текущийПользовательToolStripMenuItem.Text = CURRENT_USER_TEXT + LoginForm.CurrentUser.Name;
                предыдущийРезультатToolStripMenuItem.Text = CURRENT_USER_LAST_RESULT + LoginForm.CurrentUser.LastResult;
            }
            else
            {
                текущийПользовательToolStripMenuItem.Text = CURRENT_USER_TEXT;
                предыдущийРезультатToolStripMenuItem.Text = CURRENT_USER_LAST_RESULT;
            }
        }


        public void UpdateTestsListBox()
        {
            testsListBox.Items.Clear();
            for (int i = 0; i < testLoader.AllTests.Length; i++)
            {
                testsListBox.Items.Add(((i + 1) + ") ") + testLoader.AllTests[i].Title);
            }
        }


        private void TestListBox_ItemDraw(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < testLoader.AllTests.Length)
            {
                e.DrawBackground();
                Graphics g = e.Graphics;
                ListBox lb = (ListBox)sender;

                SolidBrush brush = new SolidBrush(answeredForeColor);
                //g.FillRectangle(new SolidBrush(unselecredSpecialityBackColor), e.Bounds);
                if (testLoader.AllTests[e.Index].IsAnswerGiven == false)
                {
                    brush = new SolidBrush(notAnsweredForeColor);
                }
                g.DrawString(lb.Items[e.Index].ToString(), e.Font, brush, new PointF(e.Bounds.X, e.Bounds.Y));

                e.DrawFocusRectangle();
            }
        }

        private void testsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testsListBox.Items.Count > 0)
                this.SelectTest(testsListBox.SelectedIndex);
        }

        public void SelectTest(int index)
        {
            testLoader.SelectTest(index);
        }

        public void GiveAnswer()
        {
            TestLoader.CurrentTest.ApplyAnswer();
            UpdateAnswerdQuestionsLabel();
            if (this.testLoader.CurrentTest.IsAnswerGiven)
                SelectNextTest();
        }

        private void UpdateAnswerdQuestionsLabel()
        {
            int totalQuestions = TestLoader.AllTests.Length;
            int answeredQuestions = 0;
            for (int i = 0; i < TestLoader.AllTests.Length; i++)
            {
                if (TestLoader.AllTests[i].IsAnswerGiven)
                    answeredQuestions++;
            }

            questionsDoneLabel.Text = answeredQuestions.ToString() + "/" + totalQuestions.ToString();

            if (answeredQuestions == testLoader.AllTests.Length)
                FinishTest();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            GiveAnswer();
            testsListBox.Refresh();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            SelectNextTest();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SelectPrevousTest();
        }

        public void SelectNextTest()
        {
            int newIndex = TestLoader.CurrentTestIndex + 1;
            newIndex = newIndex >= TestLoader.AllTests.Length ? 0 : newIndex;
            SelectTest(newIndex);
            this.testsListBox.SelectedIndex = newIndex;
        }
        public void SelectPrevousTest()
        {
            int newIndex = TestLoader.CurrentTestIndex - 1;
            newIndex = newIndex < 0 ? (TestLoader.AllTests.Length - 1) : newIndex;
            SelectTest(newIndex);
            this.testsListBox.SelectedIndex = newIndex;
        }
    }
}
