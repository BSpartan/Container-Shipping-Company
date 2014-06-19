namespace ContainerShippingCompany
{
    partial class containerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(containerForm));
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.cbMotherCompany = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbCompanyKvk = new System.Windows.Forms.TextBox();
            this.tbContactPerson = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lblNewCompany = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBCompany = new System.Windows.Forms.ListBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblAddContainers = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbGPSCode = new System.Windows.Forms.TextBox();
            this.lblGPSCode = new System.Windows.Forms.Label();
            this.NUPWeight = new System.Windows.Forms.NumericUpDown();
            this.btAddContainer = new System.Windows.Forms.Button();
            this.lblComanyLabel = new System.Windows.Forms.Label();
            this.lblCompanySelected = new System.Windows.Forms.Label();
            this.pnlCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompany
            // 
            this.pnlCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompany.Controls.Add(this.cbMotherCompany);
            this.pnlCompany.Controls.Add(this.button2);
            this.pnlCompany.Controls.Add(this.tbCompanyKvk);
            this.pnlCompany.Controls.Add(this.tbContactPerson);
            this.pnlCompany.Controls.Add(this.tbCompanyName);
            this.pnlCompany.Controls.Add(this.lblNewCompany);
            this.pnlCompany.Controls.Add(this.tbSearch);
            this.pnlCompany.Controls.Add(this.button1);
            this.pnlCompany.Controls.Add(this.listBCompany);
            this.pnlCompany.Controls.Add(this.lblCompany);
            this.pnlCompany.Location = new System.Drawing.Point(498, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(264, 493);
            this.pnlCompany.TabIndex = 0;
            // 
            // cbMotherCompany
            // 
            this.cbMotherCompany.FormattingEnabled = true;
            this.cbMotherCompany.Location = new System.Drawing.Point(25, 410);
            this.cbMotherCompany.Name = "cbMotherCompany";
            this.cbMotherCompany.Size = new System.Drawing.Size(203, 24);
            this.cbMotherCompany.TabIndex = 9;
            this.cbMotherCompany.Text = "Moeder bedrijf";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Toevoegen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbCompanyKvk
            // 
            this.tbCompanyKvk.Location = new System.Drawing.Point(25, 381);
            this.tbCompanyKvk.Name = "tbCompanyKvk";
            this.tbCompanyKvk.Size = new System.Drawing.Size(203, 22);
            this.tbCompanyKvk.TabIndex = 7;
            this.tbCompanyKvk.Text = "Kvk nummer";
            // 
            // tbContactPerson
            // 
            this.tbContactPerson.Location = new System.Drawing.Point(25, 353);
            this.tbContactPerson.Name = "tbContactPerson";
            this.tbContactPerson.Size = new System.Drawing.Size(203, 22);
            this.tbContactPerson.TabIndex = 6;
            this.tbContactPerson.Text = "Contact persoon";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(25, 325);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(203, 22);
            this.tbCompanyName.TabIndex = 5;
            this.tbCompanyName.Text = "Bedrijfsnaam";
            // 
            // lblNewCompany
            // 
            this.lblNewCompany.AutoSize = true;
            this.lblNewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCompany.Location = new System.Drawing.Point(21, 287);
            this.lblNewCompany.Name = "lblNewCompany";
            this.lblNewCompany.Size = new System.Drawing.Size(106, 20);
            this.lblNewCompany.TabIndex = 4;
            this.lblNewCompany.Text = "Nieuw bedrijf";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(25, 54);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(203, 22);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.Text = "Zoeken..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecteer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBCompany
            // 
            this.listBCompany.FormattingEnabled = true;
            this.listBCompany.ItemHeight = 16;
            this.listBCompany.Location = new System.Drawing.Point(25, 96);
            this.listBCompany.Name = "listBCompany";
            this.listBCompany.Size = new System.Drawing.Size(203, 132);
            this.listBCompany.TabIndex = 1;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(21, 12);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(62, 24);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Bedrijf";
            // 
            // lblAddContainers
            // 
            this.lblAddContainers.AutoSize = true;
            this.lblAddContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddContainers.Location = new System.Drawing.Point(21, 13);
            this.lblAddContainers.Name = "lblAddContainers";
            this.lblAddContainers.Size = new System.Drawing.Size(195, 24);
            this.lblAddContainers.TabIndex = 10;
            this.lblAddContainers.Text = "Containers toevoegen";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(114, 106);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 24);
            this.cbType.TabIndex = 12;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(23, 153);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 17);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Gewicht";
            // 
            // tbGPSCode
            // 
            this.tbGPSCode.Location = new System.Drawing.Point(114, 205);
            this.tbGPSCode.Name = "tbGPSCode";
            this.tbGPSCode.Size = new System.Drawing.Size(200, 22);
            this.tbGPSCode.TabIndex = 16;
            // 
            // lblGPSCode
            // 
            this.lblGPSCode.AutoSize = true;
            this.lblGPSCode.Location = new System.Drawing.Point(23, 205);
            this.lblGPSCode.Name = "lblGPSCode";
            this.lblGPSCode.Size = new System.Drawing.Size(72, 17);
            this.lblGPSCode.TabIndex = 15;
            this.lblGPSCode.Text = "GPS code";
            // 
            // NUPWeight
            // 
            this.NUPWeight.Location = new System.Drawing.Point(114, 153);
            this.NUPWeight.Maximum = new decimal(new int[] {
            26000,
            0,
            0,
            0});
            this.NUPWeight.Name = "NUPWeight";
            this.NUPWeight.Size = new System.Drawing.Size(200, 22);
            this.NUPWeight.TabIndex = 17;
            // 
            // btAddContainer
            // 
            this.btAddContainer.Location = new System.Drawing.Point(203, 257);
            this.btAddContainer.Name = "btAddContainer";
            this.btAddContainer.Size = new System.Drawing.Size(111, 27);
            this.btAddContainer.TabIndex = 10;
            this.btAddContainer.Text = "Toevoegen";
            this.btAddContainer.UseVisualStyleBackColor = true;
            this.btAddContainer.Click += new System.EventHandler(this.btAddContainer_Click);
            // 
            // lblComanyLabel
            // 
            this.lblComanyLabel.AutoSize = true;
            this.lblComanyLabel.Location = new System.Drawing.Point(23, 64);
            this.lblComanyLabel.Name = "lblComanyLabel";
            this.lblComanyLabel.Size = new System.Drawing.Size(48, 17);
            this.lblComanyLabel.TabIndex = 18;
            this.lblComanyLabel.Text = "Bedrijf";
            // 
            // lblCompanySelected
            // 
            this.lblCompanySelected.AutoSize = true;
            this.lblCompanySelected.Location = new System.Drawing.Point(111, 64);
            this.lblCompanySelected.Name = "lblCompanySelected";
            this.lblCompanySelected.Size = new System.Drawing.Size(0, 17);
            this.lblCompanySelected.TabIndex = 19;
            // 
            // containerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.lblCompanySelected);
            this.Controls.Add(this.lblComanyLabel);
            this.Controls.Add(this.btAddContainer);
            this.Controls.Add(this.NUPWeight);
            this.Controls.Add(this.tbGPSCode);
            this.Controls.Add(this.lblGPSCode);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAddContainers);
            this.Controls.Add(this.pnlCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 540);
            this.MinimumSize = new System.Drawing.Size(780, 540);
            this.Name = "containerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Containers toevoegen";
            this.pnlCompany.ResumeLayout(false);
            this.pnlCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.ComboBox cbMotherCompany;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCompanyKvk;
        private System.Windows.Forms.TextBox tbContactPerson;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lblNewCompany;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblAddContainers;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbGPSCode;
        private System.Windows.Forms.Label lblGPSCode;
        private System.Windows.Forms.NumericUpDown NUPWeight;
        private System.Windows.Forms.Button btAddContainer;
        private System.Windows.Forms.Label lblComanyLabel;
        private System.Windows.Forms.Label lblCompanySelected;

    }
}