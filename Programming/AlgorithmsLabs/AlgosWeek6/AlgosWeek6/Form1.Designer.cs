namespace AlgosWeek6
{
    partial class Form1
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
            this.AddHeaderLabel = new System.Windows.Forms.Label();
            this.AddIsbnTextBox = new System.Windows.Forms.TextBox();
            this.AddTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddIsbnLabel = new System.Windows.Forms.Label();
            this.AddTitleLabel = new System.Windows.Forms.Label();
            this.AddSubmitButton = new System.Windows.Forms.Button();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchIsbnTextBox = new System.Windows.Forms.TextBox();
            this.SearchTitleTextBox = new System.Windows.Forms.TextBox();
            this.SearchIsbnLabel = new System.Windows.Forms.Label();
            this.SearchTitleLabel = new System.Windows.Forms.Label();
            this.SearchIsbnButton = new System.Windows.Forms.Button();
            this.SearchTitleButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveText = new System.Windows.Forms.TextBox();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LoanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddHeaderLabel
            // 
            this.AddHeaderLabel.AutoSize = true;
            this.AddHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.AddHeaderLabel.Location = new System.Drawing.Point(628, 13);
            this.AddHeaderLabel.Name = "AddHeaderLabel";
            this.AddHeaderLabel.Size = new System.Drawing.Size(123, 29);
            this.AddHeaderLabel.TabIndex = 1;
            this.AddHeaderLabel.Text = "Add Book";
            // 
            // AddIsbnTextBox
            // 
            this.AddIsbnTextBox.Location = new System.Drawing.Point(633, 60);
            this.AddIsbnTextBox.Name = "AddIsbnTextBox";
            this.AddIsbnTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddIsbnTextBox.TabIndex = 2;
            // 
            // AddTitleTextBox
            // 
            this.AddTitleTextBox.Location = new System.Drawing.Point(756, 60);
            this.AddTitleTextBox.Name = "AddTitleTextBox";
            this.AddTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddTitleTextBox.TabIndex = 3;
            // 
            // AddIsbnLabel
            // 
            this.AddIsbnLabel.AutoSize = true;
            this.AddIsbnLabel.Location = new System.Drawing.Point(633, 87);
            this.AddIsbnLabel.Name = "AddIsbnLabel";
            this.AddIsbnLabel.Size = new System.Drawing.Size(32, 13);
            this.AddIsbnLabel.TabIndex = 4;
            this.AddIsbnLabel.Text = "ISBN";
            // 
            // AddTitleLabel
            // 
            this.AddTitleLabel.AutoSize = true;
            this.AddTitleLabel.Location = new System.Drawing.Point(756, 87);
            this.AddTitleLabel.Name = "AddTitleLabel";
            this.AddTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.AddTitleLabel.TabIndex = 5;
            this.AddTitleLabel.Text = "Title";
            // 
            // AddSubmitButton
            // 
            this.AddSubmitButton.Location = new System.Drawing.Point(636, 112);
            this.AddSubmitButton.Name = "AddSubmitButton";
            this.AddSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.AddSubmitButton.TabIndex = 6;
            this.AddSubmitButton.Text = "Submit";
            this.AddSubmitButton.UseVisualStyleBackColor = true;
            this.AddSubmitButton.Click += new System.EventHandler(this.AddSubmitButton_Click);
            // 
            // ConfirmationLabel
            // 
            this.ConfirmationLabel.AutoSize = true;
            this.ConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ConfirmationLabel.Location = new System.Drawing.Point(12, 13);
            this.ConfirmationLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ConfirmationLabel.Name = "ConfirmationLabel";
            this.ConfirmationLabel.Size = new System.Drawing.Size(0, 20);
            this.ConfirmationLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(633, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Books";
            // 
            // SearchIsbnTextBox
            // 
            this.SearchIsbnTextBox.Location = new System.Drawing.Point(633, 202);
            this.SearchIsbnTextBox.Name = "SearchIsbnTextBox";
            this.SearchIsbnTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchIsbnTextBox.TabIndex = 9;
            // 
            // SearchTitleTextBox
            // 
            this.SearchTitleTextBox.Location = new System.Drawing.Point(756, 201);
            this.SearchTitleTextBox.Name = "SearchTitleTextBox";
            this.SearchTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTitleTextBox.TabIndex = 10;
            // 
            // SearchIsbnLabel
            // 
            this.SearchIsbnLabel.AutoSize = true;
            this.SearchIsbnLabel.Location = new System.Drawing.Point(633, 229);
            this.SearchIsbnLabel.Name = "SearchIsbnLabel";
            this.SearchIsbnLabel.Size = new System.Drawing.Size(32, 13);
            this.SearchIsbnLabel.TabIndex = 11;
            this.SearchIsbnLabel.Text = "ISBN";
            // 
            // SearchTitleLabel
            // 
            this.SearchTitleLabel.AutoSize = true;
            this.SearchTitleLabel.Location = new System.Drawing.Point(756, 229);
            this.SearchTitleLabel.Name = "SearchTitleLabel";
            this.SearchTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.SearchTitleLabel.TabIndex = 12;
            this.SearchTitleLabel.Text = "Title";
            // 
            // SearchIsbnButton
            // 
            this.SearchIsbnButton.Location = new System.Drawing.Point(633, 246);
            this.SearchIsbnButton.Name = "SearchIsbnButton";
            this.SearchIsbnButton.Size = new System.Drawing.Size(75, 23);
            this.SearchIsbnButton.TabIndex = 13;
            this.SearchIsbnButton.Text = "Submit";
            this.SearchIsbnButton.UseVisualStyleBackColor = true;
            this.SearchIsbnButton.Click += new System.EventHandler(this.SearchIsbnButton_Click);
            // 
            // SearchTitleButton
            // 
            this.SearchTitleButton.Location = new System.Drawing.Point(756, 245);
            this.SearchTitleButton.Name = "SearchTitleButton";
            this.SearchTitleButton.Size = new System.Drawing.Size(75, 23);
            this.SearchTitleButton.TabIndex = 14;
            this.SearchTitleButton.Text = "Submit";
            this.SearchTitleButton.UseVisualStyleBackColor = true;
            this.SearchTitleButton.Click += new System.EventHandler(this.SearchTitleButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(578, 251);
            this.listBox1.TabIndex = 15;
            // 
            // RemoveText
            // 
            this.RemoveText.Location = new System.Drawing.Point(633, 313);
            this.RemoveText.Name = "RemoveText";
            this.RemoveText.Size = new System.Drawing.Size(100, 20);
            this.RemoveText.TabIndex = 16;
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Location = new System.Drawing.Point(633, 340);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(32, 13);
            this.RemoveLabel.TabIndex = 17;
            this.RemoveLabel.Text = "ISBN";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(633, 357);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(756, 312);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(100, 20);
            this.StatusText.TabIndex = 19;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(756, 339);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(32, 13);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "ISBN";
            // 
            // LoanButton
            // 
            this.LoanButton.Location = new System.Drawing.Point(756, 356);
            this.LoanButton.Name = "LoanButton";
            this.LoanButton.Size = new System.Drawing.Size(100, 23);
            this.LoanButton.TabIndex = 21;
            this.LoanButton.Text = "Change Status";
            this.LoanButton.UseVisualStyleBackColor = true;
            this.LoanButton.Click += new System.EventHandler(this.LoanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 459);
            this.Controls.Add(this.LoanButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RemoveLabel);
            this.Controls.Add(this.RemoveText);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchTitleButton);
            this.Controls.Add(this.SearchIsbnButton);
            this.Controls.Add(this.SearchTitleLabel);
            this.Controls.Add(this.SearchIsbnLabel);
            this.Controls.Add(this.SearchTitleTextBox);
            this.Controls.Add(this.SearchIsbnTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmationLabel);
            this.Controls.Add(this.AddSubmitButton);
            this.Controls.Add(this.AddTitleLabel);
            this.Controls.Add(this.AddIsbnLabel);
            this.Controls.Add(this.AddTitleTextBox);
            this.Controls.Add(this.AddIsbnTextBox);
            this.Controls.Add(this.AddHeaderLabel);
            this.Name = "Form1";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddHeaderLabel;
        private System.Windows.Forms.TextBox AddIsbnTextBox;
        private System.Windows.Forms.TextBox AddTitleTextBox;
        private System.Windows.Forms.Label AddIsbnLabel;
        private System.Windows.Forms.Label AddTitleLabel;
        private System.Windows.Forms.Button AddSubmitButton;
        private System.Windows.Forms.Label ConfirmationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchIsbnTextBox;
        private System.Windows.Forms.TextBox SearchTitleTextBox;
        private System.Windows.Forms.Label SearchIsbnLabel;
        private System.Windows.Forms.Label SearchTitleLabel;
        private System.Windows.Forms.Button SearchIsbnButton;
        private System.Windows.Forms.Button SearchTitleButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox RemoveText;
        private System.Windows.Forms.Label RemoveLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button LoanButton;
    }
}

