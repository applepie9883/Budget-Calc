namespace Budget_Calc
{
    partial class EditItemsForm
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
            this.ItemsBox = new System.Windows.Forms.ListBox();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.NewItemButton = new System.Windows.Forms.Button();
            this.PercentIncomeBox = new System.Windows.Forms.NumericUpDown();
            this.PercentIncomeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PercentIncomeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsBox
            // 
            this.ItemsBox.FormattingEnabled = true;
            this.ItemsBox.Location = new System.Drawing.Point(12, 41);
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.Size = new System.Drawing.Size(120, 199);
            this.ItemsBox.TabIndex = 0;
            this.ItemsBox.SelectedValueChanged += new System.EventHandler(this.ItemsBox_SelectedValueChanged);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(138, 12);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteItemButton.TabIndex = 18;
            this.DeleteItemButton.Text = "Delete Item";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // NewItemButton
            // 
            this.NewItemButton.Location = new System.Drawing.Point(12, 12);
            this.NewItemButton.Name = "NewItemButton";
            this.NewItemButton.Size = new System.Drawing.Size(120, 23);
            this.NewItemButton.TabIndex = 19;
            this.NewItemButton.Text = "New Item";
            this.NewItemButton.UseVisualStyleBackColor = true;
            this.NewItemButton.Click += new System.EventHandler(this.NewItemButton_Click);
            // 
            // PercentIncomeBox
            // 
            this.PercentIncomeBox.Location = new System.Drawing.Point(138, 109);
            this.PercentIncomeBox.Name = "PercentIncomeBox";
            this.PercentIncomeBox.Size = new System.Drawing.Size(120, 20);
            this.PercentIncomeBox.TabIndex = 17;
            // 
            // PercentIncomeLabel
            // 
            this.PercentIncomeLabel.Location = new System.Drawing.Point(138, 93);
            this.PercentIncomeLabel.Name = "PercentIncomeLabel";
            this.PercentIncomeLabel.Size = new System.Drawing.Size(120, 13);
            this.PercentIncomeLabel.TabIndex = 16;
            this.PercentIncomeLabel.Text = "Percent of Income:";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(138, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(120, 13);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(138, 57);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NameTextBox.TabIndex = 20;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(12, 246);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(120, 23);
            this.DoneButton.TabIndex = 19;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(138, 246);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 23);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 647);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.NewItemButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PercentIncomeBox);
            this.Controls.Add(this.PercentIncomeLabel);
            this.Controls.Add(this.ItemsBox);
            this.Name = "EditItemsForm";
            this.Text = "EditItemsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PercentIncomeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsBox;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button NewItemButton;
        private System.Windows.Forms.NumericUpDown PercentIncomeBox;
        private System.Windows.Forms.Label PercentIncomeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CancelButton;
    }
}