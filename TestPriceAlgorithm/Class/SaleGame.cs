using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class SaleGame
    {
        //[Key]
        public int idGame { get; set; }
        public int sales { get; set; }
        public DateTime date { get; set; }
        public double price { get; set; }

        public Game Game { get; set; }
    }
}
