using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;
using TestPriceAlgorithm.Class;
using TestPriceAlgorithm.Factory;
using TestPriceAlgorithm.Utils;
using static TestPriceAlgorithm.Class.AggressiveBuyer;
using static TestPriceAlgorithm.Class.BuyerFactory;
using static TestPriceAlgorithm.Grahps;

namespace TestPriceAlgorithm
{
    public partial class FormTestAlgorithm : Form
    {
        private List<DateTime> _exportDateData  = new List<DateTime>();
        private List<int> _exportSalesData = new List<int>();
        private List<double> _exportPriceData = new List<double>();

        private List<int> _exportBaseSalesData = new List<int>();
        private List<double> _exportBasePriceData = new List<double>();

        private List<BuyerFactory> buyers = new List<BuyerFactory>();

        public List<Game> games = new List<Game>();
        public Game mediaOfGames = new Game();
        public Game simulation = new Game();
        
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
            defaultValuesTestAlgorithm();
        }

        private void FormTestAlgorithm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //this.groupBoxExtraConf.Visible = !this.groupBoxExtraConf.Visible;
            this.txtChangePercentage.Enabled = !this.txtChangePercentage.Enabled;
            this.txtExtraPeriod.Enabled = !this.txtExtraPeriod.Enabled;
            this.txtExtraStartPeriod.Enabled = !this.txtExtraStartPeriod.Enabled;
            this.cbExtraPeriodType.Enabled = !this.cbExtraPeriodType.Enabled;
        }

        private void btnGraphReal_Click(object sender, EventArgs e)
        {
            List<Serie> series = new List<Serie>();

            DateTime[] x = mediaOfGames.GetDateFrom();
            double[] y = mediaOfGames.GetSalesFromDouble();
            series.Add(new Serie(Constancts.Serie1, x, y));
            
            Grahps grahps = new Grahps(Constancts.ImportedTitule, series);
            grahps.ShowGrahpVaues();
        }

        private void btnImportCsv_Click(object sender, EventArgs e)
        {
            importMultiplefiles();
        }

        private void importMultiplefiles()
        {
            int columnDate = 0;
            int columnSales = 0;
            int columnPrice = 0;
            Game game = null;

            OpenFileDialog dr = new OpenFileDialog();

            dr.InitialDirectory = "d:\\";
            dr.Filter = "rcc files (*.rcc)|*.rcc|All files (*.*)|*.*";
            dr.FilterIndex = 2;
            dr.RestoreDirectory = true;
            dr.Multiselect = true;
            dr.Title = "Please Select Source File(s) for Conversion";

            if (dr.ShowDialog() == DialogResult.OK)
            {
                // Read the files
                foreach (String file in dr.FileNames)
                {
                    try
                    {
                        csvFileName.Text = csvFileName.Text + file + ";";

                        game = new Game();
                        game.gameName = file;
                        game.saleByDate = new List<SaleGame>();

                        string[] lines = System.IO.File.ReadAllLines(file);
                        int count = 0;
                        foreach (string line in lines)
                        {

                            string[] columns = line.Split(';');
                            if (count == 0)
                            {

                                for (int i = 0; i < columns.Length; i++)
                                {
                                    if (columns[i] == Constancts.DateTime)
                                    {
                                        columnDate = i;
                                    }
                                    else if (columns[i] == Constancts.Price)
                                    {
                                        columnPrice = i;
                                    }
                                    else if (columns[i] == Constancts.SalesByDay)
                                    {
                                        columnSales = i;
                                    }
                                }
                            }
                            else
                            {                                                                                   
                                if (count == 1)
                                {
                                    game.basePrice = double.Parse(columns[columnPrice]);
                                }
                                else if (count == lines.Length - 1)
                                {
                                    game.price = double.Parse(columns[columnPrice]);
                                }

                                game.saleByDate.Add(new SaleGame(
                                    (int)int.Parse(columns[columnSales])/1000,
                                    Convert.ToDateTime(columns[columnDate]), 
                                    double.Parse(columns[columnPrice])));
                                
                            }

                            count++;
                        }
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );

                        csvFileName.Text = Constancts.DefaultTextCSV;
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show(Constancts.ErrorImportData + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);

                        csvFileName.Text = Constancts.DefaultTextCSV;
                    }

                    games.Add(game);
                }
            }

            CalculateImportMedia();
        }

        private void CalculateImportMedia()
        {
            double mediaBasePrice = 0;
            double currentPrice = 0;
            int count = 0;
            Dictionary<int, List<DateTime>> dateTimes = new Dictionary<int, List<DateTime>>();
            Dictionary<int, List<double>> prices = new Dictionary<int, List<double>>();
            Dictionary<int, List<int>> sales = new Dictionary<int, List<int>>();

            List<DateTime> dates = null;
            List<double> ps = null;
            List<int> sl = null;

            DateTime mediaDateTime = DateTime.MinValue;
            double mediaPrice = 0;
            int mediaSales = 0;

            foreach (Game game in games)
            {
                mediaBasePrice += game.basePrice;       

                foreach (SaleGame sg in game.saleByDate.OrderBy(x => x.date).ToList())
                {
                    if (!dateTimes.ContainsKey(count))
                    {
                        dates = new List<DateTime>();
                        ps = new List<double>();
                        sl = new List<int>();

                        dates.Add(sg.date);
                        ps.Add(sg.price);
                        sl.Add(sg.sales);

                        dateTimes.Add(count, dates);
                        prices.Add(count, ps);
                        sales.Add(count, sl);
                    }
                    else
                    {
                        dates = dateTimes[count];
                        ps = prices[count];
                        sl = sales[count];

                        dates.Add(sg.date);
                        ps.Add(sg.price);
                        sl.Add(sg.sales);

                        dateTimes[count] = dates;
                        prices[count] = ps;
                        sales[count] = sl;
                    }
                    count++;
                }
                count = 0;
            }
            mediaOfGames.saleByDate = new List<SaleGame>();

            for (int i = 0; i < dateTimes.Keys.Count; i++)
            {
                double[] psA = prices[i].ToArray();
                double[] slA = sales[i].Select(x => (double)x).ToArray();

                int c = prices[i].Count;

                mediaDateTime = AlgorithmFunctions.AverageDateTime(dateTimes[i]);
                mediaPrice = AlgorithmFunctions.Average(c, psA, 0);
                mediaSales = (int)AlgorithmFunctions.Average(c, slA, 0);

                mediaOfGames.saleByDate.Add(new SaleGame(mediaSales, mediaDateTime, mediaPrice));

                if (i == dateTimes.Keys.Count - 1)
                {
                    currentPrice = mediaPrice;
                }
            }

            mediaBasePrice = mediaBasePrice / games.Count;

            mediaOfGames.gameName = Constancts.MediaName;
            mediaOfGames.basePrice = mediaBasePrice;
            mediaOfGames.price = currentPrice; 
        }

        private void btnSingleValue_Click(object sender, EventArgs e)
        {
            double basePrice = double.Parse(txtBasePrice.Text);
            int period = int.Parse(txtPeriod.Text);
            int periodType = cbPeriodType.SelectedIndex;
            double cAmount = double.Parse(txtChangeAmount.Text);
            double maxPrice = double.Parse(txtMaxPrice.Text);
            double minPrice = double.Parse(txtMinPrice.Text);            

            txtSingleValue.Text = AlgorithmFunctions.GetNewPrice(basePrice, period, periodType, _exportDateData, _exportSalesData, cAmount, maxPrice, minPrice).ToString();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (simulation == null || simulation.saleByDate.Count == 0)
            {
                DoSimulation();
            }

            double cAmount = double.Parse(txtChangeAmount.Text);
            double maxPrice = double.Parse(txtMaxPrice.Text);
            double minPrice = double.Parse(txtMinPrice.Text);

            if (chbIncludeExtra.Checked && !ExtraFunctions.ValidateExtraConfiguration(txtPeriod.Text, txtExtraPeriod.Text,
                cbPeriodType.SelectedIndex, cbExtraPeriodType.SelectedIndex))
            {
                showError(Constancts.ErrorMessagePeriodType);
            }
            else
            {
                DateTime[] x = simulation.GetDateFrom();
                double[] y = mediaOfGames.GetSalesFromDouble();
                double[] y2 = simulation.GetSalesFromDouble();
                double[] y3 = mediaOfGames.GetPricesFrom();
                double[] y4 = simulation.GetPricesFrom();
                double[] y5 = mediaOfGames.GetBenefitsFrom();
                double[] y6 = simulation.GetBenefitsFrom();

                //List<BuyerFactory> test = new List<BuyerFactory>();
                //List<BuyerFactory> test1 = new List<BuyerFactory>();
                //List<BuyerFactory> test2 = new List<BuyerFactory>();
                //List<BuyerFactory> test3 = new List<BuyerFactory>();
                //List<BuyerFactory> test4 = new List<BuyerFactory>();
                //List<BuyerFactory> test5 = new List<BuyerFactory>();
                //List<BuyerFactory> test6 = new List<BuyerFactory>();

                //test = buyers.Where(t => t.GameAlreadyBuy() && t.GetBuyerType() == KindBuyer.Normal).ToList();
                //test1 = buyers.Where(t => t.GameAlreadyBuy() && t.GetBuyerType() == KindBuyer.Aggressive).ToList();
                //test2 = buyers.Where(t => t.GameAlreadyBuy() && t.GetBuyerType() == KindBuyer.Compulsive).ToList();
                //test3 = buyers.Where(t => t.GameAlreadyBuy() && t.GetBuyerType() == KindBuyer.Occasional).ToList();
                //test4 = buyers.Where(t => t.GameAlreadyBuy() && t.GetBuyerType() == KindBuyer.Cautious).ToList();
                //test4 = buyers.Where(t => t.GameAlreadyBuy() && t.GetBuyerType() == KindBuyer.Random).ToList();
                //test5 = buyers.Where(t => t.GameAlreadyBuy()).ToList();

                double[] countAgg = ExtraFunctions.GetBuyersBy(buyers, x, typeof(AggressiveBuyerFactory));
                double[] countCom = ExtraFunctions.GetBuyersBy(buyers, x, typeof(CompulsiveBuyerFactory));
                double[] countNor = ExtraFunctions.GetBuyersBy(buyers, x, typeof(NormalBuyerFactory));
                double[] countOcc = ExtraFunctions.GetBuyersBy(buyers, x, typeof(OccasionalBuyerFactory));
                double[] countCau = ExtraFunctions.GetBuyersBy(buyers, x, typeof(CautiousBuyerFactory));
                double[] countRan = ExtraFunctions.GetBuyersBy(buyers, x, typeof(RandomBuyerFactory));

                List<Serie> series = new List<Serie>();
                List<Serie> series2 = new List<Serie>();
                List<Serie> series3 = new List<Serie>();
                List<Serie> series5 = new List<Serie>();

                if (mediaOfGames.saleByDate.Count != 0)
                {
                    series.Add(new Serie(Constancts.Serie1, x, y));
                    series2.Add(new Serie(Constancts.Serie3, x, y3));
                    series5.Add(new Serie(Constancts.Serie5, x, y5));
                }

                if (simulation.saleByDate.Count != 0)
                {
                    series.Add(new Serie(Constancts.Serie2, x, y2));
                    series2.Add(new Serie(Constancts.Serie4, x, y4));
                    series5.Add(new Serie(Constancts.Serie6, x, y6));

                    series3.Add(new Serie(Constancts.SerieAg, x, countAgg));
                    series3.Add(new Serie(Constancts.SerieCo, x, countCom));
                    series3.Add(new Serie(Constancts.SerieNo, x, countNor));
                    series3.Add(new Serie(Constancts.SerieOc, x, countOcc));
                    series3.Add(new Serie(Constancts.SerieCa, x, countCau));
                    series3.Add(new Serie(Constancts.SerieRa, x, countRan));
                }
                if (series.Count > 0)
                {
                    Grahps grahps = new Grahps(Constancts.CompareTitule, series, x);
                    grahps.ShowGrahpVaues();
                }
                if (series2.Count > 0)
                {
                    Grahps grahpsPrices = new Grahps(Constancts.ComparePricesTitule, series2, x);
                    grahpsPrices.ShowGrahpVaues();
                }
                if (series3.Count > 0)
                { 
                    Grahps grahpsBuyers = new Grahps(Constancts.CompareBuyersTitule, series3, x);
                    grahpsBuyers.ShowGrahpVaues();
                }
                if (series5.Count > 0)
                {
                    Grahps grahpsBenefits = new Grahps(Constancts.CompareBenefitsTitule, series5, x);
                    grahpsBenefits.ShowGrahpVaues();
                }
            }           
        }
        
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (chbIncludeExtra.Checked && !ExtraFunctions.ValidateExtraConfiguration(txtPeriod.Text, txtExtraPeriod.Text, 
                cbPeriodType.SelectedIndex, cbExtraPeriodType.SelectedIndex))
            {
                showError(Constancts.ErrorMessagePeriodType);
            }
            else
            {
                if (simulation == null || simulation.saleByDate.Count == 0)
                {
                    DoSimulation();
                }

                /*
                DateTime[] dates = _exportDateData.ToArray();
                int[] sales = _exportSalesData.ToArray();
                double[] prices = _exportPriceData.ToArray();
                */

                DateTime[] dates = simulation.GetDateFrom();
                int[] sales = simulation.GetSalesFrom();
                double[] prices = simulation.GetPricesFrom();

                var csv = new StringBuilder();

                csv.AppendLine("DateTime;SalesByDay;Price");

                for (int i = 0; i < dates.Length; i++)
                {
                    var newLine = string.Format("{0};{1};{2}", dates[i], sales[i], prices[i]);
                    csv.AppendLine(newLine);
                }

                File.WriteAllText(@"C:\Users\jimen\source\repos\TestPriceAlgorithm\testCSV\Test.csv", csv.ToString());
            }
        }

        public void export()
        {
            if (chbIncludeExtra.Checked && !ExtraFunctions.ValidateExtraConfiguration(txtPeriod.Text, txtExtraPeriod.Text,
                cbPeriodType.SelectedIndex, cbExtraPeriodType.SelectedIndex))
            {
                showError(Constancts.ErrorMessagePeriodType);
            }
            else
            {
                DateTime[] dates = simulation.GetDateFrom();
                int[] sales = simulation.GetSalesFrom();
                double[] prices = simulation.GetPricesFrom();

                var csv = new StringBuilder();

                csv.AppendLine("DateTime;SalesByDay;Price");

                for (int i = 0; i < _exportDateData.Count; i++)
                {
                    var newLine = string.Format("{0};{1};{2}", dates[i], sales[i], prices[i]);
                    csv.AppendLine(newLine);
                }

                File.WriteAllText(@"C:\Users\jimen\source\repos\TestPriceAlgorithm\testCSV\Test.csv", csv.ToString());
            }
        }
        
        private void CalculateBenefits_Click(object sender, EventArgs e)
        {
            if (mediaOfGames.GetSalesFrom().Length == 0 && simulation.GetSalesFrom().Length == 0)
            {
                showError(Constancts.ErrorMessagePeriodType);
            }
            else
            {
                double basePrice = double.Parse(txtBasePrice.Text);
                
                double[] prices = simulation.GetPricesFrom();
                int[] sales = simulation.GetSalesFrom();
                double toatlValue = 0;

                for (int i = 0; i < sales.Length; i++)
                {
                    toatlValue += (prices[i] * sales[i]);
                }

                txtBenefitsReal.Text = (mediaOfGames.GetSalesFrom().Sum() * basePrice).ToString();
                txtBenefitAlg.Text = (toatlValue).ToString();
            }
        }

        private void showError(string message)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            //string message = "You did not enter a server name. Cancel this operation?";
            string caption = Constancts.ErrorDefautInput;
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

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            DoSimulation();
        }

        private void DoSimulation()
        {
            double cAmount = double.Parse(txtChangeAmount.Text);
            double maxPrice = double.Parse(txtMaxPrice.Text);
            double minPrice = double.Parse(txtMinPrice.Text);
            double basePrice = double.Parse(txtBasePrice.Text);
            int period = int.Parse(txtPeriod.Text);
            int periodType = cbPeriodType.SelectedIndex;
            double newPrice = basePrice;
            int sales = 0;
            DateTime date = DateTime.Today;
            int monthsToSim = int.Parse(txtMonths.Text);

            simulation = new Game();

            buyers = GetBuyersConf(date);

            //List<BuyerFactory> test = new List<BuyerFactory>();
            //List<BuyerFactory> test1 = new List<BuyerFactory>();
            //List<BuyerFactory> test2 = new List<BuyerFactory>();
            //List<BuyerFactory> test3 = new List<BuyerFactory>();
            //List<BuyerFactory> test4 = new List<BuyerFactory>();

            simulation = new Game(Constancts.SimulationName, date, basePrice, basePrice, period);

            for (int i = 0; i < monthsToSim * 30; i++)
            {
                newPrice = AlgorithmFunctions.GetNewPrice(newPrice, period, periodType, simulation, cAmount, maxPrice, minPrice);
                sales = AlgorithmFunctions.CalculateSales(buyers, simulation, date);
                //test = buyers.Where(x => x.GameAlreadyBuy() && x.GetBuyerType() == KindBuyer.Normal).ToList();
                //test1 = buyers.Where(x => x.GameAlreadyBuy() && x.GetBuyerType() == KindBuyer.Aggressive).ToList();
                //test2 = buyers.Where(x => x.GameAlreadyBuy() && x.GetBuyerType() == KindBuyer.Compulsive).ToList();
                //test3 = buyers.Where(x => x.GameAlreadyBuy() && x.GetBuyerType() == KindBuyer.Occasional).ToList();
                //test4 = buyers.Where(x => x.GameAlreadyBuy() && x.GetBuyerType() == KindBuyer.Cautious).ToList();
                simulation.saleByDate.Add(new SaleGame(sales, date, newPrice));
                date = date.AddDays(1);
                simulation.price = newPrice;
                buyers.AddRange(GetBuyersConf(date, i < 6));
            }
        }

        private List<BuyerFactory> GetBuyersConf(DateTime date, bool first = true)
        {
            Random rnd = new Random();
            int buyersPerDay = (int)(int.Parse(txtNumbBuyers.Text) * rnd.NextDouble()),
                monthsToSim = int.Parse(txtMonths.Text);
            double buyCautious = double.Parse(txtCautiousBuyers.Text)/100,
                buyOccasional = double.Parse(txtOcaassionalBuyers.Text) / 100,
                buyNormal = double.Parse(txtNormalBuyers.Text) / 100,
                buyCompulsive = double.Parse(txtCompulsiveBuyers.Text) / 100,
                buyAggressive = double.Parse(txtAgressiveBuyers.Text) / 100,
                buyRandom = double.Parse(txtRandomBuyers.Text) / 100;

            List<BuyerFactory> buyers = new List<BuyerFactory>();

            buyers.AddRange(CreateBuyers(BuyerFactory.KindBuyer.Cautious, date, GetTotalBuyers(buyCautious, buyersPerDay, monthsToSim, first)));
            buyers.AddRange(CreateBuyers(BuyerFactory.KindBuyer.Occasional, date, GetTotalBuyers(buyOccasional, buyersPerDay, monthsToSim, first)));
            buyers.AddRange(CreateBuyers(BuyerFactory.KindBuyer.Normal, date, GetTotalBuyers(buyNormal, buyersPerDay, monthsToSim, first)));
            buyers.AddRange(CreateBuyers(BuyerFactory.KindBuyer.Compulsive, date, GetTotalBuyers(buyCompulsive, buyersPerDay, monthsToSim, first)));
            buyers.AddRange(CreateBuyers(BuyerFactory.KindBuyer.Aggressive, date, GetTotalBuyers(buyAggressive, buyersPerDay, monthsToSim, first)));
            buyers.AddRange(CreateBuyers(BuyerFactory.KindBuyer.Random, date, GetTotalBuyers(buyRandom, buyersPerDay, monthsToSim, first)));

            return buyers;
        }

        private int GetTotalBuyers(double percentaje, int byDay, int totalMonths, bool first)
        {
            int buyersCount = (int)(percentaje * byDay);

            if (first)
            {
                buyersCount = (int)(buyersCount * 5);
            }

            return buyersCount;
        }

        private List<BuyerFactory> CreateBuyers(BuyerFactory.KindBuyer kind, DateTime date, int total)
        {
            List<BuyerFactory> buyers = new List<BuyerFactory>();
            for (int i = 0; i<total; i++)
            {
                switch (kind)
                {
                    case BuyerFactory.KindBuyer.Cautious:
                        buyers.Add(new CautiousBuyerFactory(date));
                        break;
                    case BuyerFactory.KindBuyer.Occasional:
                        buyers.Add(new OccasionalBuyerFactory(date));
                        break;
                    case BuyerFactory.KindBuyer.Normal:
                        buyers.Add(new NormalBuyerFactory(date));
                        break;
                    case BuyerFactory.KindBuyer.Compulsive:
                        buyers.Add(new CompulsiveBuyerFactory(date));
                        break;
                    case BuyerFactory.KindBuyer.Aggressive:
                        buyers.Add(new AggressiveBuyerFactory(date));
                        break;
                    case BuyerFactory.KindBuyer.Random:
                        buyers.Add(new RandomBuyerFactory(date));
                        break;
                }          
            }
            return buyers;
        }
                
        private void defaultValuesTestAlgorithm()
        {
            txtPeriod.Text = "7";
            cbPeriodType.SelectedIndex = 1;
            txtChangeAmount.Text = "3";
            txtMaxPrice.Text = "40";
            txtMinPrice.Text = "10";
            txtBasePrice.Text = "20";
            txtMonths.Text = "6";

            txtNumbBuyers.Text = "30";
            txtCautiousBuyers.Text = "20";
            txtOcaassionalBuyers.Text = "10";
            txtNormalBuyers.Text = "40";
            txtCompulsiveBuyers.Text = "15";
            txtAgressiveBuyers.Text = "10";
            txtRandomBuyers.Text = "5";
        }
    }
}
