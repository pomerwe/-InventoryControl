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
    public partial class ItemInsertView : Form
    {
        public Item newItem;
        public ItemInsertView()
        {
            InitializeComponent();
            newItem = new Item();
            newItem.CodItem = codItemInput.Text;
            newItem.Nome = nomeInput.Text;
            newItem.Quantidade = (int)quantidadeInput.Value;
            newItem.UltimoLancamento = ultimoLancamentoDatePicker.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = $"insert into item values('{newItem.CodItem}','{newItem.Nome}',{newItem.Quantidade},'{newItem.UltimoLancamento}')";
            var result = DbClass.ExecuteQuery(query);

            if(!result.HasErrors)
            {
                Program.Message("Inserção feita com Sucesso!\nDeseja inserir novo item?", ClearAll, Close);
            }
        }

        private void ClearAll()
        {
            codItemInput.Clear();
            nomeInput.Clear();
            quantidadeInput.Value = 0;
            ultimoLancamentoDatePicker.Value = DateTime.Now;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Form1 m = (Form1)Tag;
            m.Show();
        }

        private void OnCodChange(object sender, EventArgs e)
        {
            newItem.CodItem = codItemInput.Text;
        }

        private void nomeInput_TextChanged(object sender, EventArgs e)
        {
            newItem.Nome = nomeInput.Text;
        }

        private void quantidadeInput_ValueChanged(object sender, EventArgs e)
        {
            newItem.Quantidade = (int)quantidadeInput.Value;
        }

        private void ultimoLancamentoDatePicker_ValueChanged(object sender, EventArgs e)
        {
            newItem.UltimoLancamento = ultimoLancamentoDatePicker.Value;
        }
    }
}
