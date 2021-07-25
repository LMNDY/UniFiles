namespace TradingApp
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
            this.cntBox = new System.Windows.Forms.ListBox();
            this.textBNewPartner = new System.Windows.Forms.TextBox();
            this.DetailsDisplay = new System.Windows.Forms.Label();
            this.AddNewCountryBtn = new System.Windows.Forms.Button();
            this.SaveCountryButton = new System.Windows.Forms.Button();
            this.DeleteCountryButton = new System.Windows.Forms.Button();
            this.AddPartnerBtn = new System.Windows.Forms.Button();
            this.DeletePartnerBtn = new System.Windows.Forms.Button();
            this.listBMainTradePartners = new System.Windows.Forms.ListBox();
            this.lblPartners = new System.Windows.Forms.Label();
            this.textBHDIRanking = new System.Windows.Forms.TextBox();
            this.lblHDI = new System.Windows.Forms.Label();
            this.textBTradeBalance = new System.Windows.Forms.TextBox();
            this.lblTradeBalance = new System.Windows.Forms.Label();
            this.textBInflation = new System.Windows.Forms.TextBox();
            this.lblInflation = new System.Windows.Forms.Label();
            this.textBGPDGrowth = new System.Windows.Forms.TextBox();
            this.lblGPD = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBName = new System.Windows.Forms.TextBox();
            this.MainTpSearchTxt = new System.Windows.Forms.TextBox();
            this.TPSearchLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntBox
            // 
            this.cntBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntBox.FormattingEnabled = true;
            this.cntBox.Location = new System.Drawing.Point(7, 47);
            this.cntBox.Name = "cntBox";
            this.cntBox.Size = new System.Drawing.Size(184, 303);
            this.cntBox.TabIndex = 0;
            this.cntBox.SelectedIndexChanged += new System.EventHandler(this.cntBox_SelectedIndexChanged_1);
            // 
            // textBNewPartner
            // 
            this.textBNewPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBNewPartner.Location = new System.Drawing.Point(10, 112);
            this.textBNewPartner.Margin = new System.Windows.Forms.Padding(2);
            this.textBNewPartner.Name = "textBNewPartner";
            this.textBNewPartner.Size = new System.Drawing.Size(191, 20);
            this.textBNewPartner.TabIndex = 48;
            // 
            // DetailsDisplay
            // 
            this.DetailsDisplay.AutoSize = true;
            this.DetailsDisplay.Location = new System.Drawing.Point(448, 37);
            this.DetailsDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DetailsDisplay.Name = "DetailsDisplay";
            this.DetailsDisplay.Size = new System.Drawing.Size(35, 13);
            this.DetailsDisplay.TabIndex = 47;
            this.DetailsDisplay.Text = "label1";
            // 
            // AddNewCountryBtn
            // 
            this.AddNewCountryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCountryBtn.Location = new System.Drawing.Point(20, 435);
            this.AddNewCountryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewCountryBtn.Name = "AddNewCountryBtn";
            this.AddNewCountryBtn.Size = new System.Drawing.Size(188, 29);
            this.AddNewCountryBtn.TabIndex = 46;
            this.AddNewCountryBtn.Text = "Add As New Country";
            this.AddNewCountryBtn.UseVisualStyleBackColor = true;
            this.AddNewCountryBtn.Click += new System.EventHandler(this.AddNewCountryBtn_Click);
            // 
            // SaveCountryButton
            // 
            this.SaveCountryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCountryButton.Location = new System.Drawing.Point(20, 400);
            this.SaveCountryButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCountryButton.Name = "SaveCountryButton";
            this.SaveCountryButton.Size = new System.Drawing.Size(94, 29);
            this.SaveCountryButton.TabIndex = 45;
            this.SaveCountryButton.Text = "Save Country";
            this.SaveCountryButton.UseVisualStyleBackColor = true;
            this.SaveCountryButton.Click += new System.EventHandler(this.SaveCountryButton_Click);
            // 
            // DeleteCountryButton
            // 
            this.DeleteCountryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCountryButton.Location = new System.Drawing.Point(118, 400);
            this.DeleteCountryButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCountryButton.Name = "DeleteCountryButton";
            this.DeleteCountryButton.Size = new System.Drawing.Size(90, 28);
            this.DeleteCountryButton.TabIndex = 44;
            this.DeleteCountryButton.Text = "Delete Country";
            this.DeleteCountryButton.UseVisualStyleBackColor = true;
            this.DeleteCountryButton.Click += new System.EventHandler(this.DeleteCountryButton_Click);
            // 
            // AddPartnerBtn
            // 
            this.AddPartnerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartnerBtn.Location = new System.Drawing.Point(110, 137);
            this.AddPartnerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddPartnerBtn.Name = "AddPartnerBtn";
            this.AddPartnerBtn.Size = new System.Drawing.Size(93, 27);
            this.AddPartnerBtn.TabIndex = 43;
            this.AddPartnerBtn.Text = "Add Partner";
            this.AddPartnerBtn.UseVisualStyleBackColor = true;
            this.AddPartnerBtn.Click += new System.EventHandler(this.AddPartnerBtn_Click);
            // 
            // DeletePartnerBtn
            // 
            this.DeletePartnerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartnerBtn.Location = new System.Drawing.Point(10, 136);
            this.DeletePartnerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePartnerBtn.Name = "DeletePartnerBtn";
            this.DeletePartnerBtn.Size = new System.Drawing.Size(94, 28);
            this.DeletePartnerBtn.TabIndex = 41;
            this.DeletePartnerBtn.Text = "Delete Partner";
            this.DeletePartnerBtn.UseVisualStyleBackColor = true;
            this.DeletePartnerBtn.Click += new System.EventHandler(this.DeletePartnerBtn_Click);
            // 
            // listBMainTradePartners
            // 
            this.listBMainTradePartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.listBMainTradePartners.FormattingEnabled = true;
            this.listBMainTradePartners.Location = new System.Drawing.Point(10, 24);
            this.listBMainTradePartners.Margin = new System.Windows.Forms.Padding(2);
            this.listBMainTradePartners.Name = "listBMainTradePartners";
            this.listBMainTradePartners.Size = new System.Drawing.Size(191, 82);
            this.listBMainTradePartners.TabIndex = 40;
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblPartners.Location = new System.Drawing.Point(17, 213);
            this.lblPartners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(103, 13);
            this.lblPartners.TabIndex = 39;
            this.lblPartners.Text = "Main Trade Partners";
            // 
            // textBHDIRanking
            // 
            this.textBHDIRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBHDIRanking.Location = new System.Drawing.Point(20, 193);
            this.textBHDIRanking.Margin = new System.Windows.Forms.Padding(2);
            this.textBHDIRanking.Name = "textBHDIRanking";
            this.textBHDIRanking.Size = new System.Drawing.Size(191, 19);
            this.textBHDIRanking.TabIndex = 38;
            // 
            // lblHDI
            // 
            this.lblHDI.AutoSize = true;
            this.lblHDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblHDI.Location = new System.Drawing.Point(17, 177);
            this.lblHDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHDI.Name = "lblHDI";
            this.lblHDI.Size = new System.Drawing.Size(69, 13);
            this.lblHDI.TabIndex = 37;
            this.lblHDI.Text = "HDI Ranking";
            // 
            // textBTradeBalance
            // 
            this.textBTradeBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBTradeBalance.Location = new System.Drawing.Point(20, 156);
            this.textBTradeBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBTradeBalance.Name = "textBTradeBalance";
            this.textBTradeBalance.Size = new System.Drawing.Size(191, 19);
            this.textBTradeBalance.TabIndex = 36;
            // 
            // lblTradeBalance
            // 
            this.lblTradeBalance.AutoSize = true;
            this.lblTradeBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblTradeBalance.Location = new System.Drawing.Point(17, 140);
            this.lblTradeBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTradeBalance.Name = "lblTradeBalance";
            this.lblTradeBalance.Size = new System.Drawing.Size(77, 13);
            this.lblTradeBalance.TabIndex = 35;
            this.lblTradeBalance.Text = "Trade Balance";
            // 
            // textBInflation
            // 
            this.textBInflation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBInflation.Location = new System.Drawing.Point(20, 120);
            this.textBInflation.Margin = new System.Windows.Forms.Padding(2);
            this.textBInflation.Name = "textBInflation";
            this.textBInflation.Size = new System.Drawing.Size(191, 19);
            this.textBInflation.TabIndex = 34;
            // 
            // lblInflation
            // 
            this.lblInflation.AutoSize = true;
            this.lblInflation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblInflation.Location = new System.Drawing.Point(18, 104);
            this.lblInflation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInflation.Name = "lblInflation";
            this.lblInflation.Size = new System.Drawing.Size(44, 13);
            this.lblInflation.TabIndex = 33;
            this.lblInflation.Text = "Inflation";
            // 
            // textBGPDGrowth
            // 
            this.textBGPDGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBGPDGrowth.Location = new System.Drawing.Point(20, 83);
            this.textBGPDGrowth.Margin = new System.Windows.Forms.Padding(2);
            this.textBGPDGrowth.Name = "textBGPDGrowth";
            this.textBGPDGrowth.Size = new System.Drawing.Size(191, 19);
            this.textBGPDGrowth.TabIndex = 32;
            // 
            // lblGPD
            // 
            this.lblGPD.AutoSize = true;
            this.lblGPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblGPD.Location = new System.Drawing.Point(18, 67);
            this.lblGPD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPD.Name = "lblGPD";
            this.lblGPD.Size = new System.Drawing.Size(67, 13);
            this.lblGPD.TabIndex = 31;
            this.lblGPD.Text = "GPD Growth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblName.Location = new System.Drawing.Point(18, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // textBName
            // 
            this.textBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBName.Location = new System.Drawing.Point(21, 47);
            this.textBName.Margin = new System.Windows.Forms.Padding(2);
            this.textBName.Name = "textBName";
            this.textBName.Size = new System.Drawing.Size(191, 19);
            this.textBName.TabIndex = 29;
            // 
            // MainTpSearchTxt
            // 
            this.MainTpSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTpSearchTxt.Location = new System.Drawing.Point(8, 79);
            this.MainTpSearchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MainTpSearchTxt.Name = "MainTpSearchTxt";
            this.MainTpSearchTxt.Size = new System.Drawing.Size(171, 20);
            this.MainTpSearchTxt.TabIndex = 52;
            // 
            // TPSearchLabel
            // 
            this.TPSearchLabel.AutoSize = true;
            this.TPSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPSearchLabel.Location = new System.Drawing.Point(8, 62);
            this.TPSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TPSearchLabel.Name = "TPSearchLabel";
            this.TPSearchLabel.Size = new System.Drawing.Size(158, 13);
            this.TPSearchLabel.TabIndex = 51;
            this.TPSearchLabel.Text = "Search By Main Trading Partner";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SearchLabel.Location = new System.Drawing.Point(4, 24);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(122, 13);
            this.SearchLabel.TabIndex = 50;
            this.SearchLabel.Text = "Search by country name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SearchTextBox.Location = new System.Drawing.Point(8, 43);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(170, 19);
            this.SearchTextBox.TabIndex = 49;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBNewPartner);
            this.groupBox1.Controls.Add(this.AddPartnerBtn);
            this.groupBox1.Controls.Add(this.DeletePartnerBtn);
            this.groupBox1.Controls.Add(this.listBMainTradePartners);
            this.groupBox1.Location = new System.Drawing.Point(7, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 181);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trade Partners";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.AddNewCountryBtn);
            this.groupBox2.Controls.Add(this.SaveCountryButton);
            this.groupBox2.Controls.Add(this.DeleteCountryButton);
            this.groupBox2.Controls.Add(this.lblPartners);
            this.groupBox2.Controls.Add(this.textBHDIRanking);
            this.groupBox2.Controls.Add(this.lblHDI);
            this.groupBox2.Controls.Add(this.textBTradeBalance);
            this.groupBox2.Controls.Add(this.lblTradeBalance);
            this.groupBox2.Controls.Add(this.textBInflation);
            this.groupBox2.Controls.Add(this.lblInflation);
            this.groupBox2.Controls.Add(this.textBGPDGrowth);
            this.groupBox2.Controls.Add(this.lblGPD);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.textBName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(212, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 499);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MainTpSearchTxt);
            this.groupBox3.Controls.Add(this.TPSearchLabel);
            this.groupBox3.Controls.Add(this.SearchLabel);
            this.groupBox3.Controls.Add(this.SearchTextBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 129);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Countries";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cntBox);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 499);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Country List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DetailsDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cntBox;
        private System.Windows.Forms.TextBox textBNewPartner;
        private System.Windows.Forms.Label DetailsDisplay;
        private System.Windows.Forms.Button AddNewCountryBtn;
        private System.Windows.Forms.Button SaveCountryButton;
        private System.Windows.Forms.Button DeleteCountryButton;
        private System.Windows.Forms.Button AddPartnerBtn;
        private System.Windows.Forms.Button DeletePartnerBtn;
        private System.Windows.Forms.ListBox listBMainTradePartners;
        private System.Windows.Forms.Label lblPartners;
        private System.Windows.Forms.TextBox textBHDIRanking;
        private System.Windows.Forms.Label lblHDI;
        private System.Windows.Forms.TextBox textBTradeBalance;
        private System.Windows.Forms.Label lblTradeBalance;
        private System.Windows.Forms.TextBox textBInflation;
        private System.Windows.Forms.Label lblInflation;
        private System.Windows.Forms.TextBox textBGPDGrowth;
        private System.Windows.Forms.Label lblGPD;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBName;
        private System.Windows.Forms.TextBox MainTpSearchTxt;
        private System.Windows.Forms.Label TPSearchLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

