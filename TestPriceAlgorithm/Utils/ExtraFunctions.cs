using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPriceAlgorithm.Class;

namespace TestPriceAlgorithm.Utils
{
    public static class ExtraFunctions
    {
        public static void ReadCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<FileDataImport>();
            }
        }

        public static bool ValidateExtraConfiguration(string period, string extraPeriod, int periodIndex, int extraPeriodIndex)
        {
            int nPeriod = 0;
            int sPeriod = 0;
            bool ok = false;

            if (int.TryParse(period, out nPeriod) && int.TryParse(extraPeriod, out sPeriod))
            {
                if (extraPeriodIndex == periodIndex)
                {
                    ok = true;
                }
                else if (extraPeriodIndex < periodIndex)
                {
                    ok = nPeriod > sPeriod;
                }
            }

            return ok;
        }

        public static double DateToMin(DateTime datetime)
        {
            return (datetime.Year * 60 * 24 * 365) +
                (datetime.Month * 60 * 24 * 365 / 12) +
                (datetime.Day * 60 * 24);
        }

        public static double[] ConvertDateToDouble(DateTime[] datetimes)
        {
            double[] aux = new double[datetimes.Length];

            for (int i = 0; i < datetimes.Length; i++)
            {
                aux[i] = DateToMin(datetimes[i]);
            }

            return aux.ToArray();
        }

        public static double[] GetBuyersBy(List<BuyerFactory> buyers, DateTime[] dateTimes, Type type)
        {
            List<double> list = new List<double>();
            double count = 0;

            for (int i = 0; i<dateTimes.Length; i++)
            {
                foreach (BuyerFactory buyer in buyers)
                {
                    if (buyer.GetType() == type && dateTimes[i].Equals(buyer.GetDateBuy()))
                    {
                        count++;
                    }
                }

                list.Add(count);
                count = 0;
            }

            return list.ToArray();
        }
    }
}
