using System;
using System.Linq;
using System.Windows.Forms;

namespace Budget_Calc
{
    public partial class EditItemsForm : Form
    {
        private string itemName;

        public BudgetCalcData data;

        public event EventHandler OnFormDone;

        public EditItemsForm(BudgetCalcData backingData)
        {
            InitializeComponent();

            data = backingData;
            Shown += EditItemsForm_Shown;
        }

        private void RefreshListBox()
        {
            ItemsBox.DataSource = data.GetItems().Keys.ToList();
        }

        private void RefreshListBox(string selectedItem)
        {
            RefreshListBox();
            ItemsBox.SelectedItem = selectedItem;
        }

        private void EditItemsForm_Shown(object sender, EventArgs e)
        {
            RefreshListBox();
        }
        
        private void ItemsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Save the current item
            SaveCurrentItem();

            // Get the item from data whose name matches the current selected item in the list box
            BudgetCalcItem currentItem = data.GetItems()[(string)ItemsBox.SelectedItem];

            NameTextBox.Text = currentItem.ItemName;
            PercentIncomeBox.Value = currentItem.IncomePercent;

            itemName = currentItem.ItemName;
        }

        private void NewItemButton_Click(object sender, EventArgs e)
        {
            SaveCurrentItem();

            data.SetItem(new BudgetCalcItem("new item", 0, false));

            RefreshListBox("new item");
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            SaveCurrentItem();

            if (itemName != null)
            {
                data.RemoveItem(itemName);
                itemName = null;
            }

            RefreshListBox();
        }

        private void SaveCurrentItem()
        {
            if (itemName != null)
            {
                if (NameTextBox.Text == "Main")
                {
                    MessageBox.Show("Items cannot be named \"Main\"");
                    NameTextBox.Text = itemName;
                    return;
                }

                BudgetCalcItem currentItem = new BudgetCalcItem(NameTextBox.Text, PercentIncomeBox.Value, false);

                data.SetItem(currentItem);

                if (NameTextBox.Text != itemName)
                {
                    data.RemoveItem(itemName);
                    itemName = currentItem.ItemName;
                    RefreshListBox();
                }
                else
                {
                    itemName = currentItem.ItemName;
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Hide();

            SaveCurrentItem();

            RefreshListBox();

            if (OnFormDone != null)
            {
                OnFormDone(this, EventArgs.Empty);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
