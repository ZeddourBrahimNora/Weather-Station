using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class FromSensor
    {
        internal class Base
        {
            internal UInt16 SerialNumber;
            internal byte ID; // l'id
            internal bool ConfigStatus = false;
            internal UInt16 BinaryData; // la data 
            internal byte Type; // 1 / 2 / 3 Co2 Temperature Humidity  
            internal int LastUpdate;
            internal byte Checksum;


            //1.0 =  need user control

            internal Base(byte id, UInt16 data, byte type)
            {
                ID = id;
                BinaryData = data;
                Type = type;
                Checksum = 0;
            }
        }
        internal class Measure : Base
        {
            internal Int32 LowLimit;
            internal Int32 HighLimit;
            internal Int32 ConvertedData;
            internal UInt32 AlarmMaxPeriod;
            // définitions des seuils d'attentions et de critique min + max 
            internal  Int32 WarningMin;         //User Alarm
            internal  Int32 CriticalMin;         //User Alarm
            internal  Int32 WarningMax;         //User Alarm
            internal Int32 CriticalMax;         //User Alarm
            internal String Status;

            internal Queue<int> saveGraphPointsSeconds = new Queue<int>();
            internal Queue<int> saveGraphPointsMinutes = new Queue<int>();
            internal Queue<int> saveGraphPointsHours = new Queue<int>();


            internal Measure() : base(0, 0, 0)
            {
                LowLimit = 0;
                HighLimit = 0;
                ConvertedData = 0;
                AlarmMaxPeriod = 0;
                WarningMin = 0;
                CriticalMin = 0;
                WarningMax = 0;
                CriticalMax = 0;
                Status = "-";

            }

            
        }
    }
}
