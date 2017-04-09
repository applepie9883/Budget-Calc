namespace Budget_Calc
{
    partial class BudgetCalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IncomeProcessButton = new System.Windows.Forms.Button();
            this.ProcessItemButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedItemDataGrid = new System.Windows.Forms.DataGridView();
            this.ItemsBox = new System.Windows.Forms.CheckedListBox();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.CurrentBalanceDataLabel = new System.Windows.Forms.Label();
            this.EditItemsButton = new System.Windows.Forms.Button();
            this.PercentIncomeLabel = new System.Windows.Forms.Label();
            this.PercentIncomeDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedItemDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeProcessButton
            // 
            this.IncomeProcessButton.Location = new System.Drawing.Point(141, 264);
            this.IncomeProcessButton.Name = "IncomeProcessButton";
            this.IncomeProcessButton.Size = new System.Drawing.Size(120, 23);
            this.IncomeProcessButton.TabIndex = 1;
            this.IncomeProcessButton.Text = "Process Income";
            this.IncomeProcessButton.UseVisualStyleBackColor = true;
            this.IncomeProcessButton.Click += new System.EventHandler(this.InputProcessButton_Click);
            // 
            // ProcessItemButton
            // 
            this.ProcessItemButton.Location = new System.Drawing.Point(141, 293);
            this.ProcessItemButton.Name = "ProcessItemButton";
            this.ProcessItemButton.Size = new System.Drawing.Size(120, 23);
            this.ProcessItemButton.TabIndex = 6;
            this.ProcessItemButton.Text = "Process Item";
            this.ProcessItemButton.UseVisualStyleBackColor = true;
            this.ProcessItemButton.Click += new System.EventHandler(this.ProcessItemButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(15, 12);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(120, 23);
            this.NewFileButton.TabIndex = 7;
            this.NewFileButton.Text = "New File";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(141, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(120, 23);
            this.OpenFileButton.TabIndex = 7;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(267, 12);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(120, 23);
            this.SaveFileButton.TabIndex = 7;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // SelectedItemDataGrid
            // 
            this.SelectedItemDataGrid.AllowUserToOrderColumns = true;
            this.SelectedItemDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Description,
            this.Amount,
            this.Total});
            this.SelectedItemDataGrid.Location = new System.Drawing.Point(267, 41);
            this.SelectedItemDataGrid.Name = "SelectedItemDataGrid";
            this.SelectedItemDataGrid.Size = new System.Drawing.Size(443, 304);
            this.SelectedItemDataGrid.TabIndex = 10;
            // 
            // ItemsBox
            // 
            this.ItemsBox.FormattingEnabled = true;
            this.ItemsBox.Location = new System.Drawing.Point(15, 41);
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.Size = new System.Drawing.Size(120, 304);
            this.ItemsBox.TabIndex = 12;
            this.ItemsBox.SelectedIndexChanged += new System.EventHandler(this.ItemsBox_SelectedIndexChanged);
            this.ItemsBox.ItemCheck += ItemsBox_ItemCheck;
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(141, 41);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(120, 13);
            this.CurrentBalanceLabel.TabIndex = 13;
            this.CurrentBalanceLabel.Text = "Current Balance:";
            // 
            // CurrentBalanceDataLabel
            // 
            this.CurrentBalanceDataLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentBalanceDataLabel.Location = new System.Drawing.Point(141, 54);
            this.CurrentBalanceDataLabel.Name = "CurrentBalanceDataLabel";
            this.CurrentBalanceDataLabel.Size = new System.Drawing.Size(120, 15);
            this.CurrentBalanceDataLabel.TabIndex = 13;
            this.CurrentBalanceDataLabel.Text = "0.00";
            // 
            // EditItemsButton
            // 
            this.EditItemsButton.Location = new System.Drawing.Point(141, 322);
            this.EditItemsButton.Name = "EditItemsButton";
            this.EditItemsButton.Size = new System.Drawing.Size(120, 23);
            this.EditItemsButton.TabIndex = 6;
            this.EditItemsButton.Text = "Edit Items";
            this.EditItemsButton.UseVisualStyleBackColor = true;
            this.EditItemsButton.Click += new System.EventHandler(this.EditItemsButton_Click);
            // 
            // PercentIncomeLabel
            // 
            this.PercentIncomeLabel.Location = new System.Drawing.Point(141, 84);
            this.PercentIncomeLabel.Name = "PercentIncomeLabel";
            this.PercentIncomeLabel.Size = new System.Drawing.Size(120, 13);
            this.PercentIncomeLabel.TabIndex = 13;
            this.PercentIncomeLabel.Text = "Percent of Income";
            // 
            // PercentIncomeDataLabel
            // 
            this.PercentIncomeDataLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PercentIncomeDataLabel.Location = new System.Drawing.Point(141, 97);
            this.PercentIncomeDataLabel.Name = "PercentIncomeDataLabel";
            this.PercentIncomeDataLabel.Size = new System.Drawing.Size(120, 15);
            this.PercentIncomeDataLabel.TabIndex = 13;
            this.PercentIncomeDataLabel.Text = "0.00";
            // 
            // BudgetCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 715);
            this.Controls.Add(this.PercentIncomeDataLabel);
            this.Controls.Add(this.CurrentBalanceDataLabel);
            this.Controls.Add(this.PercentIncomeLabel);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Controls.Add(this.ItemsBox);
            this.Controls.Add(this.SelectedItemDataGrid);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.EditItemsButton);
            this.Controls.Add(this.ProcessItemButton);
            this.Controls.Add(this.IncomeProcessButton);
            this.Name = "BudgetCalcForm";
            this.Text = "Budget Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedItemDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IncomeProcessButton;
        private System.Windows.Forms.Button ProcessItemButton;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView SelectedItemDataGrid;
        private System.Windows.Forms.CheckedListBox ItemsBox;
        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.Label CurrentBalanceDataLabel;
        private System.Windows.Forms.Button EditItemsButton;
        private System.Windows.Forms.Label PercentIncomeLabel;
        private System.Windows.Forms.Label PercentIncomeDataLabel;
    }
}

