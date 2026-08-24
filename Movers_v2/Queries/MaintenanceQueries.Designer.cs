
namespace Movers_v2
{
    partial class MaintenanceQueries
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbxmaintenanceid = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxvanid = new System.Windows.Forms.ComboBox();
            this.dtpmaintenancedate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxregno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpmotduedate = new System.Windows.Forms.DateTimePicker();
            this.dtpMOT = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAED = new System.Windows.Forms.Button();
            this.tbxfirst = new System.Windows.Forms.TextBox();
            this.tbxsur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maintenanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 12);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(763, 479);
            this.dgvResults.TabIndex = 7;
            this.dgvResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResults_CellMouseClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1197, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 65);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "🔄";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxmaintenanceid
            // 
            this.cbxmaintenanceid.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmaintenanceid.FormattingEnabled = true;
            this.cbxmaintenanceid.Location = new System.Drawing.Point(1101, 85);
            this.cbxmaintenanceid.Name = "cbxmaintenanceid";
            this.cbxmaintenanceid.Size = new System.Drawing.Size(68, 26);
            this.cbxmaintenanceid.TabIndex = 28;
            this.cbxmaintenanceid.SelectedIndexChanged += new System.EventHandler(this.cbxmaintenanceid_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Search  maintenance start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(782, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search van being maintenanced:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search Maintenance ID:";
            // 
            // cbxvanid
            // 
            this.cbxvanid.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxvanid.FormattingEnabled = true;
            this.cbxvanid.Location = new System.Drawing.Point(1101, 122);
            this.cbxvanid.Name = "cbxvanid";
            this.cbxvanid.Size = new System.Drawing.Size(68, 26);
            this.cbxvanid.TabIndex = 30;
            this.cbxvanid.SelectedIndexChanged += new System.EventHandler(this.cbxvanid_SelectedIndexChanged);
            // 
            // dtpmaintenancedate
            // 
            this.dtpmaintenancedate.CalendarFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmaintenancedate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmaintenancedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmaintenancedate.Location = new System.Drawing.Point(785, 195);
            this.dtpmaintenancedate.Name = "dtpmaintenancedate";
            this.dtpmaintenancedate.Size = new System.Drawing.Size(362, 26);
            this.dtpmaintenancedate.TabIndex = 31;
            this.dtpmaintenancedate.ValueChanged += new System.EventHandler(this.dtpmaintenancedate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(781, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 18);
            this.label5.TabIndex = 68;
            this.label5.Text = "Search Maintenance Type:";
            // 
            // cbxtype
            // 
            this.cbxtype.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtype.FormattingEnabled = true;
            this.cbxtype.Items.AddRange(new object[] {
            "monthlycheck",
            "motservice",
            "motexam",
            "repair"});
            this.cbxtype.Location = new System.Drawing.Point(785, 268);
            this.cbxtype.Name = "cbxtype";
            this.cbxtype.Size = new System.Drawing.Size(270, 26);
            this.cbxtype.TabIndex = 69;
            this.cbxtype.SelectedIndexChanged += new System.EventHandler(this.cbxtype_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Search Staff First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1025, 813);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Search van MOT due date:";
            // 
            // cbxregno
            // 
            this.cbxregno.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxregno.FormattingEnabled = true;
            this.cbxregno.Location = new System.Drawing.Point(336, 532);
            this.cbxregno.Name = "cbxregno";
            this.cbxregno.Size = new System.Drawing.Size(315, 26);
            this.cbxregno.TabIndex = 75;
            this.cbxregno.SelectedIndexChanged += new System.EventHandler(this.cbxregno_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Search Van registration number:";
            // 
            // dtpmotduedate
            // 
            this.dtpmotduedate.CalendarFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmotduedate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmotduedate.Location = new System.Drawing.Point(1029, 838);
            this.dtpmotduedate.Name = "dtpmotduedate";
            this.dtpmotduedate.Size = new System.Drawing.Size(362, 29);
            this.dtpmotduedate.TabIndex = 77;
            // 
            // dtpMOT
            // 
            this.dtpMOT.CalendarFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMOT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMOT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMOT.Location = new System.Drawing.Point(336, 606);
            this.dtpMOT.Name = "dtpMOT";
            this.dtpMOT.Size = new System.Drawing.Size(362, 26);
            this.dtpMOT.TabIndex = 79;
            this.dtpMOT.ValueChanged += new System.EventHandler(this.dtpMOT_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 18);
            this.label10.TabIndex = 78;
            this.label10.Text = "Search MOT due date:";
            // 
            // btnAED
            // 
            this.btnAED.BackColor = System.Drawing.Color.Black;
            this.btnAED.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAED.Location = new System.Drawing.Point(1097, 625);
            this.btnAED.Name = "btnAED";
            this.btnAED.Size = new System.Drawing.Size(168, 85);
            this.btnAED.TabIndex = 80;
            this.btnAED.Text = "Maintenance Manager";
            this.btnAED.UseVisualStyleBackColor = false;
            this.btnAED.Click += new System.EventHandler(this.btnAED_Click);
            // 
            // tbxfirst
            // 
            this.tbxfirst.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxfirst.Location = new System.Drawing.Point(15, 532);
            this.tbxfirst.Name = "tbxfirst";
            this.tbxfirst.Size = new System.Drawing.Size(287, 26);
            this.tbxfirst.TabIndex = 81;
            this.tbxfirst.TextChanged += new System.EventHandler(this.tbxfirst_TextChanged);
            // 
            // tbxsur
            // 
            this.tbxsur.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsur.Location = new System.Drawing.Point(16, 606);
            this.tbxsur.Name = "tbxsur";
            this.tbxsur.Size = new System.Drawing.Size(287, 26);
            this.tbxsur.TabIndex = 83;
            this.tbxsur.TextChanged += new System.EventHandler(this.tbxsur_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 18);
            this.label11.TabIndex = 82;
            this.label11.Text = "Search Staff Surname:";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(761, 625);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(152, 85);
            this.btnMenu.TabIndex = 84;
            this.btnMenu.Text = "Return to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceDetailsToolStripMenuItem,
            this.editMaintenanceToolStripMenuItem,
            this.deleteMaintenanceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // maintenanceDetailsToolStripMenuItem
            // 
            this.maintenanceDetailsToolStripMenuItem.Name = "maintenanceDetailsToolStripMenuItem";
            this.maintenanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.maintenanceDetailsToolStripMenuItem.Text = "Maintenance Details";
            this.maintenanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.maintenanceDetailsToolStripMenuItem_Click);
            // 
            // editMaintenanceToolStripMenuItem
            // 
            this.editMaintenanceToolStripMenuItem.Name = "editMaintenanceToolStripMenuItem";
            this.editMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.editMaintenanceToolStripMenuItem.Text = "Edit Maintenance";
            this.editMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.editMaintenanceToolStripMenuItem_Click);
            // 
            // deleteMaintenanceToolStripMenuItem
            // 
            this.deleteMaintenanceToolStripMenuItem.Name = "deleteMaintenanceToolStripMenuItem";
            this.deleteMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deleteMaintenanceToolStripMenuItem.Text = "Delete Maintenance";
            this.deleteMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.deleteMaintenanceToolStripMenuItem_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Black;
            this.btnReport.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(781, 300);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(294, 42);
            this.btnReport.TabIndex = 85;
            this.btnReport.Text = "Generate custom report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 27);
            this.label1.TabIndex = 86;
            this.label1.Text = "Right-Click cell to manage maintenance!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(922, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 85);
            this.button1.TabIndex = 87;
            this.button1.Text = "Maintenance Stock Manager";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MaintenanceQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1277, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.tbxsur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxfirst);
            this.Controls.Add(this.btnAED);
            this.Controls.Add(this.dtpMOT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpmotduedate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxregno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpmaintenancedate);
            this.Controls.Add(this.cbxvanid);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbxmaintenanceid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResults);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "MaintenanceQueries";
            this.Text = "MaintenanceQueries";
            this.Load += new System.EventHandler(this.MaintenanceQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbxmaintenanceid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxvanid;
        private System.Windows.Forms.DateTimePicker dtpmaintenancedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxregno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpmotduedate;
        private System.Windows.Forms.DateTimePicker dtpMOT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAED;
        private System.Windows.Forms.TextBox tbxfirst;
        private System.Windows.Forms.TextBox tbxsur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMaintenanceToolStripMenuItem;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}