using SecurHub;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Dependency(typeof(SQliteDroid))]
namespace SecurHub
{
    public class SQliteDroid : Isqlite
    {
       
        public SQLiteAsyncConnection Connection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            var path = Path.Combine(documentsPath, "AJAXs.db3");

            return new SQLiteAsyncConnection(path);
        }


    }
    
  


 
}
