using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PING.Interfaces
{
    interface ICheckAccess
    {
        string PingUrl(string url);
    }
}
