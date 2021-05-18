using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestPriceAlgorithm.Utils;

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

        private List<int> _exportBaseSalesData = new List<int>();
        private List<double> _exportBasePriceData = new List<double>();

        enum KindBuyer
        {
            Cautious = 1,
            Occasional,
            Normal,
            Compulsive,
            Aggressive
        }

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
            cbPeriodType.DataSource = Enum.GetValues(typeof(PeriodType));
            cbExtraPeriodType.DataSource = Enum.GetValues(typeof(PeriodType));
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
            double cAmount = double.Parse(txtChangeAmount.Text);
            double maxPrice = double.Parse(txtMaxPrice.Text);
            double minPrice = double.Parse(txtMinPrice.Text);

            SetImport2FirstPeriods(period, basePrice);

            txtSingleValue.Text = AlgorithmFunctions.GetNewPrice(basePrice, period, periodType, _exportDateData, _exportSalesData, cAmount, maxPrice, minPrice).ToString();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            double cAmount = double.Parse(txtChangeAmount.Text);
            double maxPrice = double.Parse(txtMaxPrice.Text);
            double minPrice = double.Parse(txtMinPrice.Text);

            if (chbIncludeExtra.Checked && !ExtraFunctions.ValidateExtraConfiguration(txtPeriod.Text, tbExtraPeriod.Text,
                cbPeriodType.SelectedIndex, cbExtraPeriodType.SelectedIndex))
            {
                showError("There was an error format on period types.");
            }
            double basePrice = double.Parse(txtBasePrice.Text);
            int period = int.Parse(txtPeriod.Text);
            int periodType = cbPeriodType.SelectedIndex;
            double newPrice = basePrice;

            SetImport2FirstPeriods(period, basePrice);

            for (int i=period; i<_importDateData.Count; i++)
            {
                newPrice = AlgorithmFunctions.GetNewPrice(newPrice, period, periodType, _exportDateData, _exportSalesData, cAmount, maxPrice, minPrice);
                _exportPriceData.Add(newPrice);
                _exportSalesData.Add(AlgorithmFunctions.CalculateSales(newPrice, _importSalesData.ToArray()[i], double.Parse(txtBasePrice.Text)));
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
            if (chbIncludeExtra.Checked && !ExtraFunctions.ValidateExtraConfiguration(txtPeriod.Text, tbExtraPeriod.Text, 
                cbPeriodType.SelectedIndex, cbExtraPeriodType.SelectedIndex))
            {
                showError("There was an error format on period types.");
            }

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

        private void showError(string message)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            //string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }            
        }
    }
}
