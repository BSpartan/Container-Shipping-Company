namespace ContainerShippingCompany
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnNewContainers = new System.Windows.Forms.Button();
            this.btnNewMapping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewContainers
            // 
            this.btnNewContainers.Location = new System.Drawing.Point(156, 113);
            this.btnNewContainers.Name = "btnNewContainers";
            this.btnNewContainers.Size = new System.Drawing.Size(438, 98);
            this.btnNewContainers.TabIndex = 0;
            this.btnNewContainers.Text = "Containers toevoegen";
            this.btnNewContainers.UseVisualStyleBackColor = true;
            this.btnNewContainers.Click += new System.EventHandler(this.btnNewContainers_Click);
            // 
            // btnNewMapping
            // 
            this.btnNewMapping.Location = new System.Drawing.Point(156, 250);
            this.btnNewMapping.Name = "btnNewMapping";
            this.btnNewMapping.Size = new System.Drawing.Size(438, 98);
            this.btnNewMapping.TabIndex = 1;
            this.btnNewMapping.Text = "Indeling maken";
            this.btnNewMapping.UseVisualStyleBackColor = true;
            this.btnNewMapping.Click += new System.EventHandler(this.btnNewMapping_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.btnNewMapping);
            this.Controls.Add(this.btnNewContainers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 540);
            this.MinimumSize = new System.Drawing.Size(780, 540);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hoofdscherm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewContainers;
        private System.Windows.Forms.Button btnNewMapping;
    }
}

