namespace Movers_v2
{
    partial class StaffAED
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
            this.tcStaff = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.chbReadyToWork = new System.Windows.Forms.CheckBox();
            this.cbxrole0 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxtel0 = new System.Windows.Forms.TextBox();
            this.tbxsurname0 = new System.Windows.Forms.TextBox();
            this.tbxfirstname0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.cbxstaffid1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxrole1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxtel1 = new System.Windows.Forms.TextBox();
            this.tbxsurname1 = new System.Windows.Forms.TextBox();
            this.tbxfirstname1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.cbxstaffid2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxrole2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxtel2 = new System.Windows.Forms.TextBox();
            this.tbxsurname2 = new System.Windows.Forms.TextBox();
            this.tbxfirstname2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tcStaff.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcStaff
            // 
            this.tcStaff.Controls.Add(this.tabAdd);
            this.tcStaff.Controls.Add(this.tabEdit);
            this.tcStaff.Controls.Add(this.tabDelete);
            this.tcStaff.Location = new System.Drawing.Point(13, 12);
            this.tcStaff.Name = "tcStaff";
            this.tcStaff.SelectedIndex = 0;
            this.tcStaff.Size = new System.Drawing.Size(872, 428);
            this.tcStaff.TabIndex = 2;
            this.tcStaff.SelectedIndexChanged += new System.EventHandler(this.tcStaff_SelectedIndexChanged);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabAdd.Controls.Add(this.chbReadyToWork);
            this.tabAdd.Controls.Add(this.cbxrole0);
            this.tabAdd.Controls.Add(this.label12);
            this.tabAdd.Controls.Add(this.label13);
            this.tabAdd.Controls.Add(this.tbxtel0);
            this.tabAdd.Controls.Add(this.tbxsurname0);
            this.tabAdd.Controls.Add(this.tbxfirstname0);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.ForeColor = System.Drawing.Color.LightGray;
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(864, 402);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add Staff";
            // 
            // chbReadyToWork
            // 
            this.chbReadyToWork.AutoSize = true;
            this.chbReadyToWork.Font = new System.Drawing.Font("Courier New", 15F);
            this.chbReadyToWork.Location = new System.Drawing.Point(360, 316);
            this.chbReadyToWork.Name = "chbReadyToWork";
            this.chbReadyToWork.Size = new System.Drawing.Size(197, 26);
            this.chbReadyToWork.TabIndex = 56;
            this.chbReadyToWork.Text = "Ready to work?";
            this.chbReadyToWork.UseVisualStyleBackColor = true;
            this.chbReadyToWork.CheckedChanged += new System.EventHandler(this.chbReadyToWork_CheckedChanged);
            // 
            // cbxrole0
            // 
            this.cbxrole0.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxrole0.FormattingEnabled = true;
            this.cbxrole0.Items.AddRange(new object[] {
            "Driver",
            "Mechanic",
            "Assistant Driver"});
            this.cbxrole0.Location = new System.Drawing.Point(360, 263);
            this.cbxrole0.Name = "cbxrole0";
            this.cbxrole0.Size = new System.Drawing.Size(401, 26);
            this.cbxrole0.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Job Role:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 33);
            this.label13.TabIndex = 11;
            this.label13.Text = "Staff details";
            // 
            // tbxtel0
            // 
            this.tbxtel0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtel0.Location = new System.Drawing.Point(360, 198);
            this.tbxtel0.Name = "tbxtel0";
            this.tbxtel0.Size = new System.Drawing.Size(404, 35);
            this.tbxtel0.TabIndex = 10;
            // 
            // tbxsurname0
            // 
            this.tbxsurname0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsurname0.Location = new System.Drawing.Point(360, 143);
            this.tbxsurname0.Name = "tbxsurname0";
            this.tbxsurname0.Size = new System.Drawing.Size(404, 35);
            this.tbxsurname0.TabIndex = 9;
            // 
            // tbxfirstname0
            // 
            this.tbxfirstname0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxfirstname0.Location = new System.Drawing.Point(357, 82);
            this.tbxfirstname0.Name = "tbxfirstname0";
            this.tbxfirstname0.Size = new System.Drawing.Size(404, 35);
            this.tbxfirstname0.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name:";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.SystemColors.MenuText;
            this.tabEdit.Controls.Add(this.cbxstaffid1);
            this.tabEdit.Controls.Add(this.label5);
            this.tabEdit.Controls.Add(this.cbxrole1);
            this.tabEdit.Controls.Add(this.label4);
            this.tabEdit.Controls.Add(this.tbxtel1);
            this.tabEdit.Controls.Add(this.tbxsurname1);
            this.tabEdit.Controls.Add(this.tbxfirstname1);
            this.tabEdit.Controls.Add(this.label7);
            this.tabEdit.Controls.Add(this.label8);
            this.tabEdit.Controls.Add(this.label14);
            this.tabEdit.ForeColor = System.Drawing.Color.LightGray;
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(864, 402);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit Staff";
            // 
            // cbxstaffid1
            // 
            this.cbxstaffid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstaffid1.FormattingEnabled = true;
            this.cbxstaffid1.Location = new System.Drawing.Point(347, 41);
            this.cbxstaffid1.Name = "cbxstaffid1";
            this.cbxstaffid1.Size = new System.Drawing.Size(400, 21);
            this.cbxstaffid1.TabIndex = 24;
            this.cbxstaffid1.SelectedIndexChanged += new System.EventHandler(this.cbxstaffid1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Staff ID:";
            // 
            // cbxrole1
            // 
            this.cbxrole1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxrole1.FormattingEnabled = true;
            this.cbxrole1.Items.AddRange(new object[] {
            "Driver",
            "Mechanic",
            "Assistant Driver"});
            this.cbxrole1.Location = new System.Drawing.Point(347, 263);
            this.cbxrole1.Name = "cbxrole1";
            this.cbxrole1.Size = new System.Drawing.Size(401, 26);
            this.cbxrole1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Job Role:";
            // 
            // tbxtel1
            // 
            this.tbxtel1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtel1.Location = new System.Drawing.Point(347, 198);
            this.tbxtel1.Name = "tbxtel1";
            this.tbxtel1.Size = new System.Drawing.Size(404, 35);
            this.tbxtel1.TabIndex = 19;
            // 
            // tbxsurname1
            // 
            this.tbxsurname1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsurname1.Location = new System.Drawing.Point(347, 143);
            this.tbxsurname1.Name = "tbxsurname1";
            this.tbxsurname1.Size = new System.Drawing.Size(404, 35);
            this.tbxsurname1.TabIndex = 18;
            // 
            // tbxfirstname1
            // 
            this.tbxfirstname1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxfirstname1.Location = new System.Drawing.Point(344, 82);
            this.tbxfirstname1.Name = "tbxfirstname1";
            this.tbxfirstname1.Size = new System.Drawing.Size(404, 35);
            this.tbxfirstname1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Surname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telephone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 27);
            this.label14.TabIndex = 14;
            this.label14.Text = "First name:";
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.Black;
            this.tabDelete.Controls.Add(this.cbxstaffid2);
            this.tabDelete.Controls.Add(this.label1);
            this.tabDelete.Controls.Add(this.cbxrole2);
            this.tabDelete.Controls.Add(this.label9);
            this.tabDelete.Controls.Add(this.tbxtel2);
            this.tabDelete.Controls.Add(this.tbxsurname2);
            this.tabDelete.Controls.Add(this.tbxfirstname2);
            this.tabDelete.Controls.Add(this.label10);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Controls.Add(this.label15);
            this.tabDelete.ForeColor = System.Drawing.Color.LightGray;
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(864, 402);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete Staff";
            // 
            // cbxstaffid2
            // 
            this.cbxstaffid2.FormattingEnabled = true;
            this.cbxstaffid2.Location = new System.Drawing.Point(347, 38);
            this.cbxstaffid2.Name = "cbxstaffid2";
            this.cbxstaffid2.Size = new System.Drawing.Size(400, 21);
            this.cbxstaffid2.TabIndex = 34;
            this.cbxstaffid2.SelectedIndexChanged += new System.EventHandler(this.cbxstaffid2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Staff ID:";
            // 
            // cbxrole2
            // 
            this.cbxrole2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxrole2.FormattingEnabled = true;
            this.cbxrole2.Items.AddRange(new object[] {
            "Driver",
            "Cleaner",
            "Assistant",
            "Manager",
            "Mechanic"});
            this.cbxrole2.Location = new System.Drawing.Point(347, 260);
            this.cbxrole2.Name = "cbxrole2";
            this.cbxrole2.Size = new System.Drawing.Size(401, 26);
            this.cbxrole2.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Job Role:";
            // 
            // tbxtel2
            // 
            this.tbxtel2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtel2.Location = new System.Drawing.Point(347, 195);
            this.tbxtel2.Name = "tbxtel2";
            this.tbxtel2.Size = new System.Drawing.Size(404, 35);
            this.tbxtel2.TabIndex = 30;
            // 
            // tbxsurname2
            // 
            this.tbxsurname2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsurname2.Location = new System.Drawing.Point(347, 140);
            this.tbxsurname2.Name = "tbxsurname2";
            this.tbxsurname2.Size = new System.Drawing.Size(404, 35);
            this.tbxsurname2.TabIndex = 29;
            // 
            // tbxfirstname2
            // 
            this.tbxfirstname2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxfirstname2.Location = new System.Drawing.Point(344, 79);
            this.tbxfirstname2.Name = "tbxfirstname2";
            this.tbxfirstname2.Size = new System.Drawing.Size(404, 35);
            this.tbxfirstname2.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 27);
            this.label10.TabIndex = 27;
            this.label10.Text = "Surname:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 27);
            this.label11.TabIndex = 26;
            this.label11.Text = "Telephone:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 27);
            this.label15.TabIndex = 25;
            this.label15.Text = "First name:";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExecute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExecute.Location = new System.Drawing.Point(763, 446);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(122, 64);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "ADD STAFF";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnQuery.Location = new System.Drawing.Point(613, 446);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(122, 64);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Return to staff Queries";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(17, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StaffAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(897, 522);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.tcStaff);
            this.Name = "StaffAED";
            this.Text = "StaffAED";
            this.Load += new System.EventHandler(this.StaffAED_Load);
            this.tcStaff.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStaff;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxtel0;
        private System.Windows.Forms.TextBox tbxsurname0;
        private System.Windows.Forms.TextBox tbxfirstname0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.ComboBox cbxrole0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.ComboBox cbxstaffid1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxrole1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxtel1;
        private System.Windows.Forms.TextBox tbxsurname1;
        private System.Windows.Forms.TextBox tbxfirstname1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxstaffid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxrole2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxtel2;
        private System.Windows.Forms.TextBox tbxsurname2;
        private System.Windows.Forms.TextBox tbxfirstname2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chbReadyToWork;
    }
}