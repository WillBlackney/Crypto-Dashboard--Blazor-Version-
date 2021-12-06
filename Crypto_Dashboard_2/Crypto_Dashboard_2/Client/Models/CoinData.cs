using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_Dashboard_2.Client.Models
{
    public class CoinData
    {
        public string name { get; set; }
        public string image { get; set; }
        public string symbol { get; set; }
        public double current_price { get; set; }
        public double total_volume { get; set; }
        public double price_change_percentage_24h { get; set; }
        public double market_cap { get; set; }

        public CoinData() { }
        public CoinData(string name, string image, string symbol, double price, double volume, double priceChange, double marketcap)
        {
            this.name = name;
            this.image = image;
            this.symbol = symbol;
            this.current_price = price;
            this.total_volume = volume;
            this.price_change_percentage_24h = priceChange;
            this.market_cap = marketcap;
        }
    }
}
