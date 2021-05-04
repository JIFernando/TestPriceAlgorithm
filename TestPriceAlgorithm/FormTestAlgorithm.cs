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
    public partial class FormTestAlgorithm : Form
    {
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

        }

        private void btnImportCsv_Click(object sender, EventArgs e)
        {

        }

        private void btnSingleValue_Click(object sender, EventArgs e)
        {

        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Form formGraph = new Form();
            formGraph.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
