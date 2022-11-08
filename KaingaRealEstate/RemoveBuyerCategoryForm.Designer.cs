
namespace KaingaRealEstate
{
    partial class RemoveBuyerCategoryForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveBuyerCategory = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCategoriesAssigned = new System.Windows.Forms.Label();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.lstCategoriesAssigned = new System.Windows.Forms.ListBox();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(454, 469);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveBuyerCategory
            // 
            this.btnRemoveBuyerCategory.Location = new System.Drawing.Point(69, 469);
            this.btnRemoveBuyerCategory.Name = "btnRemoveBuyerCategory";
            this.btnRemoveBuyerCategory.Size = new System.Drawing.Size(231, 48);
            this.btnRemoveBuyerCategory.TabIndex = 7;
            this.btnRemoveBuyerCategory.Text = "Remove Buyer Category";
            this.btnRemoveBuyerCategory.UseVisualStyleBackColor = true;
            this.btnRemoveBuyerCategory.Click += new System.EventHandler(this.btnRemoveBuyerCategory_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Remove Buyer Category";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Location = new System.Drawing.Point(130, 106);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(50, 19);
            this.lblBuyer.TabIndex = 9;
            this.lblBuyer.Text = "Buyer:";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBuyer.Click += new System.EventHandler(this.lblBuyer_Click);
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(108, 154);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(68, 19);
            this.lblBuyerID.TabIndex = 10;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBuyerID.Click += new System.EventHandler(this.lblBuyerID_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(91, 202);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(88, 250);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblCategoriesAssigned
            // 
            this.lblCategoriesAssigned.AutoSize = true;
            this.lblCategoriesAssigned.Location = new System.Drawing.Point(11, 352);
            this.lblCategoriesAssigned.Name = "lblCategoriesAssigned";
            this.lblCategoriesAssigned.Size = new System.Drawing.Size(146, 19);
            this.lblCategoriesAssigned.TabIndex = 13;
            this.lblCategoriesAssigned.Text = "Categories Assigned:";
            this.lblCategoriesAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCategoriesAssigned.Click += new System.EventHandler(this.lblCategoriesAssigned_Click);
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(70, 298);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(96, 19);
            this.lblCreditStatus.TabIndex = 14;
            this.lblCreditStatus.Text = "Credit Status:";
            this.lblCreditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreditStatus.Click += new System.EventHandler(this.lblCreditStatus_Click);
            // 
            // cboBuyer
            // 
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(199, 103);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(486, 27);
            this.cboBuyer.TabIndex = 15;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(199, 151);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(79, 27);
            this.txtBuyerID.TabIndex = 16;
            this.txtBuyerID.TextChanged += new System.EventHandler(this.txtBuyerID_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(199, 199);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(272, 27);
            this.txtLastName.TabIndex = 17;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(199, 247);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(272, 27);
            this.txtFirstName.TabIndex = 18;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(199, 295);
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(79, 27);
            this.txtCreditStatus.TabIndex = 19;
            this.txtCreditStatus.TextChanged += new System.EventHandler(this.txtCreditStatus_TextChanged);
            // 
            // lstCategoriesAssigned
            // 
            this.lstCategoriesAssigned.FormattingEnabled = true;
            this.lstCategoriesAssigned.ItemHeight = 19;
            this.lstCategoriesAssigned.Location = new System.Drawing.Point(199, 352);
            this.lstCategoriesAssigned.Name = "lstCategoriesAssigned";
            this.lstCategoriesAssigned.Size = new System.Drawing.Size(530, 99);
            this.lstCategoriesAssigned.TabIndex = 20;
            this.lstCategoriesAssigned.SelectedIndexChanged += new System.EventHandler(this.lstCategoriesAssigned_SelectedIndexChanged);
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction2.Location = new System.Drawing.Point(195, 328);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(235, 19);
            this.lblInstruction2.TabIndex = 21;
            this.lblInstruction2.Text = "Please select a category to remove";
            this.lblInstruction2.Click += new System.EventHandler(this.lblInstruction2_Click);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(195, 57);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(292, 19);
            this.lblInstruction1.TabIndex = 22;
            this.lblInstruction1.Text = "Please select a buyer to remove a category:";
            this.lblInstruction1.Click += new System.EventHandler(this.lblInstruction1_Click);
            // 
            // RemoveBuyerCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 585);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lstCategoriesAssigned);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblCategoriesAssigned);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBuyerCategory);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveBuyerCategoryForm";
            this.Text = "Remove Buyer Category";
            this.Load += new System.EventHandler(this.RemoveBuyerCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveBuyerCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCategoriesAssigned;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.ListBox lstCategoriesAssigned;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblInstruction1;
    }
}