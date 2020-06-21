using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatternsTest
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
        //private ResultForm resultForm;
        //private LoginFormIFMIT loginForm;

        //private TestLoader testLoader;



        public MainForm()
        {
            infoForm = new InfoForm(this);
            //loginForm = new LoginFormIFMIT(this);
            //resultForm = new ResultForm(this, loginForm);


            InitializeComponent();
            testsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            testsListBox.DrawItem += TestListBox_ItemDraw;

            timeLeftLabel.Text = "00:00";

            //testLoader = TestLoader.LoaderInstance;
            //testLoader.MainForm = this;
            //testLoader.LoadTest();
            //StartTest();
        }
        public InfoForm InfoForm
        {
            get
            {
                return this.infoForm;
            }
        }
    }
}