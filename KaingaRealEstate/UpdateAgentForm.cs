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
    public partial class UpdateAgentForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int aAgentID;
        private CurrencyManager cmAgent;
        public UpdateAgentForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmAgent = (CurrencyManager)this.BindingContext[DC.dsKainga, "AGENT"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void ClearFields()
        {
            txtAgentID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            nudSalary.ResetText();
            cboCert.Text = "";
            cboCert.Items.Clear();
            cboAgent.Text = "";
            cboAgent.Items.Clear();
        }
        private void LoadAgents()
        {
            foreach (DataRow drAgent in DC.dtAgent.Rows)
            {
                cboAgent.Items.Add(drAgent["agentID"] + (" ") + drAgent["lastName"] + (" ") + drAgent["firstName"]);
            }
        }

        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string agent;

            if (cboAgent.SelectedItem != null)
            {
                // get the selected agent
                agent = cboAgent.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = agent.Split(' ');
                // extract ID
                aAgentID = Convert.ToInt32(parts[0]);
                // Get the position of the selected agent and assigns it to the Position property of cmAgent
                cmAgent.Position = DC.suburbView.Find(aAgentID);
                // Get the datarow for the selected agent
                DataRow drAgent = DC.dtAgent.Rows[cmAgent.Position];
                // Populate agent textboxes
                txtAgentID.Text = drAgent["agentID"].ToString();
                txtLastName.Text = drAgent["lastName"].ToString();
                txtFirstName.Text = drAgent["firstName"].ToString();
                txtStreetAddress.Text = drAgent["streetAddress"].ToString();
                txtSuburb.Text = drAgent["suburb"].ToString();
                txtEmail.Text = drAgent["emailAddress"].ToString();
                txtPhone.Text = drAgent["phoneNumber"].ToString();
                nudSalary.Text = drAgent["salary"].ToString();
                cboCert.Text = drAgent["certification"].ToString();
            }
        }
        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            if (cboAgent.SelectedIndex == 0) // cannot click it if the agent is not selected 
            {
                // handle case where no agent has been selected
                MessageBox.Show("An agent hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAgentID.Text == "" || txtLastName.Text == "" || txtFirstName.Text == "" || txtStreetAddress.Text == "" || txtSuburb.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                // handle cases where any of the input fields are empty
                MessageBox.Show("One or more field is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get data row for selected agent
                DataRow updateAgentRow = DC.dtAgent.Rows[cmAgent.Position];
                // assign textbox values to updateAgentRow
                updateAgentRow["lastName"] = txtLastName.Text;
                updateAgentRow["firstName"] = txtFirstName.Text;
                updateAgentRow["streetAddress"] = txtStreetAddress.Text;
                updateAgentRow["suburb"] = txtSuburb.Text;
                updateAgentRow["emailAddress"] = txtEmail.Text;
                updateAgentRow["phoneNumber"] = txtPhone.Text;
                updateAgentRow["salary"] = nudSalary.Text;
                updateAgentRow["certification"] = cboCert.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this agent?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmAgent.EndCurrentEdit();
                    DC.UpdateAgent();
                    MessageBox.Show("Agent updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadAgents();
                }
            }
        }

        private void UpdateAgentForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadAgents();
        }
    }

}
