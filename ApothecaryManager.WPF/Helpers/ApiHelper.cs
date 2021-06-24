using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Configuration;
using ApothecaryManager.WPF.Models;
using System.Net;
using System.Net.Security;

namespace ApothecaryManager.WPF.Helpers
{
    class ApiHelper
    {
        public HttpClient ApiClient { get; set; }

        public ApiHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            string api = "http://localhost:42937/api/";//Properties.Settings.Default.ApiAddress;

            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri(api);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) =>
            {
                // local dev, just approve all certs
                if (true) return true;
                return errors == SslPolicyErrors.None;
            };
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            using (HttpResponseMessage response = await ApiClient.GetAsync("now"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync();
                }
            }


            return null;
        }
    }
}
