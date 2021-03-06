using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class AggressiveBuyer : Buyer
    {
        public override bool GameBought { get; set; }
        public override DateTime DateBuy { get; set; }
        public override DateTime DateAppear { get; set; }

        public AggressiveBuyer() : base()
        {
            GameBought = false;
        }

        public AggressiveBuyer(DateTime date) : base()
        {
            DateAppear = date;
        }
    }
}
