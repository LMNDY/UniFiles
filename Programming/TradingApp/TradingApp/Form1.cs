using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingApp
{
    public partial class Form1 : Form
    {
        AVLTree<Country> loadedTree = new AVLTree<Country>();
        public Form1()
        {
            InitializeComponent();
            this.Load += MainScreen_Load;
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            DataHandler.loadCSV(ref loadedTree, "countries.csv");
            DataHandler.loadList(cntBox, loadedTree);
            displayTreeDetails();
        }

        private void refresh()
        {
            cntBox.DataSource = null;
            DataHandler.loadList(cntBox, loadedTree);
            displayTreeDetails();
            SearchTextBox.Text = "";
        }

        private void displayTreeDetails()
        {
            DetailsDisplay.Text = "Number of countries: " + loadedTree.NodeCount()+"\nTree Height: " + loadedTree.TreeHeight();
        }

        private void cntBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Country country = loadedTree.GetData((String)cntBox.SelectedItem);

            textBName.Text = country.CountryName;
            textBGPDGrowth.Text = country.GPDGrowth.ToString();
            textBInflation.Text = country.Inflation.ToString();
            textBTradeBalance.Text = country.TradeBalance.ToString();
            textBHDIRanking.Text = country.HDIRanking.ToString();
            listBMainTradePartners.DataSource = country.MainTradePartners;
            Refresh();
        }

        private void SaveCountryButton_Click(object sender, EventArgs e)
        {
            Country country = loadedTree.GetData((string)cntBox.SelectedItem);
            country.CountryName = textBName.Text;
            country.GPDGrowth = float.Parse(textBGPDGrowth.Text);
            country.Inflation = float.Parse(textBInflation.Text);
            country.TradeBalance = float.Parse(textBTradeBalance.Text);
            country.HDIRanking = int.Parse(textBHDIRanking.Text);
            country.MainTradePartners = listBMainTradePartners.Items.OfType<string>().ToArray();
            Refresh();
        }

        private void DeleteCountryButton_Click(object sender, EventArgs e)
        {
            loadedTree.RemoveItem((String)cntBox.SelectedItem);
            DataHandler.loadList(cntBox, loadedTree);
        }

        private void AddNewCountryBtn_Click(object sender, EventArgs e)
        {
            Country country = new Country(
                textBName.Text,
                float.Parse(textBGPDGrowth.Text),
                float.Parse(textBInflation.Text),
                float.Parse(textBTradeBalance.Text),
                int.Parse(textBHDIRanking.Text),
                listBMainTradePartners.Items.OfType<string>().ToArray());

            loadedTree.InsertItem(country);
            Refresh();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPartnerBtn_Click(object sender, EventArgs e)
        {
            if (textBNewPartner != null) {
                string newpart = textBNewPartner.Text;
                Country country = loadedTree.GetData((String)cntBox.SelectedItem);
                Country countrypart = loadedTree.GetData(newpart);
                foreach (String st in country.MainTradePartners)
                {
                    if (st == newpart)
                    {
                        MessageBox.Show(@"Already trading");
                        return;
                    }
                }

                String[] temp = country.MainTradePartners;
                Array.Resize(ref temp, temp.Length + 1);
                temp[temp.Length - 1] = newpart;
                country.MainTradePartners = temp;

                String[] temp2 = countrypart.MainTradePartners;
                Array.Resize(ref temp2, temp2.Length + 1);
                temp2[temp2.Length - 1] = country.CountryName;
                countrypart.MainTradePartners = temp2;
                Refresh();
                listBMainTradePartners.DataSource = country.MainTradePartners;
            }
        }

        private void DeletePartnerBtn_Click(object sender, EventArgs e)
        {
            bool present = false;
            string part = textBNewPartner.Text;
            Country country = loadedTree.GetData((String)cntBox.SelectedItem);
            Country countrypart = loadedTree.GetData(part);

            foreach (String st in country.MainTradePartners)
            {
                if (st == part)
                {
                    present = true;
                }
            }
            if (present != true)
            {
                MessageBox.Show(@"Not Currently Trading");
                return;
            }
            if (present == true)
            {
                String[] temp = null;
                String[] temp2 = country.MainTradePartners;

                int i = 0;
                int j = 0;
                for (i = 0; i < temp2.Length; i++)
                {
                    if (temp2[i] != part)
                    {
                        temp[j] = temp2[i];
                        j++;
                    }
                }
                country.MainTradePartners = temp;

                temp = null;
                temp2 = countrypart.MainTradePartners;

                j = 0;
                for (i = 0; i < temp2.Length; i++)
                {
                    if (temp2[i] != country.CountryName)
                    {
                        temp[j] = temp2[i];
                        j++;
                    }
                }
                countrypart.MainTradePartners = temp;
            }
            Refresh();
            listBMainTradePartners.DataSource = country.MainTradePartners;
        }
    }
}
