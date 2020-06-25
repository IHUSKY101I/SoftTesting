using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public class TestConnections : Test
    {
        public TestConnections(string title, string task, string[] allVariants, AnswerInfo correctAnswer)
        {
            this.testType = TestType.Connections;
            this.title = title;
            this.task = task;
            this.allVariants = allVariants;
            this.correctAnswer = correctAnswer;
        }


        public override void ConstructLayoutPanel(Panel parentPanel)
        {
            Console.WriteLine("Missing TestConnections panel...");
        }
        public override void ApplyAnswer()
        {
            throw new NotImplementedException();
        }

        public override bool IsAnswerCorrect()
        {
            throw new NotImplementedException();
        }

        public override void ResetTest()
        {
            throw new NotImplementedException();
        }
    }
}