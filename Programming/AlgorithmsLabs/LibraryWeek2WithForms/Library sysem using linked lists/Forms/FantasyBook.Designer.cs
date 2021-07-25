namespace Library_sysem_using_linked_lists
{
    partial class FantasyBook
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
            this.BackButton = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConfLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 226);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(13, 39);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 1;
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(120, 38);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(100, 20);
            this.TitleInput.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(144, 172);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(10, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(120, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // ConfLabel
            // 
            this.ConfLabel.AutoSize = true;
            this.ConfLabel.Location = new System.Drawing.Point(144, 202);
            this.ConfLabel.Name = "ConfLabel";
            this.ConfLabel.Size = new System.Drawing.Size(0, 13);
            this.ConfLabel.TabIndex = 6;
            // 
            // FantasyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 326);
            this.Controls.Add(this.ConfLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.BackButton);
            this.Name = "FantasyBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FantasyBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ConfLabel;
    }
}