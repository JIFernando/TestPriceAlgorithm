using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm
{
    public static class Constancts
    {
        public const string ImportedTitule = "Imported sales values.";
        public const string Serie1 = "Imported";
        public const string Serie2 = "Simulation";
        public const string Serie3 = "ImportedPrice";
        public const string Serie4 = "SimulationPrice";
        public const string SimulationName = "Simulation";
        public const string MediaName = "MediaImportedGames";
        public const string CompareTitule = "Real vs Algorithm sales.";
        public const string ComparePricesTitule = "Real vs Algorithm prices.";
        public const string DateTime = "DateTime";
        public const string SalesByDay = "SalesByDay";
        public const string BasePrice = "BasePrice";
        public const string Price = "Price";

        public const string ErrorMessagePeriodType = "There was an error format on period types.";
        public const string ErrorDefautInput = "Error Detected in Input.";
        public const string ErrorNoSalesData = "You should importdata or simulate the sales results after apply the algorithm.";
        public const string ErrorImportData = "The imported data error on file: ";

        public const string DefaultTextCSV = "Real data file name";

        //Percentajes by type of buyer
        public const double HighAgressivePercentaje = 1.3;
        public const double HighCompùlsivePercentaje = 1.1;
        public const double HighNormalPercentaje = 0.9;
        public const double HighOcasionalPercentaje = 0.75;
        public const double HighCautiousPercentaje = 0.6;

        public const double DecreaseAgressivePercentaje = 0.8;
        public const double DecreaseCompùlsivePercentaje = 1;
        public const double DecreaseNormalPercentaje = 1.1;
        public const double DecreaseOcasionalPercentaje = 1.2;
        public const double DecreaseCautiousPercentaje = 1.4;

    }
}
