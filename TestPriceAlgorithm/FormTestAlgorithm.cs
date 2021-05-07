using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPriceAlgorithm
{
    public partial class FormTestAlgorithm : Form
    {
        private readonly FileDialog _fileDialog = new OpenFileDialog();
        private readonly Random _random = new Random();
        private List<DateTime> _importDateData  = new List<DateTime>();
        private List<int> _importSalesData = new List<int>();
        private List<DateTime> _exportDateData  = new List<DateTime>();
        private List<int> _exportSalesData = new List<int>();
        private List<double> _exportPriceData = new List<double>();

        public enum PeriodType
        {
            Minutes = 1,
            Hours,
            Days,
            Months
        }


        public FormTestAlgorithm()
        {
            InitializeComponent();
        }

        private void FormTestAlgorithm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxExtraConf.Visible = !this.groupBoxExtraConf.Visible;
        }

        private void btnGraphReal_Click(object sender, EventArgs e)
        {
            //Form form = CreateFormGrahp();
            DateTime[] x = _importDateData.ToArray();
            int[] y = _importSalesData.ToArray();

            chart1.Titles.Clear();

            chart1.Titles.Add("Imported sales values");
            for (int i = 0; i<_importDateData.Count; i++)
            {
                chart1.Series["Imported"].Points.AddXY(x[i], y[i]);

            }
        }

        private void btnImportCsv_Click(object sender, EventArgs e)
        {
            int columnDate = 0;
            int columnSales = 0;

            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                csvFileName.Text = _fileDialog.FileName;
                
                string[] lines = System.IO.File.ReadAllLines(_fileDialog.FileName);
                int count = 0;
                foreach (string line in lines)
                {
                    if (count == 0)
                    {
                        string[] columns = line.Split(';');

                        for (int i = 0; i < columns.Length; i++)
                        {
                            if (columns[i] == "DateTime")
                            {
                                columnDate = i;
                            }
                            else if (columns[i] == "SalesByDay")
                            {
                                columnSales = i;
                            }
                        }
                    }
                    else
                    {
                        string[] columns = line.Split(';');

                        foreach (string column in columns)
                        {
                            _importDateData.Add(Convert.ToDateTime(columns[columnDate]));
                            _importSalesData.Add(int.Parse(columns[columnSales]));
                        }
                    }

                    count++;
                }
            }            
        }

        private void btnSingleValue_Click(object sender, EventArgs e)
        {
            double basePrice = double.Parse(txtBasePrice.Text);
            int period = int.Parse(txtPeriod.Text);
            int periodType = cbPeriodType.SelectedIndex;

            SetImport2FirstPeriods(period, basePrice);

            txtSingleValue.Text = GetNewPrice(basePrice, period, periodType).ToString();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            double basePrice = double.Parse(txtBasePrice.Text);
            int period = int.Parse(txtPeriod.Text);
            int periodType = cbPeriodType.SelectedIndex;
            double newPrice = basePrice;

            SetImport2FirstPeriods(period, basePrice);

            for (int i=period; i<_importDateData.Count; i++)
            {
                newPrice = GetNewPrice(newPrice, period, periodType);
                _exportPriceData.Add(newPrice);
                _exportSalesData.Add(CalculateSales(newPrice, _importSalesData.ToArray()[i]));
            }

            DateTime[] x = _importDateData.ToArray();
            int[] y = _importSalesData.ToArray();
            int[] y2 = _exportSalesData.ToArray();

            chart1.Titles.Clear();

            chart1.Titles.Add("Real vs Algorithm sales");
            for (int i = 0; i < _importDateData.Count; i++)
            {
                chart1.Series["Imported"].Points.AddXY(x[i], y[i]);
                chart1.Series["Simulation"].Points.AddXY(x[i], y2[i]);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DateTime[] dates = _exportDateData.ToArray();
            int[] sales = _exportSalesData.ToArray();
            double[] prices = _exportPriceData.ToArray();

            var csv = new StringBuilder();

            csv.AppendLine("DateTime;SalesByDay;Price");

            for (int i = 0; i<_exportDateData.Count; i++)
            {
                var newLine = string.Format("{0};{1};{2}", dates[i], sales[i], prices[i]);
                csv.AppendLine(newLine);
            }
            
            File.WriteAllText(@"C:\Users\jimen\source\repos\TestPriceAlgorithm\testCSV\Test.csv", csv.ToString());
        }

        private void ReadCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<FileDataImport>();
            }            
        }

        private double GetNewPrice(double currentPrice, int period, int periocType)
        {
            double newPrice = currentPrice,
                   tendence0 = Tendence(_exportDateData.ToArray()[_exportDateData.Count - period], period, 0),
                   tendence1 = Tendence(_exportDateData.ToArray()[_exportDateData.Count - 1], period, 0),
                   changeAmount = double.Parse(this.txtChangeAmount.Text),
                   maxPrice = double.Parse(this.txtMaxPrice.Text),
                   minPrice = double.Parse(this.txtMinPrice.Text);

            if (tendence0 < tendence1 && maxPrice > newPrice + changeAmount)
            {
                //Positive number of sales => Increase value
                newPrice += changeAmount;
            }
            else if (minPrice < newPrice - double.Parse(this.txtChangeAmount.Text))
            {
                //Negative number of sales => Decrease value
                newPrice -= changeAmount;
            }

            return newPrice;
        }

        private double Tendence(DateTime endDatePeriod, int period, int periocType)
        {
            //First Period
            double mediaSales1 = Average(period, _exportSalesData.ToArray(), _exportSalesData.Count - 2*period);
		    double mediaDates1 = Average(period, ConvertDateToDouble(_exportDateData.ToArray()),
                _exportDateData.Count - 2*period); 

            //Second Period
            double mediaSales2 = Average(period, _exportSalesData.ToArray(), _exportSalesData.Count - 1 - period);
            double mediaDates2 = Average(period, ConvertDateToDouble(_exportDateData.ToArray()), 
                _exportDateData.Count- 1 - period);

            double currentPeriod = DateToMin(endDatePeriod);

            return ((mediaSales2 - mediaSales1) / (mediaDates2 - mediaDates1) * (currentPeriod - mediaDates1)) + mediaSales1;
        }

        private double Average( int period, int[] array, int startIndex = 0)
        {
            double total = 0;

            for (int i = startIndex; i < period && period < array.Length; i++)
            {
                total += array[i];
            }

            return total / period;
        }

        private void SetImport2FirstPeriods(int period, double basePrice)
        {
            int[] auxSales = new int[period * 2];
            DateTime[] auxDates = new DateTime[period * 2];

            Array.Copy(_importSalesData.ToArray(), 0, auxSales,  0, (period * 2) - 1);
            //Array.Copy(_importDateData.ToArray(),  0, auxDates,  0, (period * 2) - 1);

            for (int i= 0; i<period*2; i++)
            {
                _exportPriceData.Add(basePrice);
            }

            _exportSalesData = auxSales.ToList();
            //_exportDateData = auxDates.OfType<DateTime>().ToList();
            _exportDateData = _importDateData;
        }

        private int[] ConvertDateToDouble(DateTime[] datetimes)
        {
            int[] aux = new int[datetimes.Length];

            for (int i = 0; i< datetimes.Length; i++)
            {
                aux[i] = DateToMin(datetimes[i]);
            }

            return aux.ToArray();
        }
        
        //15% to 5%
        private int CalculateSales(double newPrice, double realSales)
        {
            double priceBaseReal = double.Parse(txtBasePrice.Text);
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

        private int DateToMin(DateTime datetime)
        {
            return (datetime.Year * 60 * 24 * 365) + 
                (datetime.Month * 60 * 24 * 365 / 12) + 
                (datetime.Day * 60 * 24);
        }

        private void CalculateBenefits_Click(object sender, EventArgs e)
        {
            double basePrice = double.Parse(txtBasePrice.Text);

            DateTime[] x = _importDateData.ToArray();
            double[] prices = _exportPriceData.ToArray();
            int[] sales = _exportSalesData.ToArray();
            double toatlValue = 0;
            
            for (int i=0; i< _exportSalesData.Count; i++)
            {
                toatlValue += (prices[i] * sales[i]); 
            }

            txtBenefitsReal.Text = (_importSalesData.Sum() * basePrice).ToString();
            txtBenefitAlg.Text = (toatlValue).ToString();
        }


        /*
        /// <summary>
        /// Generate dummy date for 2 months with min save sentions of mins
        /// </summary>
        private void GenerateRandomHistory()
        {
            ClearExportData();

            int num = 0;
            //2 months = 86400 min
            for (int i = 0; i<60; i++)
            {
                num = _random.Next(0, 100);


            }
        }

        private void ClearExportData()
        {
            _exportDateData = null;
            _exportSalesData = null;
        }*/
    }
}
