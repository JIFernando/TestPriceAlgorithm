using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestPriceAlgorithm.FormTestAlgorithm;

namespace TestPriceAlgorithm.Class
{
    public abstract class Buyer
    {
        public abstract bool GameBought { get; set; }
        public abstract DateTime DateBuy { get; set; }
        public abstract DateTime DateAppear { get; set; }
    }
}
