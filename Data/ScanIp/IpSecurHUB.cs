using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ScanIp
{
    public struct IpSecurHUB : IEquatable<IpSecurHUB>
    {
        public int ID { get; set; }

        public string HostName { get; set; }

        public string IPAddress { get; set; }
        public string MacAddress { get; set; }

        public string Note { get; set; }

        public bool Equals([AllowNull] IpSecurHUB other)
        {
            throw new NotImplementedException();
        }
    }
}

