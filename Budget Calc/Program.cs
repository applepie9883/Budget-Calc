using System;
using System.Windows.Forms;

namespace Budget_Calc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BudgetCalcForm calcForm = new BudgetCalcForm();

            if (args.Length > 0)
            {
                if (args[0] != null)
                {
                    calcForm.OpenFile(args[0]);
                }
            }

            Application.Run(calcForm);
        }
    }
}
