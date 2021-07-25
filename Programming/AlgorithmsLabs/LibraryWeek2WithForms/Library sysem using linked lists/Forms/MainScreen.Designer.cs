namespace Library_sysem_using_linked_lists.Forms
{
    partial class MainScreen
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
            this.AddBooksButton = new System.Windows.Forms.Button();
            this.CheckBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBooksButton
            // 
            this.AddBooksButton.Location = new System.Drawing.Point(13, 13);
            this.AddBooksButton.Name = "AddBooksButton";
            this.AddBooksButton.Size = new System.Drawing.Size(75, 23);
            this.AddBooksButton.TabIndex = 0;
            this.AddBooksButton.Text = "AddBooks";
            this.AddBooksButton.UseVisualStyleBackColor = true;
            this.AddBooksButton.Click += new System.EventHandler(this.AddBooksButton_Click);
            // 
            // CheckBooks
            // 
            this.CheckBooks.Location = new System.Drawing.Point(13, 52);
            this.CheckBooks.Name = "CheckBooks";
            this.CheckBooks.Size = new System.Drawing.Size(75, 23);
            this.CheckBooks.TabIndex = 1;
            this.CheckBooks.Text = "Search";
            this.CheckBooks.UseVisualStyleBackColor = true;
            this.CheckBooks.Click += new System.EventHandler(this.CheckBooks_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 326);
            this.Controls.Add(this.CheckBooks);
            this.Controls.Add(this.AddBooksButton);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBooksButton;
        private System.Windows.Forms.Button CheckBooks;
    }
}