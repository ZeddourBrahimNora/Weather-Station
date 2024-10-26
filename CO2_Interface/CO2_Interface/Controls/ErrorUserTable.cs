using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface.Controls
{
    public partial class ErrorUserTable : UserControl
    {
        /****** CODE EXAMEN : DEBUT ******/
     

        public byte cBoxErrorType_SelectedItem { get; private set; }
        

        public ErrorUserTable()
        {
            InitializeComponent();
        }


        internal class TypeError
        {
           internal byte TypeErrorNum; // 1,2,3,4,5 diff types d'erreurs

            internal static void InitTypeError(out string type, TypeError item)
            {
                type = "";

                if (item.TypeErrorNum == 1)
                {
                    type = "COM error";
                }
                else if (item.TypeErrorNum == 2)
                {
                    type = "Data error";
                }
                else if (item.TypeErrorNum == 3)
                {
                    type = "CSV file error";
                }
                else if (item.TypeErrorNum == 4)
                {
                    type = "Database access error";
                }
                else if (item.TypeErrorNum == 5)
                {
                    type = "Try catch errors";
                }
            }

            internal static void InitTypeError()
            {
                throw new NotImplementedException();
            }
        }
        // écrire avec la date + heure un msg chaque fois qu'il y'a un soucis

        // test avec msg box après on met dans une data grid view

        

        private void cBoxErrorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TypeError item in Data.Collections.ErrorList )
            {
                if (item.TypeErrorNum == cBoxErrorType_SelectedItem)
                {
                    if (item.TypeErrorNum == 1)
                    {
                        
                    }
                    else if (item.TypeErrorNum  == 2)
                    {

                    }
                    else if (item.TypeErrorNum == 3)
                    {

                    }
                    else if (item.TypeErrorNum == 4)
                    {

                    }
                    else if (item.TypeErrorNum == 5)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please select an type of error");
                }
            }
           // Data.Collections.ErrorList.Add(2);
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            TypeError.InitTypeError();
        }
        /******CODE EXAMEN: Fin * *****/

    }
}
