namespace Library_sysem_using_linked_lists
{
    partial class BookTypeSelectScreen
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
            this.FantasyBookButton = new System.Windows.Forms.Button();
            this.Classical = new System.Windows.Forms.Button();
            this.Horror = new System.Windows.Forms.Button();
            this.YoungAdult = new System.Windows.Forms.Button();
            this.ScienceFiction = new System.Windows.Forms.Button();
            this.Biographical = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FantasyBookButton
            // 
            this.FantasyBookButton.Location = new System.Drawing.Point(80, 78);
            this.FantasyBookButton.Name = "FantasyBookButton";
            this.FantasyBookButton.Size = new System.Drawing.Size(75, 23);
            this.FantasyBookButton.TabIndex = 0;
            this.FantasyBookButton.Text = "Fantasy";
            this.FantasyBookButton.UseVisualStyleBackColor = true;
            this.FantasyBookButton.Click += new System.EventHandler(this.FantasyBookButton_Click);
            // 
            // Classical
            // 
            this.Classical.Location = new System.Drawing.Point(80, 108);
            this.Classical.Name = "Classical";
            this.Classical.Size = new System.Drawing.Size(75, 23);
            this.Classical.TabIndex = 1;
            this.Classical.Text = "Classical";
            this.Classical.UseVisualStyleBackColor = true;
            // 
            // Horror
            // 
            this.Horror.Location = new System.Drawing.Point(80, 138);
            this.Horror.Name = "Horror";
            this.Horror.Size = new System.Drawing.Size(75, 23);
            this.Horror.TabIndex = 2;
            this.Horror.Text = "Horror";
            this.Horror.UseVisualStyleBackColor = true;
            // 
            // YoungAdult
            // 
            this.YoungAdult.Location = new System.Drawing.Point(80, 168);
            this.YoungAdult.Name = "YoungAdult";
            this.YoungAdult.Size = new System.Drawing.Size(75, 23);
            this.YoungAdult.TabIndex = 3;
            this.YoungAdult.Text = "Young Adult";
            this.YoungAdult.UseVisualStyleBackColor = true;
            // 
            // ScienceFiction
            // 
            this.ScienceFiction.Location = new System.Drawing.Point(80, 198);
            this.ScienceFiction.Name = "ScienceFiction";
            this.ScienceFiction.Size = new System.Drawing.Size(75, 23);
            this.ScienceFiction.TabIndex = 4;
            this.ScienceFiction.Text = "Sci Fi";
            this.ScienceFiction.UseVisualStyleBackColor = true;
            // 
            // Biographical
            // 
            this.Biographical.Location = new System.Drawing.Point(80, 228);
            this.Biographical.Name = "Biographical";
            this.Biographical.Size = new System.Drawing.Size(75, 23);
            this.Biographical.TabIndex = 5;
            this.Biographical.Text = "Biographical";
            this.Biographical.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(13, 291);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BookTypeSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 326);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.Biographical);
            this.Controls.Add(this.ScienceFiction);
            this.Controls.Add(this.YoungAdult);
            this.Controls.Add(this.Horror);
            this.Controls.Add(this.Classical);
            this.Controls.Add(this.FantasyBookButton);
            this.Name = "BookTypeSelectScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTypeSelectScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FantasyBookButton;
        private System.Windows.Forms.Button Classical;
        private System.Windows.Forms.Button Horror;
        private System.Windows.Forms.Button YoungAdult;
        private System.Windows.Forms.Button ScienceFiction;
        private System.Windows.Forms.Button Biographical;
        private System.Windows.Forms.Button HomeButton;
    }
}

