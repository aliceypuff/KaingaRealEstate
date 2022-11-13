
namespace KaingaRealEstate
{
    partial class UpdateSuburbForm
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
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSuburbName = new System.Windows.Forms.TextBox();
            this.txtSuburbID = new System.Windows.Forms.TextBox();
            this.cboSuburb = new System.Windows.Forms.ComboBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblSuburbName = new System.Windows.Forms.Label();
            this.lblSuburbID = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateSuburb = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblrequired1 = new System.Windows.Forms.Label();
            this.lblrequired2 = new System.Windows.Forms.Label();
            this.kaingaRealEstateDataSet = new KaingaRealEstate.KaingaRealEstateDataSet();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(195, 57);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(225, 19);
            this.lblInstruction1.TabIndex = 56;
            this.lblInstruction1.Text = "Please select a suburb to update:";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction2.Location = new System.Drawing.Point(195, 281);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(147, 19);
            this.lblInstruction2.TabIndex = 55;
            this.lblInstruction2.Text = "*Cannot be left blank";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostcode.Location = new System.Drawing.Point(199, 247);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(79, 27);
            this.txtPostcode.TabIndex = 53;
            this.txtPostcode.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtSuburbName
            // 
            this.txtSuburbName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuburbName.Location = new System.Drawing.Point(199, 199);
            this.txtSuburbName.Name = "txtSuburbName";
            this.txtSuburbName.Size = new System.Drawing.Size(272, 27);
            this.txtSuburbName.TabIndex = 51;
            this.txtSuburbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtSuburbID
            // 
            this.txtSuburbID.Location = new System.Drawing.Point(199, 151);
            this.txtSuburbID.Name = "txtSuburbID";
            this.txtSuburbID.ReadOnly = true;
            this.txtSuburbID.Size = new System.Drawing.Size(79, 27);
            this.txtSuburbID.TabIndex = 50;
            // 
            // cboSuburb
            // 
            this.cboSuburb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuburb.FormattingEnabled = true;
            this.cboSuburb.Location = new System.Drawing.Point(199, 103);
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(486, 27);
            this.cboSuburb.TabIndex = 49;
            this.cboSuburb.SelectedIndexChanged += new System.EventHandler(this.cboSuburb_SelectedIndexChanged);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(121, 250);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(72, 19);
            this.lblPostcode.TabIndex = 48;
            this.lblPostcode.Text = "Postcode:";
            this.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbName
            // 
            this.lblSuburbName.AutoSize = true;
            this.lblSuburbName.Location = new System.Drawing.Point(94, 202);
            this.lblSuburbName.Name = "lblSuburbName";
            this.lblSuburbName.Size = new System.Drawing.Size(99, 19);
            this.lblSuburbName.TabIndex = 45;
            this.lblSuburbName.Text = "Suburb Name:";
            this.lblSuburbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbID
            // 
            this.lblSuburbID.AutoSize = true;
            this.lblSuburbID.Location = new System.Drawing.Point(118, 154);
            this.lblSuburbID.Name = "lblSuburbID";
            this.lblSuburbID.Size = new System.Drawing.Size(75, 19);
            this.lblSuburbID.TabIndex = 44;
            this.lblSuburbID.Text = "Suburb ID:";
            this.lblSuburbID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(136, 106);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 43;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(454, 325);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateSuburb
            // 
            this.btnUpdateSuburb.Location = new System.Drawing.Point(69, 325);
            this.btnUpdateSuburb.Name = "btnUpdateSuburb";
            this.btnUpdateSuburb.Size = new System.Drawing.Size(231, 48);
            this.btnUpdateSuburb.TabIndex = 41;
            this.btnUpdateSuburb.Text = "Update Suburb";
            this.btnUpdateSuburb.UseVisualStyleBackColor = true;
            this.btnUpdateSuburb.Click += new System.EventHandler(this.btnUpdateSuburb_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 29);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Update Suburb";
            // 
            // lblrequired1
            // 
            this.lblrequired1.AutoSize = true;
            this.lblrequired1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired1.ForeColor = System.Drawing.Color.Red;
            this.lblrequired1.Location = new System.Drawing.Point(180, 239);
            this.lblrequired1.Name = "lblrequired1";
            this.lblrequired1.Size = new System.Drawing.Size(17, 19);
            this.lblrequired1.TabIndex = 57;
            this.lblrequired1.Text = "*";
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
            this.lblrequired2.TabIndex = 58;
            this.lblrequired2.Text = "*";
            // 
            // kaingaRealEstateDataSet
            // 
            this.kaingaRealEstateDataSet.DataSetName = "KaingaRealEstateDataSet";
            this.kaingaRealEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // UpdateSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 431);
            this.Controls.Add(this.lblrequired2);
            this.Controls.Add(this.lblrequired1);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtSuburbName);
            this.Controls.Add(this.txtSuburbID);
            this.Controls.Add(this.cboSuburb);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblSuburbName);
            this.Controls.Add(this.lblSuburbID);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateSuburb);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateSuburbForm";
            this.Text = "Update Suburbs";
            this.Load += new System.EventHandler(this.UpdateSuburbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSuburbName;
        private System.Windows.Forms.TextBox txtSuburbID;
        private System.Windows.Forms.ComboBox cboSuburb;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblSuburbName;
        private System.Windows.Forms.Label lblSuburbID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateSuburb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblrequired1;
        private System.Windows.Forms.Label lblrequired2;
        private KaingaRealEstateDataSet kaingaRealEstateDataSet;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
    }
}