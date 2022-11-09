
namespace KaingaRealEstate
{
    partial class RemoveBuyerSuburbForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lstSuburbsAssigned = new System.Windows.Forms.ListBox();
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.lblSuburbsAssigned = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveBuyerSuburb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 29);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Remove Buyer Suburb";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(195, 57);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(280, 19);
            this.lblInstruction1.TabIndex = 39;
            this.lblInstruction1.Text = "Please select a buyer to remove a suburb:";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction2.Location = new System.Drawing.Point(195, 328);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(222, 19);
            this.lblInstruction2.TabIndex = 38;
            this.lblInstruction2.Text = "Please select a suburb to remove";
            // 
            // lstSuburbsAssigned
            // 
            this.lstSuburbsAssigned.FormattingEnabled = true;
            this.lstSuburbsAssigned.ItemHeight = 19;
            this.lstSuburbsAssigned.Location = new System.Drawing.Point(199, 352);
            this.lstSuburbsAssigned.Name = "lstSuburbsAssigned";
            this.lstSuburbsAssigned.Size = new System.Drawing.Size(486, 99);
            this.lstSuburbsAssigned.TabIndex = 37;
            this.lstSuburbsAssigned.SelectedIndexChanged += new System.EventHandler(this.lstSuburbsAssigned_SelectedIndexChanged);
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(199, 295);
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(79, 27);
            this.txtCreditStatus.TabIndex = 36;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(199, 247);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(272, 27);
            this.txtFirstName.TabIndex = 35;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(199, 199);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(272, 27);
            this.txtLastName.TabIndex = 34;
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(199, 151);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(79, 27);
            this.txtBuyerID.TabIndex = 33;
            // 
            // cboBuyer
            // 
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(199, 103);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(486, 27);
            this.cboBuyer.TabIndex = 32;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(97, 298);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(96, 19);
            this.lblCreditStatus.TabIndex = 31;
            this.lblCreditStatus.Text = "Credit Status:";
            this.lblCreditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbsAssigned
            // 
            this.lblSuburbsAssigned.AutoSize = true;
            this.lblSuburbsAssigned.Location = new System.Drawing.Point(65, 352);
            this.lblSuburbsAssigned.Name = "lblSuburbsAssigned";
            this.lblSuburbsAssigned.Size = new System.Drawing.Size(127, 19);
            this.lblSuburbsAssigned.TabIndex = 30;
            this.lblSuburbsAssigned.Text = "Assigned Suburbs:";
            this.lblSuburbsAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(110, 250);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(110, 202);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(125, 154);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(68, 19);
            this.lblBuyerID.TabIndex = 27;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Location = new System.Drawing.Point(143, 106);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(50, 19);
            this.lblBuyer.TabIndex = 26;
            this.lblBuyer.Text = "Buyer:";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(454, 469);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveBuyerSuburb
            // 
            this.btnRemoveBuyerSuburb.Location = new System.Drawing.Point(69, 469);
            this.btnRemoveBuyerSuburb.Name = "btnRemoveBuyerSuburb";
            this.btnRemoveBuyerSuburb.Size = new System.Drawing.Size(231, 48);
            this.btnRemoveBuyerSuburb.TabIndex = 24;
            this.btnRemoveBuyerSuburb.Text = "Remove Buyer Suburb";
            this.btnRemoveBuyerSuburb.UseVisualStyleBackColor = true;
            this.btnRemoveBuyerSuburb.Click += new System.EventHandler(this.btnRemoveBuyerSuburb_Click);
            // 
            // RemoveBuyerSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 563);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lstSuburbsAssigned);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblSuburbsAssigned);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBuyerSuburb);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveBuyerSuburbForm";
            this.Text = "Remove Buyer Suburbs";
            this.Load += new System.EventHandler(this.RemoveBuyerSuburbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.ListBox lstSuburbsAssigned;
        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.Label lblSuburbsAssigned;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveBuyerSuburb;
    }
}