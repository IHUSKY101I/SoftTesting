using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTesting
{
    public struct AnswerInfo
    {
        private TestType testType;
        private string singleAnswer;
        private string[] multyAnswer;

        public AnswerInfo(TestType testType, string singleAnswer, string[] multyAnswer)
        {
            this.testType = testType;
            this.singleAnswer = singleAnswer;
            this.multyAnswer = multyAnswer;
        }



        public TestType TestType
        {
            get
            {
                return testType;
            }
        }
        public string SingleAnswer
        {
            get
            {
                return singleAnswer;
            }
        }
        public string[] MultyAnswer
        {
            get
            {
                return multyAnswer;
            }
        }
    }
}
