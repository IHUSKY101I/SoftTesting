using System;
using System.Windows.Forms;

namespace SoftTesting
{
    public partial class ImageAnswerTestPanel : UserControl
    {
        private TableLayoutPanel tableLayoutPanel;

        private int columnsCount = 2;
        private int rowsCount = 2;
        private int rowHeight = 160;
        private int rowWidth = 250;
        private bool autoAdjustAnswerWidth = true;
        private bool autoAdjustAnswerHeight = true;

        public ImageAnswerTestPanel(TableLayoutPanel tableLayout)
        {
            InitializeComponent();
            this.tableLayoutPanel = tableLayout;

            foreach (Control item in this.Controls)
            {
                item.Dispose();
            }
            this.Controls.Clear();
            this.Controls.Add(this.tableLayoutPanel);

            this.Resize += AdjustSizes;
        }


        ~ImageAnswerTestPanel()
        {
            this.Resize -= AdjustSizes;
        }

        public void AdjustSizes(object sender, EventArgs e)
        {
            if (autoAdjustAnswerWidth)
                AdjustAnswerWidth();
            if (autoAdjustAnswerHeight)
                AdjustAnswerHeight();
        }
        private void AdjustAnswerWidth()
        {
            rowWidth = this.Width / columnsCount;
        }

        private void AdjustAnswerHeight()
        {
            rowHeight = this.Height / rowsCount;
        }

        public int RowHeight
        {
            get
            {
                return rowHeight;
            }

            set
            {
                rowHeight = value;
            }
        }
        public int RowWidth
        {
            get
            {
                return rowWidth;
            }

            set
            {
                rowWidth = value;
            }
        }
        public bool AutoAdjustAnswerSize
        {
            get
            {
                return autoAdjustAnswerWidth;
            }

            set
            {
                autoAdjustAnswerWidth = value;
            }
        }
        public int ColumnsCount
        {
            get
            {
                return columnsCount;
            }

            set
            {
                columnsCount = value;
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

        public TableLayoutPanel TableLayoutPanel
        {
            get
            {
                return tableLayoutPanel;
            }
        }
    }
}
