using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace WSCApp
{
    class Program
    {

        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            
            var sitecount = int.Parse(ConfigurationManager.AppSettings["NoOfSites"]);
            var waitTime = int.Parse(ConfigurationManager.AppSettings["WaitTime"]);

            var sitename = "Site";
            var siteurl = "";
            for(int i=0; i< sitecount; i++ )
            {
                sitename = sitename+i.ToString();
                siteurl = ConfigurationManager.AppSettings[sitename];

                var request = client.GetAsync(new Uri(siteurl));
                Trace.TraceInformation("{0}: {1}", DateTime.Now, request.Result.StatusCode);
                sitename = "Site";
            }


        }

      
    }
}
