using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPriceAlgorithm
{
    public partial class Grahps : Form
    {
        public string titule { get; set; }
        public DateTime[] x { get; set; }
        List<Serie> series = new List<Serie>();

        public Grahps()
        {
            InitializeComponent();
        }
        
        public Grahps(string titule, List<Serie> series, DateTime[] x = null) : this()
        {
            this.titule = titule;
            this.series = series;
        }

        public void ShowGrahpVaues()
        {
            this.Show();
            chart1.Titles.Clear();
            chart1.Titles.Add(titule);

            if (x == null || x.Length == 0)
            {
                x = series.First().x;
            }

            foreach (Serie serie in series)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    chart1.Series[serie.serieName].Enabled = true;
                    chart1.Series[serie.serieName].Points.AddXY(x[i], serie.y[i]);
                }
            }
        }

        public class Serie
        {
            public DateTime[] x { get; set; }
            public string serieName { get; set; }
            public double[] y { get; set; }

            public Serie(string serie, DateTime[] x, double[] y)
            {
                this.serieName = serie;
                this.x = x;
                this.y = y;
            }
        }
    }
}
