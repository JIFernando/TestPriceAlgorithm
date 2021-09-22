using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class OccasionalBuyer : Buyer
    {        
        public override bool GameBought { get; set; }
        public override DateTime DateBuy { get; set; }
        public override DateTime DateAppear { get; set; }

        public OccasionalBuyer() : base()
        {
            GameBought = false;
        }

        public OccasionalBuyer(DateTime date) : base()
        {
            DateAppear = date;
        }
    }
}
