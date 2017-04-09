namespace Budget_Calc
{
    public class BudgetCalcItem
    {
        public string ItemName { get; set; }

        private decimal _IncomePercent;

        public decimal IncomePercent
        {
            get
            {
                return _IncomePercent;
            }

            set
            {
                _IncomePercent = value < 0 ? 0 : value > 100 ? 100 : value;
            }
        }

        public bool Selected { get; set; }

        public BudgetCalcItem(string name, decimal incomePercent, bool isSelected)
        {
            ItemName = name;
            IncomePercent = incomePercent;
            Selected = isSelected;
        }
    }
}
