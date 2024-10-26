﻿
using System.IO.Ports;
using System.Collections.Generic;

namespace CO2_Interface.SerialDataHandler
{
    internal static partial class Reception
    {
        internal static void ReceptionHandler(object sender,SerialDataReceivedEventArgs e)
        { 
            SerialPort sp = (SerialPort)sender;
            byte[] ByteArray = new byte[sp.BytesToRead];

            sp.Read(ByteArray, 0, ByteArray.Length);
            for (int i = 0; i < ByteArray.Length; i++)
            {
                System.Console.WriteLine(ByteArray[i]);
                
            }
            for (int i = 0; i < ByteArray.Length; i++) Data.Collections.SerialBuffer.Enqueue(ByteArray[i]);      
        }
    }
}
