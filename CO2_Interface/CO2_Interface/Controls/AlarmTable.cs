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
    public partial class AlarmTable : UserControl
    {

        internal event EventHandler ApplyAlarmClick;

        public AlarmTable()
        {
            InitializeComponent();
        }

        internal void InitID()
        {

            foreach (Data.FromSensor.Measure item in Data.Collections.ObjectList)
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
                if (inIdMenu == false && item.ID != 0 && item.ConfigStatus == true)
                {
                    idMenu.Items.Add(item.ID);
                }

            }


        }

        private void UpdateIdMenu_Tick(object sender, EventArgs e)
        {
            InitID();
        }

        private void BtApplyConfig_Click(object sender, EventArgs e)
        {

            ApplyAlarmClick(sender, e);

        }

        private void idMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Data.FromSensor.Measure item in Data.Collections.ObjectList)
            {
                if (item.ID == (byte)idMenu.SelectedItem)
                {
                    tbMaxCritic.Text = item.CriticalMax.ToString();
                    tbMaxWarning.Text = item.WarningMax.ToString();
                    tbMinWarning.Text = item.WarningMin.ToString();
                    tbMinCritic.Text = item.CriticalMin.ToString();
                }
            }
        }
    }
}
