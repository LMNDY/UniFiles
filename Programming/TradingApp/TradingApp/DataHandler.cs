using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingApp
{
    class DataHandler
    {
        public static void loadCSV(ref AVLTree<Country> Countries, String filePath)
        {
            string[][] countries = File.ReadAllLines(filePath).Select(i => i.Split(',')).ToArray();
            for (int i = 1; i < countries.Length; i++)
            {
                Countries.InsertItem(new Country(countries[i][0], float.Parse(countries[i][1]),
                    float.Parse(countries[i][2]), float.Parse(countries[i][3]), int.Parse(countries[i][4]),
                    countries[i][5].Split(';').Select(x => new Regex("([[]|[]])").Replace(x, "")).ToArray()));
            }
        }

        public static void loadList(ListBox lb, AVLTree<Country> Countries)
        {
            string[] SortedCountries = getCountries(Countries);
            Array.Sort(SortedCountries);
            lb.DataSource = SortedCountries;
        }

        public static string[] getCountries(AVLTree<Country> Countries)
        {
            return Countries.PostOrder().Split(',').Where(p => p != "").ToArray();
        }

        //------------------------------------
    }
}
