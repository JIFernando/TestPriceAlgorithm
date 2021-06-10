using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class CautiousBuyer : Buyer
    {
        public override bool GameBought { get; set; }

        public CautiousBuyer() : base()
        {
            GameBought = false;
        }        
    }
}
