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
    public partial class RemoveBuyerCategoryForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        public RemoveBuyerCategoryForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
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

        private void RemoveBuyerCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBuyer_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruction1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuyerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBuyerID_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblCreditStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoriesAssigned_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lstCategoriesAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblInstruction2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveBuyerCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtCreditStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
