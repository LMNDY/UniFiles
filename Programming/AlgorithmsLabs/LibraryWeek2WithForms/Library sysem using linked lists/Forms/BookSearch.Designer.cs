namespace Library_sysem_using_linked_lists.Forms
{
    partial class BookSearch
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleSearch = new System.Windows.Forms.Button();
            this.authorSearch = new System.Windows.Forms.Button();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLable = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(46, 50);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 0;
            // 
            // titleSearch
            // 
            this.titleSearch.Location = new System.Drawing.Point(46, 97);
            this.titleSearch.Name = "titleSearch";
            this.titleSearch.Size = new System.Drawing.Size(75, 23);
            this.titleSearch.TabIndex = 1;
            this.titleSearch.Text = "Search";
            this.titleSearch.UseVisualStyleBackColor = true;
            // 
            // authorSearch
            // 
            this.authorSearch.Location = new System.Drawing.Point(174, 97);
            this.authorSearch.Name = "authorSearch";
            this.authorSearch.Size = new System.Drawing.Size(75, 23);
            this.authorSearch.TabIndex = 2;
            this.authorSearch.Text = "Search";
            this.authorSearch.UseVisualStyleBackColor = true;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(174, 50);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(100, 20);
            this.authorBox.TabIndex = 3;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(46, 31);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title:";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorLable
            // 
            this.AuthorLable.AutoSize = true;
            this.AuthorLable.Location = new System.Drawing.Point(174, 31);
            this.AuthorLable.Name = "AuthorLable";
            this.AuthorLable.Size = new System.Drawing.Size(41, 13);
            this.AuthorLable.TabIndex = 5;
            this.AuthorLable.Text = "Author:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 291);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 326);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AuthorLable);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.authorSearch);
            this.Controls.Add(this.titleSearch);
            this.Controls.Add(this.titleBox);
            this.Name = "BookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button titleSearch;
        private System.Windows.Forms.Button authorSearch;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLable;
        private System.Windows.Forms.Button BackButton;
    }
}