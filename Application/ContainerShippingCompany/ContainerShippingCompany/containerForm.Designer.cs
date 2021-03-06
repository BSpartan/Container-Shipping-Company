﻿namespace ContainerShippingCompany
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
            this.lblErrorCompany = new System.Windows.Forms.Label();
            this.btDeleteContainers = new System.Windows.Forms.Button();
            this.cbMotherCompany = new System.Windows.Forms.ComboBox();
            this.btAddCompany = new System.Windows.Forms.Button();
            this.tbCompanyKvk = new System.Windows.Forms.TextBox();
            this.tbContactPerson = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lblNewCompany = new System.Windows.Forms.Label();
            this.btSelectCompany = new System.Windows.Forms.Button();
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
            this.lbError = new System.Windows.Forms.Label();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.lbDestination = new System.Windows.Forms.Label();
            this.pnlCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompany
            // 
            this.pnlCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompany.Controls.Add(this.lblErrorCompany);
            this.pnlCompany.Controls.Add(this.btDeleteContainers);
            this.pnlCompany.Controls.Add(this.cbMotherCompany);
            this.pnlCompany.Controls.Add(this.btAddCompany);
            this.pnlCompany.Controls.Add(this.tbCompanyKvk);
            this.pnlCompany.Controls.Add(this.tbContactPerson);
            this.pnlCompany.Controls.Add(this.tbCompanyName);
            this.pnlCompany.Controls.Add(this.lblNewCompany);
            this.pnlCompany.Controls.Add(this.btSelectCompany);
            this.pnlCompany.Controls.Add(this.listBCompany);
            this.pnlCompany.Controls.Add(this.lblCompany);
            this.pnlCompany.Location = new System.Drawing.Point(499, 0);
            this.pnlCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(263, 500);
            this.pnlCompany.TabIndex = 0;
            // 
            // lblErrorCompany
            // 
            this.lblErrorCompany.AutoSize = true;
            this.lblErrorCompany.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCompany.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCompany.Location = new System.Drawing.Point(29, 315);
            this.lblErrorCompany.Name = "lblErrorCompany";
            this.lblErrorCompany.Size = new System.Drawing.Size(0, 17);
            this.lblErrorCompany.TabIndex = 21;
            // 
            // btDeleteContainers
            // 
            this.btDeleteContainers.Location = new System.Drawing.Point(25, 182);
            this.btDeleteContainers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteContainers.Name = "btDeleteContainers";
            this.btDeleteContainers.Size = new System.Drawing.Size(115, 49);
            this.btDeleteContainers.TabIndex = 10;
            this.btDeleteContainers.Text = "Verwijder containers";
            this.btDeleteContainers.UseVisualStyleBackColor = true;
            this.btDeleteContainers.Visible = false;
            this.btDeleteContainers.Click += new System.EventHandler(this.btDeleteContainers_Click);
            // 
            // cbMotherCompany
            // 
            this.cbMotherCompany.FormattingEnabled = true;
            this.cbMotherCompany.Location = new System.Drawing.Point(25, 423);
            this.cbMotherCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMotherCompany.Name = "cbMotherCompany";
            this.cbMotherCompany.Size = new System.Drawing.Size(204, 24);
            this.cbMotherCompany.TabIndex = 9;
            this.cbMotherCompany.Text = "Moeder bedrijf";
            // 
            // btAddCompany
            // 
            this.btAddCompany.Location = new System.Drawing.Point(111, 454);
            this.btAddCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddCompany.Name = "btAddCompany";
            this.btAddCompany.Size = new System.Drawing.Size(119, 27);
            this.btAddCompany.TabIndex = 8;
            this.btAddCompany.Text = "Toevoegen";
            this.btAddCompany.UseVisualStyleBackColor = true;
            this.btAddCompany.Click += new System.EventHandler(this.btAddCompany_Click);
            // 
            // tbCompanyKvk
            // 
            this.tbCompanyKvk.Location = new System.Drawing.Point(25, 395);
            this.tbCompanyKvk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCompanyKvk.Name = "tbCompanyKvk";
            this.tbCompanyKvk.Size = new System.Drawing.Size(204, 22);
            this.tbCompanyKvk.TabIndex = 7;
            this.tbCompanyKvk.Text = "Kvk nummer";
            this.tbCompanyKvk.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // tbContactPerson
            // 
            this.tbContactPerson.Location = new System.Drawing.Point(25, 367);
            this.tbContactPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContactPerson.Name = "tbContactPerson";
            this.tbContactPerson.Size = new System.Drawing.Size(204, 22);
            this.tbContactPerson.TabIndex = 6;
            this.tbContactPerson.Text = "Contact persoon";
            this.tbContactPerson.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(25, 338);
            this.tbCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(204, 22);
            this.tbCompanyName.TabIndex = 5;
            this.tbCompanyName.Text = "Bedrijfsnaam";
            this.tbCompanyName.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblNewCompany
            // 
            this.lblNewCompany.AutoSize = true;
            this.lblNewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCompany.Location = new System.Drawing.Point(21, 291);
            this.lblNewCompany.Name = "lblNewCompany";
            this.lblNewCompany.Size = new System.Drawing.Size(106, 20);
            this.lblNewCompany.TabIndex = 4;
            this.lblNewCompany.Text = "Nieuw bedrijf";
            // 
            // btSelectCompany
            // 
            this.btSelectCompany.Location = new System.Drawing.Point(145, 182);
            this.btSelectCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSelectCompany.Name = "btSelectCompany";
            this.btSelectCompany.Size = new System.Drawing.Size(85, 49);
            this.btSelectCompany.TabIndex = 2;
            this.btSelectCompany.Text = "Selecteer";
            this.btSelectCompany.UseVisualStyleBackColor = true;
            this.btSelectCompany.Click += new System.EventHandler(this.btSelectCompany_Click);
            // 
            // listBCompany
            // 
            this.listBCompany.FormattingEnabled = true;
            this.listBCompany.ItemHeight = 16;
            this.listBCompany.Location = new System.Drawing.Point(25, 44);
            this.listBCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBCompany.Name = "listBCompany";
            this.listBCompany.Size = new System.Drawing.Size(204, 132);
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
            this.lblAddContainers.Location = new System.Drawing.Point(21, 14);
            this.lblAddContainers.Name = "lblAddContainers";
            this.lblAddContainers.Size = new System.Drawing.Size(195, 24);
            this.lblAddContainers.TabIndex = 10;
            this.lblAddContainers.Text = "Containers toevoegen";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 144);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(115, 140);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 24);
            this.cbType.TabIndex = 12;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(22, 215);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 17);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Gewicht";
            // 
            // tbGPSCode
            // 
            this.tbGPSCode.Location = new System.Drawing.Point(115, 339);
            this.tbGPSCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGPSCode.Name = "tbGPSCode";
            this.tbGPSCode.Size = new System.Drawing.Size(200, 22);
            this.tbGPSCode.TabIndex = 16;
            this.tbGPSCode.Visible = false;
            // 
            // lblGPSCode
            // 
            this.lblGPSCode.AutoSize = true;
            this.lblGPSCode.Location = new System.Drawing.Point(23, 339);
            this.lblGPSCode.Name = "lblGPSCode";
            this.lblGPSCode.Size = new System.Drawing.Size(72, 17);
            this.lblGPSCode.TabIndex = 15;
            this.lblGPSCode.Text = "GPS code";
            this.lblGPSCode.Visible = false;
            // 
            // NUPWeight
            // 
            this.NUPWeight.Location = new System.Drawing.Point(114, 215);
            this.NUPWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btAddContainer.Location = new System.Drawing.Point(204, 260);
            this.btAddContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblComanyLabel.Location = new System.Drawing.Point(23, 98);
            this.lblComanyLabel.Name = "lblComanyLabel";
            this.lblComanyLabel.Size = new System.Drawing.Size(48, 17);
            this.lblComanyLabel.TabIndex = 18;
            this.lblComanyLabel.Text = "Bedrijf";
            // 
            // lblCompanySelected
            // 
            this.lblCompanySelected.AutoSize = true;
            this.lblCompanySelected.Location = new System.Drawing.Point(111, 98);
            this.lblCompanySelected.Name = "lblCompanySelected";
            this.lblCompanySelected.Size = new System.Drawing.Size(184, 17);
            this.lblCompanySelected.TabIndex = 19;
            this.lblCompanySelected.Text = "Geen bedrijf geselecteerd...";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.SystemColors.Control;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(24, 45);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 20;
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(115, 178);
            this.cbDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(200, 24);
            this.cbDestination.TabIndex = 22;
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(23, 182);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(85, 17);
            this.lbDestination.TabIndex = 21;
            this.lbDestination.Text = "Bestemming";
            // 
            // containerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 491);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.lbError);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(779, 538);
            this.MinimumSize = new System.Drawing.Size(779, 538);
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
        private System.Windows.Forms.Button btAddCompany;
        private System.Windows.Forms.TextBox tbCompanyKvk;
        private System.Windows.Forms.TextBox tbContactPerson;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lblNewCompany;
        private System.Windows.Forms.Button btSelectCompany;
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
        private System.Windows.Forms.Button btDeleteContainers;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lblErrorCompany;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Label lbDestination;

    }
}