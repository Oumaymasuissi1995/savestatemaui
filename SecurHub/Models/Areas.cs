using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurHub.Models
{
    public partial class Areas
    {
        public short Area_Id_Pk { get; set; }
        public short? Area_Status { get; set; }
        public string Area_Description { get; set; }
        public string Area_Partition_1 { get; set; }
        public string Area_Partition_2 { get; set; }
        public short? Area_Rearm_Option { get; set; }
        public short? Area_Rearm_Time { get; set; }
        public byte[] Area_Voice_Message { get; set; }
        public short? Area_Audio_Resource { get; set; }
        public short? Area_Voice_Msg_Selection { get; set; }
        public string Area_Text_To_Speech { get; set; }



        public Areas()
        {
        }

        // your method to pull data from database to datatable   

    }

}
