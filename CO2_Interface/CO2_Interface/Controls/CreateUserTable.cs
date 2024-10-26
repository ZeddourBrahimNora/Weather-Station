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
    public partial class CreateUserTable : UserControl
    {
        internal event EventHandler AddUser;

        internal event EventHandler TimerTick;

        public CreateUserTable()
        {
            InitializeComponent();
            //   DBAccess_Provider.DataReader.Read(User_Grid, "UserTable");

        }

        private void Timer1sec_Tick(object sender, EventArgs e)
        {
            TimerTick(sender, e);
            //DBAccess_Provider.DataReader.Read(User_Grid, CO2_Interface.MainForm.LocalUserTable, "UserTable");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUser(sender, e);
        
        }

      
    }
}
