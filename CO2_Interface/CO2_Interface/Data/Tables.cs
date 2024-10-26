using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class Tables
    {
        internal static DataTable DataFromSensor = new DataTable();
        internal class Columns
        {

            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn ConfigStatus = new DataColumn("Config Status");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn NbrBytes = new DataColumn("Destroy ID");
            internal static DataColumn Data = new DataColumn("Data");
            internal static DataColumn LastUpdate = new DataColumn("Last Update");
            internal static DataColumn Alarm = new DataColumn("Alarm");
        }

        internal static DataTable DataFromSensorAlarm = new DataTable(); // création d'une data table pr contenir nos données

        internal class Columns2
        {
            
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn WarningMin = new DataColumn("Warning min");
            internal static DataColumn CriticalMin = new DataColumn("Critical min");
            internal static DataColumn WarningMax = new DataColumn("Warning Max");
            internal static DataColumn CriticalMax = new DataColumn("Critical Max");
            internal static DataColumn Status = new DataColumn("Status");
        }

        internal static DataTable DataTableAccess = new DataTable(); // création d'une data table pr contenir nos données

        internal class Columns3
        {
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn AccessIDPK = new DataColumn("Access rights");
            internal static DataColumn AllowCreateID = new DataColumn("Create ID");
            internal static DataColumn AllowDestroyID = new DataColumn("Destroy ID");
            internal static DataColumn AllowConfigAlarm = new DataColumn("Config Alarm");
            internal static DataColumn UserCreation = new DataColumn("User Creation");
        }

        internal static DataTable DataTableError = new DataTable(); // data table pour les erreurs

        internal class Columns4
        {
            internal static DataColumn Ref = new DataColumn("Ref");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn Date = new DataColumn("Date");
            internal static DataColumn Description = new DataColumn("Description");
        }


    }

}
