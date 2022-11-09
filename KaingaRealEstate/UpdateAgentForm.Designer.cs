
namespace KaingaRealEstate
{
    partial class UpdateAgentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblrequired2 = new System.Windows.Forms.Label();
            this.lblrequired1 = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAgentD = new System.Windows.Forms.Label();
            this.lblAgent = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateAgent = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblrequired2
            // 
            this.lblrequired2.AutoSize = true;
            this.lblrequired2.BackColor = System.Drawing.Color.Transparent;
            this.lblrequired2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired2.ForeColor = System.Drawing.Color.Red;
            this.lblrequired2.Location = new System.Drawing.Point(180, 191);
            this.lblrequired2.Margin = new System.Windows.Forms.Padding(0);
            this.lblrequired2.Name = "lblrequired2";
            this.lblrequired2.Size = new System.Drawing.Size(17, 19);
            this.lblrequired2.TabIndex = 73;
            this.lblrequired2.Text = "*";
            // 
            // lblrequired1
            // 
            this.lblrequired1.AutoSize = true;
            this.lblrequired1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired1.ForeColor = System.Drawing.Color.Red;
            this.lblrequired1.Location = new System.Drawing.Point(180, 239);
            this.lblrequired1.Name = "lblrequired1";
            this.lblrequired1.Size = new System.Drawing.Size(17, 19);
            this.lblrequired1.TabIndex = 72;
            this.lblrequired1.Text = "*";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(195, 57);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(226, 19);
            this.lblInstruction1.TabIndex = 71;
            this.lblInstruction1.Text = "Please select an agent to update:";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction2.Location = new System.Drawing.Point(204, 435);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(147, 19);
            this.lblInstruction2.TabIndex = 70;
            this.lblInstruction2.Text = "*Cannot be left blank";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(199, 247);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(272, 27);
            this.txtFirstName.TabIndex = 69;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(199, 199);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(272, 27);
            this.txtLastName.TabIndex = 68;
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(199, 151);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.ReadOnly = true;
            this.txtAgentID.Size = new System.Drawing.Size(79, 27);
            this.txtAgentID.TabIndex = 67;
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(199, 103);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(486, 27);
            this.cboAgent.TabIndex = 66;
            this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(110, 250);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 65;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(111, 202);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 64;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgentD
            // 
            this.lblAgentD.AutoSize = true;
            this.lblAgentD.Location = new System.Drawing.Point(124, 154);
            this.lblAgentD.Name = "lblAgentD";
            this.lblAgentD.Size = new System.Drawing.Size(69, 19);
            this.lblAgentD.TabIndex = 63;
            this.lblAgentD.Text = "Agent ID:";
            this.lblAgentD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(142, 106);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(51, 19);
            this.lblAgent.TabIndex = 62;
            this.lblAgent.Text = "Agent:";
            this.lblAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(454, 469);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 61;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.Location = new System.Drawing.Point(69, 469);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(231, 48);
            this.btnUpdateAgent.TabIndex = 60;
            this.btnUpdateAgent.Text = "Update Agent";
            this.btnUpdateAgent.UseVisualStyleBackColor = true;
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 29);
            this.lblTitle.TabIndex = 59;
            this.lblTitle.Text = "Update Agent";
            // 
            // UpdateAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 561);
            this.Controls.Add(this.lblrequired2);
            this.Controls.Add(this.lblrequired1);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.cboAgent);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAgentD);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateAgentForm";
            this.Text = "Update Agents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrequired2;
        private System.Windows.Forms.Label lblrequired1;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAgentD;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateAgent;
        private System.Windows.Forms.Label lblTitle;
    }
}