using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace CrudMvc
{
    public static class ProductWebClient
    {

        public static HttpClient WebApiClient = new HttpClient();

        static ProductWebClient()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:56108/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}