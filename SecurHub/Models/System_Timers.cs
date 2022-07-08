using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurHub.Models
{
    public  class System_Timers
    {
    public int? TIMERS_ID_PK { get; set; }
     public int? TIMERS_ENTRYTIME_1 { get; set; }
     public int? TIMERS_ENTRYTIME_2 { get; set; }     
     public int? TIMERS_EXTRAENTRYTIME { get; set; }
     public int? TIMERS_EXITTIME_1 { get; set; }
     public int? TIMERS_EXITTIME_2 { get; set; }

     public int? TIMERS_INTERNALSIRENTIMER { get; set; }
     public int? TIMERS_EXTERNALSIRENTIMER { get; set; }
     public int? TIMERS_SIRENDELAY { get; set; }
     public int? TIMERS_DOUBLEZONEALARM { get; set; }

     public int? TIMERS_DOUBLEKNOCK { get; set; }


    }
}
