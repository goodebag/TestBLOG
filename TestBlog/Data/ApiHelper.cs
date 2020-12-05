using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TestBlog.Data
{
    public  class ApiHelper
    {
        public ApiHelper()
        {
            InitailizeClient();
        }
        public HttpClient ApiClient { get; set; }
        public  void InitailizeClient()
        {
         
                ApiClient = new HttpClient();
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         
            
        }
    }
}
