using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurHub
{
    internal class FormUpdate
    {
        class UpdateListRetry : EventArgs
        {
            public string UpdateList { get; set; }
            public UpdateListRetry(string s)
            {
                UpdateList = s;
            }
        }
    }
}
