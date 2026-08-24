
namespace Movers_v2
{
    partial class TrainingQueries
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cbxsessiontype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxsessioncompleted = new System.Windows.Forms.CheckBox();
            this.dtpsessionDate = new System.Windows.Forms.DateTimePicker();
            this.cbxstaff = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.GridColor = System.Drawing.Color.Black;
            this.dgvResults.Location = new System.Drawing.Point(12, 51);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Size = new System.Drawing.Size(577, 549);
            this.dgvResults.TabIndex = 8;
            // 
            // cbxsessiontype
            // 
            this.cbxsessiontype.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsessiontype.ForeColor = System.Drawing.Color.Black;
            this.cbxsessiontype.FormattingEnabled = true;
            this.cbxsessiontype.Location = new System.Drawing.Point(612, 154);
            this.cbxsessiontype.Name = "cbxsessiontype";
            this.cbxsessiontype.Size = new System.Drawing.Size(287, 26);
            this.cbxsessiontype.TabIndex = 27;
            this.cbxsessiontype.SelectedIndexChanged += new System.EventHandler(this.cbxsessiontype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(608, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Search By Completion Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(608, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Search By Scheduled Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(608, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search By Session:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(608, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search By Staff name:";
            // 
            // checkboxsessioncompleted
            // 
            this.checkboxsessioncompleted.AutoSize = true;
            this.checkboxsessioncompleted.Checked = true;
            this.checkboxsessioncompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxsessioncompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.checkboxsessioncompleted.Location = new System.Drawing.Point(612, 302);
            this.checkboxsessioncompleted.Name = "checkboxsessioncompleted";
            this.checkboxsessioncompleted.Size = new System.Drawing.Size(323, 29);
            this.checkboxsessioncompleted.TabIndex = 28;
            this.checkboxsessioncompleted.Text = "Has Session been completed?";
            this.checkboxsessioncompleted.UseVisualStyleBackColor = true;
            this.checkboxsessioncompleted.CheckedChanged += new System.EventHandler(this.checkboxsessioncompleted_CheckedChanged);
            // 
            // dtpsessionDate
            // 
            this.dtpsessionDate.CalendarFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsessionDate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsessionDate.Location = new System.Drawing.Point(612, 224);
            this.dtpsessionDate.Name = "dtpsessionDate";
            this.dtpsessionDate.Size = new System.Drawing.Size(270, 26);
            this.dtpsessionDate.TabIndex = 32;
            this.dtpsessionDate.ValueChanged += new System.EventHandler(this.dtpsessionDate_ValueChanged);
            // 
            // cbxstaff
            // 
            this.cbxstaff.BackColor = System.Drawing.SystemColors.Window;
            this.cbxstaff.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstaff.ForeColor = System.Drawing.Color.Black;
            this.cbxstaff.FormattingEnabled = true;
            this.cbxstaff.Location = new System.Drawing.Point(612, 76);
            this.cbxstaff.Name = "cbxstaff";
            this.cbxstaff.Size = new System.Drawing.Size(287, 26);
            this.cbxstaff.TabIndex = 33;
            this.cbxstaff.SelectedIndexChanged += new System.EventHandler(this.cbxstaff_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(998, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 71);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "🔄";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(737, 517);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(141, 71);
            this.btnMenu.TabIndex = 36;
            this.btnMenu.Text = "Return to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.Color.Black;
            this.btnTraining.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraining.Location = new System.Drawing.Point(944, 517);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(141, 71);
            this.btnTraining.TabIndex = 35;
            this.btnTraining.Text = "Training manager";
            this.btnTraining.UseVisualStyleBackColor = false;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click_1);
            // 
            // TrainingQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1111, 612);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbxstaff);
            this.Controls.Add(this.dtpsessionDate);
            this.Controls.Add(this.checkboxsessioncompleted);
            this.Controls.Add(this.cbxsessiontype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResults);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "TrainingQueries";
            this.Text = "TrainingQueries";
            this.Load += new System.EventHandler(this.TrainingQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ComboBox cbxsessiontype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxsessioncompleted;
        private System.Windows.Forms.DateTimePicker dtpsessionDate;
        private System.Windows.Forms.ComboBox cbxstaff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnTraining;
    }
}