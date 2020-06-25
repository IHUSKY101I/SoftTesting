using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SoftTesting
{
    public class CustomRadioButton : RadioButton
    {
        protected int buttonIndex = 0;

        public event IndexArgs CheckedChangedEvent;

        public CustomRadioButton(int buttonIndex)
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
            CheckedChangedEvent?.Invoke(buttonIndex);
        }

        public void ResetState()
        {
            this.Checked = false;
        }


        public delegate void IndexArgs(int index);
    }
}
