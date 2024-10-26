using System.Windows.Forms;
using System.Data;
using System;
using CO2_Interface.Data;
using System.Linq;
using System.IO;
using System.Text;

namespace CO2_Interface.SerialDataHandler
{
    internal static partial class Reception
    {
        internal static void DataTreatment(DataTable dt, DataGridView dg)
        {
            if(Data.Collections.ObjectList.Count == 0) { 
           LoadConfig();
            }

            while ((Data.Collections.SerialBuffer.Count > 2) &&
                    ((Data.Collections.SerialBuffer.ElementAt(0) != 0x55) ||
                    (Data.Collections.SerialBuffer.ElementAt(1) != 0x55) ||
                    (Data.Collections.SerialBuffer.ElementAt(2) != 0xAA))) Data.Collections.SerialBuffer.Dequeue();
            //Suppresion des octets encombrants ne faisant partie de la trame

            while (Data.Collections.SerialBuffer.Count > 12)
            {
                Data.FromSensor.Base obj = new Data.FromSensor.Base(0, 0, 0);


                Data.Collections.SerialBuffer.Dequeue();//Dequeue de l'entete
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                obj.SerialNumber = Data.Collections.SerialBuffer.Dequeue(); //"0x0002" 
                obj.SerialNumber <<= 8;//On fait avancer le SerialNumber de 8bit pour ajouter le 2eme octet "0x02"
                obj.SerialNumber += Data.Collections.SerialBuffer.Dequeue();//"0x0203"
                obj.ID = Data.Collections.SerialBuffer.Dequeue();
                obj.Type = Data.Collections.SerialBuffer.Dequeue();
                obj.BinaryData = Data.Collections.SerialBuffer.Dequeue();//Meme chose etant donné qu il est en 16bits 
                obj.BinaryData <<= 8;
                obj.BinaryData += Data.Collections.SerialBuffer.Dequeue();
                obj.Checksum = Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();//Dequeue de l'entete
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                CSCheck(obj);//verif du checkSUM

                ObjToList(obj, dt, dg);
            }
        }
        internal static void ObjToList(Data.FromSensor.Base obj, DataTable dt, DataGridView dg)
        {
            DataChecking(obj);

            DataInsertion(dt, dg);
        }

        internal static void UpdateTreatment()
        {

            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID != 0) //On verifie que l'on manipule bien une mesure
                {
                    Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;
                    item.LastUpdate++;
                }
            }
        }
        private static void StatusUpdate(FromSensor.Measure item)
        {
            if (item.ConfigStatus == true)
            {
                if (item.ConvertedData >= item.CriticalMax)
                {
                    item.Status = "Too high";
                }
                else if (item.ConvertedData <= item.WarningMax)
                {
                    item.Status = "High";
                }
                else if (item.ConvertedData < item.WarningMax && item.ConvertedData > item.WarningMin)
                {
                    item.Status = "Ok";
                }
                else if (item.ConvertedData <= item.WarningMin)
                {
                    item.Status = "Low";
                }
                else if (item.ConvertedData <= item.CriticalMin)
                {
                    item.Status = "Too Low";
                }

            }

        }
        internal static void DataAlarmTreatment(DataTable dt, DataGridView dg)
        {
            dt.Rows.Clear();
            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID != 0) //On verifie que l'on manipule bien une mesure
                {
                    Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;
                    IntiTypeData(out string type, out _, item);//"_" est utilisé pour ignorer la valeur a envoyé

                    
                        dt.Rows.Add(new object[] { item.ID, type, item.CriticalMin, item.WarningMin, item.WarningMax, item.CriticalMax, item.Status });
                    

                }
            }
        }

        
        internal static void DataChecking(FromSensor.Base obj)
        {
            bool objFound = false;
            foreach (Data.FromSensor.Base item in Data.Collections.ObjectList)
            {
                //Si on trouve un doublon on update ses attributs
                if (item.ID == obj.ID)
                {
                    objFound = true;

                    item.BinaryData = obj.BinaryData;
                    item.LastUpdate = 0;
                    item.Type = obj.Type;
                    break;
                }
            }

            if (objFound != true)//Sinn on l'ajoute dans la liste
            {
                Data.FromSensor.Measure measureObj = new Data.FromSensor.Measure
                {
                    ID = obj.ID,
                    SerialNumber = obj.SerialNumber,
                    Type = obj.Type,
                    BinaryData = obj.BinaryData,
                    Checksum = obj.Checksum

                };


                Data.Collections.ObjectList.Add(measureObj);
            }

            //Supprime les anciennes lignes 
            //pour faire place au nouvelles
        }
        internal static void DataInsertion(DataTable dt, DataGridView dg)
        {
            dt.Rows.Clear();
            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID != 0) //On verifie que l'on manipule bien une mesure
                {
                    Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;

                    if (item.HighLimit != 0)
                    {
                        ConversionTreatment(item); //Si les limites sont définies on effectue la conversion
                    }

                    StatusUpdate(item);
                    // SaveForGraph(item);

                    IntiTypeData(out string type, out string valuesPrefix, item);//initialisation du préfix et type
                                                                                 //  MessageBox.Show(item.LastUpdate + " lasssss");
                    if (item.ConfigStatus == true) dt.Rows.Add(new object[] { item.ID, item.ConfigStatus, type, item.ConvertedData + valuesPrefix, item.LastUpdate, item.Status });

                    else dt.Rows.Add(new object[] { item.ID, item.ConfigStatus, type, "-", item.LastUpdate, item.Status });
                    //Indique la donnée convertie, « - » si non ID configuré 

                    if (item.ID == 1)
                    {
                        // MessageBox.Show(item.LastUpdate + "");
                    }
                }
            }
            dg.DataSource = dt;
        }
        private static void CSCheck(FromSensor.Base obj)
        {

            byte checksum;
            checksum = (byte)(obj.SerialNumber >> 8);
            checksum += (byte)(obj.SerialNumber & 0x00ff);
            checksum += (byte)obj.ID;
            checksum += (byte)obj.Type;
            checksum += (byte)(obj.BinaryData >> 8);
            checksum += (byte)(obj.BinaryData & 0x00ff);

            if (checksum != obj.Checksum)
            {
                MessageBox.Show("Transimission Error !" + checksum + " - " + obj.Checksum);

                /****** CODE EXAMEN : DEBUT ******/
                MessageBox.Show(DateTime.Now + " - " + " Erreur de type : 2 -> Checksum error ");
                /******CODE EXAMEN: FIN * *****/

            }


        }

        internal static void LoadConfig()
        {
            int i, j;

            string FilePath = Directory.GetCurrentDirectory();

            FilePath += "\\Config.csv";
            //          MessageBox.Show(FilePath.ToString());

            try
            {
                StreamReader Reader = new StreamReader(FilePath, ASCIIEncoding.ASCII);
                string fileContent = Reader.ReadToEnd();

                Reader.Close();

                i = fileContent.IndexOf("\r");

                var Text = string.Empty;
                for (j = 0; j < i; j++) Text += fileContent[j];


                if (Text == "MeteoStation_Configuration_file")
                {

                    int convertText = 0;
                    i = fileContent.IndexOf("Start");
                    int FileEnd = fileContent.IndexOf("End");

                    i += 7;

                    if (i >= FileEnd) MessageBox.Show("Empty"); //ConfigFile_Status.Text = "Empty";

                    //ConfigFile_Content.Text = "";

                    while (i < FileEnd)
                    {

                        //ConfigFile_Content.Text += fileContent[i].ToString();


                        Data.FromSensor.Measure item = new Data.FromSensor.Measure();
                    
                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.ID = (byte)convertText;
                        i++;


                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.Type = (byte)convertText;
                        i++;

                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.LowLimit = convertText;
                        i++;

                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.HighLimit = convertText;
                        i++;

                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.CriticalMax = convertText;
                        i++;

                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.WarningMin = (byte)convertText;
                        i++;


                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.WarningMax = (byte)convertText;
                         i++;

                        Text = string.Empty;
                        while (fileContent[i] != ';')
                        {
                            Text += fileContent[i];
                            i++;
                        }
                        convertText = Int32.Parse(Text);
                        item.CriticalMax = (byte)convertText;
                        i++;

                        if (item.ID != 0)
                        {
                            checkImportedData(item);
                        }
                        // Data.Collections.ObjectList.Add(item);


                        i +=2;
                    }

                    //  ConfigFile_Status.Text = "Imported";  
                    MessageBox.Show("Imported");


                }
                else MessageBox.Show("Corrupted");
                //else ConfigFile_Status.Text = "Corrupted";
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Not found");
                ///ConfigFile_Status.Text = "Not found";
            }
            catch (IOException)
            {
                MessageBox.Show("Not loaded");
                //ConfigFile_Status.Text = "Not loaded";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ConfigFile_Status.Text = "Error";
            }
        }

        private static void checkImportedData(FromSensor.Measure item)
        {
            bool objFound = false;
            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                //Si on trouve un doublon on update ses attributs
                if (item.ID == obj.ID)
                {
                    objFound = true;
                    obj.Type = item.Type;
                    obj.ConfigStatus = true;
                    obj.LowLimit = item.LowLimit;
                    obj.HighLimit = item.HighLimit;
                    obj.CriticalMin = item.CriticalMin;
                    obj.WarningMin = item.WarningMin;
                    obj.WarningMax = item.WarningMax;
                    obj.CriticalMax = item.CriticalMax;
                    break;
                }
            }

            if (objFound != true)//Sinn on l'ajoute dans la liste
            {
                Data.FromSensor.Measure measureObj = new Data.FromSensor.Measure
                {
                    ID = item.ID,
                    SerialNumber = item.SerialNumber,
                    Type = item.Type,
                    ConfigStatus = true,
                    BinaryData = item.BinaryData,
                    Checksum = item.Checksum,
                    LowLimit = item.LowLimit,
                    HighLimit = item.HighLimit,
                    CriticalMin = item.CriticalMin,
                    WarningMin = item.WarningMin,
                    WarningMax = item.WarningMax,
                    CriticalMax = item.CriticalMax,

                };


                Data.Collections.ObjectList.Add(measureObj);
            }
        }

        //Méthodes secondaires
        private static void ConversionTreatment(FromSensor.Measure item)
        {
            double calcul = (double)item.BinaryData / 65535;
            int max_min = item.HighLimit - item.LowLimit;
            calcul *= max_min;
            calcul += item.LowLimit;
            item.ConvertedData = (int)calcul;

        }
        private static void IntiTypeData(out string type, out string valuesPrefix, FromSensor.Base item)
        {
            type = "";
            valuesPrefix = "";

            if (item.Type == 1)
            {
                type = "CO²";
                valuesPrefix = " ppm";
            }
            else if (item.Type == 2)
            {
                type = "Temperature";
                valuesPrefix = " °C";
            }
            else if (item.Type == 3)
            {
                type = "Humidity";
                valuesPrefix = " %";
            }
        }

        internal static void SaveForGraphSeconds()
        {
            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID != 0) //On verifie que l'on manipule bien une mesure
                {
                    Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;

                    int maxSecondsMinutes = 60;
                   
                    if (item.saveGraphPointsSeconds.Count == maxSecondsMinutes)
                    {
                        item.saveGraphPointsSeconds.Dequeue();
                    }



                    if (item.saveGraphPointsMinutes.Count == maxSecondsMinutes)
                    {

                        item.saveGraphPointsMinutes.Dequeue();
                    }

                    if (item.saveGraphPointsHours.Count >= 24)
                    {
                        item.saveGraphPointsHours.Dequeue();
                    }

                    if (item.ConfigStatus == true)
                    {
                        item.saveGraphPointsSeconds.Enqueue(item.ConvertedData);
                    }
                }
            }
        }

        internal static void SaveForGraphMinutes()
        {
            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID != 0) //On verifie que l'on manipule bien une mesure
                {
                    Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;

                    int maxSecondsMinutes = 60;
                    int moyenne = 0;
                    
                        foreach (var elem in item.saveGraphPointsSeconds)
                        {
                            moyenne += elem;
                        }

                        moyenne /= maxSecondsMinutes;

                        item.saveGraphPointsMinutes.Enqueue(moyenne);
                     
                }
            }
        }


         
        internal static void SaveForGraphHours()
         {
            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID != 0) //On verifie que l'on manipule bien une mesure
                {
                    Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;

                    int maxSecondsMinutes = 60;
                    int moyenne = 0;

                    foreach (var elem in item.saveGraphPointsMinutes)
                    {
                        moyenne += elem;
                    }

                    moyenne /= maxSecondsMinutes;

                    item.saveGraphPointsHours.Enqueue(moyenne);

                }
            }
        }
    }
}
