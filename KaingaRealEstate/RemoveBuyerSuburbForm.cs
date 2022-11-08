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
    public partial class RemoveBuyerSuburbForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private CurrencyManager cmBuyer;
        private int aBuyerID, aSuburbID;
        public RemoveBuyerSuburbForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControls();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void RemoveBuyerSuburbForm_Load(object sender, EventArgs e)
        {
            string buyerText = "";
            // clears cboBuyer Combobox
            cboBuyer.Items.Clear();

            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                buyerText += drBuyer["BuyerID"];
                buyerText += " " + drBuyer["LastName"];
                buyerText += ", " + drBuyer["FirstName"];
                cboBuyer.Items.Add(buyerText);
                buyerText = "";
            }

            string buyerSuburbText = "";
            // clears lstSuburbsAssigned ListBox
            lstSuburbsAssigned.Items.Clear();

            foreach (DataRow drBuyerSuburb in DC.dtBuyerSuburb.Rows)
            {
                buyerSuburbText += drBuyerSuburb["SuburbID"];
                buyerSuburbText += ", " + drBuyerSuburb["Importance"];
                lstSuburbsAssigned.Items.Add(buyerSuburbText);
                buyerSuburbText = "";
            }
        }
        public void bindControls()
        {
            // define currency manager items
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "Buyer"];

            // Bind DataController data to textbox
            // Buyer
            txtBuyerID.DataBindings.Add("Text", DC.dsKainga, "Buyer.BuyerID");
            txtLastName.DataBindings.Add("Text", DC.dsKainga, "Buyer.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsKainga, "Buyer.FirstName");

            // Show buyer suburb table to check if updated
            //dgvBuyerSuburb.DataSource = DC.dsKainga;
            //dgvBuyerSuburb.DataMember = "BuyerSuburb";
        }

        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buyer;

            if (cboBuyer.SelectedItem != null)
            {
                // get the selected buyer in the cboBuyer combobox
                buyer = cboBuyer.SelectedItem.ToString();
                // split the string from cboBuyer
                string[] parts = buyer.Split('\u002C');
                // extract buyerID
                //buyerID = Convert.ToInt32(parts[0]);
                // Get the position of the selected buyer and assigns it to the Position property of cmBuyer
                cmBuyer.Position = DC.buyerView.Find(buyerID);
                // Get the datarow for the selected buyer
                DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            }
        }
    }
}
// To do list:
// [x] Get all of the buyers
// [x] Display the list of all of the buyers (buyer id, last name, first name)
// [] Get the selected buyer’s details
// [] Display buyer’s details (buyer id, last name, first name, credit status)
// [] Get suburbs assigned to buyer
// [] Display list of buyer suburbs (suburb id, suburb name and importance)
// [] Delete suburb from buyer
// [] Display success message