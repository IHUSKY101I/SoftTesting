using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoftTesting
{
    public class TestLoader
    {
        public const string TESTS_FILE_PATH = @"Resources/Tasks.test";
        private static TestLoader loaderInstance;

        private Test[] allTests;
        private Test currentTest;
        private int currentTestIndex = 0;
        private string testsDirectory;
        private string testsExpansion;

        private bool testHasTimer = false;
        private TimeSpan totalTimeForTest;

        private MainForm mainForm;



        // Ограничение возможности создания ещё одного экземпляра класса TestLoader через ключевое слово new.
        private TestLoader()
        {

        }

        // Singleton.
        public static TestLoader LoaderInstance
        {
            get
            {
                if (loaderInstance == null)
                    loaderInstance = new TestLoader();
                return loaderInstance;
            }
        }



        public string TestsDirectory
        {
            get
            {
                return testsDirectory;
            }

            set
            {
                testsDirectory = value;
            }
        }
        public string TestsExpansion
        {
            get
            {
                return testsExpansion;
            }

            set
            {
                testsExpansion = value;
            }
        }
        public Test[] AllTests
        {
            get
            {
                return allTests;
            }

            set
            {
                allTests = value;
            }
        }
        public MainForm MainForm
        {
            get
            {
                return mainForm;
            }

            set
            {
                if (mainForm == null)
                    mainForm = value;
            }
        }

        public bool TestHasTimer
        {
            get
            {
                return testHasTimer;
            }
        }
        public TimeSpan TotalTimeForTest
        {
            get
            {
                return totalTimeForTest;
            }
        }
        public Test CurrentTest
        {
            get
            {
                return currentTest;
            }
        }
        public int CurrentTestIndex
        {
            get
            {
                return currentTestIndex;
            }
        }

        public void LoadTest()
        {
            allTests = LoadTestsFromFile(TESTS_FILE_PATH);

            for (int i = 0; i < allTests.Length; i++)
            {
                Test t = allTests[i];
                //Console.WriteLine("Test: " + t.TestType);
                t.ConstructLayoutPanel(MainForm.TestGridHolder);
                if (t.UserControlPanel != null)
                    t.UserControlPanel.Visible = false;
                else Console.WriteLine("---UserControlPanel missing at test: " + t.Title);
            }

            currentTest = allTests[0];
            //if (allTests.Length > 0)
            //    SelectTest(0);
        }



        public void RandomizeTests()
        {
            List<Test> tempStorage = new List<Test>();
            for (int i = 0; i < allTests.Length; i++)
            {
                tempStorage.Add(allTests[i]);
            }

            Random rnd = new Random();
            for (int i = 0; i < allTests.Length; i++)
            {
                int index = rnd.Next(0, tempStorage.Count);
                allTests[i] = tempStorage[index];
                tempStorage.RemoveAt(index);
            }
            mainForm.UpdateTestsListBox();
        }


        public void SelectTest(int index)
        {
            if (index >= 0)
            {
                //if (index != currentTestIndex)
                //{
                currentTest.UserControlPanel.Visible = false;

                currentTestIndex = index;
                currentTest = allTests[index];
                currentTest.UserControlPanel.Visible = true;
                MainForm.TaskLabel.Text = currentTest.Task;
                //}
            }
        }



        /// <summary>
        /// Загрузка всех заданий из файла
        /// </summary>
        /// <param name="path">Путь к файлу вместе с его именем и расширением</param>
        /// <returns></returns>
        private Test[] LoadTestsFromFile(string path)
        {
            bool clearTimeFlag = true;

            // Создание списка объектов класса TestInfo. Объект класса TestInfo содержит информацию об одном вопросе теста
            List<Test> testList = new List<Test>();
            // Открытие файла. Использование ключевого слова using гарантирует освобождение неуправляемых ресурсов (закрытие файла)
            // в конце блока кода (в фигурных скобках) + включение кодировки для корректного чтения русских букв.
            using (StreamReader fs = new StreamReader(path, Encoding.GetEncoding(1251)))
            {
                // Флаг указывающий игнорировать ли текущую строку которую читает загрузчик (например если она помечена как комментарий)
                bool ignoreString = false;
                // Флаг указывающий найден ли в данный момент тест. Если тест не найден загрузчик будет игнорировать все встречающиеся символы
                // пока не найдёт заглавную букву T
                bool testFound = false;

                bool timeFound = false;
                bool readingTime = false;
                // Тип информации на текущей строке
                ReadingType type = ReadingType.None;

                // Название задания (отображаеться в списке тестов)
                string title = "default title";
                // Текст задания
                string task = "default task";
                // Правильный вариант ответа текущего обрабатываемого теста
                int correctVariant = 1;
                // Тип найденного теста
                TestType currentTestType = TestType.Text;
                // Список всех текстовых полей для текущего теста
                List<string> fieldsList = new List<string>();
                // Список всех изображений в тестах с изображениями для текущего вопроса (если есть)
                List<string> picturesList = new List<string>();
                // Список всех соответствия в тесте на соответствие для текущего вопроса (если есть)
                List<int> connectionsList = new List<int>();

                // Буфферный байт. В него записывается текущий читаемый символ.
                // Имеет тип int т.к. метод StreamReader.Read() возвращает тип int (хотя по идее должен byte)
                int buffer;
                // Буферная строка. В неё записываются символы из буффера buffer. После чтения и обработки экранной строки этот буфер очищается
                // и в него записывается следующая строка.
                string strBuffer = "";

                // Чтение файла до самого конца
                while (fs.EndOfStream == false)
                {
                    buffer = fs.Read();
                    if (ignoreString)
                    {
                        if (buffer == '\n')
                        {
                            ignoreString = false;
                        }
                    }
                    else
                    {
                        if (testFound)
                        {
                            switch (type)
                            {
                                case ReadingType.Instruction:
                                    strBuffer += Convert.ToChar(buffer);
                                    if (buffer == '\n')
                                    {
                                        if (strBuffer.Contains("Title:"))
                                        {
                                            title = GetInstructionArg("Title:", strBuffer);
                                        }
                                        else if (strBuffer.Contains("Task:"))
                                        {
                                            task = GetInstructionArg("Task:", strBuffer);
                                        }
                                        else if (strBuffer.Contains("Type:"))
                                        {
                                            string typeStr = GetInstructionArg("Type:", strBuffer);
                                            if (typeStr == "Text")
                                                currentTestType = TestType.Text;
                                            else if (typeStr == "SingleAnswer")
                                                currentTestType = TestType.SingleAnswer;
                                            else if (typeStr == "MultyAnswer")
                                                currentTestType = TestType.MultyAnswer;
                                            else if (typeStr == "Image")
                                                currentTestType = TestType.Image;
                                            else if (typeStr == "Connection")
                                                currentTestType = TestType.Connections;
                                        }
                                        else if (strBuffer.Contains("Correct:"))
                                        {
                                            correctVariant = Convert.ToInt32(GetInstructionArg("Correct:", strBuffer));
                                        }
                                        type = ReadingType.None;
                                        strBuffer = "";
                                    }
                                    break;
                                case ReadingType.Variant:
                                    strBuffer += Convert.ToChar(buffer);
                                    if (buffer == '\n')
                                    {
                                        if (strBuffer.Contains("@Field:"))
                                        {
                                            fieldsList.Add(GetInstructionArg("@Field:", strBuffer));
                                        }
                                        else if (strBuffer.Contains("@Picture:"))
                                        {
                                            picturesList.Add(GetInstructionArg("@Picture:", strBuffer));
                                        }
                                        else if (strBuffer.Contains("@Connection:"))
                                        {
                                            connectionsList.Add(Convert.ToInt32(GetInstructionArg("@Connection:", strBuffer)));
                                        }
                                        else if (strBuffer.Contains("@E"))
                                        {
                                            type = ReadingType.None;
                                        }
                                        strBuffer = "";
                                    }
                                    break;
                                case ReadingType.None:
                                    if (buffer == '@')
                                        type = ReadingType.Instruction;
                                    else if (buffer == 'V')
                                        type = ReadingType.Variant;
                                    else if (buffer == 'S')
                                    {
                                        testFound = false;

                                        switch (currentTestType)
                                        {
                                            case TestType.SingleAnswer:
                                                TestSingleAnswer single = new TestSingleAnswer(title, task, fieldsList.ToArray(), new AnswerInfo(currentTestType, fieldsList[correctVariant - 1], new string[] { }));
                                                testList.Add(single);
                                                break;
                                            case TestType.MultyAnswer:
                                                List<string> correctAnswers = new List<string>();
                                                for (int i = 0; i < picturesList.Count; i++)
                                                {
                                                    if (picturesList[i] == "1")
                                                        correctAnswers.Add(fieldsList[i]);
                                                }
                                                TestMultyAnswer multy = new TestMultyAnswer(title, task, fieldsList.ToArray(), new AnswerInfo(currentTestType, "", correctAnswers.ToArray()));
                                                testList.Add(multy);
                                                break;
                                            case TestType.Image:
                                                TestImage img = new TestImage(title, task, picturesList.ToArray(), fieldsList.ToArray(), new AnswerInfo(currentTestType, correctVariant.ToString(), new string[] { }));
                                                testList.Add(img);
                                                break;
                                            case TestType.Text:
                                                TestText txt = new TestText(title, task, fieldsList.ToArray(), new AnswerInfo(currentTestType, fieldsList[0], new string[] { }));
                                                testList.Add(txt);
                                                break;
                                            case TestType.Connections:
                                                TestConnections conns = new TestConnections(title, task, fieldsList.ToArray(), new AnswerInfo(currentTestType, fieldsList[correctVariant + 1], new string[] { }));
                                                testList.Add(conns);
                                                break;
                                            default:
                                                break;
                                        }

                                        fieldsList.Clear();
                                        picturesList.Clear();
                                        connectionsList.Clear();
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (timeFound)
                        {
                            if (readingTime)
                            {
                                if (buffer == ' ' || buffer == '\n' || buffer == '\b' || buffer == '\r' || buffer == (char)9)
                                {
                                    readingTime = false;
                                    testHasTimer = true;
                                    timeFound = false;
                                    clearTimeFlag = false;

                                    int minuts = 0;
                                    int seconds = 0;
                                    //Console.WriteLine("Time found: " + strBuffer);
                                    string[] buffers = strBuffer.Split(':');
                                    minuts = Convert.ToInt32(buffers[0]);
                                    seconds = Convert.ToInt32(buffers[1]);
                                    strBuffer = "";
                                    totalTimeForTest = new TimeSpan(0, minuts, seconds);
                                }
                                else
                                {
                                    strBuffer += Convert.ToChar(buffer);
                                }
                            }
                            else
                            {
                                if ((buffer == ' ' || buffer == '\n' || buffer == '\b' || buffer == '\r' || buffer == (char)9) == false)
                                {
                                    readingTime = true;
                                    strBuffer += Convert.ToChar(buffer);
                                }
                            }
                        }
                        else
                        {
                            if (buffer == '#')
                            {
                                ignoreString = true;
                            }
                            else if (buffer == 'T')
                            {
                                testFound = true;
                            }
                            else if (buffer == 'V')
                            {
                                timeFound = true;
                            }
                        }
                    }
                }
            }
            if (clearTimeFlag)
            {
                testHasTimer = false;
            }
            // Возвращение полученнного списка с преобразованием его в массив
            return testList.ToArray();
        }

        /// <summary>
        /// Достать из строки значение следующие сразу после подстроки instruction
        /// </summary>
        /// <param name="instruction">Подстрока значение после которой нужно получить</param>
        /// <param name="str">Вся строка (имеется ввиду экранная строка (до нажатия Enter), а не строка string)</param>
        /// <returns></returns>
        private string GetInstructionArg(string instruction, string str)
        {
            int pos = str.IndexOf(instruction);
            string subStr = str.Remove(pos, instruction.Length);
            subStr = subStr.Trim('\n');
            subStr = subStr.Trim('\r');
            subStr = subStr.Trim('\t');
            return subStr;
        }

        /// <summary>
        /// Тип информации на текущей строке (нужен для внутреннего пользования данным классом)
        /// </summary>
        private enum ReadingType
        {
            Instruction, Variant, None
        }

        void Sort(int[] arr)
        {
            int temp;
            int curIndex = 1;
            int iteration = 1;
            int min = arr[0];
            int minValue = 0;
            int curValue = arr[0];


            while (iteration < arr.Length)
            {
                if (curIndex >= arr.Length)
                {
                    arr[minValue] = min;
                    iteration++;
                    curIndex = iteration;
                }

                if (arr[curIndex] < min)
                {
                    temp = arr[curIndex];
                    arr[curIndex] = min;
                    min = temp;
                    //minValue = 
                }

                curIndex++;
            }
        }
    }
}