
namespace Movers_v2
{
    partial class StaffQueries
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
            this.btnAED = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tbxfirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxsurname = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxtelno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxjobrole = new System.Windows.Forms.ComboBox();
            this.cbxQuery = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAED
            // 
            this.btnAED.BackColor = System.Drawing.Color.Black;
            this.btnAED.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAED.Location = new System.Drawing.Point(962, 407);
            this.btnAED.Name = "btnAED";
            this.btnAED.Size = new System.Drawing.Size(141, 71);
            this.btnAED.TabIndex = 10;
            this.btnAED.Text = "Go to Staff Manager";
            this.btnAED.UseVisualStyleBackColor = false;
            this.btnAED.Click += new System.EventHandler(this.btnAED_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(22, 481);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(68, 18);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter by:";
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.GridColor = System.Drawing.Color.Black;
            this.dgvResults.Location = new System.Drawing.Point(25, 69);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Size = new System.Drawing.Size(681, 412);
            this.dgvResults.TabIndex = 6;
            // 
            // tbxfirstname
            // 
            this.tbxfirstname.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxfirstname.Location = new System.Drawing.Point(755, 94);
            this.tbxfirstname.Name = "tbxfirstname";
            this.tbxfirstname.Size = new System.Drawing.Size(287, 26);
            this.tbxfirstname.TabIndex = 11;
            this.tbxfirstname.TextChanged += new System.EventHandler(this.tbxfirstname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(751, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search Staff first name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search Staff surname:";
            // 
            // tbxsurname
            // 
            this.tbxsurname.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsurname.Location = new System.Drawing.Point(755, 162);
            this.tbxsurname.Name = "tbxsurname";
            this.tbxsurname.Size = new System.Drawing.Size(287, 26);
            this.tbxsurname.TabIndex = 14;
            this.tbxsurname.TextChanged += new System.EventHandler(this.tbxsurname_TextChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(755, 407);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(141, 71);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Return to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search Staff Telephone number:";
            // 
            // tbxtelno
            // 
            this.tbxtelno.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtelno.Location = new System.Drawing.Point(755, 242);
            this.tbxtelno.Name = "tbxtelno";
            this.tbxtelno.Size = new System.Drawing.Size(287, 26);
            this.tbxtelno.TabIndex = 17;
            this.tbxtelno.TextChanged += new System.EventHandler(this.tbxtelno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(751, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Search staff job role:";
            // 
            // cbxjobrole
            // 
            this.cbxjobrole.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxjobrole.FormattingEnabled = true;
            this.cbxjobrole.Items.AddRange(new object[] {
            "Driver",
            "Assistant Driver",
            "Mechanic"});
            this.cbxjobrole.Location = new System.Drawing.Point(755, 318);
            this.cbxjobrole.Name = "cbxjobrole";
            this.cbxjobrole.Size = new System.Drawing.Size(287, 26);
            this.cbxjobrole.TabIndex = 19;
            this.cbxjobrole.SelectedIndexChanged += new System.EventHandler(this.cbxjobrole_SelectedIndexChanged);
            // 
            // cbxQuery
            // 
            this.cbxQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuery.FormattingEnabled = true;
            this.cbxQuery.Items.AddRange(new object[] {
            "display all staff (firstname asc)",
            "display all staff(firstname desc)",
            "display all staff(staffID asc)",
            "display all staff(staffID desc)",
            "display all staff(surname asc)",
            "display all staff(surname desc)"});
            this.cbxQuery.Location = new System.Drawing.Point(156, 35);
            this.cbxQuery.Name = "cbxQuery";
            this.cbxQuery.Size = new System.Drawing.Size(388, 26);
            this.cbxQuery.TabIndex = 8;
            this.cbxQuery.SelectedIndexChanged += new System.EventHandler(this.cbxQuery_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightGray;
            this.btnReset.Location = new System.Drawing.Point(1057, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 39);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1163, 508);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbxjobrole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxtelno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.tbxsurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxfirstname);
            this.Controls.Add(this.btnAED);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cbxQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResults);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "StaffQueries";
            this.Text = "StaffQueries";
            this.Load += new System.EventHandler(this.StaffQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAED;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TextBox tbxfirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxsurname;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxtelno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxjobrole;
        private System.Windows.Forms.ComboBox cbxQuery;
        private System.Windows.Forms.Button btnReset;
    }
}