using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp
{
    class Country : IComparable
    {
        private string countryName;
        private float gpdGrowth;
        private float inflation;
        private float tradeBalance;
        private int hdiRanking;
        private string[] mainTradePartners;

        public Country(string cntName, float growth, float inflation, float trdBalance, int ranking, string[] partners)
        {
            this.countryName = cntName;
            this.gpdGrowth = growth;
            this.inflation = inflation;
            this.tradeBalance = trdBalance;
            this.hdiRanking = ranking;
            this.mainTradePartners = partners;
        }

        public String CountryName { get { return this.countryName; } set { this.countryName = value; } }
        public float GPDGrowth { get { return this.gpdGrowth; } set { this.gpdGrowth = value; } }
        public float Inflation { get { return this.inflation; } set { this.inflation = value; } }
        public float TradeBalance { get { return this.tradeBalance; } set { this.tradeBalance = value; } }
        public int HDIRanking { get { return this.hdiRanking; } set { this.hdiRanking = value; } }
        public string[] MainTradePartners { get { return this.mainTradePartners; } set { this.mainTradePartners = value; } }

        public override string ToString() {
            return this.countryName;
        }

        public int CompareTo(object obj) {
            return this.ToString().CompareTo(((Country)obj).ToString());
        }
    }
}
