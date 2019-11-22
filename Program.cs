using System;
using System.Drawing;
using System.Windows.Forms;

namespace linuxcc2
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lccMainWindow());
        }
    }
}
