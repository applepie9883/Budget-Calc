using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Budget_Calc
{
    public class BudgetCalcData
    {
        private Dictionary<string, BudgetCalcItem> __Items;

        private Dictionary<string, BudgetCalcItem> _Items
        {
            get
            {
                return __Items;
            }
            set
            {
                __Items = value;
                Items = new ReadOnlyDictionary<string, BudgetCalcItem>(_Items);
            }
        }

        private ReadOnlyDictionary<string, BudgetCalcItem> Items { get; set; }

        public BudgetCalcData()
        {
            _Items = new Dictionary<string, BudgetCalcItem>();
        }

        public void SetItem(BudgetCalcItem item)
        {
            if (item.ItemName == "Main")
            {
                throw new System.ArgumentException("Items cannot be named \"Main\"");
            }

            if (_Items.ContainsKey(item.ItemName))
            {
                _Items[item.ItemName] = item;
            }
            else
            {
                _Items.Add(item.ItemName, item);
            }
        }

        public void RemoveItem(string itemName)
        {
            _Items.Remove(itemName);
        }

        public IReadOnlyDictionary<string, BudgetCalcItem> GetItems()
        {
            return Items;
        }

        public void ReadFromFile(string filePath)
        {
            _Items = new Dictionary<string, BudgetCalcItem>();

            using (BinaryReader reader = new BinaryReader(File.OpenRead(filePath)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string key = reader.ReadString();
                    decimal value = reader.ReadDecimal();
                    bool selected = reader.ReadBoolean();

                    SetItem(new BudgetCalcItem(key, value, selected));
                }
            }
        }

        public void WriteToFile(string filePath)
        {
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(filePath)))
            {
                foreach (var item in _Items.Values)
                {
                    writer.Write(item.ItemName);
                    writer.Write(item.IncomePercent);
                    writer.Write(item.Selected);
                }
            }
        }

        /*
        public void ReadFromFile(string filePath)
        {
            NotSelectedItems = new Dictionary<string, decimal>();
            SelectedItems = new Dictionary<string, decimal>();

            using (BinaryReader reader = new BinaryReader(File.OpenRead(filePath)))
            {
                bool selected = false;

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string key = reader.ReadString();

                    if (key == Environment.NewLine)
                    {
                        selected = true;
                        continue;
                    }

                    decimal value = reader.ReadDecimal();

                    if (selected)
                    {
                        SelectedItems.Add(key, value);
                    }
                    else
                    {
                        NotSelectedItems.Add(key, value);
                    }
                }
            }
        }

        public void WriteToFile(string filePath)
        {
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(filePath)))
            {
                foreach (var pair in NotSelectedItems)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }

                writer.Write(Environment.NewLine);

                foreach (var pair in SelectedItems)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
        }
        */
    }
}
