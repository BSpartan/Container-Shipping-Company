namespace ContainerShippingCompany
{
    partial class deleteContainerForm
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
            this.lblOptions = new System.Windows.Forms.Label();
            this.btDeleteSelected = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvContainers = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(13, 9);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(58, 20);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Opties";
            // 
            // btDeleteSelected
            // 
            this.btDeleteSelected.Location = new System.Drawing.Point(73, 414);
            this.btDeleteSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteSelected.Name = "btDeleteSelected";
            this.btDeleteSelected.Size = new System.Drawing.Size(137, 27);
            this.btDeleteSelected.TabIndex = 8;
            this.btDeleteSelected.Text = "Verwijderen";
            this.btDeleteSelected.UseVisualStyleBackColor = true;
            this.btDeleteSelected.Click += new System.EventHandler(this.btDeleteSelected_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btDeleteSelected);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblOptions);
            this.panel2.Location = new System.Drawing.Point(537, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 499);
            this.panel2.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(73, 458);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 27);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvContainers
            // 
            this.dgvContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContainers.Location = new System.Drawing.Point(16, 15);
            this.dgvContainers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvContainers.Name = "dgvContainers";
            this.dgvContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContainers.Size = new System.Drawing.Size(515, 474);
            this.dgvContainers.TabIndex = 9;
            // 
            // deleteContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 491);
            this.Controls.Add(this.dgvContainers);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(779, 538);
            this.MinimumSize = new System.Drawing.Size(779, 538);
            this.Name = "deleteContainerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Indelingscherm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btDeleteSelected;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvContainers;

    }
}