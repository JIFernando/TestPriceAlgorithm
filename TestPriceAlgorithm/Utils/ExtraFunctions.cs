using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static int DateToMin(DateTime datetime)
        {
            return (datetime.Year * 60 * 24 * 365) +
                (datetime.Month * 60 * 24 * 365 / 12) +
                (datetime.Day * 60 * 24);
        }

        public static int[] ConvertDateToDouble(DateTime[] datetimes)
        {
            int[] aux = new int[datetimes.Length];

            for (int i = 0; i < datetimes.Length; i++)
            {
                aux[i] = DateToMin(datetimes[i]);
            }

            return aux.ToArray();
        }
    }
}
