using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestBlog.Models.CoinMarketCap;

namespace TestBlog.Data
{ 
    public class CoinProcessor
    {
        public  async Task<IEnumerable< CryptoMarketResponse>> LoadCoins() 
        {
         
            string Url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false";
            ApiHelper helper = new ApiHelper();
            HttpResponseMessage Response = await helper.ApiClient.GetAsync(Url);
            
            if (Response.IsSuccessStatusCode)
            {
                var myresp = await Response.Content.ReadAsStringAsync();
                IEnumerable<CryptoMarketResponse> marketResponse = JsonConvert.DeserializeObject<IEnumerable<CryptoMarketResponse>>(myresp);
                return marketResponse;
            }
            else
            {
                throw new Exception(Response.ReasonPhrase);
            }
            
        }
    }
}
