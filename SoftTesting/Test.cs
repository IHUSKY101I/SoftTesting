using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTesting
{
    public abstract class Test
    {
        public ResetControl ResetControlEvent;

        protected int fontSize = 18;

        protected TestType testType;
        protected string title = "";
        protected string task = "";
        protected string[] allVariants;
        protected AnswerInfo correctAnswer;
        protected AnswerInfo givenAnswer;
        protected bool isAnswerGiven = false;

        protected UserControl userControlPanel;
        protected Control[] allVariantsControl;


        public TestType TestType
        {
            get
            {
                return testType;
            }
        }
        public bool IsAnswerGiven
        {
            get
            {
                return isAnswerGiven;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
        }
        public string Task
        {
            get
            {
                return task;
            }
        }

        public AnswerInfo AnswerInfo
        {
            get
            {
                return givenAnswer;
            }
        }
        public AnswerInfo CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
        }
        public UserControl UserControlPanel
        {
            get
            {
                return userControlPanel;
            }
            set
            {
                userControlPanel = value;
            }
        }
        public Control[] AllVariantsControl
        {
            get
            {
                return allVariantsControl;
            }
            set
            {
                allVariantsControl = value;
            }
        }

        public int FontSize
        {
            get
            {
                return fontSize;
            }

            set
            {
                fontSize = value;
            }
        }

        public abstract void ConstructLayoutPanel(Panel parentPanel);
        public abstract void ApplyAnswer();
        public abstract bool IsAnswerCorrect();
        public abstract void ResetTest();

        public void GiveAnswer(AnswerInfo answer)
        {
            isAnswerGiven = true;
            givenAnswer = answer;
        }


    }


    public enum TestType
    {
        SingleAnswer,
        MultyAnswer,
        Image,
        Text,
        Connections
    }
}