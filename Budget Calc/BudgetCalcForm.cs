using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Budget_Calc
{
    public partial class BudgetCalcForm : Form
    {
        private bool processSingle;

        public string dataFilePath;

        private BudgetCalcData data;

        private EditItemsForm editForm;
        private ProcessForm processForm;

        public BudgetCalcForm()
        {
            InitializeComponent();

            processSingle = false;

            data = new BudgetCalcData();

            editForm = new EditItemsForm(data);
            editForm.OnFormDone += EditForm_Done;
            processForm = new ProcessForm();
            processForm.ProcessEvent += ProcessForm_ProcessEvent;
        }

        private void InputProcessButton_Click(object sender, EventArgs e)
        {
            decimal totalInputPercentage = 0;
            totalInputPercentage = data.GetItems().Values.Sum(i => i.IncomePercent);

            if (totalInputPercentage > 100)
            {
                MessageBox.Show("The sum of the input percentages of the selected items is greater than 100 percent");
            }

            processSingle = false;
            processForm.Show();
        }

        private void ProcessToFile(string fileName, string desc, decimal amount)
        {
            amount = Math.Round(amount, 2);

            if (dataFilePath == null)
            {
                MessageBox.Show("Please open a file, or create a new file.");
                return;
            }

            string filePath = Path.GetDirectoryName(dataFilePath) + $"\\{fileName}";

            decimal totalAmount = amount;

            if (File.Exists(filePath))
            {
                totalAmount += decimal.Parse(File.ReadLines(filePath).Last().Split(',').Last());
            }

            totalAmount = Math.Round(totalAmount, 2);

            File.AppendAllText(filePath, $"{DateTime.Today.ToString("MM/dd/yyyy")},{desc.Replace(",", "")},{amount},{totalAmount}" + Environment.NewLine);
        }

        private void ProcessItemButton_Click(object sender, EventArgs e)
        {
            processSingle = true;
            processForm.Show();
        }

        private void ProcessForm_ProcessEvent(decimal amount, string description)
        {
            amount = Math.Round(amount, 2);

            if (processSingle)
            {
                ProcessToFile("Main.csv", description, amount);
                ProcessToFile($"{(string)ItemsBox.SelectedItem}.csv", description, amount);
            }
            else
            {
                decimal takenAmount = 0;

                Dictionary<string, decimal> itemAmounts = new Dictionary<string, decimal>();

                for (int i = 0; i < ItemsBox.CheckedItems.Count; i++)
                {
                    string name = (string)ItemsBox.CheckedItems[i];

                    decimal alottedAmount = 0;

                    if (i == ItemsBox.CheckedItems.Count - 1)
                    {
                        alottedAmount = Math.Round(amount - takenAmount, 2);
                    }
                    else
                    {
                        decimal itemPercentDecimal = data.GetItems()[name].IncomePercent * 0.01m;
                        alottedAmount = Math.Round(itemPercentDecimal * amount, 2);
                        takenAmount += alottedAmount;
                    }

                    itemAmounts.Add(name, alottedAmount);
                }

                ProcessToFile("Main.csv", description, amount);

                foreach (var item in itemAmounts)
                {
                    ProcessToFile($"{item.Key}.csv", description, item.Value);
                }
            }
        }

        // TODO: Maybe instead of reading the amount from file every time a new item is selected, I could read it all at once when the file is opened?
        // TODO: Decide on this once I figure out if I am going to save everything in the one file instead of the csv files.
        private void ItemsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BudgetCalcItem selectedItem = data.GetItems()[(string)ItemsBox.SelectedItem];
            string filePath = Path.GetDirectoryName(dataFilePath) + $"\\{selectedItem.ItemName}.csv";

            PercentIncomeDataLabel.Text = selectedItem.IncomePercent.ToString();
            if (File.Exists(filePath))
            {
                CurrentBalanceDataLabel.Text = File.ReadLines(filePath).Last().Split(',').Last();
            }
            else
            {
                CurrentBalanceDataLabel.Text = "0.00";
            }
        }

        private void ItemsBox_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            BudgetCalcItem selectedItem = data.GetItems()[(string)ItemsBox.Items[e.Index]];

            if (e.NewValue == CheckState.Checked)
            {
                selectedItem.Selected = true;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                selectedItem.Selected = false;
            }

            data.SetItem(selectedItem);
        }

        public void EditForm_Done(object sender, EventArgs e)
        {
            UpdateItemsBox();
        }

        private void UpdateItemsBox()
        {
            for (int i = ItemsBox.Items.Count - 1; i >= 0; i--)
            {
                ItemsBox.Items.RemoveAt(i);
            }

            for (int i = 0; i < data.GetItems().Count(); i++)
            {
                BudgetCalcItem item = data.GetItems().ElementAt(i).Value;
                ItemsBox.Items.Add(item.ItemName);
                ItemsBox.SetItemChecked(ItemsBox.Items.IndexOf(item.ItemName), item.Selected);
            }
        }

        private void EditItemsButton_Click(object sender, EventArgs e)
        {
            editForm.Show();
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            CreateNewFile();
        }

        private DialogResult CreateNewFile()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Budget Calc Data Files|*.bcd";
            dialog.DefaultExt = "odt";
            dialog.AddExtension = true;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                dataFilePath = dialog.FileName;
            }

            return result;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Budget Calc Data Files|*.bcd|All Files|*";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                OpenFile(dialog.FileName);
            }
        }

        public void OpenFile(string filePath)
        {
            dataFilePath = filePath;
            data.ReadFromFile(filePath);
            UpdateItemsBox();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (dataFilePath == null)
            {
                if (CreateNewFile() != DialogResult.OK)
                {
                    return;
                }
            }

            data.WriteToFile(dataFilePath);
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// NOTES
//
// TODO: "Please open a file or create a new file" shows up twice.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////