namespace Movers_v2
{
    partial class displayMembersForSession
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblNoResults = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.GridColor = System.Drawing.Color.Black;
            this.dgvResults.Location = new System.Drawing.Point(42, 93);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Size = new System.Drawing.Size(965, 435);
            this.dgvResults.TabIndex = 8;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Courier New", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenu.Location = new System.Drawing.Point(42, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 75);
            this.btnMenu.TabIndex = 85;
            this.btnMenu.Text = "↩";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.BackColor = System.Drawing.Color.DarkGray;
            this.lblNoResults.Font = new System.Drawing.Font("Microsoft Himalaya", 30.25F, System.Drawing.FontStyle.Bold);
            this.lblNoResults.ForeColor = System.Drawing.Color.Black;
            this.lblNoResults.Location = new System.Drawing.Point(221, 282);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(633, 41);
            this.lblNoResults.TabIndex = 86;
            this.lblNoResults.Tag = "";
            this.lblNoResults.Text = "No staff members booked on this session and date!";
            // 
            // displayMembersForSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1065, 571);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvResults);
            this.Name = "displayMembersForSession";
            this.Text = "displaySessionsForStaff";
            this.Load += new System.EventHandler(this.displayMembersForSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblNoResults;
    }
}