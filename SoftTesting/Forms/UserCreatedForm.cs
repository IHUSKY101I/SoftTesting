using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public partial class UserCreatedForm : Form
    {
        private LoginForm loginForm;
        private string login = "";
        private string password = "";
        public UserCreatedForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }
        public LoginForm LoginForm
        {
            get
            {
                return loginForm;
            }
        }
        public void UpdateLogin_AndPassword(string login, string password)
        {
            this.login = login;
            this.password = password;
            this.loginText.Text = login;
            UpdatePasswordState();
        }
        private void UpdatePasswordState()
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordText.Text = password;
            }
            else
            {
                string hiddenPassword = "";
                for (int i = 0; i < password.Length; i++)
                {
                    hiddenPassword += (char)0x2022;
                }
                passwordText.Text = hiddenPassword;
            }
            //0x2022
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePasswordState();
        }

        private void UserCreatedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.SaveAllUsers();
            if (startTestCheckBox.Checked)
                loginForm.TryToLogin();
        }
    }
}
