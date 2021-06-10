using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class Game
    {
        public DateTime releaseDate { get; set; }
        public double basePrice { get; set; }
        public double price { get; set; }
        public string gameName { get; set; }
        public int period { get; set; }
        public int shortPeriod { set; get; }
        
        public IList<SaleGame> saleByDate { get; set; }

        public Game()
        {
            this.saleByDate = new List<SaleGame>();
        }

        public Game(string name, DateTime dateTime, double basePrice, double price, int period = 0)
        {
            this.gameName = name;
            this.releaseDate = dateTime;
            this.basePrice = basePrice;
            this.price = price;
            this.period = period;
            this.saleByDate = new List<SaleGame>();
        }

        public double[] GetPricesFrom()
        {
            List<double> result = new List<double>();

            foreach (SaleGame sg in this.saleByDate)
            {
                result.Add(sg.price);
            }

            return result.ToArray();
        }

        public int[] GetSalesFrom()
        {
            List<int> result = new List<int>();

            foreach (SaleGame sg in this.saleByDate)
            {
                result.Add(sg.sales);
            }

            return result.ToArray();
        }

        public double[] GetSalesFromDouble()
        {
            List<double> result = new List<double>();

            foreach (SaleGame sg in this.saleByDate)
            {
                result.Add(sg.sales);
            }

            return result.ToArray();
        }

        public DateTime[] GetDateFrom()
        {
            List<DateTime> result = new List<DateTime>();

            foreach (SaleGame sg in this.saleByDate)
            {
                result.Add(sg.date);
            }

            return result.ToArray();
        }
    }
}
