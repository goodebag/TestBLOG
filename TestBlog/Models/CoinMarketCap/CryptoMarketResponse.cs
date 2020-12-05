using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Models.CoinMarketCap
{  
    public class CryptoMarketResponse
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public float current_price { get; set; }
        public long market_cap { get; set; }
        public int market_cap_rank { get; set; }
        public long total_volume { get; set; }
      
    }

}
