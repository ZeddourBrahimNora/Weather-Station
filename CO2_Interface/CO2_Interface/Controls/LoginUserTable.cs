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
    public partial class LoginUserTable : UserControl
    {
        internal event EventHandler LoginClick;

        public LoginUserTable()
        {
            InitializeComponent();
            boxPassLogin.PasswordChar = '●';
        }
        
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoginClick(sender, e);
        }

        public static implicit operator LoginUserTable(ErrorUserTable v)
        {
            throw new NotImplementedException();
        }
    }

}
