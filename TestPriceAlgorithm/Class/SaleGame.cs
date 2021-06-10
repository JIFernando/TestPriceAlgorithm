using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class SaleGame
    {
        public int sales { get; set; }
        public DateTime date { get; set; }
        public double price { get; set; }
        public double tendence { get; set; }

        public SaleGame() { }

        public SaleGame(int sales, DateTime date, double price)
        {
            this.sales = sales;
            this.date = date;
            this.price = price;
        }
    }
}
