using CO2_Interface.Data;
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


    public partial class MeasureTable : UserControl
    {
        internal event EventHandler ApplyMeasureClick;
        internal event EventHandler DeleteMeasureClick;
        public MeasureTable()
        {
            InitializeComponent();
        }

        internal void InitID()
        {

            foreach (Data.FromSensor.Base item in Data.Collections.ObjectList)
            {
                bool inIdMenu = false;
                foreach (Object asset in idMenu.Items)
                {
                    if (item.ID == (byte)asset && item.ID != 0)
                    {
                        inIdMenu = true;
                        break;
                    }
                }
                if (inIdMenu == false && item.ID != 0)
                {
                    idMenu.Items.Add(item.ID);

                }
            }


        }

        private void UpdateIdMenu_Tick(object sender, EventArgs e)
        {
            InitID();
        }



        private void idMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Data.FromSensor.Measure measureObj in Data.Collections.ObjectList)
            {

                if (measureObj.ID == (byte)idMenu.SelectedItem)
                {

                    if (measureObj.ID != 0)
                    {

                        if (measureObj.Type == 1)
                        {
                            lbType.Text = "CO2";

                        }
                        else if (measureObj.Type == 2)
                        {
                            lbType.Text = "Temperature";
                        }
                        else if (measureObj.Type == 3)
                        {
                            lbType.Text = "Humidity";
                        }


                        tbMaxValue.Text = measureObj.HighLimit.ToString();
                        tbMinValue.Text = measureObj.LowLimit.ToString();

                    }
                }
            }
        }

        private void btApplyConfig_Click(object sender, EventArgs e)
        {
            ApplyMeasureClick(sender, e);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteMeasureClick(sender, e);

        }
    }
}
