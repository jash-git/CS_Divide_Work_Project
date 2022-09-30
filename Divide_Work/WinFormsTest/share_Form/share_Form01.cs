using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest.share_Form
{
    public partial class share_Form01 : Form
    {
        public share_Form01()
        {
            InitializeComponent();
        }

        private void share_Form01_Load(object sender, EventArgs e)
        {
            LogFile.Write("share_Form01 Start");
        }

        private void share_Form01_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogFile.Write("share_Form01 Close");
        }
    }
}
