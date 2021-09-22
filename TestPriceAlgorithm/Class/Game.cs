using System;
using System.Collections.Generic;
using System.Globalization;
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

        public double[] GetBenefitsFrom()
        {
            List<double> result = new List<double>();
            double total = 0;

            foreach (SaleGame sg in this.saleByDate)
            {
                total += Math.Truncate((sg.price * sg.sales) / 1000);

                result.Add(total);
            }

            return result.ToArray();
        }

        public int[] GetSalesFrom()
        {
            //List<int> result = new List<int>();

            //foreach (SaleGame sg in this.saleByDate)
            //{
            //    result.Add(sg.sales);
            //}
            IList<SaleGame> aux = saleByDate.OrderBy(x => x.date).ToList();           

            return aux.Select(x => x.sales).ToArray();
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
            return this.saleByDate.Select(s => s.date).OrderBy(x => x).ToArray();
        }
    }
}
