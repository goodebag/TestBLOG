using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;
using TestBlog.Models.CoinMarketCap;

namespace TestBlog.ViewModels
{
    public class postDishOut
    {
        public IEnumerable<RePost> Allpost { get; set; }
        public IEnumerable<RePost> Manypost { get; set; }
        public RePost post { get; set; }
        public AdminViewModel AdminViewModel { get; set; }
        public LogInViewModel LogInViewModel { get; set; }
        public postViewModel postViewModel  { get; set; }
        public PostTypeCount CatigoryTypeCount { get; set; }
        public IEnumerable<CryptoMarketResponse> Cryptos { get; set; }
    }
}
