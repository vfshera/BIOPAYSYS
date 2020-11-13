using BiometricPayroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.HELPERS
{
    public static class Requests
    {
        public static async Task<JPlaceHolder> getPost()
        {
            string url = "/posts/1";


            using(HttpResponseMessage res = await PayrollAPI.PayrollApiService.GetAsync(url))
            {
               
                if (res.IsSuccessStatusCode)
                {
                    JPlaceHolder post = await res.Content.ReadAsAsync<JPlaceHolder>();

                    return post;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }
        }

        public static async Task<Salary> processPay()
        {
            string url = "/process-payroll";

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            
            using (HttpResponseMessage res = await PayrollAPI.PayrollApiService.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {
                    Salary payslip = await res.Content.ReadAsAsync<Salary>();

                    return payslip;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }
        }
    }
}
