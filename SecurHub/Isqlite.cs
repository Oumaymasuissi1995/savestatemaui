using SecurHub.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurHub
{
    public class Isqlite
    {
        private readonly SQLiteConnection db;
        // SQLiteAsyncConnection Connection();
        IEnumerable<Areas> dtAreas;
        IEnumerable<BASKET_ADRS_CAMPI> dtFields;
        IEnumerable<System_Timers> dtTimers;
        public Isqlite()
        {

            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                 "AJAXs.db3");

            var db = new SQLiteConnection(dbPath);
         
            db.CreateTable<Areas>();
            db.CreateTable<BASKET_ADRS_CAMPI>();
            db.CreateTable<Communication_Options>();
            db.CreateTable<System_Timers>();
            dtAreas = (from i in db.Table<Areas>() select i);
            dtFields = (from i in db.Table<BASKET_ADRS_CAMPI>() select i);
            dtTimers = (from i in db.Table<System_Timers>() select i);
            int count = db.Table<Areas>().Count();
            if (count == 0)
            { FillAreas(dbPath); }
            int counte = db.Table<BASKET_ADRS_CAMPI>().Count();
            if (counte == 0)
            { FillPanelFields(dbPath); }
            int counter = db.Table<System_Timers>().Count();
            if (counter == 0)
            { FillTimers(dbPath); }




        }

        public static void FillTimers(string dbPath)
        {
            var db = new SQLiteConnection(dbPath);
            var queries = new List<string>()
        {

          "INSERT INTO System_Timers VALUES( 1,30, 30, 0, 30, 30, 3, 3, 0, 3,  20 )"

        };

            db.BeginTransaction();
            queries.ForEach(query => db.Execute(query));
            db.Commit();

        }
      
        public static void FillAreas(string dbPath)
        {
            var db = new SQLiteConnection(dbPath);
            var queries = new List<string>()
        {

        "INSERT into Areas  VALUES(1, 1, \"Area 1\", \"Area 1 partition 1\", \"Area 1 partition 2\", 4, 1, NULL, 0, 0, \"''\")",
        "INSERT into Areas  VALUES(2, 0, \"Area 2\", \"Area 2 partition 1\", \"Area 2 partition 2\", 4, 1, NULL, 0, 0, \"''\")",
        "INSERT into Areas  VALUES(3, 0, \"Area 3\", \"Area 3 partition 1\", \"Area 3 partition 2\", 4, 1, NULL, 0, 0, \"''\")",
        "INSERT into Areas  VALUES(4, 0, \"Area 4\", \"Area 4 partition 1\", \"Area 4 partition 2\", 4, 1, NULL, 0, 0, \"''\")"

        };

            db.BeginTransaction();
            queries.ForEach(query => db.Execute(query)); 
            db.Commit();

        }
        public static void FillPanelFields(string dbPath)
        {
            var db = new SQLiteConnection(dbPath);
            var queries = new List<string>()
        {
  
        "INSERT into BASKET_ADRS_CAMPI  VALUES (0,0, 1, 16,  \"AREA_MAX_NUMBER\", 1, 1, 1, 0, 0, 0)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (1,1, 1, 16,  \"AREA_DESCRIPTION\", 2, 33, 1, 0, 0, 0)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (2,2, 1, 16,  \"AREA_PARTITION_1\", 2, 33, 1, 0, 0, 1)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (3,3, 1, 16,  \"AREA_PARTITION_2\", 2, 33, 1, 0, 0, 1)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (7,7, 1, 16,  \"AREA_REARM_TIME\", 1, 1, 1, 1, 0, 1)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (8,8, 1, 16,  \"AREA_REARM_OPTION\", 1, 1, 1, 1, 0, 1)",
//for send areas 
        "INSERT into BASKET_ADRS_CAMPI  VALUES (0,10, 2, 16,  \"AREA_MAX_NUMBER\", 1, 1, 1, 0, 0, 0)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (1,11, 2, 16,  \"AREA_DESCRIPTION\", 2, 33, 1, 0, 0, 0)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (2,12, 2, 16,  \"AREA_PARTITION_1\", 2, 33, 1, 0, 0, 1)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (3,13,2, 16,  \"AREA_PARTITION_2\", 2, 33, 1, 0, 0, 1)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (7,14, 2, 16,  \"AREA_REARM_TIME\", 1, 1, 1, 1, 0, 1)",
        "INSERT into BASKET_ADRS_CAMPI  VALUES (8,15, 2, 16,  \"AREA_REARM_OPTION\", 1, 1, 1, 1, 0, 1)",
//for receive timers

        "INSERT INTO BASKET_ADRS_CAMPI VALUES (0,20, 1, 1,  \"TIMERS_ENTRYTIME_1\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES (1,21, 1, 1, \"TIMERS_ENTRYTIME_2\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES( 2,22, 1, 1,  \"TIMERS_EXTRAENTRYTIME\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES (3,23, 1, 1,  \"TIMERS_EXITTIME_1\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES ( 4,24, 1, 1,  \"TIMERS_EXITTIME_2\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES (5,25, 1, 1,  \"TIMERS_INTERNALSIRENTIMER\", 1, 1, 1, 0, 0, 1)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES(6,26, 1, 1,  \"TIMERS_EXTERNALSIRENTIMER\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES (8,28, 1, 1,  \"TIMERS_SIRENDELAY\", 1, 1, 1, 0, 0, 1)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES (10,30, 1, 1,  \"TIMERS_DOUBLEZONEALARM\", 1, 1, 1, 0, 0, 0)",
        "INSERT INTO BASKET_ADRS_CAMPI VALUES (11,31, 1, 1,  \"TIMERS_DOUBLEKNOCK\", 1, 1, 1, 0, 0, 0)",

//for send timers 

         "INSERT INTO BASKET_ADRS_CAMPI VALUES (0,20, 2, 1,  \"TIMERS_ENTRYTIME_1\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES ( 1,21, 2, 1, \"TIMERS_ENTRYTIME_2\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES (2,22, 2, 1,  \"TIMERS_EXTRAENTRYTIME\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES ( 3,23, 2, 1, \"TIMERS_EXITTIME_1\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES (4,24, 2, 1,  \"TIMERS_EXITTIME_2\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES (5,25, 2, 1,  \"TIMERS_INTERNALSIRENTIMER\", 1, 1, 1, 0, 0, 1)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES (6,26, 2, 1,  \"TIMERS_EXTERNALSIRENTIMER\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES ( 8, 28, 2, 1,\"TIMERS_SIRENDELAY\", 1, 1, 1, 0, 0, 1)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES  ( 10,30, 2, 1, \"TIMERS_DOUBLEZONEALARM\", 1, 1, 1, 0, 0, 0)",
         "INSERT INTO BASKET_ADRS_CAMPI VALUES (11,31, 2, 1,  \"TIMERS_DOUBLEKNOCK\", 1, 1, 1, 0, 0, 0)"

        };

            db.BeginTransaction();
            queries.ForEach(query => db.Execute(query));
            db.Commit();
        }
    }
}
