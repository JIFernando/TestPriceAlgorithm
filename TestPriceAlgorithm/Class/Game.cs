using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class Game
    {
        //[Key]
        public int id { get; set; }
        public string gameName { get; set; }

        public virtual IList<SaleGame> Games { get; set; }
    }
}
