using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPriceAlgorithm.Class;

namespace TestPriceAlgorithm.Utils
{
    public static class AlgorithmFunctions
    {

        private readonly static Random _random = new Random();

        public static DateTime AverageDateTime(List<DateTime> dates)
        {
            var count = dates.Count;
            double temp = 0D;
            for (int i = 0; i < count; i++)
            {
                temp += dates[i].Ticks / (double)count;
            }
            return new DateTime((long)temp);
        }

        public static double Average(int period, double[] array, int startIndex = 0)
        {
            double total = 0;

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < period && period <= array.Length; i++)
            {
                total += array[i];
            }

            return total / period;
        }

        public static double Tendence(DateTime endDatePeriod, int period, int periocType, DateTime[] exportDateData,
           int[] exportSalesData)
        {
            //First Period
            double mediaSales1 = Average(period, exportSalesData.Select(x => (double)x).ToArray(), exportSalesData.Length - 2 * period);
            double mediaDates1 = Average(period, ExtraFunctions.ConvertDateToDouble(exportDateData),
                exportDateData.Length - 2 * period);

            //Second Period
            double mediaSales2 = Average(period, exportSalesData.Select(x => (double)x).ToArray(), exportSalesData.Length - 1 - period);
            double mediaDates2 = Average(period, ExtraFunctions.ConvertDateToDouble(exportDateData),
                exportDateData.Length - 1 - period);

            double currentPeriod = ExtraFunctions.DateToMin(endDatePeriod);

            return ((mediaSales2 - mediaSales1) / (mediaDates2 - mediaDates1) * (currentPeriod - mediaDates1)) + mediaSales1;
        }

        public static double GetNewPrice(double currentPrice, int period, int periocType, List<DateTime> exportDateData, List<int> exportSalesData,
            double changeAmount, double maxPrice, double minPrice)
        {
            double newPrice = currentPrice,
                   tendence0 = Tendence(exportDateData.ToArray()[exportDateData.Count - period], period, 0, exportDateData.ToArray(), exportSalesData.ToArray()),
                   tendence1 = Tendence(exportDateData.ToArray()[exportDateData.Count - 1], period, 0, exportDateData.ToArray(), exportSalesData.ToArray());

            if (tendence0 <= tendence1 && maxPrice >= newPrice + changeAmount)
            {
                //Positive number of sales => Increase value
                newPrice += changeAmount;
            }
            else if (minPrice <= newPrice - changeAmount)
            {
                //Negative number of sales => Decrease value
                newPrice -= changeAmount;
            }

            return newPrice;
        }

        public static double GetNewPrice(double currentPrice, int period, int periocType, Game game,
           double changeAmount, double maxPrice, double minPrice)
        {
            double newPrice = currentPrice;

            if (game.saleByDate.Count >= period)
            {
                double tendence0 = Tendence(game.GetDateFrom()[game.saleByDate.Count - period], period, 0, game.GetDateFrom(), game.GetSalesFrom()),
                   tendence1 = Tendence(game.GetDateFrom()[game.saleByDate.Count - 1], period, 0, game.GetDateFrom(), game.GetSalesFrom());

                if (tendence0 <= tendence1 && maxPrice >= newPrice + changeAmount)
                {
                    //Positive number of sales => Increase value
                    newPrice += changeAmount;
                }
                else if (minPrice <= newPrice - changeAmount)
                {
                    //Negative number of sales => Decrease value
                    newPrice -= changeAmount;
                }
            }

            return newPrice;
        }

        //15% to 5%
        public static int CalculateSales(double newPrice, int realSales, double priceBaseReal)
        {
            int newSales = 0;

            if (newPrice > priceBaseReal)
            {
                //15% - de probablilidades de mas ventas y un 5% de mas que el real
                newSales = Convert.ToInt32(_random.Next(85, 105) * realSales / 100);
            }
            else
            {
                //15% + de probablilidades de mas ventas y un 5% de menos que el real
                newSales = Convert.ToInt32(_random.Next(95, 115) * realSales / 100);
            }

            return newSales;
        }

        public static int CalculateSales(List<BuyerFactory> buyers, Game game)
        {
            int sale = 0;
            double tendence0 = 0,
                   tendence1 = 0;

            if (game.saleByDate.Count >= game.period) {
                tendence0 = Tendence(game.GetDateFrom()[game.saleByDate.Count - game.period], game.period, 0, game.GetDateFrom(), game.GetSalesFrom());
                tendence1 = Tendence(game.GetDateFrom()[game.saleByDate.Count - 1], game.period, 0, game.GetDateFrom(), game.GetSalesFrom());
            }

            foreach (BuyerFactory buyer in buyers)
            {
                if (buyer.PercentajeOfBuy(game, tendence0, tendence1))
                {
                    sale++;
                }
            }

            return sale;
        }
    }
}
