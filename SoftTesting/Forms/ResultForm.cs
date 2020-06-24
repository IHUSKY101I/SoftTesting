using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public partial class ResultForm : Form
    {
        public const string YOUR_RESULT_TEXT = ", ваш результат:";

        private MainForm mainForm;
        private LoginForm loginForm;

        public ResultForm(MainForm mainForm, LoginForm loginForm)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.mainForm = mainForm;
        }

        public MainForm MainForm
        {
            get
            {
                return mainForm;
            }
        }
        public LoginForm LoginForm
        {
            get
            {
                return loginForm;
            }
        }

        public void RestartTest()
        {
            this.Hide();
            MainForm.Show();
            MainForm.StartTest();
        }

        public void Relogin()
        {
            this.Hide();
            loginForm.Show();
        }

        public void ShowUserResult(User user)
        {
            this.resultTextLabel.Text = user.LastResult;
            this.loginLabel.Text = user.Name + YOUR_RESULT_TEXT;

            foreach (Test item in MainForm.TestLoader.AllTests)
            {
                Console.WriteLine("Тест: " + item.Task);
                Console.WriteLine("Введённый вариант: " + item.AnswerInfo.SingleAnswer);
                Console.WriteLine("Правельный вариант: " + item.CorrectAnswer.SingleAnswer + "\n---------");
            }
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Relogin();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            RestartTest();
        }

    }
}
