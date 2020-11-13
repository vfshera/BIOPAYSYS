using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.HELPERS
{
    public static class PayrollAPI
    {

        public static HttpClient PayrollApiService { get; set; }

        public static void InitializeClient()
        {
            PayrollApiService = new HttpClient();
            PayrollApiService.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            PayrollApiService.DefaultRequestHeaders.Accept.Clear();
            PayrollApiService.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
