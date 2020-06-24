using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace SoftTesting
{
    public partial class LoginForm : Form
    {
        public const string USERS_FILE_PATH = @"Resources/Users.list";

        private bool isControllPressed = false;
        private bool isShiftPressed = false;
        private bool isLetter_N_Pressed = false;

        private Color regularTextBoxBackColor;
        private Color errorTextBoxBackColor = Color.FromKnownColor(KnownColor.Crimson);

        private bool userExist = false;
        private User currentUser = null;

        private Thread saveThread = null;

        private MainForm mainForm;
        private UserCreatedForm userCreatedForm;

        private List<User> allUsers;


        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            KeyPreview = true;
            userCreatedForm = new UserCreatedForm(this);

            this.regularTextBoxBackColor = loginTextBox.BackColor;

            this.mainForm = mainForm;

            LoadAllUsers(USERS_FILE_PATH);
        }

        public MainForm MainForm
        {
            get
            {
                return mainForm;
            }
        }
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
        }
        public bool UserExist
        {
            get
            {
                return userExist;
            }
        }
        public List<User> AllUsers
        {
            get
            {
                return allUsers;
            }
        }

        public UserCreatedForm UserCreatedForm
        {
            get
            {
                return userCreatedForm;
            }
        }

        public void StartTest()
        {
            this.Hide();
            MainForm.StartTest();
            mainForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }

        public void TryToLogin()
        {
            for (int i = 0; i < allUsers.Count; i++)
            {
                User u = allUsers[i];
                if (u.Name.ToUpperInvariant() == loginTextBox.Text.ToUpperInvariant())
                {
                    if (u.Password == passwordTextBox.Text)
                    {
                        userExist = true;
                        currentUser = u;
                        StartTest();
                        return;
                    }
                }
            }
            errorProvider.SetError(loginTextBox, "Пользователь " + loginTextBox.Text + " не существует или введён неверный пароль!");
            loginTextBox.BackColor = errorTextBoxBackColor;
            passwordTextBox.BackColor = errorTextBoxBackColor;
        }

        private void LoadAllUsers(string usersFilePath)
        {
            try
            {
                using (FileStream fs = new FileStream(usersFilePath, FileMode.Open))
                {
                    byte[] array = new byte[fs.Length];
                    int pos = 0;
                    fs.Position = 0;
                    fs.Read(array, 0, array.Length);

                    List<User> allUsersList = new List<User>();

                    UsersFieldType currentField = UsersFieldType.None;
                    string userName = User.DEFAULT_USERNAME;
                    string password = User.DEFAULT_PASSWORD;
                    string lastResult = User.DEFAULT_LAST_RESULT;

                    byte buffer = 0;
                    string token = "";
                    bool isReadingToken = false;
                    bool isReadingValue = false;

                    bool isCommentString = false;
                    bool isUserFound = false;

                    while (pos < array.Length)
                    {
                        buffer = array[pos];
                        pos++;

                        if (isCommentString)
                        {
                            if (buffer == '\n')
                            {
                                isCommentString = false;
                            }
                            continue;
                        }
                        else
                        {
                            if (isUserFound)
                            {
                                if (buffer == '}')
                                {
                                    allUsersList.Add(new User(userName, password, lastResult));
                                    password = User.DEFAULT_PASSWORD;
                                    userName = User.DEFAULT_USERNAME;
                                    lastResult = User.DEFAULT_LAST_RESULT;
                                    isUserFound = false;
                                }
                                else
                                {
                                    if (buffer == ' ' || buffer == '\n' || buffer == '\r' || buffer == '\b' || buffer == (char)9)
                                    {
                                        if (isReadingToken)
                                        {
                                            if (isReadingValue)
                                            {
                                                switch (currentField)
                                                {
                                                    case UsersFieldType.None:
                                                        break;
                                                    case UsersFieldType.Name:
                                                        string nameStr = token;
                                                        nameStr = nameStr.Replace(";", "");
                                                        nameStr = nameStr.Replace(((char)34).ToString(), "");
                                                        //nameStr = nameStr.ToUpperInvariant();
                                                        userName = nameStr;
                                                        break;
                                                    case UsersFieldType.Password:
                                                        string passStr = token;
                                                        passStr = passStr.Replace(";", "");
                                                        passStr = passStr.Replace(((char)34).ToString(), "");
                                                        password = passStr;
                                                        break;
                                                    case UsersFieldType.LastResult:
                                                        string resultStr = token;
                                                        resultStr = resultStr.Replace(";", "");
                                                        resultStr = resultStr.Replace(((char)34).ToString(), "");
                                                        lastResult = resultStr;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                currentField = UsersFieldType.None;
                                                isReadingValue = false;
                                            }
                                            else
                                            {
                                                switch (token)
                                                {
                                                    case "name":
                                                        isReadingValue = true;
                                                        currentField = UsersFieldType.Name;
                                                        break;
                                                    case "password":
                                                        isReadingValue = true;
                                                        currentField = UsersFieldType.Password;
                                                        break;
                                                    case "lastResult":
                                                        isReadingValue = true;
                                                        currentField = UsersFieldType.LastResult;
                                                        break;
                                                    default:
#if DEBUG
                                                        Console.WriteLine("Неизвестный токен: " + token);
#endif
                                                        break;
                                                }
                                            }
                                            token = "";
                                        }
                                        else
                                        {

                                        }
                                        isReadingToken = false;
                                    }
                                    else
                                    {
                                        isReadingToken = true;
                                        token += Convert.ToChar(buffer);
                                    }
                                }
                            }
                            else
                            {
                                if (buffer == '#')
                                {
                                    isCommentString = true;
                                    continue;
                                }

                                if (isReadingToken)
                                {
                                    if (buffer == ' ' || buffer == '\n' || buffer == '\r' || buffer == (char)9)
                                    {
                                        isReadingToken = false;
                                        if (token == "user")
                                        {
                                            isUserFound = true;
                                            token = "";
#if DEBUG
                                            Console.WriteLine("User FOUND!");
#endif
                                        }
                                    }
                                    else
                                    {
                                        token += Convert.ToChar(buffer);
                                    }
                                }
                                else
                                {
                                    if (buffer == ' ' || buffer == '\n' || buffer == '\0' || buffer == '\b' || buffer == '\r' || buffer == 0xEF || buffer == 0xBB || buffer == 0xBF)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        isReadingToken = true;
                                        token = "";
                                        token += Convert.ToChar(buffer);
                                    }
                                }
                            }
                        }
                    }
                    allUsers = allUsersList;

#if DEBUG
                    Console.WriteLine("---Всего пользователей: " + allUsersList.Count);
                    foreach (User item in allUsersList)
                    {
                        Console.WriteLine("Загружен пользователь: " + item.Name + " пароль: " + item.Password);
                    }
#endif
                }
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine(e.Message);
#endif
            }

        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveAllUsers();
            if (userExist == false)
            {
                Application.Exit();
            }
        }

        public void ResetLogin()
        {
            this.userExist = false;
            this.currentUser = null;
            errorProvider.Clear();
            loginTextBox.BackColor = regularTextBoxBackColor;
            passwordTextBox.BackColor = regularTextBoxBackColor;
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            this.ShowDialog();
        }

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TryToLogin();
                //passwordTextBox.Focus();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TryToLogin();
            }
        }

        public void SaveAllUsers()
        {
            saveThread = new Thread(StartSavingAsync);
            saveThread.IsBackground = false;
            saveThread.Start();
        }

        private void StartSavingAsync()
        {
            try
            {
                string result = "";
                foreach (User item in allUsers)
                {
                    result += ConstructUserDataForSave(item);
                }

                using (StreamWriter streamWriter = new StreamWriter(USERS_FILE_PATH))
                {
                    streamWriter.Write(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private string ConstructUserDataForSave(User user)
        {
            string result = "\nuser\n{";
            result += "\n" + ((char)9) + "name " + '"' + user.Name + '"' + ";";
            result += "\n" + ((char)9) + "password " + '"' + user.Password + '"' + ";";
            result += "\n" + ((char)9) + "lastResult " + '"' + user.LastResult + '"' + ";";
            result += "\n}\n";
            return result;
        }



        private void TryToAddUser()
        {
            string login = loginTextBox.Text;
            string pass = passwordTextBox.Text;
            pass = pass.Replace(" ", "");
            if (pass.Length < 3)
                return;
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].Name == login)
                    return;
            }
            login = login.Replace(" ", "");
            if (login.Length < 3)
                return;

            allUsers.Add(new User(login, pass, "0/0(0%)"));
            userCreatedForm.UpdateLogin_AndPassword(login, pass);
            userCreatedForm.ShowDialog();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
                isLetter_N_Pressed = true;
            if (e.Shift)
                isShiftPressed = true;
            if (e.Control)
                isControllPressed = true;

            //Console.WriteLine("Ctrl: " + isControllPressed);
            //Console.WriteLine("Shift: " + isShiftPressed);
            //Console.WriteLine("N: " + isLetter_N_Pressed);

            if (isControllPressed && isShiftPressed && isLetter_N_Pressed)
                TryToAddUser();
        }

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
                isLetter_N_Pressed = false;
            if (e.Shift == false)
                isShiftPressed = false;
            if (e.Control == false)
                isControllPressed = false;
        }





        public enum UsersFieldType
        {
            None, Name, Password, LastResult
        }
    }
}
