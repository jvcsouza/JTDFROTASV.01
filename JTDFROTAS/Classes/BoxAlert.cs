using System;
using System.Windows.Forms;

namespace JTDFROTAS.Classes
{
    class BoxAlert : Exception
    {
        public BoxAlert(String msg)
        {
            MessageBox.Show(msg);
        }
        public BoxAlert(String msg, String title)
        {
            MessageBox.Show(msg, title);
        }
    }
}
