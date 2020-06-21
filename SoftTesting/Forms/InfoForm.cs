using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public partial class InfoForm : Form
    {
        private MainForm mainForm;

        public InfoForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            label1.Text = "Дмитренко Н.П.\nЗайцев А.Д.\nКоваленко А.А.\n515ст2";
        }

        public MainForm MainForm
        {
            get
            {
                return mainForm;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
