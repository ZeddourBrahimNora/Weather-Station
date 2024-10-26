using System;
using System.Collections;
using System.Collections.Generic;

namespace CO2_Interface.Data
{
    internal class Collections
    {
        internal static ArrayList ObjectList = new ArrayList();
        internal static ArrayList ObjectListAlarm = new ArrayList();
        internal static Queue<byte> SerialBuffer = new Queue<byte>();

        
        // liste qui va contenir tout les types d'erreurs
        internal static ArrayList ErrorList = new ArrayList();
    }
}
