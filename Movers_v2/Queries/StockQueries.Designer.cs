namespace Movers_v2
{
    partial class StockQueries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcStock = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.cbxQuery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReportOrders = new System.Windows.Forms.Button();
            this.cbxViewOrder = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbxDisplayReorderID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbxDisplayStatus = new System.Windows.Forms.ComboBox();
            this.tbxDisplayQty = new System.Windows.Forms.TextBox();
            this.tbxDisplayStockID = new System.Windows.Forms.TextBox();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.tbxDiscrepancies = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.tbxOrderQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxOrderItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReorder = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReportDiscrepancies = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnUpdateDiscrepancy = new System.Windows.Forms.Button();
            this.checkBoxDiscrepancy = new System.Windows.Forms.CheckBox();
            this.tbxReportedDiscrepancies = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvDiscrepancies = new System.Windows.Forms.DataGridView();
            this.cbxOrdersWithDiscrepancies = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tcStock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscrepancies)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStock
            // 
            this.tcStock.Controls.Add(this.tabPage1);
            this.tcStock.Controls.Add(this.tabPage2);
            this.tcStock.Controls.Add(this.tabPage3);
            this.tcStock.Location = new System.Drawing.Point(12, 12);
            this.tcStock.Name = "tcStock";
            this.tcStock.SelectedIndex = 0;
            this.tcStock.Size = new System.Drawing.Size(1169, 638);
            this.tcStock.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcStock.TabIndex = 0;
            this.tcStock.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btnMenu);
            this.tabPage1.Controls.Add(this.lblResults);
            this.tabPage1.Controls.Add(this.cbxQuery);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvResults);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tabPage1.ForeColor = System.Drawing.Color.LightGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stockviewer";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(21, 521);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(152, 85);
            this.btnMenu.TabIndex = 85;
            this.btnMenu.Text = "Return to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(18, 449);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(68, 18);
            this.lblResults.TabIndex = 31;
            this.lblResults.Text = "label2";
            // 
            // cbxQuery
            // 
            this.cbxQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuery.FormattingEnabled = true;
            this.cbxQuery.Items.AddRange(new object[] {
            "ID ascending",
            "ID descending",
            "item name ascending",
            "item name descending",
            "quantity ascending",
            "quantity descending",
            "price ascending",
            "price descending"});
            this.cbxQuery.Location = new System.Drawing.Point(143, 72);
            this.cbxQuery.Name = "cbxQuery";
            this.cbxQuery.Size = new System.Drawing.Size(388, 26);
            this.cbxQuery.TabIndex = 30;
            this.cbxQuery.Text = "ID ascending";
            this.cbxQuery.SelectedIndexChanged += new System.EventHandler(this.cbxQuery_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filter by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "AVAILABLE STOCK:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.Color.Black;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(21, 107);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Size = new System.Drawing.Size(1122, 339);
            this.dgvResults.TabIndex = 27;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnReportOrders);
            this.tabPage2.Controls.Add(this.cbxViewOrder);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.tbxDisplayReorderID);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lblPrice);
            this.tabPage2.Controls.Add(this.cbxDisplayStatus);
            this.tabPage2.Controls.Add(this.tbxDisplayQty);
            this.tabPage2.Controls.Add(this.tbxDisplayStockID);
            this.tabPage2.Controls.Add(this.btnUpdateOrder);
            this.tabPage2.Controls.Add(this.tbxDiscrepancies);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lbldate);
            this.tabPage2.Controls.Add(this.tbxOrderQty);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbxOrderItem);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnOrder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvReorder);
            this.tabPage2.ForeColor = System.Drawing.Color.LightGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Stock";
            // 
            // btnReportOrders
            // 
            this.btnReportOrders.BackColor = System.Drawing.Color.Black;
            this.btnReportOrders.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOrders.Location = new System.Drawing.Point(935, 301);
            this.btnReportOrders.Name = "btnReportOrders";
            this.btnReportOrders.Size = new System.Drawing.Size(214, 64);
            this.btnReportOrders.TabIndex = 60;
            this.btnReportOrders.Text = "GENERATE REPORT";
            this.btnReportOrders.UseVisualStyleBackColor = false;
            this.btnReportOrders.Click += new System.EventHandler(this.btnReportOrders_Click);
            // 
            // cbxViewOrder
            // 
            this.cbxViewOrder.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxViewOrder.ForeColor = System.Drawing.Color.Black;
            this.cbxViewOrder.FormattingEnabled = true;
            this.cbxViewOrder.Items.AddRange(new object[] {
            "All",
            "Today",
            "This Week",
            "This Month",
            "This Year"});
            this.cbxViewOrder.Location = new System.Drawing.Point(934, 269);
            this.cbxViewOrder.Name = "cbxViewOrder";
            this.cbxViewOrder.Size = new System.Drawing.Size(215, 26);
            this.cbxViewOrder.TabIndex = 58;
            this.cbxViewOrder.SelectedIndexChanged += new System.EventHandler(this.cbxViewOrder_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(930, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 22);
            this.label13.TabIndex = 57;
            this.label13.Text = "Display Orders made:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Courier New", 14F);
            this.checkBox2.Location = new System.Drawing.Point(934, 172);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(227, 46);
            this.checkBox2.TabIndex = 56;
            this.checkBox2.Text = "Display \r\nundelivered orders";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Courier New", 15F);
            this.checkBox1.Location = new System.Drawing.Point(934, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 48);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Display \r\ndelivered orders";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbxDisplayReorderID
            // 
            this.tbxDisplayReorderID.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDisplayReorderID.Location = new System.Drawing.Point(133, 339);
            this.tbxDisplayReorderID.Name = "tbxDisplayReorderID";
            this.tbxDisplayReorderID.Size = new System.Drawing.Size(165, 26);
            this.tbxDisplayReorderID.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 10.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(7, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "reorderID:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Silver;
            this.lblPrice.Location = new System.Drawing.Point(6, 185);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(142, 22);
            this.lblPrice.TabIndex = 52;
            this.lblPrice.Text = "Total Price:";
            // 
            // cbxDisplayStatus
            // 
            this.cbxDisplayStatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisplayStatus.ForeColor = System.Drawing.Color.Black;
            this.cbxDisplayStatus.FormattingEnabled = true;
            this.cbxDisplayStatus.Items.AddRange(new object[] {
            "Delivered",
            "Not Delivered"});
            this.cbxDisplayStatus.Location = new System.Drawing.Point(133, 442);
            this.cbxDisplayStatus.Name = "cbxDisplayStatus";
            this.cbxDisplayStatus.Size = new System.Drawing.Size(165, 26);
            this.cbxDisplayStatus.TabIndex = 41;
            // 
            // tbxDisplayQty
            // 
            this.tbxDisplayQty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDisplayQty.Location = new System.Drawing.Point(133, 410);
            this.tbxDisplayQty.Name = "tbxDisplayQty";
            this.tbxDisplayQty.Size = new System.Drawing.Size(165, 26);
            this.tbxDisplayQty.TabIndex = 51;
            // 
            // tbxDisplayStockID
            // 
            this.tbxDisplayStockID.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDisplayStockID.Location = new System.Drawing.Point(133, 373);
            this.tbxDisplayStockID.Name = "tbxDisplayStockID";
            this.tbxDisplayStockID.Size = new System.Drawing.Size(165, 26);
            this.tbxDisplayStockID.TabIndex = 50;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.Black;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrder.Location = new System.Drawing.Point(317, 504);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(61, 102);
            this.btnUpdateOrder.TabIndex = 49;
            this.btnUpdateOrder.Text = "U\r\nP\r\nD\r\nA\r\nT\r\nE\r\n";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // tbxDiscrepancies
            // 
            this.tbxDiscrepancies.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscrepancies.Location = new System.Drawing.Point(9, 504);
            this.tbxDiscrepancies.Multiline = true;
            this.tbxDiscrepancies.Name = "tbxDiscrepancies";
            this.tbxDiscrepancies.Size = new System.Drawing.Size(302, 102);
            this.tbxDiscrepancies.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(6, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 22);
            this.label11.TabIndex = 45;
            this.label11.Text = "Report order discrepancies:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 10.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(7, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "order status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(7, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "quantity:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(7, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "stockID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(6, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Update status: Click on a cell to update!";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Silver;
            this.lbldate.Location = new System.Drawing.Point(389, 78);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(164, 22);
            this.lbldate.TabIndex = 43;
            this.lbldate.Text = "Today\'s Date: ";
            // 
            // tbxOrderQty
            // 
            this.tbxOrderQty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderQty.Location = new System.Drawing.Point(187, 151);
            this.tbxOrderQty.Name = "tbxOrderQty";
            this.tbxOrderQty.Size = new System.Drawing.Size(69, 26);
            this.tbxOrderQty.TabIndex = 42;
            this.tbxOrderQty.TextChanged += new System.EventHandler(this.tbxOrderQty_TextChanged);
            this.tbxOrderQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOrderQty_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Enter quantity:";
            // 
            // cbxOrderItem
            // 
            this.cbxOrderItem.Font = new System.Drawing.Font("Courier New", 10F);
            this.cbxOrderItem.ForeColor = System.Drawing.Color.Black;
            this.cbxOrderItem.FormattingEnabled = true;
            this.cbxOrderItem.Location = new System.Drawing.Point(10, 103);
            this.cbxOrderItem.Name = "cbxOrderItem";
            this.cbxOrderItem.Size = new System.Drawing.Size(287, 24);
            this.cbxOrderItem.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Select item to order:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(3, 220);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(291, 71);
            this.btnOrder.TabIndex = 38;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "STOCK REORDER:";
            // 
            // dgvReorder
            // 
            this.dgvReorder.AllowUserToAddRows = false;
            this.dgvReorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReorder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReorder.Location = new System.Drawing.Point(393, 103);
            this.dgvReorder.Name = "dgvReorder";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReorder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvReorder.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReorder.Size = new System.Drawing.Size(536, 439);
            this.dgvReorder.TabIndex = 33;
            this.dgvReorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReorder_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.btnReportDiscrepancies);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.btnUpdateDiscrepancy);
            this.tabPage3.Controls.Add(this.checkBoxDiscrepancy);
            this.tabPage3.Controls.Add(this.tbxReportedDiscrepancies);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dgvDiscrepancies);
            this.tabPage3.Controls.Add(this.cbxOrdersWithDiscrepancies);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.ForeColor = System.Drawing.Color.Silver;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1161, 612);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Discrepancies";
            // 
            // btnReportDiscrepancies
            // 
            this.btnReportDiscrepancies.BackColor = System.Drawing.Color.Black;
            this.btnReportDiscrepancies.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportDiscrepancies.Location = new System.Drawing.Point(619, 451);
            this.btnReportDiscrepancies.Name = "btnReportDiscrepancies";
            this.btnReportDiscrepancies.Size = new System.Drawing.Size(291, 71);
            this.btnReportDiscrepancies.TabIndex = 59;
            this.btnReportDiscrepancies.Text = "GENERATE REPORT";
            this.btnReportDiscrepancies.UseVisualStyleBackColor = false;
            this.btnReportDiscrepancies.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(350, 31);
            this.label16.TabIndex = 58;
            this.label16.Text = "MANAGE DISCREPANCIES:";
            // 
            // btnUpdateDiscrepancy
            // 
            this.btnUpdateDiscrepancy.BackColor = System.Drawing.Color.Black;
            this.btnUpdateDiscrepancy.Font = new System.Drawing.Font("Courier New", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDiscrepancy.Location = new System.Drawing.Point(29, 368);
            this.btnUpdateDiscrepancy.Name = "btnUpdateDiscrepancy";
            this.btnUpdateDiscrepancy.Size = new System.Drawing.Size(470, 60);
            this.btnUpdateDiscrepancy.TabIndex = 57;
            this.btnUpdateDiscrepancy.Text = "UPDATE";
            this.btnUpdateDiscrepancy.UseVisualStyleBackColor = false;
            this.btnUpdateDiscrepancy.Click += new System.EventHandler(this.btnUpdateDiscrepancy_Click);
            // 
            // checkBoxDiscrepancy
            // 
            this.checkBoxDiscrepancy.AutoSize = true;
            this.checkBoxDiscrepancy.Font = new System.Drawing.Font("Courier New", 15F);
            this.checkBoxDiscrepancy.Location = new System.Drawing.Point(29, 336);
            this.checkBoxDiscrepancy.Name = "checkBoxDiscrepancy";
            this.checkBoxDiscrepancy.Size = new System.Drawing.Size(425, 26);
            this.checkBoxDiscrepancy.TabIndex = 56;
            this.checkBoxDiscrepancy.Text = "Have discrepancies been resolved?";
            this.checkBoxDiscrepancy.UseVisualStyleBackColor = true;
            this.checkBoxDiscrepancy.CheckedChanged += new System.EventHandler(this.checkBoxDiscrepancy_CheckedChanged);
            // 
            // tbxReportedDiscrepancies
            // 
            this.tbxReportedDiscrepancies.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReportedDiscrepancies.Location = new System.Drawing.Point(29, 154);
            this.tbxReportedDiscrepancies.Multiline = true;
            this.tbxReportedDiscrepancies.Name = "tbxReportedDiscrepancies";
            this.tbxReportedDiscrepancies.Size = new System.Drawing.Size(457, 176);
            this.tbxReportedDiscrepancies.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(25, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(461, 22);
            this.label15.TabIndex = 49;
            this.label15.Text = "reported discrepancies of selected order:";
            // 
            // dgvDiscrepancies
            // 
            this.dgvDiscrepancies.AllowUserToAddRows = false;
            this.dgvDiscrepancies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscrepancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscrepancies.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiscrepancies.Location = new System.Drawing.Point(619, 6);
            this.dgvDiscrepancies.Name = "dgvDiscrepancies";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscrepancies.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDiscrepancies.Size = new System.Drawing.Size(536, 439);
            this.dgvDiscrepancies.TabIndex = 43;
            // 
            // cbxOrdersWithDiscrepancies
            // 
            this.cbxOrdersWithDiscrepancies.Font = new System.Drawing.Font("Courier New", 10F);
            this.cbxOrdersWithDiscrepancies.ForeColor = System.Drawing.Color.Black;
            this.cbxOrdersWithDiscrepancies.FormattingEnabled = true;
            this.cbxOrdersWithDiscrepancies.Location = new System.Drawing.Point(29, 84);
            this.cbxOrdersWithDiscrepancies.Name = "cbxOrdersWithDiscrepancies";
            this.cbxOrdersWithDiscrepancies.Size = new System.Drawing.Size(457, 24);
            this.cbxOrdersWithDiscrepancies.TabIndex = 42;
            this.cbxOrdersWithDiscrepancies.SelectedIndexChanged += new System.EventHandler(this.cbxOrdersWithDiscrepancies_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(25, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 22);
            this.label14.TabIndex = 41;
            this.label14.Text = "Select item with discrepancies:";
            // 
            // StockQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1193, 662);
            this.Controls.Add(this.tcStock);
            this.Name = "StockQueries";
            this.Text = "StockQueries";
            this.Load += new System.EventHandler(this.StockQueries_Load);
            this.Shown += new System.EventHandler(this.StockQueries_Shown);
            this.tcStock.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscrepancies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cbxQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxOrderItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxOrderQty;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDisplayQty;
        private System.Windows.Forms.TextBox tbxDisplayStockID;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.TextBox tbxDiscrepancies;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxDisplayStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxDisplayReorderID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxViewOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUpdateDiscrepancy;
        private System.Windows.Forms.CheckBox checkBoxDiscrepancy;
        private System.Windows.Forms.TextBox tbxReportedDiscrepancies;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvDiscrepancies;
        private System.Windows.Forms.ComboBox cbxOrdersWithDiscrepancies;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnReportDiscrepancies;
        private System.Windows.Forms.Button btnReportOrders;
    }
}