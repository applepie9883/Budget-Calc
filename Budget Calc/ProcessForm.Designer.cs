namespace Budget_Calc
{
    partial class ProcessForm
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
            this.InputAmountBox = new System.Windows.Forms.NumericUpDown();
            this.InputAmountLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputAmountBox
            // 
            this.InputAmountBox.DecimalPlaces = 2;
            this.InputAmountBox.Location = new System.Drawing.Point(15, 25);
            this.InputAmountBox.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.InputAmountBox.Minimum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            -2147483648});
            this.InputAmountBox.Name = "InputAmountBox";
            this.InputAmountBox.Size = new System.Drawing.Size(120, 20);
            this.InputAmountBox.TabIndex = 0;
            // 
            // InputAmountLabel
            // 
            this.InputAmountLabel.Location = new System.Drawing.Point(12, 9);
            this.InputAmountLabel.Name = "InputAmountLabel";
            this.InputAmountLabel.Size = new System.Drawing.Size(123, 13);
            this.InputAmountLabel.TabIndex = 4;
            this.InputAmountLabel.Text = "Input Amount";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(138, 9);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(123, 13);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(141, 25);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(120, 20);
            this.DescriptionBox.TabIndex = 1;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(15, 52);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(120, 23);
            this.ProcessButton.TabIndex = 2;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(141, 52);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 93);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.InputAmountBox);
            this.Controls.Add(this.InputAmountLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            ((System.ComponentModel.ISupportInitialize)(this.InputAmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InputAmountBox;
        private System.Windows.Forms.Label InputAmountLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button CancelButton;
    }
}