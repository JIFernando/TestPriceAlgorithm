using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class SalesEvolution
    {
        public string NameGraph { get; set; }
        public Dictionary<DateTime, double> SalesValues { get; set; }

        public SalesEvolution() { }

        public SalesEvolution(string name, Dictionary<DateTime, double> values) {
            this.NameGraph = name;
            this.SalesValues = SalesValues;
        }
    }
}
