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
