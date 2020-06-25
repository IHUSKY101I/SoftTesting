using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public partial class MultyAnswerTestPanel : UserControl
    {
        private TableLayoutPanel tableLayoutPanel;
        private int rowsCount = 6;
        private int rowHeight = 50;
        private bool autoAdjustHeight = true;

        public MultyAnswerTestPanel(TableLayoutPanel tableLayoutPanel)
        {
            InitializeComponent();
            this.tableLayoutPanel = tableLayoutPanel;

            foreach (Control item in this.Controls)
            {
                item.Dispose();
            }
            this.Controls.Clear();
            this.Controls.Add(this.tableLayoutPanel);

            this.Resize += AdjustSizes;
        }


        ~MultyAnswerTestPanel()
        {
            this.Resize -= AdjustSizes;
        }

        public void AdjustSizes(object sender, EventArgs e)
        {
            if (autoAdjustHeight)
                AdjustHeight();
        }
        private void AdjustHeight()
        {
            rowHeight = this.Height / rowsCount;
        }


        public TableLayoutPanel TableLayoutPanel
        {
            get
            {
                return tableLayoutPanel;
            }
        }
        public int RowHeight
        {
            get
            {
                return rowHeight;
            }
        }
        public int RowsCount
        {
            get
            {
                return rowsCount;
            }

            set
            {
                rowsCount = value;
            }
        }
        public bool AutoAdjustHeight
        {
            get
            {
                return autoAdjustHeight;
            }

            set
            {
                autoAdjustHeight = value;
            }
        }
    }
}
