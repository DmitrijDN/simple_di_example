using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PING.Interfaces;

namespace PING
{
    class CheckAccess: ICheckAccess
    {
        public string PingUrl(string url)
        {
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(url);
            httpReq.AllowAutoRedirect = false;
            HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();
            if (httpRes.StatusCode == HttpStatusCode.NotFound)
            {
                return "Not";
            }
            else
            {
                return "Ok";
            }
            httpRes.Close();
        }
    }
}
