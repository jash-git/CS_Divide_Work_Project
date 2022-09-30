using Console_Folder_namespace;//前提條件，選擇相依專案
using ClassLibrary1;
using WinFormsTest.share_Form;
namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console_Folder_namespace.global.LogFile.CleanLog();
            Console_Folder_namespace.global.LogFile.Write("WinForm Start");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogFile.Write("WinForm Close");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            share_Form01 share_Form01 = new share_Form01();
            share_Form01.ShowDialog();
        }
    }
}