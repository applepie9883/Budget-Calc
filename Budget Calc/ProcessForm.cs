using System;
using System.Windows.Forms;

namespace Budget_Calc
{
    public partial class ProcessForm : Form
    {
        public event ProcessDelegate ProcessEvent;

        public ProcessForm()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            ProcessEvent?.Invoke(InputAmountBox.Value, DescriptionBox.Text);

            ClearForm();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            Hide();
            InputAmountBox.Value = 0;
            DescriptionBox.Text = string.Empty;
            InputAmountBox.Select();
        }
    }
}

public delegate void ProcessDelegate(decimal amount, string description);
