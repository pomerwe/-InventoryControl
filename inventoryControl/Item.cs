using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryControl
{
    public class Item
    {
        public int ItemId { get; set; }
        public string CodItem { get; set; }
        public string Nome { get; set; }
        public int Quantidade{ get; set; }
        public DateTime UltimoLancamento { get; set; }

        public Item()
        {
        }
    }
}
