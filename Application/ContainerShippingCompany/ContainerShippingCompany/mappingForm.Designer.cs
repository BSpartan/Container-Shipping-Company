namespace ContainerShippingCompany
{
    partial class mappingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mappingForm));
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbTypeShip = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTypeShip = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMarkContainers = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.rtbLegenda = new System.Windows.Forms.RichTextBox();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.rtbMapping = new System.Windows.Forms.RichTextBox();
            this.lblMapping = new System.Windows.Forms.Label();
            this.pnlCompany.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCompany
            // 
            this.pnlCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompany.Controls.Add(this.btnGenerate);
            this.pnlCompany.Controls.Add(this.cbDestination);
            this.pnlCompany.Controls.Add(this.cbTypeShip);
            this.pnlCompany.Controls.Add(this.lblDestination);
            this.pnlCompany.Controls.Add(this.lblTypeShip);
            this.pnlCompany.Controls.Add(this.lblSettings);
            this.pnlCompany.Location = new System.Drawing.Point(12, 12);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(738, 120);
            this.pnlCompany.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(577, 85);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 27);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Indeling genereren";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(149, 82);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(201, 24);
            this.cbDestination.TabIndex = 5;
            // 
            // cbTypeShip
            // 
            this.cbTypeShip.FormattingEnabled = true;
            this.cbTypeShip.Location = new System.Drawing.Point(149, 48);
            this.cbTypeShip.Name = "cbTypeShip";
            this.cbTypeShip.Size = new System.Drawing.Size(201, 24);
            this.cbTypeShip.TabIndex = 4;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(18, 85);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(85, 17);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Bestemming";
            // 
            // lblTypeShip
            // 
            this.lblTypeShip.AutoSize = true;
            this.lblTypeShip.Location = new System.Drawing.Point(18, 51);
            this.lblTypeShip.Name = "lblTypeShip";
            this.lblTypeShip.Size = new System.Drawing.Size(77, 17);
            this.lblTypeShip.TabIndex = 2;
            this.lblTypeShip.Text = "Type schip";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(14, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(123, 20);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Eigenschappen";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMarkContainers);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.rtbLegenda);
            this.panel2.Controls.Add(this.lblLegenda);
            this.panel2.Location = new System.Drawing.Point(470, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 329);
            this.panel2.TabIndex = 8;
            // 
            // btnMarkContainers
            // 
            this.btnMarkContainers.Location = new System.Drawing.Point(18, 287);
            this.btnMarkContainers.Name = "btnMarkContainers";
            this.btnMarkContainers.Size = new System.Drawing.Size(249, 27);
            this.btnMarkContainers.TabIndex = 8;
            this.btnMarkContainers.Text = "Markeer containers als ingepland";
            this.btnMarkContainers.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(18, 254);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(249, 27);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Indeling exporteren";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // rtbLegenda
            // 
            this.rtbLegenda.Location = new System.Drawing.Point(18, 45);
            this.rtbLegenda.Name = "rtbLegenda";
            this.rtbLegenda.ReadOnly = true;
            this.rtbLegenda.Size = new System.Drawing.Size(249, 168);
            this.rtbLegenda.TabIndex = 3;
            this.rtbLegenda.Text = "";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(14, 9);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(73, 20);
            this.lblLegenda.TabIndex = 1;
            this.lblLegenda.Text = "Legenda";
            // 
            // rtbMapping
            // 
            this.rtbMapping.Location = new System.Drawing.Point(31, 198);
            this.rtbMapping.Name = "rtbMapping";
            this.rtbMapping.ReadOnly = true;
            this.rtbMapping.Size = new System.Drawing.Size(399, 267);
            this.rtbMapping.TabIndex = 10;
            this.rtbMapping.Text = "";
            // 
            // lblMapping
            // 
            this.lblMapping.AutoSize = true;
            this.lblMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapping.Location = new System.Drawing.Point(24, 162);
            this.lblMapping.Name = "lblMapping";
            this.lblMapping.Size = new System.Drawing.Size(66, 20);
            this.lblMapping.TabIndex = 9;
            this.lblMapping.Text = "Indeling";
            // 
            // mappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.rtbMapping);
            this.Controls.Add(this.lblMapping);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 540);
            this.MinimumSize = new System.Drawing.Size(780, 540);
            this.Name = "mappingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Indelingscherm";
            this.pnlCompany.ResumeLayout(false);
            this.pnlCompany.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbTypeShip;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTypeShip;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMarkContainers;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RichTextBox rtbLegenda;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.RichTextBox rtbMapping;
        private System.Windows.Forms.Label lblMapping;

    }
}