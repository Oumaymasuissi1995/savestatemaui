
using SecurHub.Data;


using System;
using System.Collections;
using System.Data;
using System.Threading;

using SQLite;
using SecurHub.Models;

namespace SecurHub.Services
{
     public  class AreaService 
    {
        private short maxAreaNumber =4 ; //areas
        private DataTable myDtAreas;

  

        public AreaService(DataTable dtAreas)
        {
            myDtAreas = dtAreas;
           
        }
       
        public Task<Areas[]> GetForecastAsync(DataTable dtAreas, List<Areas> arealist)
        {
            for (int i = 0; i < dtAreas.Rows.Count; i++)
            {
                Areas ar = new Areas();
                ar.Area_Id_Pk = short.Parse(dtAreas.Rows[i]["Area_Id_Pk"].ToString());
                ar.Area_Status = short.Parse(dtAreas.Rows[i]["Area_Status"].ToString());
                ar.Area_Description = dtAreas.Rows[i]["Area_Description"].ToString();
                ar.Area_Partition_1 = dtAreas.Rows[i]["Area_Partition_1"].ToString();
                ar.Area_Partition_2 = dtAreas.Rows[i]["Area_Partition_2"].ToString();
                arealist.Add(ar);
            }

            return Task.FromResult(arealist.ToArray());
        }
      

 
    }
}

