namespace Movers_v2
{
    partial class VanAED
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
            this.tcVAN = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cbxsize0 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxColor0 = new System.Windows.Forms.TextBox();
            this.tbxModel0 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpMOT0 = new System.Windows.Forms.DateTimePicker();
            this.tbxRegNo0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxsize1 = new System.Windows.Forms.ComboBox();
            this.tbxColor1 = new System.Windows.Forms.TextBox();
            this.tbxModel1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpMOT1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxRegNo1 = new System.Windows.Forms.TextBox();
            this.cbxVanID1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.cbxsize2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxColor2 = new System.Windows.Forms.TextBox();
            this.tbxModel2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpMOT2 = new System.Windows.Forms.DateTimePicker();
            this.tbxRegNo2 = new System.Windows.Forms.TextBox();
            this.cbxVanID2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcVAN.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcVAN
            // 
            this.tcVAN.Controls.Add(this.tabAdd);
            this.tcVAN.Controls.Add(this.tabEdit);
            this.tcVAN.Controls.Add(this.tabDelete);
            this.tcVAN.Location = new System.Drawing.Point(12, 12);
            this.tcVAN.Name = "tcVAN";
            this.tcVAN.SelectedIndex = 0;
            this.tcVAN.Size = new System.Drawing.Size(787, 377);
            this.tcVAN.TabIndex = 0;
            this.tcVAN.SelectedIndexChanged += new System.EventHandler(this.tabcontrol1_SelectedIndexChanged);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Black;
            this.tabAdd.Controls.Add(this.cbxsize0);
            this.tabAdd.Controls.Add(this.label16);
            this.tabAdd.Controls.Add(this.tbxColor0);
            this.tabAdd.Controls.Add(this.tbxModel0);
            this.tabAdd.Controls.Add(this.label11);
            this.tabAdd.Controls.Add(this.label10);
            this.tabAdd.Controls.Add(this.dtpMOT0);
            this.tabAdd.Controls.Add(this.tbxRegNo0);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.ForeColor = System.Drawing.Color.LightGray;
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(779, 351);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add van";
            // 
            // cbxsize0
            // 
            this.cbxsize0.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsize0.FormattingEnabled = true;
            this.cbxsize0.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbxsize0.Location = new System.Drawing.Point(319, 304);
            this.cbxsize0.Name = "cbxsize0";
            this.cbxsize0.Size = new System.Drawing.Size(401, 26);
            this.cbxsize0.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 27);
            this.label16.TabIndex = 9;
            this.label16.Text = "van size:";
            // 
            // tbxColor0
            // 
            this.tbxColor0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxColor0.Location = new System.Drawing.Point(316, 253);
            this.tbxColor0.Name = "tbxColor0";
            this.tbxColor0.Size = new System.Drawing.Size(404, 35);
            this.tbxColor0.TabIndex = 8;
            // 
            // tbxModel0
            // 
            this.tbxModel0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModel0.Location = new System.Drawing.Point(316, 199);
            this.tbxModel0.Name = "tbxModel0";
            this.tbxModel0.Size = new System.Drawing.Size(404, 35);
            this.tbxModel0.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 27);
            this.label11.TabIndex = 6;
            this.label11.Text = "van color:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 27);
            this.label10.TabIndex = 5;
            this.label10.Text = "van model:";
            // 
            // dtpMOT0
            // 
            this.dtpMOT0.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMOT0.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMOT0.Location = new System.Drawing.Point(316, 144);
            this.dtpMOT0.Name = "dtpMOT0";
            this.dtpMOT0.Size = new System.Drawing.Size(404, 29);
            this.dtpMOT0.TabIndex = 4;
            this.dtpMOT0.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tbxRegNo0
            // 
            this.tbxRegNo0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegNo0.Location = new System.Drawing.Point(316, 86);
            this.tbxRegNo0.Name = "tbxRegNo0";
            this.tbxRegNo0.Size = new System.Drawing.Size(404, 35);
            this.tbxRegNo0.TabIndex = 3;
            this.tbxRegNo0.TextChanged += new System.EventHandler(this.tbxRegNo0_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot Due:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Van details";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.Black;
            this.tabEdit.Controls.Add(this.label17);
            this.tabEdit.Controls.Add(this.cbxsize1);
            this.tabEdit.Controls.Add(this.tbxColor1);
            this.tabEdit.Controls.Add(this.tbxModel1);
            this.tabEdit.Controls.Add(this.label13);
            this.tabEdit.Controls.Add(this.label12);
            this.tabEdit.Controls.Add(this.dtpMOT1);
            this.tabEdit.Controls.Add(this.label6);
            this.tabEdit.Controls.Add(this.tbxRegNo1);
            this.tabEdit.Controls.Add(this.cbxVanID1);
            this.tabEdit.Controls.Add(this.label5);
            this.tabEdit.Controls.Add(this.label4);
            this.tabEdit.ForeColor = System.Drawing.Color.LightGray;
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(779, 351);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit van";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 27);
            this.label17.TabIndex = 15;
            this.label17.Text = "van size:";
            // 
            // cbxsize1
            // 
            this.cbxsize1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsize1.FormattingEnabled = true;
            this.cbxsize1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbxsize1.Location = new System.Drawing.Point(325, 310);
            this.cbxsize1.Name = "cbxsize1";
            this.cbxsize1.Size = new System.Drawing.Size(401, 26);
            this.cbxsize1.TabIndex = 14;
            // 
            // tbxColor1
            // 
            this.tbxColor1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxColor1.Location = new System.Drawing.Point(322, 258);
            this.tbxColor1.Name = "tbxColor1";
            this.tbxColor1.Size = new System.Drawing.Size(404, 35);
            this.tbxColor1.TabIndex = 13;
            // 
            // tbxModel1
            // 
            this.tbxModel1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModel1.Location = new System.Drawing.Point(322, 205);
            this.tbxModel1.Name = "tbxModel1";
            this.tbxModel1.Size = new System.Drawing.Size(404, 35);
            this.tbxModel1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 27);
            this.label13.TabIndex = 11;
            this.label13.Text = "van color:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 27);
            this.label12.TabIndex = 10;
            this.label12.Text = "van model:";
            // 
            // dtpMOT1
            // 
            this.dtpMOT1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMOT1.Location = new System.Drawing.Point(322, 158);
            this.dtpMOT1.Name = "dtpMOT1";
            this.dtpMOT1.Size = new System.Drawing.Size(404, 29);
            this.dtpMOT1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "MOT due:";
            // 
            // tbxRegNo1
            // 
            this.tbxRegNo1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegNo1.Location = new System.Drawing.Point(322, 93);
            this.tbxRegNo1.Name = "tbxRegNo1";
            this.tbxRegNo1.Size = new System.Drawing.Size(400, 35);
            this.tbxRegNo1.TabIndex = 6;
            // 
            // cbxVanID1
            // 
            this.cbxVanID1.FormattingEnabled = true;
            this.cbxVanID1.Location = new System.Drawing.Point(322, 30);
            this.cbxVanID1.Name = "cbxVanID1";
            this.cbxVanID1.Size = new System.Drawing.Size(400, 21);
            this.cbxVanID1.TabIndex = 5;
            this.cbxVanID1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Registration Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Van ID: ";
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.Black;
            this.tabDelete.Controls.Add(this.cbxsize2);
            this.tabDelete.Controls.Add(this.label18);
            this.tabDelete.Controls.Add(this.tbxColor2);
            this.tabDelete.Controls.Add(this.tbxModel2);
            this.tabDelete.Controls.Add(this.label14);
            this.tabDelete.Controls.Add(this.label15);
            this.tabDelete.Controls.Add(this.dtpMOT2);
            this.tabDelete.Controls.Add(this.tbxRegNo2);
            this.tabDelete.Controls.Add(this.cbxVanID2);
            this.tabDelete.Controls.Add(this.label9);
            this.tabDelete.Controls.Add(this.label8);
            this.tabDelete.Controls.Add(this.label7);
            this.tabDelete.ForeColor = System.Drawing.Color.LightGray;
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(779, 351);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete van";
            // 
            // cbxsize2
            // 
            this.cbxsize2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsize2.FormattingEnabled = true;
            this.cbxsize2.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbxsize2.Location = new System.Drawing.Point(321, 318);
            this.cbxsize2.Name = "cbxsize2";
            this.cbxsize2.Size = new System.Drawing.Size(401, 26);
            this.cbxsize2.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 27);
            this.label18.TabIndex = 18;
            this.label18.Text = "van size:";
            // 
            // tbxColor2
            // 
            this.tbxColor2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxColor2.Location = new System.Drawing.Point(318, 267);
            this.tbxColor2.Name = "tbxColor2";
            this.tbxColor2.Size = new System.Drawing.Size(404, 35);
            this.tbxColor2.TabIndex = 17;
            // 
            // tbxModel2
            // 
            this.tbxModel2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModel2.Location = new System.Drawing.Point(318, 214);
            this.tbxModel2.Name = "tbxModel2";
            this.tbxModel2.Size = new System.Drawing.Size(404, 35);
            this.tbxModel2.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 27);
            this.label14.TabIndex = 15;
            this.label14.Text = "van color:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 27);
            this.label15.TabIndex = 14;
            this.label15.Text = "van model:";
            // 
            // dtpMOT2
            // 
            this.dtpMOT2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMOT2.Location = new System.Drawing.Point(318, 163);
            this.dtpMOT2.Name = "dtpMOT2";
            this.dtpMOT2.Size = new System.Drawing.Size(388, 29);
            this.dtpMOT2.TabIndex = 8;
            // 
            // tbxRegNo2
            // 
            this.tbxRegNo2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegNo2.Location = new System.Drawing.Point(318, 93);
            this.tbxRegNo2.Name = "tbxRegNo2";
            this.tbxRegNo2.Size = new System.Drawing.Size(388, 35);
            this.tbxRegNo2.TabIndex = 7;
            // 
            // cbxVanID2
            // 
            this.cbxVanID2.FormattingEnabled = true;
            this.cbxVanID2.Location = new System.Drawing.Point(318, 25);
            this.cbxVanID2.Name = "cbxVanID2";
            this.cbxVanID2.Size = new System.Drawing.Size(388, 21);
            this.cbxVanID2.TabIndex = 6;
            this.cbxVanID2.SelectedIndexChanged += new System.EventHandler(this.cbxVanID2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "MOT due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Registration Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Van ID: ";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.Black;
            this.btnExecute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.LightGray;
            this.btnExecute.Location = new System.Drawing.Point(677, 395);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(122, 64);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "ADD VAN";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Black;
            this.btnQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.ForeColor = System.Drawing.Color.LightGray;
            this.btnQuery.Location = new System.Drawing.Point(528, 395);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(122, 64);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Return to van queries";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(16, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // VanAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(829, 482);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.tcVAN);
            this.Name = "VanAED";
            this.Text = "VanAED";
            this.Load += new System.EventHandler(this.VanAED_Load);
            this.tcVAN.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVAN;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TextBox tbxRegNo0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cbxVanID1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tbxRegNo1;
        private System.Windows.Forms.ComboBox cbxVanID2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRegNo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpMOT0;
        private System.Windows.Forms.DateTimePicker dtpMOT1;
        private System.Windows.Forms.DateTimePicker dtpMOT2;
        private System.Windows.Forms.TextBox tbxColor0;
        private System.Windows.Forms.TextBox tbxModel0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxColor1;
        private System.Windows.Forms.TextBox tbxModel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxColor2;
        private System.Windows.Forms.TextBox tbxModel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxsize0;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxsize1;
        private System.Windows.Forms.ComboBox cbxsize2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}