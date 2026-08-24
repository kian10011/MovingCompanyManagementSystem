namespace Movers_v2
{
    partial class VanQueries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnAED = new System.Windows.Forms.Button();
            this.cbxvanid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxmodel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxcolor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxsize = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.BackgroundColor = System.Drawing.Color.Black;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.GridColor = System.Drawing.Color.Black;
            this.dgvResults.Location = new System.Drawing.Point(12, 73);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(681, 412);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(14, 501);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(68, 18);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "label2";
            // 
            // btnAED
            // 
            this.btnAED.BackColor = System.Drawing.Color.Black;
            this.btnAED.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAED.Location = new System.Drawing.Point(972, 459);
            this.btnAED.Name = "btnAED";
            this.btnAED.Size = new System.Drawing.Size(141, 71);
            this.btnAED.TabIndex = 5;
            this.btnAED.Text = "Go to Van Manager";
            this.btnAED.UseVisualStyleBackColor = false;
            this.btnAED.Click += new System.EventHandler(this.btnAED_Click);
            // 
            // cbxvanid
            // 
            this.cbxvanid.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxvanid.FormattingEnabled = true;
            this.cbxvanid.Location = new System.Drawing.Point(725, 53);
            this.cbxvanid.Name = "cbxvanid";
            this.cbxvanid.Size = new System.Drawing.Size(287, 26);
            this.cbxvanid.TabIndex = 27;
            this.cbxvanid.SelectedIndexChanged += new System.EventHandler(this.cbxvanid_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(721, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Search van color:";
            // 
            // tbxmodel
            // 
            this.tbxmodel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxmodel.Location = new System.Drawing.Point(725, 223);
            this.tbxmodel.Name = "tbxmodel";
            this.tbxmodel.Size = new System.Drawing.Size(287, 26);
            this.tbxmodel.TabIndex = 25;
            this.tbxmodel.TextChanged += new System.EventHandler(this.tbxmodel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(721, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Search van model:";
            // 
            // tbxRegNo
            // 
            this.tbxRegNo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegNo.Location = new System.Drawing.Point(725, 143);
            this.tbxRegNo.Name = "tbxRegNo";
            this.tbxRegNo.Size = new System.Drawing.Size(287, 26);
            this.tbxRegNo.TabIndex = 23;
            this.tbxRegNo.TextChanged += new System.EventHandler(this.tbxRegNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(721, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search van Registration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(721, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search Van ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxcolor
            // 
            this.tbxcolor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxcolor.Location = new System.Drawing.Point(725, 298);
            this.tbxcolor.Name = "tbxcolor";
            this.tbxcolor.Size = new System.Drawing.Size(287, 26);
            this.tbxcolor.TabIndex = 20;
            this.tbxcolor.TextChanged += new System.EventHandler(this.tbxcolor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(721, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Search van size:";
            // 
            // cbxsize
            // 
            this.cbxsize.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsize.FormattingEnabled = true;
            this.cbxsize.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.cbxsize.Location = new System.Drawing.Point(725, 382);
            this.cbxsize.Name = "cbxsize";
            this.cbxsize.Size = new System.Drawing.Size(287, 26);
            this.cbxsize.TabIndex = 29;
            this.cbxsize.SelectedIndexChanged += new System.EventHandler(this.cbxsize_SelectedIndexChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(715, 459);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(141, 71);
            this.btnMenu.TabIndex = 30;
            this.btnMenu.Text = "Return to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1037, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 39);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "VAN MANAGER";
            // 
            // VanQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1139, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cbxsize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxvanid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxmodel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxRegNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxcolor);
            this.Controls.Add(this.btnAED);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvResults);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "VanQueries";
            this.Text = "VanQueries";
            this.Load += new System.EventHandler(this.MaintenanceQueries_Load);
            this.Shown += new System.EventHandler(this.VanQueries_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnAED;
        private System.Windows.Forms.ComboBox cbxvanid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxmodel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxcolor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxsize;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
    }
}