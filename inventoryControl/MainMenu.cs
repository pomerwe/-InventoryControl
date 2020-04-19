using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridButton_Click(object sender, EventArgs e)
        {
            InventoryView v = new InventoryView();
            v.Tag = this;
            v.Show();
            Hide();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            ItemInsertView window = new ItemInsertView();
            window.Show();
            window.Tag = this;
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Program.Message("Deseja realmente fechar o programa?", Close);
        }
    }
}
