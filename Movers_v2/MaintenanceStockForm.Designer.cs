namespace Movers_v2
{
    partial class MaintenanceStockForm
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvStockQuantity = new System.Windows.Forms.DataGridView();
            this.lblStockName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSelectMaintenance = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnMaintenanceQueries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(1, 68);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(577, 287);
            this.dgvResults.TabIndex = 8;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(584, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 383);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Silver;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(594, 102);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 33);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "Maintenance cost:";
            // 
            // dgvStockQuantity
            // 
            this.dgvStockQuantity.AllowUserToAddRows = false;
            this.dgvStockQuantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockQuantity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStockQuantity.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockQuantity.Location = new System.Drawing.Point(1, 361);
            this.dgvStockQuantity.Name = "dgvStockQuantity";
            this.dgvStockQuantity.Size = new System.Drawing.Size(577, 277);
            this.dgvStockQuantity.TabIndex = 69;
            this.dgvStockQuantity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockQuantity_CellClick);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.BackColor = System.Drawing.Color.Silver;
            this.lblStockName.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblStockName.ForeColor = System.Drawing.Color.Black;
            this.lblStockName.Location = new System.Drawing.Point(594, 164);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(179, 23);
            this.lblStockName.TabIndex = 70;
            this.lblStockName.Text = "Select stock:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Silver;
            this.lblQuantity.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(594, 224);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(218, 23);
            this.lblQuantity.TabIndex = 71;
            this.lblQuantity.Text = "Quantity needed:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.BackColor = System.Drawing.Color.Silver;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.lblPricePerUnit.Location = new System.Drawing.Point(594, 279);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(231, 23);
            this.lblPricePerUnit.TabIndex = 73;
            this.lblPricePerUnit.Text = "Price (£) / unit:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.Color.Silver;
            this.lblTotalCost.Font = new System.Drawing.Font("Courier New", 13.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCost.Location = new System.Drawing.Point(596, 428);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(318, 22);
            this.lblTotalCost.TabIndex = 74;
            this.lblTotalCost.Text = "Total maintenance cost (£): ";
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.LightGray;
            this.numQuantity.DecimalPlaces = 1;
            this.numQuantity.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.numQuantity.Location = new System.Drawing.Point(827, 223);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.ReadOnly = true;
            this.numQuantity.Size = new System.Drawing.Size(120, 29);
            this.numQuantity.TabIndex = 75;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lblSelectMaintenance
            // 
            this.lblSelectMaintenance.AutoSize = true;
            this.lblSelectMaintenance.BackColor = System.Drawing.Color.Black;
            this.lblSelectMaintenance.Font = new System.Drawing.Font("Courier New", 13.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblSelectMaintenance.ForeColor = System.Drawing.Color.White;
            this.lblSelectMaintenance.Location = new System.Drawing.Point(132, 43);
            this.lblSelectMaintenance.Name = "lblSelectMaintenance";
            this.lblSelectMaintenance.Size = new System.Drawing.Size(241, 22);
            this.lblSelectMaintenance.TabIndex = 76;
            this.lblSelectMaintenance.Text = "Select a maintenance!";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExecute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExecute.Location = new System.Drawing.Point(935, 477);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(124, 42);
            this.btnExecute.TabIndex = 77;
            this.btnExecute.Text = "ADD";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnMaintenanceQueries
            // 
            this.btnMaintenanceQueries.BackColor = System.Drawing.Color.Black;
            this.btnMaintenanceQueries.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceQueries.ForeColor = System.Drawing.Color.LightGray;
            this.btnMaintenanceQueries.Location = new System.Drawing.Point(584, 578);
            this.btnMaintenanceQueries.Name = "btnMaintenanceQueries";
            this.btnMaintenanceQueries.Size = new System.Drawing.Size(160, 60);
            this.btnMaintenanceQueries.TabIndex = 85;
            this.btnMaintenanceQueries.Text = "Maintenance manager";
            this.btnMaintenanceQueries.UseVisualStyleBackColor = false;
            this.btnMaintenanceQueries.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MaintenanceStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1071, 659);
            this.Controls.Add(this.btnMaintenanceQueries);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblSelectMaintenance);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblPricePerUnit);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.dgvStockQuantity);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvResults);
            this.Name = "MaintenanceStockForm";
            this.Text = "MaintenanceStockForm";
            this.Load += new System.EventHandler(this.MaintenanceStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvStockQuantity;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblSelectMaintenance;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnMaintenanceQueries;
    }
}