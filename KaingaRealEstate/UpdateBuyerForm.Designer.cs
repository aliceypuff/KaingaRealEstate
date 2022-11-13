
namespace KaingaRealEstate
{
    partial class UpdateBuyerForm
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.buyercategoryTableAdapter1 = new KaingaRealEstate.KaingaRealEstateDataSetTableAdapters.BUYERCATEGORYTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.cboCreditStatus = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblrequired2 = new System.Windows.Forms.Label();
            this.lblrequired1 = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateBuyer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAgentFirstName = new System.Windows.Forms.TextBox();
            this.txtAgentLastName = new System.Windows.Forms.TextBox();
            this.lblAgentFirstName = new System.Windows.Forms.Label();
            this.lblAgentLastName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMortgageStatus = new System.Windows.Forms.Label();
            this.cboMortStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(180, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 160;
            this.label6.Text = "*";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(153, 304);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 19);
            this.lblCity.TabIndex = 159;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCity.Location = new System.Drawing.Point(199, 301);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(245, 27);
            this.txtCity.TabIndex = 158;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // buyercategoryTableAdapter1
            // 
            this.buyercategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(575, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 157;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(180, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 156;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(180, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 155;
            this.label4.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 154;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(180, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 153;
            this.label2.Text = "*";
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(496, 374);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(96, 19);
            this.lblCreditStatus.TabIndex = 152;
            this.lblCreditStatus.Text = "Credit Status:";
            this.lblCreditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCreditStatus
            // 
            this.cboCreditStatus.FormattingEnabled = true;
            this.cboCreditStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboCreditStatus.Location = new System.Drawing.Point(592, 371);
            this.cboCreditStatus.Name = "cboCreditStatus";
            this.cboCreditStatus.Size = new System.Drawing.Size(93, 27);
            this.cboCreditStatus.TabIndex = 151;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(86, 371);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(108, 19);
            this.lblPhone.TabIndex = 150;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(199, 367);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 27);
            this.txtPhone.TabIndex = 149;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(88, 338);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 19);
            this.lblEmail.TabIndex = 148;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(199, 334);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 27);
            this.txtEmail.TabIndex = 147;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(136, 271);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 146;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSuburb
            // 
            this.txtSuburb.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuburb.Location = new System.Drawing.Point(199, 268);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(245, 27);
            this.txtSuburb.TabIndex = 145;
            this.txtSuburb.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(86, 238);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblStreetAddress.TabIndex = 144;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtStreetAddress.Location = new System.Drawing.Point(199, 235);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(486, 27);
            this.txtStreetAddress.TabIndex = 143;
            this.txtStreetAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblrequired2
            // 
            this.lblrequired2.AutoSize = true;
            this.lblrequired2.BackColor = System.Drawing.Color.Transparent;
            this.lblrequired2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired2.ForeColor = System.Drawing.Color.Red;
            this.lblrequired2.Location = new System.Drawing.Point(180, 161);
            this.lblrequired2.Margin = new System.Windows.Forms.Padding(0);
            this.lblrequired2.Name = "lblrequired2";
            this.lblrequired2.Size = new System.Drawing.Size(17, 19);
            this.lblrequired2.TabIndex = 142;
            this.lblrequired2.Text = "*";
            // 
            // lblrequired1
            // 
            this.lblrequired1.AutoSize = true;
            this.lblrequired1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired1.ForeColor = System.Drawing.Color.Red;
            this.lblrequired1.Location = new System.Drawing.Point(180, 194);
            this.lblrequired1.Name = "lblrequired1";
            this.lblrequired1.Size = new System.Drawing.Size(17, 19);
            this.lblrequired1.TabIndex = 141;
            this.lblrequired1.Text = "*";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(195, 57);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(217, 19);
            this.lblInstruction1.TabIndex = 140;
            this.lblInstruction1.Text = "Please select a buyer to update:";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction2.Location = new System.Drawing.Point(204, 470);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(147, 19);
            this.lblInstruction2.TabIndex = 139;
            this.lblInstruction2.Text = "*Cannot be left blank";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(199, 202);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(272, 27);
            this.txtFirstName.TabIndex = 138;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(199, 169);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(272, 27);
            this.txtLastName.TabIndex = 137;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(199, 136);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(79, 27);
            this.txtBuyerID.TabIndex = 136;
            // 
            // cboBuyer
            // 
            this.cboBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(199, 103);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(486, 27);
            this.cboBuyer.TabIndex = 135;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(110, 205);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 134;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(111, 172);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 133;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(124, 139);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(68, 19);
            this.lblBuyerID.TabIndex = 132;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(142, 106);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(50, 19);
            this.lblSeller.TabIndex = 131;
            this.lblSeller.Text = "Buyer:";
            this.lblSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.CausesValidation = false;
            this.btnReturn.Location = new System.Drawing.Point(454, 504);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 130;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateBuyer
            // 
            this.btnUpdateBuyer.Location = new System.Drawing.Point(69, 504);
            this.btnUpdateBuyer.Name = "btnUpdateBuyer";
            this.btnUpdateBuyer.Size = new System.Drawing.Size(231, 48);
            this.btnUpdateBuyer.TabIndex = 129;
            this.btnUpdateBuyer.Text = "Update Buyer";
            this.btnUpdateBuyer.UseVisualStyleBackColor = true;
            this.btnUpdateBuyer.Click += new System.EventHandler(this.btnUpdateBuyer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 29);
            this.lblTitle.TabIndex = 128;
            this.lblTitle.Text = "Update Buyer";
            // 
            // txtAgentFirstName
            // 
            this.txtAgentFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAgentFirstName.Location = new System.Drawing.Point(199, 433);
            this.txtAgentFirstName.Name = "txtAgentFirstName";
            this.txtAgentFirstName.ReadOnly = true;
            this.txtAgentFirstName.Size = new System.Drawing.Size(272, 27);
            this.txtAgentFirstName.TabIndex = 164;
            // 
            // txtAgentLastName
            // 
            this.txtAgentLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAgentLastName.Location = new System.Drawing.Point(199, 400);
            this.txtAgentLastName.Name = "txtAgentLastName";
            this.txtAgentLastName.ReadOnly = true;
            this.txtAgentLastName.Size = new System.Drawing.Size(272, 27);
            this.txtAgentLastName.TabIndex = 163;
            // 
            // lblAgentFirstName
            // 
            this.lblAgentFirstName.AutoSize = true;
            this.lblAgentFirstName.Location = new System.Drawing.Point(69, 436);
            this.lblAgentFirstName.Name = "lblAgentFirstName";
            this.lblAgentFirstName.Size = new System.Drawing.Size(125, 19);
            this.lblAgentFirstName.TabIndex = 162;
            this.lblAgentFirstName.Text = "Agent First Name:";
            this.lblAgentFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgentLastName
            // 
            this.lblAgentLastName.AutoSize = true;
            this.lblAgentLastName.Location = new System.Drawing.Point(70, 403);
            this.lblAgentLastName.Name = "lblAgentLastName";
            this.lblAgentLastName.Size = new System.Drawing.Size(124, 19);
            this.lblAgentLastName.TabIndex = 161;
            this.lblAgentLastName.Text = "Agent Last Name:";
            this.lblAgentLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(526, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 167;
            this.label7.Text = "*";
            // 
            // lblMortgageStatus
            // 
            this.lblMortgageStatus.AutoSize = true;
            this.lblMortgageStatus.Location = new System.Drawing.Point(417, 139);
            this.lblMortgageStatus.Name = "lblMortgageStatus";
            this.lblMortgageStatus.Size = new System.Drawing.Size(120, 19);
            this.lblMortgageStatus.TabIndex = 166;
            this.lblMortgageStatus.Text = "Mortgage Status:";
            this.lblMortgageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMortStatus
            // 
            this.cboMortStatus.FormattingEnabled = true;
            this.cboMortStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboMortStatus.Location = new System.Drawing.Point(543, 136);
            this.cboMortStatus.Name = "cboMortStatus";
            this.cboMortStatus.Size = new System.Drawing.Size(142, 27);
            this.cboMortStatus.TabIndex = 165;
            // 
            // UpdateBuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 599);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMortgageStatus);
            this.Controls.Add(this.cboMortStatus);
            this.Controls.Add(this.txtAgentFirstName);
            this.Controls.Add(this.txtAgentLastName);
            this.Controls.Add(this.lblAgentFirstName);
            this.Controls.Add(this.lblAgentLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.cboCreditStatus);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblrequired2);
            this.Controls.Add(this.lblrequired1);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateBuyer);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateBuyerForm";
            this.Text = "Update Buyers";
            this.Load += new System.EventHandler(this.UpdateBuyerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.ComboBox cboCreditStatus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblrequired2;
        private System.Windows.Forms.Label lblrequired1;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateBuyer;
        private System.Windows.Forms.Label lblTitle;
        private KaingaRealEstateDataSetTableAdapters.BUYERCATEGORYTableAdapter buyercategoryTableAdapter1;
        private System.Windows.Forms.TextBox txtAgentFirstName;
        private System.Windows.Forms.TextBox txtAgentLastName;
        private System.Windows.Forms.Label lblAgentFirstName;
        private System.Windows.Forms.Label lblAgentLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMortgageStatus;
        private System.Windows.Forms.ComboBox cboMortStatus;
    }
}