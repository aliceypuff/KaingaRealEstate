using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class SuburbReportForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        public SuburbReportForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

        }

        private void SuburbReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
