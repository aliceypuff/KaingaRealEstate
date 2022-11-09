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
    public partial class UpdateSuburbForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        private int aSuburbID;
        private CurrencyManager cmSuburb;
        public UpdateSuburbForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmSuburb = (CurrencyManager)this.BindingContext[DC.dsKainga, "SUBURB"];
        }
        private void ClearFields()
        {
            txtSuburbID.Text = "";
            txtSuburbName.Text = "";
            txtPostcode.Text = "";
            cboSuburb.Text = "";
            cboSuburb.Items.Clear();
        }
        private void LoadSuburbs()
        {
            foreach (DataRow drSuburb in DC.dtSuburb.Rows)
            {
            cboSuburb.Items.Add(drSuburb["suburbID"] + (" ") + drSuburb["suburbName"] + (" ") + drSuburb["postcode"]);
            }
        }
        private void UpdateSuburbForm_Load(object sender, EventArgs e)
        {
            LoadSuburbs();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void cboSuburb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string suburb;

            if (cboSuburb.SelectedItem != null)
            {
                // get the selected suburb
                suburb = cboSuburb.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = suburb.Split(' ');
                // extract ID
                aSuburbID = Convert.ToInt32(parts[0]);
                // Get the position of the selected suburb and assigns it to the Position property of cmSuburb
                cmSuburb.Position = DC.suburbView.Find(aSuburbID);
                // Get the datarow for the selected suburb
                DataRow drSuburb = DC.dtSuburb.Rows[cmSuburb.Position];
                // Populate suburb textboxes
                txtSuburbID.Text = drSuburb["suburbID"].ToString();
                txtSuburbName.Text = drSuburb["suburbName"].ToString();
                txtPostcode.Text = drSuburb["postcode"].ToString();
            }
        }
        private void btnUpdateSuburb_Click(object sender, EventArgs e)
        {
            if (cboSuburb.SelectedIndex == 0) // cannot click it if the suburb is not selected 
            {
                // handle case where no suburb has been selected
                MessageBox.Show("A suburb hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSuburbID.Text == "" || txtSuburbName.Text == "" || txtPostcode.Text == "")
            {
                // handle cases where any of the input fields are empty
                MessageBox.Show("One or more field is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get data row for selected suburb
                DataRow updateSuburbRow = DC.dtSuburb.Rows[cmSuburb.Position];
                // assign textbox values to updateSuburbRow
                updateSuburbRow["suburbName"] = txtSuburbName.Text;
                updateSuburbRow["postcode"] = txtPostcode.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this suburb?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmSuburb.EndCurrentEdit();
                    DC.UpdateSuburb();
                    MessageBox.Show("Suburb updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadSuburbs();
                }
            }
        }   
    }   
}
