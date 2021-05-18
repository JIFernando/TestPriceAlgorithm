using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Utils
{
    public static class AlgorithmFunctions
    {

        private readonly static Random _random = new Random();

        public static double Average(int period, int[] array, int startIndex = 0)
        {
            double total = 0;

            for (int i = startIndex; i < period && period < array.Length; i++)
            {
                total += array[i];
            }

            return total / period;
        }

        public static double Tendence(DateTime endDatePeriod, int period, int periocType, List<DateTime> exportDateData,
            List<int> exportSalesData)
        {
            //First Period
            double mediaSales1 = Average(period, exportSalesData.ToArray(), exportSalesData.Count - 2 * period);
            double mediaDates1 = Average(period, ExtraFunctions.ConvertDateToDouble(exportDateData.ToArray()),
                exportDateData.Count - 2 * period);

            //Second Period
            double mediaSales2 = Average(period, exportSalesData.ToArray(), exportSalesData.Count - 1 - period);
            double mediaDates2 = Average(period, ExtraFunctions.ConvertDateToDouble(exportDateData.ToArray()),
                exportDateData.Count - 1 - period);

            double currentPeriod = ExtraFunctions.DateToMin(endDatePeriod);

            return ((mediaSales2 - mediaSales1) / (mediaDates2 - mediaDates1) * (currentPeriod - mediaDates1)) + mediaSales1;
        }

        public static double GetNewPrice(double currentPrice, int period, int periocType, List<DateTime> exportDateData, List<int> exportSalesData,
            double changeAmount, double maxPrice, double minPrice)
        {
            double newPrice = currentPrice,
                   tendence0 = Tendence(exportDateData.ToArray()[exportDateData.Count - period], period, 0, exportDateData, exportSalesData),
                   tendence1 = Tendence(exportDateData.ToArray()[exportDateData.Count - 1], period, 0, exportDateData, exportSalesData);

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
    }
}
