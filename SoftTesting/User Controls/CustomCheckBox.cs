using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftTesting
{
    public class CustomCheckBox : CheckBox
    {
        protected int buttonIndex = 0;

        public event IndexBoolArgs CheckedChangedEvent;

        public CustomCheckBox(int buttonIndex)
        {
            this.buttonIndex = buttonIndex;
            this.CheckedChanged += InvokeCheckedChangedEvent;
        }

        public int ButtonIndex
        {
            get
            {
                return buttonIndex;
            }
            set
            {
                buttonIndex = value;
            }
        }


        private void InvokeCheckedChangedEvent(object sender, EventArgs e)
        {
            CheckedChangedEvent?.Invoke(buttonIndex, this.Checked);
        }

        public void ResetState()
        {
            this.Checked = false;
        }

        public delegate void IndexBoolArgs(int index, bool state);
    }
}
