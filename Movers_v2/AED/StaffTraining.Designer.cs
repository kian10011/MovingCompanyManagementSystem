namespace Movers_v2
{
    partial class StaffTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffTraining));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllMembersOfSelecedSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNoBooked = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNoSessionsCompleted = new System.Windows.Forms.Label();
            this.lblPleaseSelect = new System.Windows.Forms.Label();
            this.imgSession = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpSessionDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInd2 = new System.Windows.Forms.Label();
            this.lblInd1 = new System.Windows.Forms.Label();
            this.lblInd3 = new System.Windows.Forms.Label();
            this.lblRefresher = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSessionCap = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imgCertificate = new System.Windows.Forms.PictureBox();
            this.btnAddCertificate = new System.Windows.Forms.Button();
            this.tbxCertificateDetails = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDisplayCertificateForSession = new System.Windows.Forms.ComboBox();
            this.cbxCertificateSession = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStaffCertificate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCertificate = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllMembersOfSelecedSessionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(317, 26);
            // 
            // showAllMembersOfSelecedSessionToolStripMenuItem
            // 
            this.showAllMembersOfSelecedSessionToolStripMenuItem.Name = "showAllMembersOfSelecedSessionToolStripMenuItem";
            this.showAllMembersOfSelecedSessionToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.showAllMembersOfSelecedSessionToolStripMenuItem.Text = "Show all members of selected session and date";
            this.showAllMembersOfSelecedSessionToolStripMenuItem.Click += new System.EventHandler(this.showAllMembersOfSelectedSessionToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1172, 595);
            this.tabControl1.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.lblNoBooked);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.lblNoSessionsCompleted);
            this.tabPage1.Controls.Add(this.lblPleaseSelect);
            this.tabPage1.Controls.Add(this.imgSession);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.dtpSessionDate);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblInd2);
            this.tabPage1.Controls.Add(this.lblInd1);
            this.tabPage1.Controls.Add(this.lblInd3);
            this.tabPage1.Controls.Add(this.lblRefresher);
            this.tabPage1.Controls.Add(this.lblDuration);
            this.tabPage1.Controls.Add(this.lblSessionCap);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.cbxStaff);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbxSession);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.dgvResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1164, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Training";
            // 
            // lblNoBooked
            // 
            this.lblNoBooked.AutoSize = true;
            this.lblNoBooked.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBooked.ForeColor = System.Drawing.Color.Silver;
            this.lblNoBooked.Location = new System.Drawing.Point(17, 446);
            this.lblNoBooked.Name = "lblNoBooked";
            this.lblNoBooked.Size = new System.Drawing.Size(348, 18);
            this.lblNoBooked.TabIndex = 90;
            this.lblNoBooked.Text = "Staff booked for selected session:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1086, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 65);
            this.btnReset.TabIndex = 89;
            this.btnReset.Text = "🔄";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.LightGray;
            this.btnBack.Location = new System.Drawing.Point(19, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 61);
            this.btnBack.TabIndex = 88;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNoSessionsCompleted
            // 
            this.lblNoSessionsCompleted.AutoSize = true;
            this.lblNoSessionsCompleted.BackColor = System.Drawing.Color.DarkGray;
            this.lblNoSessionsCompleted.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSessionsCompleted.ForeColor = System.Drawing.Color.Black;
            this.lblNoSessionsCompleted.Location = new System.Drawing.Point(696, 308);
            this.lblNoSessionsCompleted.Name = "lblNoSessionsCompleted";
            this.lblNoSessionsCompleted.Size = new System.Drawing.Size(439, 22);
            this.lblNoSessionsCompleted.TabIndex = 87;
            this.lblNoSessionsCompleted.Tag = "";
            this.lblNoSessionsCompleted.Text = "staff member has completed no sessions!";
            // 
            // lblPleaseSelect
            // 
            this.lblPleaseSelect.AutoSize = true;
            this.lblPleaseSelect.BackColor = System.Drawing.Color.DarkGray;
            this.lblPleaseSelect.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelect.ForeColor = System.Drawing.Color.Black;
            this.lblPleaseSelect.Location = new System.Drawing.Point(736, 280);
            this.lblPleaseSelect.Name = "lblPleaseSelect";
            this.lblPleaseSelect.Size = new System.Drawing.Size(329, 22);
            this.lblPleaseSelect.TabIndex = 86;
            this.lblPleaseSelect.Tag = "";
            this.lblPleaseSelect.Text = "Please select a staff member!";
            // 
            // imgSession
            // 
            this.imgSession.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSession.BackgroundImage")));
            this.imgSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSession.Location = new System.Drawing.Point(383, 99);
            this.imgSession.Name = "imgSession";
            this.imgSession.Size = new System.Drawing.Size(45, 43);
            this.imgSession.TabIndex = 85;
            this.imgSession.TabStop = false;
            this.imgSession.MouseHover += new System.EventHandler(this.imgSession_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnUpdate.Location = new System.Drawing.Point(978, 506);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 43);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "UPDATE TABLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.CalendarFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSessionDate.Font = new System.Drawing.Font("Courier New", 13.25F, System.Drawing.FontStyle.Bold);
            this.dtpSessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSessionDate.Location = new System.Drawing.Point(371, 338);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.Size = new System.Drawing.Size(194, 28);
            this.dtpSessionDate.TabIndex = 83;
            this.dtpSessionDate.ValueChanged += new System.EventHandler(this.dtpSessionDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(368, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 18);
            this.label10.TabIndex = 82;
            this.label10.Text = "Book session date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(636, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "Sessions of selected member:";
            // 
            // lblInd2
            // 
            this.lblInd2.AutoSize = true;
            this.lblInd2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInd2.ForeColor = System.Drawing.Color.Silver;
            this.lblInd2.Location = new System.Drawing.Point(11, 185);
            this.lblInd2.Name = "lblInd2";
            this.lblInd2.Size = new System.Drawing.Size(238, 18);
            this.lblInd2.TabIndex = 80;
            this.lblInd2.Text = "Induction 2 completed?:";
            // 
            // lblInd1
            // 
            this.lblInd1.AutoSize = true;
            this.lblInd1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInd1.ForeColor = System.Drawing.Color.Silver;
            this.lblInd1.Location = new System.Drawing.Point(11, 153);
            this.lblInd1.Name = "lblInd1";
            this.lblInd1.Size = new System.Drawing.Size(238, 18);
            this.lblInd1.TabIndex = 79;
            this.lblInd1.Text = "Induction 1 completed?:";
            // 
            // lblInd3
            // 
            this.lblInd3.AutoSize = true;
            this.lblInd3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInd3.ForeColor = System.Drawing.Color.Silver;
            this.lblInd3.Location = new System.Drawing.Point(11, 215);
            this.lblInd3.Name = "lblInd3";
            this.lblInd3.Size = new System.Drawing.Size(238, 18);
            this.lblInd3.TabIndex = 78;
            this.lblInd3.Text = "Induction 3 completed?:";
            // 
            // lblRefresher
            // 
            this.lblRefresher.AutoSize = true;
            this.lblRefresher.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresher.ForeColor = System.Drawing.Color.Silver;
            this.lblRefresher.Location = new System.Drawing.Point(11, 245);
            this.lblRefresher.Name = "lblRefresher";
            this.lblRefresher.Size = new System.Drawing.Size(218, 18);
            this.lblRefresher.TabIndex = 77;
            this.lblRefresher.Text = "Refresher completed?:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Silver;
            this.lblDuration.Location = new System.Drawing.Point(16, 417);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(178, 18);
            this.lblDuration.TabIndex = 76;
            this.lblDuration.Text = "Session Duration:";
            // 
            // lblSessionCap
            // 
            this.lblSessionCap.AutoSize = true;
            this.lblSessionCap.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionCap.ForeColor = System.Drawing.Color.Silver;
            this.lblSessionCap.Location = new System.Drawing.Point(16, 383);
            this.lblSessionCap.Name = "lblSessionCap";
            this.lblSessionCap.Size = new System.Drawing.Size(178, 18);
            this.lblSessionCap.TabIndex = 75;
            this.lblSessionCap.Text = "Session Capacity:";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExecute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExecute.Location = new System.Drawing.Point(458, 479);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(176, 84);
            this.btnExecute.TabIndex = 74;
            this.btnExecute.Text = "ADD SESSION";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cbxStaff
            // 
            this.cbxStaff.Font = new System.Drawing.Font("Courier New", 15F);
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(14, 106);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(349, 30);
            this.cbxStaff.TabIndex = 73;
            this.cbxStaff.SelectedIndexChanged += new System.EventHandler(this.cbxStaff_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 19.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 30);
            this.label1.TabIndex = 72;
            this.label1.Tag = "";
            this.label1.Text = "Select Staff Member:";
            // 
            // cbxSession
            // 
            this.cbxSession.Font = new System.Drawing.Font("Courier New", 8F);
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Location = new System.Drawing.Point(19, 340);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(346, 22);
            this.cbxSession.TabIndex = 71;
            this.cbxSession.SelectedIndexChanged += new System.EventHandler(this.cbxSession_SelectedIndexChanged);
            this.cbxSession.MouseHover += new System.EventHandler(this.cbxSession_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 19.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(14, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 30);
            this.label2.TabIndex = 70;
            this.label2.Tag = "";
            this.label2.Text = "Select Session:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(14, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(253, 33);
            this.label13.TabIndex = 69;
            this.label13.Text = "Staff Training";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.GridColor = System.Drawing.Color.Black;
            this.dgvResults.Location = new System.Drawing.Point(640, 99);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Size = new System.Drawing.Size(514, 401);
            this.dgvResults.TabIndex = 68;
            this.dgvResults.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvResults_CellBeginEdit);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.imgCertificate);
            this.tabPage2.Controls.Add(this.btnAddCertificate);
            this.tabPage2.Controls.Add(this.tbxCertificateDetails);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbxDisplayCertificateForSession);
            this.tabPage2.Controls.Add(this.cbxCertificateSession);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbxStaffCertificate);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvCertificate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1164, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Certification";
            // 
            // imgCertificate
            // 
            this.imgCertificate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgCertificate.BackgroundImage")));
            this.imgCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCertificate.Location = new System.Drawing.Point(462, 200);
            this.imgCertificate.Name = "imgCertificate";
            this.imgCertificate.Size = new System.Drawing.Size(38, 36);
            this.imgCertificate.TabIndex = 82;
            this.imgCertificate.TabStop = false;
            this.imgCertificate.MouseHover += new System.EventHandler(this.imgCertificate_MouseHover);
            // 
            // btnAddCertificate
            // 
            this.btnAddCertificate.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddCertificate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCertificate.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddCertificate.Location = new System.Drawing.Point(963, 479);
            this.btnAddCertificate.Name = "btnAddCertificate";
            this.btnAddCertificate.Size = new System.Drawing.Size(176, 84);
            this.btnAddCertificate.TabIndex = 81;
            this.btnAddCertificate.Text = "Award Certificate";
            this.btnAddCertificate.UseVisualStyleBackColor = false;
            this.btnAddCertificate.Click += new System.EventHandler(this.btnAddCertificate_Click);
            // 
            // tbxCertificateDetails
            // 
            this.tbxCertificateDetails.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCertificateDetails.Location = new System.Drawing.Point(10, 323);
            this.tbxCertificateDetails.Multiline = true;
            this.tbxCertificateDetails.Name = "tbxCertificateDetails";
            this.tbxCertificateDetails.Size = new System.Drawing.Size(465, 240);
            this.tbxCertificateDetails.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(6, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 22);
            this.label8.TabIndex = 79;
            this.label8.Tag = "";
            this.label8.Text = "Enter certificate details:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 18.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(636, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(478, 30);
            this.label7.TabIndex = 78;
            this.label7.Text = "Display certificates given for:";
            // 
            // cbxDisplayCertificateForSession
            // 
            this.cbxDisplayCertificateForSession.Font = new System.Drawing.Font("Courier New", 10F);
            this.cbxDisplayCertificateForSession.FormattingEnabled = true;
            this.cbxDisplayCertificateForSession.Location = new System.Drawing.Point(622, 47);
            this.cbxDisplayCertificateForSession.Name = "cbxDisplayCertificateForSession";
            this.cbxDisplayCertificateForSession.Size = new System.Drawing.Size(517, 24);
            this.cbxDisplayCertificateForSession.TabIndex = 77;
            this.cbxDisplayCertificateForSession.SelectedIndexChanged += new System.EventHandler(this.cbxDisplayCertificateForSession_SelectedIndexChanged);
            // 
            // cbxCertificateSession
            // 
            this.cbxCertificateSession.Font = new System.Drawing.Font("Courier New", 8F);
            this.cbxCertificateSession.FormattingEnabled = true;
            this.cbxCertificateSession.Location = new System.Drawing.Point(10, 214);
            this.cbxCertificateSession.Name = "cbxCertificateSession";
            this.cbxCertificateSession.Size = new System.Drawing.Size(434, 22);
            this.cbxCertificateSession.TabIndex = 76;
            this.cbxCertificateSession.SelectedIndexChanged += new System.EventHandler(this.cbxCertificateSession_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 22);
            this.label5.TabIndex = 75;
            this.label5.Tag = "";
            this.label5.Text = "Select session to award certificate for:";
            // 
            // cbxStaffCertificate
            // 
            this.cbxStaffCertificate.Font = new System.Drawing.Font("Courier New", 14F);
            this.cbxStaffCertificate.FormattingEnabled = true;
            this.cbxStaffCertificate.Location = new System.Drawing.Point(10, 108);
            this.cbxStaffCertificate.Name = "cbxStaffCertificate";
            this.cbxStaffCertificate.Size = new System.Drawing.Size(424, 29);
            this.cbxStaffCertificate.TabIndex = 74;
            this.cbxStaffCertificate.SelectedIndexChanged += new System.EventHandler(this.cbxStaffCertificate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 22);
            this.label4.TabIndex = 73;
            this.label4.Tag = "";
            this.label4.Text = "Select staff member for certification:";
            // 
            // dgvCertificate
            // 
            this.dgvCertificate.AllowUserToAddRows = false;
            this.dgvCertificate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCertificate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCertificate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCertificate.GridColor = System.Drawing.Color.Black;
            this.dgvCertificate.Location = new System.Drawing.Point(622, 83);
            this.dgvCertificate.Name = "dgvCertificate";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            this.dgvCertificate.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCertificate.Size = new System.Drawing.Size(517, 366);
            this.dgvCertificate.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 33);
            this.label3.TabIndex = 70;
            this.label3.Text = "Certification:";
            // 
            // StaffTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1197, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffTraining";
            this.Text = "StaffTraining";
            this.Load += new System.EventHandler(this.StaffTraining_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAllMembersOfSelecedSessionToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNoSessionsCompleted;
        private System.Windows.Forms.Label lblPleaseSelect;
        private System.Windows.Forms.PictureBox imgSession;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInd2;
        private System.Windows.Forms.Label lblInd1;
        private System.Windows.Forms.Label lblInd3;
        private System.Windows.Forms.Label lblRefresher;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSessionCap;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDisplayCertificateForSession;
        private System.Windows.Forms.ComboBox cbxCertificateSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStaffCertificate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCertificate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddCertificate;
        private System.Windows.Forms.TextBox tbxCertificateDetails;
        private System.Windows.Forms.PictureBox imgCertificate;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNoBooked;
    }
}