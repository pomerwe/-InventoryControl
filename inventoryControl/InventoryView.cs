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
    public partial class InventoryView : Form
    {
        List<Item> dbItens;
        public InventoryView()
        {
            InitializeComponent();
            var selectResult = DbClass.ExecuteQuery("select * from item");
            var itens = selectResult.AsEnumerable().ToList();
            grid.RowCount = 0;
            dbItens = selectResult.AsEnumerable().Select(m => new Item()
            {
                ItemId = m.Field<int>("itemId"),
                CodItem = m.Field<string>("codItem"),
                Nome = m.Field<string>("nome"),
                Quantidade = m.Field<int>("quantidade"),
                UltimoLancamento = m.Field<DateTime>("ultimoLancamento"),
            }).ToList();
            dbItens.ForEach(i => InsertIntoGrid(i));
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Form1 m = (Form1)Tag;
            m.Show();
        }

        private void InsertIntoGrid(Item item)
        {
            grid.RowCount = grid.RowCount + 1;
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            grid.Controls.Add(new Label() { Text = item.CodItem }, 0, grid.RowCount - 1);
            grid.Controls.Add(new Label() { Text = item.Nome }, 1, grid.RowCount - 1);
            grid.Controls.Add(new Label() { Text = item.Quantidade.ToString() }, 2, grid.RowCount - 1);
            grid.Controls.Add(new Label() { Text = item.UltimoLancamento.ToString() }, 3, grid.RowCount - 1);
            var size = grid.Size;
            size.Height = grid.RowCount * 40;
            grid.Size = size;
        }
    }
}
