using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryControl
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Message(string message, Action acceptMethod, Action refuseAction = null)
        {
            if (MessageBox.Show(message, "Inventory Control",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                acceptMethod.Invoke();
            }
            else
            {
                if(refuseAction != null)
                {
                    refuseAction.Invoke();
                }
            }
        }
    }
}
