using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class NormalBuyer : Buyer
    {
        public override bool GameBought { get; set; }
        public override DateTime DateBuy { get; set; }
        public override DateTime DateAppear { get; set; }

        public NormalBuyer(): base ()
        {
            GameBought = false;
        }

        public NormalBuyer(DateTime date) : base()
        {
            DateAppear = date;
        }
    }
}
