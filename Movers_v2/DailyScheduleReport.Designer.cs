
namespace Movers_v2
{
    partial class DailyScheduleReport
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
            this.dgvMaintenances = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.lblTraining = new System.Windows.Forms.Label();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.lblOrder = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxViewBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenances)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMaintenance.SuspendLayout();
            this.tabTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaintenances
            // 
            this.dgvMaintenances.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMaintenances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaintenances.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaintenances.GridColor = System.Drawing.Color.Black;
            this.dgvMaintenances.Location = new System.Drawing.Point(21, 37);
            this.dgvMaintenances.Name = "dgvMaintenances";
            this.dgvMaintenances.Size = new System.Drawing.Size(617, 360);
            this.dgvMaintenances.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "DAILY SCHEDULE:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaintenance);
            this.tabControl1.Controls.Add(this.tabTraining);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Location = new System.Drawing.Point(18, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 438);
            this.tabControl1.TabIndex = 36;
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.BackColor = System.Drawing.Color.Black;
            this.tabMaintenance.Controls.Add(this.lblMaintenance);
            this.tabMaintenance.Controls.Add(this.dgvMaintenances);
            this.tabMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaintenance.Size = new System.Drawing.Size(658, 412);
            this.tabMaintenance.TabIndex = 0;
            this.tabMaintenance.Text = "Maintenance";
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Courier New", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblMaintenance.ForeColor = System.Drawing.Color.Silver;
            this.lblMaintenance.Location = new System.Drawing.Point(17, 11);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(244, 23);
            this.lblMaintenance.TabIndex = 37;
            this.lblMaintenance.Text = "Maintenances for :";
            // 
            // tabTraining
            // 
            this.tabTraining.BackColor = System.Drawing.Color.Black;
            this.tabTraining.Controls.Add(this.lblTraining);
            this.tabTraining.Controls.Add(this.dgvTraining);
            this.tabTraining.Location = new System.Drawing.Point(4, 22);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraining.Size = new System.Drawing.Size(658, 412);
            this.tabTraining.TabIndex = 1;
            this.tabTraining.Text = "Staff Training";
            // 
            // lblTraining
            // 
            this.lblTraining.AutoSize = true;
            this.lblTraining.Font = new System.Drawing.Font("Courier New", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTraining.ForeColor = System.Drawing.Color.Silver;
            this.lblTraining.Location = new System.Drawing.Point(17, 15);
            this.lblTraining.Name = "lblTraining";
            this.lblTraining.Size = new System.Drawing.Size(257, 23);
            this.lblTraining.TabIndex = 38;
            this.lblTraining.Text = "Staff Training for:";
            // 
            // dgvTraining
            // 
            this.dgvTraining.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraining.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraining.GridColor = System.Drawing.Color.Black;
            this.dgvTraining.Location = new System.Drawing.Point(21, 41);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.Size = new System.Drawing.Size(617, 356);
            this.dgvTraining.TabIndex = 3;
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.Black;
            this.tabOrders.Controls.Add(this.lblOrder);
            this.tabOrders.Controls.Add(this.dgvOrder);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(658, 412);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "Orders";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Courier New", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblOrder.ForeColor = System.Drawing.Color.Silver;
            this.lblOrder.Location = new System.Drawing.Point(17, 13);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(153, 23);
            this.lblOrder.TabIndex = 38;
            this.lblOrder.Text = "Orders for:";
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.GridColor = System.Drawing.Color.Black;
            this.dgvOrder.Location = new System.Drawing.Point(21, 39);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(617, 358);
            this.dgvOrder.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.button1.Location = new System.Drawing.Point(600, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 63);
            this.button1.TabIndex = 37;
            this.button1.Text = "🖨️";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxViewBy
            // 
            this.cbxViewBy.Font = new System.Drawing.Font("Courier New", 15F);
            this.cbxViewBy.ForeColor = System.Drawing.Color.Black;
            this.cbxViewBy.FormattingEnabled = true;
            this.cbxViewBy.Items.AddRange(new object[] {
            "Today",
            "This week",
            "This month",
            "This year"});
            this.cbxViewBy.Location = new System.Drawing.Point(324, 39);
            this.cbxViewBy.Name = "cbxViewBy";
            this.cbxViewBy.Size = new System.Drawing.Size(287, 30);
            this.cbxViewBy.TabIndex = 41;
            this.cbxViewBy.SelectedIndexChanged += new System.EventHandler(this.cbxViewBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "View reports for:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(18, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DailyScheduleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxViewBy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Name = "DailyScheduleReport";
            this.Text = "DailyScheduleReport";
            this.Load += new System.EventHandler(this.DailyScheduleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenances)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMaintenance.ResumeLayout(false);
            this.tabMaintenance.PerformLayout();
            this.tabTraining.ResumeLayout(false);
            this.tabTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaintenances;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMaintenance;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.TabPage tabTraining;
        private System.Windows.Forms.Label lblTraining;
        private System.Windows.Forms.DataGridView dgvTraining;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxViewBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}