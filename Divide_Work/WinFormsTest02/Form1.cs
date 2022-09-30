using ClassLibrary1;
using WinFormsTest.share_Form;
namespace WinFormsTest02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogFile.Write("WinForm start");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogFile.Write("WinForm Close");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinFormsTest.share_Form.share_Form01 share_Form01 = new WinFormsTest.share_Form.share_Form01();
            share_Form01.ShowDialog();
        }
    }
}